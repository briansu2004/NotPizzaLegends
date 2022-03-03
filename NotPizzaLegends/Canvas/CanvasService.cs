using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using NotPizzaLegends.Scenes;

namespace NotPizzaLegends.Canvas;

public class CanvasService : ICanvasService
{
    private const double _baseSize = 32.0;

    private readonly IJSRuntime _js;

    public CanvasService(IJSRuntime js)
    {
        _js = js;
    }

    public async Task RenderScene(ElementReference canvas, IScene scene)
    {
        await _js.InvokeVoidAsync("clearCanvas", canvas);
        await DrawImage(canvas, scene.Map.LowerSource, 0, 0);

        foreach (var obj in scene.GameObjects)
            await DrawGameObject(canvas, obj);

        await DrawImage(canvas, scene.Map.UpperSource, 0, 0);
    }

    async Task DrawGameObject(ElementReference canvas, IGameObject obj)
    {
        Console.WriteLine("Drawing game object...");

        if (obj.Sprite.ShadowSource != null && obj.ShowShadow)
            await DrawImage(canvas, obj.Sprite.ShadowSource, 0, 0, Scale(obj.X), Scale(obj.Y));

        await DrawImage(canvas, obj.Sprite.Source, 0, 0, Scale(obj.X), Scale(obj.Y));
    }

    async Task DrawImage(ElementReference canvas, ElementReference? img, double dx, double dy)
    {
        if (img != null)
            await _js.InvokeVoidAsync("drawImage", canvas, img, dx / 2.0, dy / 2.0);
    }

    async Task DrawImage(ElementReference canvas, ElementReference? img, double sx, double sy, double dx, double dy)
    {
        if (img != null)
            await _js.InvokeVoidAsync("drawAndCropImage", canvas, img, sx, sy, _baseSize, _baseSize, dx / 2.0, dy / 2.0, _baseSize, _baseSize);
    }

    private static double Scale(double value) => value * _baseSize;
}
