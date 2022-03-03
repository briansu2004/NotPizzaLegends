using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace NotPizzaLegends.Canvas;

public interface ICanvasService
{
    bool IsInitialized { get; }

    Task ClearCanvas();
    Task Draw(ElementReference? img, double dx, double dy);
    Task Draw(ElementReference? img, double sx, double sy, double dx, double dy);
    void Initialize(ElementReference canvas);
}

public class CanvasService : ICanvasService
{
    private const double _baseSize = 32.0;

    private readonly IJSRuntime _js;

    private ElementReference? _canvas;

    public bool IsInitialized => _canvas != null;

    public CanvasService(IJSRuntime js)
    {
        _js = js;
    }

    public void Initialize(ElementReference canvas)
    {
        _canvas = canvas;
    }

    public async Task ClearCanvas()
    {

        await _js.InvokeVoidAsync("clearCanvas", _canvas);
    }

    public async Task Draw(ElementReference? img, double dx, double dy)
    {
        await _js.InvokeVoidAsync("drawImage", _canvas, img, Scale(dx) / 2.0, Scale(dy) / 2.0);
    }

    public async Task Draw(ElementReference? img, double sx, double sy, double dx, double dy)
    {
        await _js.InvokeVoidAsync("drawAndCropImage", _canvas, img, sx, sy, _baseSize, _baseSize, Scale(dx) / 2.0, Scale(dy) / 2.0, _baseSize, _baseSize);
    }
    private static double Scale(double value) => value * _baseSize;
}
