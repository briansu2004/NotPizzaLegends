using Microsoft.AspNetCore.Components;

namespace NotPizzaLegends.Sprites;

public abstract class Sprite : ISprite
{
    public double X { get; protected set; } = 0;
    public double Y { get; protected set; } = 0;
    public double Width { get; protected set; } = 1.0;
    public double Height { get; protected set; } = 1.0;
    public string Source { get; protected set; } = string.Empty;
    public string? ShadowSource { get; protected set; }

    public Sprite(double x, double y)
    {
        X = x;
        Y = y;
    }
}
