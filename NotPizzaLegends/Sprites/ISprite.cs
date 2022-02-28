namespace NotPizzaLegends.Sprites;

public interface ISprite
{
    string? ShadowSource { get; }
    string Source { get; }
    double X { get; }
    double Y { get; }
}