using Microsoft.AspNetCore.Components;

namespace NotPizzaLegends.Maps;

public interface IMap
{
    ElementReference? UpperSource { get; set; }
    ElementReference? LowerSource { get; set; }
}