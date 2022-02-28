namespace NotPizzaLegends.Sprites;

public abstract class Sprite : ISprite
{
    public string Source { get; protected set; } = string.Empty;
    public string? ShadowSource { get; protected set; }
}
