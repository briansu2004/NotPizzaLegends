using NotPizzaLegends.Maps;

namespace NotPizzaLegends.Scenes;

public interface IScene
{
    IMap Map { get; }
    IGameObject[] GameObjects { get; }
}
