namespace NotPizzaLegends.Sprites.Characters;

public class Hero : Sprite
{
    public Hero(double x, double y) : base(x, y)
    {
        Source = "../images/characters/people/hero.png";
        ShadowSource = "../images/characters/shadow.png";
    }
}
