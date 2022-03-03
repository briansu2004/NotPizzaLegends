using Microsoft.AspNetCore.Components;

namespace NotPizzaLegends.Sprites;

public interface ISprite
{
    ElementReference? ShadowSource { get; set; }
    ElementReference? Source { get; set; }
}