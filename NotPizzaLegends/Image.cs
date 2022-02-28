namespace NotPizzaLegends;

public interface IImage
{
    string Source { get; }
    double Width { get; }
    double Height { get; }
}

public record Image(string Source, double Width, double Height) : IImage;