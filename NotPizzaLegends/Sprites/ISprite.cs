namespace NotPizzaLegends.Sprites;

public interface ISprite
{
    double Height { get; }
    string? ShadowSource { get; }
    string Source { get; }
    double Width { get; }
    double X { get; }
    double Y { get; }
}