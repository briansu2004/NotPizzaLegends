using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace NotPizzaLegends;

public class CanvasReference
{
    private readonly ElementReference _canvas;
    private readonly IJSRuntime _js;

    public CanvasReference(ElementReference canvas, IJSRuntime js)
    {
        _canvas = canvas;
        _js = js;
    }

    public async Task DrawImage(string src, int x, int y)
    {
        await _js.InvokeVoidAsync("drawImage", _canvas, src, x, y);
    }
}
