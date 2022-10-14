using System;
using System.Drawing;

namespace Chess
{
    public class GameSettings
    {
        public static int BoardSize = 8;
        public static int PieceSize = 50;
        public static int BoardWidth = BoardSize * PieceSize;
        public static int BoardHeight = BoardSize * PieceSize;
        public static int BoardMarginLeft = 30;
        public static int BoardMarginTop = 30;
        
        
        public static Color LightColor = Color.FromArgb(255, 255, 255);
        public static Color DarkColor = Color.Green;
        public static Color OptionsColor = Color.Cyan;
        public static Color SelectedColor = Color.DimGray;
        public static Color EatPiesOptionColor = Color.Gold;

        public static string GetSettingsText()
        {
            string result = "";
            result += "BoardSize: " + BoardSize + "\n";
            result += "PieceSize: " + PieceSize + "\n";
            result += "BoardMarginLeft: " + BoardMarginLeft + "\n";
            result += "BoardMarginTop: " + BoardMarginTop + "\n";
            result += "LightColor: " + LightColor + "\n";
            result += "DarkColor: " + DarkColor + "\n";
            result += "OptionsColor: " + OptionsColor + "\n";
            result += "SelectedColor: " + SelectedColor + "\n";
            result += "EatPiesOptionColor: " + EatPiesOptionColor + "\n";
            return result;
        }

        public static string SetSetting(string name, string value)
        {
            try
            {
                switch (name)
                {
                    case "BoardSize":
                        BoardSize = int.Parse(value);
                        break;
                    case "PieceSize":
                        PieceSize = int.Parse(value);
                        break;
                    case "BoardMarginLeft":
                        BoardMarginLeft = int.Parse(value);
                        break;
                    case "BoardMarginTop":
                        BoardMarginTop = int.Parse(value);
                        break;
                    case "LightColor":
                        LightColor = Color.FromName(value);
                        break;
                    case "DarkColor":
                        DarkColor = Color.FromName(value);
                        break;
                    case "OptionsColor":
                        OptionsColor = Color.FromName(value);
                        break;
                    case "SelectedColor":
                        SelectedColor = Color.FromName(value);
                        break;
                    case "EatPiesOptionColor":
                        EatPiesOptionColor = Color.FromName(value);
                        break;
                    default:
                        return "Unknown setting";
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }

            return null;
        }
    }
}