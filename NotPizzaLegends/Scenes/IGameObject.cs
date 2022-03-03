using NotPizzaLegends.Sprites;

namespace NotPizzaLegends.Scenes;

public interface IGameObject
{
    bool ShowShadow { get; }
    ISprite Sprite { get; }
    double X { get; }
    double Y { get; }

    void Move(double x, double y);
}