using Raylib_cs;
using System.Numerics;
class Screen:GameColor
{
    int ScreenHeight;
    int ScreenWidth;
    List<GameObject> Objects = new List<GameObject>();
    

    Player player = new Player();
    Score score = new Score();
    public Screen(): base ()
    {
        ScreenHeight = 480;
        ScreenWidth = 800;
        var gem = new Gem ();
        Objects.Add(gem);
    }
    
    public void Run()
    {
        Raylib.InitWindow(ScreenWidth, ScreenHeight, "Greed");
        Raylib.SetTargetFPS(60);
  
        while (!Raylib.WindowShouldClose())
        {
            bool delete = false;
            int deleteIndex = 0;
            int index = 0;
            foreach (var obj in Objects)
            {
                if (!obj.CheckCollision(player.thePlayer))
                {
                    obj.Move();
                }
                else
                {
                    score.AdjustScore(obj);
                    delete = true;
                    deleteIndex = index;
                }

                index += 1;
            }
            if (delete)
            {
                Objects.RemoveAt(deleteIndex);
            }

            player.Move();

            if (random.Next(7) == 1)
            {
                int randNum = random.Next(2);
                if (randNum == 1)
                {
                    var rock = new Rock();
                    Objects.Add(rock);
                }
                else
                {
                    var gem = new Gem ();
                    Objects.Add(gem);
                }

            }

            Raylib.BeginDrawing();
            Raylib.ClearBackground(backgroundColor);

            score.Draw();
            player.Draw();

            foreach (var obj in Objects)
            {
                obj.Draw();
            }

            Raylib.EndDrawing();
        }

        Raylib.CloseWindow();
    }

}