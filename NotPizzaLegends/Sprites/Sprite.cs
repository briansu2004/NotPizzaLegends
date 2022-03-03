using Microsoft.AspNetCore.Components;

namespace NotPizzaLegends.Sprites;

public abstract class Sprite : ISprite
{
    public ElementReference? Source { get; set; }
    public ElementReference? ShadowSource { get; set; }
}
