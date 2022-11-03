using Raylib_cs;
using System.Numerics;
class Screen:Color
{

    int ScreenHeight;
    int ScreenWidth;
    public Screen()
    {
        ScreenHeight = 480;
        ScreenWidth = 800;
    }
    
    public void Run()
    {
        Raylib.InitWindow(ScreenWidth, ScreenHeight, "Square Game");
        Raylib.SetTargetFPS(60);


        while (!Raylib.WindowShouldClose())
        {
            Raylib.BeginDrawing();
            Raylib.ClearBackground(backgroundColor);

            Raylib.DrawRectangleRec(TargetRectangle, Color.BLUE);
            Raylib.DrawRectangleRec(PlayerRectangle, Color.RED);

            if (Raylib.CheckCollisionRecs(PlayerRectangle, TargetRectangle)) {
                Raylib.DrawText("You did it!!!!", 12, 34, 20, Color.BLACK);
            }

            Raylib.EndDrawing();
        }

        Raylib.CloseWindow();

    }

}