using Raylib_cs;
using System.Numerics;
class Screen: Color
{

    public Screen()
    {
        while (!Raylib.WindowShouldClose())
        {
            Raylib.BeginDrawing();
            Raylib.ClearBackground(Color.WHITE);
            Raylib.DrawText("Move the red square to the blue square with the arrow keys!", 12, 12, 20, Color.BLACK);

            if (Raylib.IsKeyDown(KeyboardKey.KEY_RIGHT)) 
            {
                PlayerRectangle.x += MovementSpeed;
            }
            if (Raylib.IsKeyDown(KeyboardKey.KEY_LEFT)) 
            {
                PlayerRectangle.x -= MovementSpeed;
            }
            if (Raylib.IsKeyDown(KeyboardKey.KEY_UP)) {
                PlayerRectangle.y -= MovementSpeed;
            }
            if (Raylib.IsKeyDown(KeyboardKey.KEY_DOWN)) {
                PlayerRectangle.y += MovementSpeed;
            }
            Raylib.DrawRectangleRec(TargetRectangle, Color.BLUE);
            Raylib.DrawRectangleRec(PlayerRectangle, Color.RED);

            if (Raylib.CheckCollisionRecs(PlayerRectangle, TargetRectangle)) {
                Raylib.DrawText("You did it!!!!", 12, 34, 20, Color.BLACK);
            }

            Raylib.EndDrawing();
        }
    }

}