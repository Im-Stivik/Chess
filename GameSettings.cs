using System.Drawing;

namespace Chess
{
    public class GameSettings
    {
        public static int BoardSize = 8;
        public static int PieceSize = 50;
        public static int BoardWidth = BoardSize * PieceSize;
        public static int BoardHeight = BoardSize * PieceSize;
        public static int BoardMarginLeft = 50;
        public static int BoardMarginTop = 50;
        
        
        public static Color LightColor = Color.FromArgb(255, 255, 255);
        public static Color DarkColor = Color.Green;
        public static Color OptionsColor = Color.Cyan;
        public static Color SelectedColor = Color.DimGray;
        public static Color EatPiesOptionColor = Color.Gold;
    }
}