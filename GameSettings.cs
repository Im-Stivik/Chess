using System;
using System.Drawing;

namespace Chess
{
    public class GameSettings
    {
        public static int BoardSize = 8;
        public static int PieceSize = 50;
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
                        LightColor = TextToColor(value);
                        Console.WriteLine("LightColor: " + LightColor);
                        break;
                    case "DarkColor":
                        DarkColor = TextToColor(value);
                        Console.WriteLine("DarkColor: " + DarkColor);
                        break;
                    case "OptionsColor":
                        OptionsColor = TextToColor(value);
                        Console.WriteLine("OptionsColor: " + OptionsColor);
                        break;
                    case "SelectedColor":
                        SelectedColor = TextToColor(value);
                        break;
                    case "EatPiesOptionColor":
                        EatPiesOptionColor = TextToColor(value);;
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
        
        private static Color TextToColor(string text)
        {
            //get the name from inside the brackets
            string name = text.Substring(text.IndexOf("[") + 1, text.IndexOf("]") - text.IndexOf("[") - 1);
            //if there are commas, it's not a named color
            if (name.Contains(","))
            {
                //get the RGB values
                string[] rgb = name.Split(',');
                //return the color
                return Color.FromArgb(int.Parse(rgb[0]), int.Parse(rgb[1]), int.Parse(rgb[2]));
            }
            else
            {
                //return the named color
                return Color.FromName(name);
            }
        }
    }
}