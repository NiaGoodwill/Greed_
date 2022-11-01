class Color {
 List<string> ColorsList = new List<string>();
 string thecolor;
 string[] colors = { "LIGHTGRAY", "GRAY", "DARKGRAY", "YELLOW", "GOLD", "ORANGE",
 "PINK", "RED", "MARON", "GREEN", "LIME", "DARKGREEN", "SKYBLUE", "BLUE",
 "DARKBLUE", "PURPLE", "VIOLET", "DARKPURPLE", "BEIGE", "BROWN", "DARKBROWN"
 };
 public Color(){
    ColorsList.AddRange(colors);

 }

 string BackgroundColor = "BLACK";
 string PlayerColor = "WHITE";
// string BackgroundColor(){
//     thecolor = "BLACK";
//     return thecolor;
// }

// string PlayerColor(){
//     thecolor = "WHITE";
//     return thecolor;
// }

}