using Microsoft.AspNetCore.Components;

namespace NotPizzaLegends.Sprites;

public interface ISprite
{
    ElementReference? ShadowSource { get; set; }
    ElementReference? Source { get; set; }

    bool ShowShadow { get; }
    double X { get; }
    double Y { get; }

    void Move(double x, double y);
}

public abstract class Sprite : ComponentBase, ISprite
{
    public ElementReference? Source { get; set; }
    public ElementReference? ShadowSource { get; set; }

    [Parameter] public bool ShowShadow { get; set; } = true;
    [Parameter] public double X { get; set; }
    [Parameter] public double Y { get; set; }

    public Sprite(double x = 0, double y = 0)
    {
        X = x;
        Y = y;
    }

    public void Move(double x, double y)
    {
        X += x;
        Y += y;
    }
}
