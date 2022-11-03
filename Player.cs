using Raylib_cs;

class Player: Position{

    int MovementSpeed;

    public Player()
    {
        ColorsList.AddRange(colors);
        MovementSpeed = 4;

    }

    public void Move()
    {
        if (Raylib.IsKeyDown(KeyboardKey.KEY_UP)) {
            PlayerRectangle.y -= MovementSpeed;
        }
        if (Raylib.IsKeyDown(KeyboardKey.KEY_DOWN)) {
            PlayerRectangle.y += MovementSpeed;
        }

    }


}