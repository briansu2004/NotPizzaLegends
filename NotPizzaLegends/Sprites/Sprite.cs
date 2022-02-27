using Microsoft.AspNetCore.Components;

namespace NotPizzaLegends.Sprites;

public abstract class Sprite : ComponentBase
{
    private const double _blockSize = 32.0;

    protected double Width { get; set; } = 1.0;
    protected double Height { get; set; } = 1.0;

    [Inject] protected ICanvasService CanvasService { get; set; } = null!;

    [Parameter]  public virtual double X { get; set; } = 0;
    [Parameter] public virtual double Y { get; set; } = 0;

    public string Source { get; protected set; } = string.Empty;
    public string? ShadowSource { get; protected set; }

    public virtual async Task Draw(ElementReference canvas, bool includeShadow = true)
    {
        if (ShadowSource != null && includeShadow)
            await CanvasService.DrawImage(canvas, ShadowSource, 0, 0, _blockSize * Width, _blockSize * Height, X * _blockSize, Y * _blockSize, _blockSize * Width, _blockSize * Height);

        await CanvasService.DrawImage(canvas, Source, 
            0, 0, Scale(Width), Scale(Height), 
            Scale(X), Scale(Y), Scale(Width), Scale(Height));
    }

    private static double Scale(double value) => value * _blockSize;
}
