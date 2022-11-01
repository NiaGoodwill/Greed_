using Raylib_cs;
using System.Numerics;

namespace HelloWorld
{
    static class Program
    {
        public static void Main()
        {

            var ScreenHeight = 480;
            var ScreenWidth = 800;
            var RectangleSize = 50;

            var PlayerRectangle = new Rectangle(ScreenWidth - (RectangleSize * 2), ScreenHeight - (RectangleSize * 2), RectangleSize, RectangleSize);
            var TargetRectangle = new Rectangle(100, 100, RectangleSize, RectangleSize);
            var MovementSpeed = 4;

            Raylib.InitWindow(ScreenWidth, ScreenHeight, "Square Game");
            Raylib.SetTargetFPS(60);

            Raylib.CloseWindow();
        }
    }
}

