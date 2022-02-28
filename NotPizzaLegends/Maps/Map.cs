namespace NotPizzaLegends.Maps;

public abstract class Map : IMap
{
    public double Width { get; protected set; } = 1.0;
    public double Height { get; protected set; } = 1.0;
    public string Source { get; protected set; } = string.Empty;
}
