namespace NotPizzaLegends.Maps.Interiors;

public class DemoMap : Map
{
    private const string _upperSource = "../images/maps/DemoUpper.png";
    private const string _lowerSource = "../images/maps/DemoLower.png";

    public DemoMap() : base(_upperSource, _lowerSource)
    {
    }
}
