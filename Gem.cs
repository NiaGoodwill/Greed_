using Raylib_cs;
using System.Numerics;

class Gem: GameObject{

    int Radius;

    public Gem(): base()
    {
        Radius = 7;
    }

    public override void Draw()
    {
        Raylib.DrawCircle((int)Position.X, (int)Position.Y, Radius, theColor);

    }
    
    public override bool CheckCollision(Rectangle player)
    {
        return Raylib.CheckCollisionCircleRec (Position, Radius, player);
    }

}