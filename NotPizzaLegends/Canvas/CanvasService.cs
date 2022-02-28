using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using NotPizzaLegends.Maps;
using NotPizzaLegends.Sprites;

namespace NotPizzaLegends.Canvas;

public interface ICanvasService
{
    Task Draw(ElementReference canvas, ISprite sprite, bool includeShadow = true);
    Task Draw(ElementReference canvas, IMap map);
}

public class CanvasService : ICanvasService
{
    private const double _baseSize = 32.0;

    private readonly IJSRuntime _js;

    public CanvasService(IJSRuntime js)
    {
        _js = js;
    }

    public async Task Draw(ElementReference canvas, IMap map)
    {
        await DrawImage(canvas, map.Source, 0, 0);
    }

    public async Task Draw(ElementReference canvas, ISprite sprite, bool includeShadow = true)
    {
        if (sprite.ShadowSource != null && includeShadow)
            await DrawImage(canvas, sprite.ShadowSource,
                0, 0, Scale(sprite.Width), Scale(sprite.Height),
                Scale(sprite.X), Scale(sprite.Y), Scale(sprite.Width), Scale(sprite.Height));

        await DrawImage(canvas, sprite.Source,
            0, 0, Scale(sprite.Width), Scale(sprite.Height),
            Scale(sprite.X), Scale(sprite.Y), Scale(sprite.Width), Scale(sprite.Height));
    }

    async Task DrawImage(ElementReference canvas, string src, double dx, double dy)
    {
        await _js.InvokeVoidAsync("drawImage", canvas, src, dx / 2.0, dy / 2.0);
    }

    async Task DrawImage(ElementReference canvas, string src, double sx, double sy, double sw, double sh, double dx, double dy, double dw, double dh)
    {
        await _js.InvokeVoidAsync("drawAndCropImage", canvas, src, sx, sy, sw, sh, dx / 2.0, dy / 2.0, dw, dh);
    }

    private static double Scale(double value) => value * _baseSize;
}
