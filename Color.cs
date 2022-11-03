class Color {
List<string> ColorsList = new List<string>();
string thecolor;
string[] colors = { "LIGHTGRAY", "GRAY", "DARKGRAY", "YELLOW", "GOLD", "ORANGE", "PINK", "RED", "MARON", "GREEN", "LIME", "DARKGREEN", "SKYBLUE", "BLUE", "DARKBLUE", "PURPLE", "VIOLET", "DARKPURPLE", "BEIGE", "BROWN", "DARKBROWN"
};
public Color(){
   ColorsList.AddRange(colors);
}

// protected string backgroundColor = "Color.BLACK";
// protected string playerColor = "WHITE";
// protected void BackgroundColor()
// {
   // Color.BLACK;
// }

// string PlayerColor(){
//     thecolor = "WHITE";
//     return thecolor;
// }

}