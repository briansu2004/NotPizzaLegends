using Microsoft.AspNetCore.Components;

namespace NotPizzaLegends.Sprites;

public abstract class Sprite : ComponentBase
{
    protected double BlockSize { get; set; } = 32.0;

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
            await CanvasService.DrawImage(canvas, ShadowSource, 0, 0, BlockSize * Width, BlockSize * Height, X * BlockSize, Y * BlockSize, BlockSize * Width, BlockSize * Height);

        await CanvasService.DrawImage(canvas, Source, 
            0, 0, Scale(Width), Scale(Height), 
            Scale(X), Scale(Y), Scale(Width), Scale(Height));
    }

    private double Scale(double value) => value * BlockSize;
}
