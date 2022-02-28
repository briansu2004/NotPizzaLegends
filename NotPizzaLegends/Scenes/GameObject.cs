using NotPizzaLegends.Sprites;

namespace NotPizzaLegends.Scenes;

public class GameObject : IGameObject
{
    public bool ShowShadow { get; } = true;
    public ISprite Sprite { get; private set; }
    public double X { get; protected set; }
    public double Y { get; protected set; }

    public GameObject(ISprite sprite, double x = 0, double y = 0)
    {
        Sprite = sprite;
        X = x;
        Y = y;
    }
}

public class GameObject<T> : GameObject where T : ISprite, new()
{
    public GameObject(double x = 0, double y = 0) : base(new T(), x, y) { }
}
