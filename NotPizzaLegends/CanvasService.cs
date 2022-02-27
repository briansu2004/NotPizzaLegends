using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace NotPizzaLegends;

public interface ICanvasService
{
    Task DrawImage(ElementReference canvas, string src, double sx, double sy, double sw, double sh, double dx, double dy, double dw, double dh);
}

public class CanvasService : ICanvasService
{
    private readonly IJSRuntime _js;

    public CanvasService(IJSRuntime js)
    {
        _js = js;
    }

    public async Task DrawImage(ElementReference canvas, string src, double sx, double sy, double sw, double sh, double dx, double dy, double dw, double dh)
    {
        await _js.InvokeVoidAsync("drawAndCropImage", canvas, src, sx, sy, sw, sh, dx, dy, dw, dh);
    }
}
