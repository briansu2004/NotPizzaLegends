using Microsoft.AspNetCore.Components;
using NotPizzaLegends.Maps;
using NotPizzaLegends.Sprites;

namespace NotPizzaLegends.Scenes;

public interface IScene
{
    IMap? Map { get; }
    List<ISprite?> Sprites { get; }
    bool IsRunning { get; }

    void MoveDown();
    void MoveLeft();
    void MoveRight();
    void MoveUp();
}

public abstract class Scene : ComponentBase, IScene
{
    public IMap? Map { get; protected set; }
    public List<ISprite?> Sprites { get; } = new();

    public bool IsRunning { get; protected set; }

    public abstract void MoveUp();
    public abstract void MoveDown();
    public abstract void MoveLeft();
    public abstract void MoveRight();
}