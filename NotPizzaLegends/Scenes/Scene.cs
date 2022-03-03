using Microsoft.AspNetCore.Components;
using NotPizzaLegends.Maps;
using NotPizzaLegends.Sprites;

namespace NotPizzaLegends.Scenes;

public interface IScene
{
    IMap? Map { get; }
    List<ISprite?> Sprites { get; }
    bool IsRunning { get; }
}

public abstract class Scene : ComponentBase, IScene
{
    public IMap? Map { get; protected set; }
    public List<ISprite?> Sprites { get; } = new();

    public bool IsRunning { get; protected set; }
}