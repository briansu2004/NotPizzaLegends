using Microsoft.AspNetCore.Components;

namespace NotPizzaLegends.Maps;

public interface IMap
{
    ElementReference? UpperSource { get; set; }
    ElementReference? LowerSource { get; set; }
}

public class Map : ComponentBase, IMap
{
    public ElementReference? UpperSource { get; set; }
    public ElementReference? LowerSource { get; set; }
}
