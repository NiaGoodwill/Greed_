using Raylib_cs;
using System.Numerics;


class GameColor {
   protected Random random = new Random();
   protected List<Color> ColorsList = new List<Color>();
   protected Color[] colors = { Color.LIGHTGRAY, Color.GRAY, Color.DARKGRAY, Color.YELLOW, Color.GOLD, Color.ORANGE, Color.PINK, Color.RED, Color.MAROON, Color.GREEN, Color.LIME, Color.DARKGREEN, Color.SKYBLUE, Color.BLUE, Color.DARKBLUE, Color.PURPLE, Color.VIOLET, Color.DARKPURPLE, Color.BEIGE, Color.BROWN, Color.DARKBROWN};

   protected Color backgroundColor = Color.BLACK;
   protected Color playerColor = Color.WHITE;

   public GameColor()
   {
      ColorsList.AddRange(colors);
   }

   public Color RandomColor()
   {
      int randIndex = random.Next(ColorsList.Count());
      Color thecolor = ColorsList[randIndex];
      return thecolor;
   }

}