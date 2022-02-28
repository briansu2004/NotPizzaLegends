using NotPizzaLegends.Maps;
using NotPizzaLegends.Maps.Interiors;
using NotPizzaLegends.Sprites;
using NotPizzaLegends.Sprites.Characters;

namespace NotPizzaLegends.Scenes;

public class DemoScene : IScene
{
    public IMap Map => DemoMap;
    public IGameObject[] GameObjects => new IGameObject[] { Hero };


    // Map
    public DemoMap DemoMap { get; private set; } = new DemoMap();

    // Character(s) in scene
    public IGameObject Hero { get; private set; } = new GameObject<Hero>(0.5, 3.0);
}
