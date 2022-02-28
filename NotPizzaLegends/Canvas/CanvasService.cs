using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using NotPizzaLegends.Maps;
using NotPizzaLegends.Sprites;

namespace NotPizzaLegends.Canvas;

public interface ICanvasService
{
    Task RenderScene(ElementReference canvas, IMap map, params ISprite[] sprites);
}

public class CanvasService : ICanvasService
{
    private const double _baseSize = 32.0;

    private readonly IJSRuntime _js;

    public CanvasService(IJSRuntime js)
    {
        _js = js;
    }

    public async Task RenderScene(ElementReference canvas, IMap map, params ISprite[] sprites)
    {
        await DrawImage(canvas, map.LowerSource, 0, 0);

        foreach (var sprite in sprites)
            await DrawSprite(canvas, sprite);

        await DrawImage(canvas, map.UpperSource, 0, 0);
    }

    async Task DrawSprite(ElementReference canvas, ISprite sprite, bool includeShadow = true)
    {
        if (sprite.ShadowSource != null && includeShadow)
            await DrawImage(canvas, sprite.ShadowSource, 0, 0, Scale(sprite.X), Scale(sprite.Y));

        await DrawImage(canvas, sprite.Source, 0, 0, Scale(sprite.X), Scale(sprite.Y));
    }

    async Task DrawImage(ElementReference canvas, string src, double dx, double dy)
    {
        await _js.InvokeVoidAsync("drawImage", canvas, src, dx / 2.0, dy / 2.0);
    }

    async Task DrawImage(ElementReference canvas, string src, double sx, double sy, double dx, double dy)
    {
        await _js.InvokeVoidAsync("drawAndCropImage", canvas, src, sx, sy, _baseSize, _baseSize, dx / 2.0, dy / 2.0, _baseSize, _baseSize);
    }

    private static double Scale(double value) => value * _baseSize;
}
