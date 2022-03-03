using Microsoft.AspNetCore.Components;

namespace NotPizzaLegends.Maps;

public abstract class Map : IMap
{
    public ElementReference? UpperSource { get; set; }
    public ElementReference? LowerSource { get; set; }
}
