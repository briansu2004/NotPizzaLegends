using Microsoft.AspNetCore.Components;
using NotPizzaLegends.Scenes;

namespace NotPizzaLegends.Canvas;

public interface ICanvasService
{
    Task RenderScene(ElementReference canvas, IScene scene);
}
