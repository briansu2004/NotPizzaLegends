namespace NotPizzaLegends.Maps;

public abstract class Map : IMap
{
    public string UpperSource { get; private set; }
    public string LowerSource { get; private set; }

    public Map(string upperSource, string lowerSource)
    {
        UpperSource = upperSource;
        LowerSource = lowerSource;
    }
}
