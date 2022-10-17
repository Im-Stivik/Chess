using System;
using System.Drawing;

namespace Chess
{
    public class GameSettings
    {
        public const int BoardSize = 8;
        public static int PieceSize = 50;
        public static int BoardWidth {get {return BoardSize * PieceSize;} set {PieceSize = value / BoardSize;}}
        public static int BoardHeight {get {return BoardSize * PieceSize;} set {PieceSize = value / BoardSize;}}
        public static int BoardMarginLeft = 30;
        public static int BoardMarginTop = 30;
        
        
        public static Color LightColor = Color.FromArgb(255, 255, 255);
        public static Color DarkColor = Color.Green;
        public static Color OptionsColor = Color.Cyan;
        public static Color SelectedColor = Color.DimGray;
        public static Color EatPiesOptionColor = Color.Gold;
        
        public static int ForwardButtonMarginLeft = 30;
        public static int ForwardButtonMarginTop = 30;
        public static int ForwardButtonWidth = 50;
        public static int ForwardButtonHeight = 50;
        public static int ForwardButtonX { get { return BoardMarginLeft + BoardWidth + ForwardButtonMarginLeft; } }
        public static int ForwardButtonY { get{ return ForwardButtonMarginTop; }}

        public static int BackButtonMarginLeft = 30;
        public static int BackButtonMarginTop = 30;
        public static int BackButtonWidth = 50;
        public static int BackButtonHeight = 50;
        public static int BackButtonX { get { return BoardMarginLeft + BoardWidth + BackButtonMarginLeft; } }
        public static int BackButtonY {get {return BackButtonMarginTop + ForwardButtonHeight + ForwardButtonMarginTop;}}

        public static Size GetWindowSize()
        {
            int width = BackButtonX + BackButtonWidth;
            if(width < ForwardButtonX + ForwardButtonWidth)
                width = ForwardButtonX + ForwardButtonWidth;
            int height = BoardHeight + BoardMarginTop;
            if(height < ForwardButtonY + ForwardButtonHeight)
                height = ForwardButtonY + ForwardButtonHeight;
            if(height < BackButtonY + BackButtonHeight)
                height = BackButtonY + BackButtonHeight;
            return new Size(width + PieceSize, height +PieceSize);
        }
        
        public static string GetSettingsText()
        {
            string result = "";
            result += "PieceSize: " + PieceSize + "\n";
            result += "BoardMarginLeft: " + BoardMarginLeft + "\n";
            result += "BoardMarginTop: " + BoardMarginTop + "\n";
            result += "LightColor: " + LightColor + "\n";
            result += "DarkColor: " + DarkColor + "\n";
            result += "OptionsColor: " + OptionsColor + "\n";
            result += "SelectedColor: " + SelectedColor + "\n";
            result += "EatPiesOptionColor: " + EatPiesOptionColor + "\n";
            result += "ForwardButtonMarginLeft: " + ForwardButtonMarginLeft + "\n";
            result += "ForwardButtonMarginTop: " + ForwardButtonMarginTop + "\n";
            result += "ForwardButtonWidth: " + ForwardButtonWidth + "\n";
            result += "ForwardButtonHeight: " + ForwardButtonHeight + "\n";
            result += "BackButtonMarginLeft: " + BackButtonMarginLeft + "\n";
            result += "BackButtonMarginTop: " + BackButtonMarginTop + "\n";
            result += "BackButtonWidth: " + BackButtonWidth + "\n";
            result += "BackButtonHeight: " + BackButtonHeight + "\n";
            return result;
        }

        public static string SetSetting(string name, string value)
        {
            try
            {
                switch (name)
                {
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
                    case "ForwardButtonMarginLeft":
                        ForwardButtonMarginLeft = int.Parse(value);
                        break;
                    case "ForwardButtonMarginTop":
                        ForwardButtonMarginTop = int.Parse(value);
                        break;
                    case "ForwardButtonWidth":
                        ForwardButtonWidth = int.Parse(value);
                        break;
                    case "ForwardButtonHeight":
                        ForwardButtonHeight = int.Parse(value);
                        break;
                    case "BackButtonMarginLeft":
                        BackButtonMarginLeft = int.Parse(value);
                        break;
                    case "BackButtonMarginTop":
                        BackButtonMarginTop = int.Parse(value);
                        break;
                    case "BackButtonWidth":
                        BackButtonWidth = int.Parse(value);
                        break;
                    case "BackButtonHeight":
                        BackButtonHeight = int.Parse(value);
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