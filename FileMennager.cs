using System;
using System.IO;

namespace Chess
{
    public class FileMennager
    {
        private static string path = "./"; //TODO: change to @"C:\Users\Public\Documents\Chess\";
        private static string settingsFile = "chessSettings.settings";
        private static string settingsPath {get {return path + settingsFile;}}
        
        
        public static bool SaveSettings()
        {
            string settings = GameSettings.GetSettingsText();
            try
            {
                using (StreamWriter sw = new StreamWriter(settingsPath))
                {
                    sw.WriteLine(settings.ToString());
                }
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }
        
        public static Exception LoadSettings()
        {
            try
            {
                if(!File.Exists(settingsPath))
                {
                    return new FileNotFoundException("Settings file not found");
                }
                using (StreamReader sr = new StreamReader(settingsPath))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        if (!line.Contains(":"))
                        {
                            continue;
                        }
                        string setting = line.Split(':')[0];
                        Console.WriteLine(setting);
                        string value = line.Split(':')[1];
                        Console.WriteLine(value);
                        GameSettings.SetSetting(setting, value);
                    }
                }

                Console.WriteLine("Settings loaded");   

                return null;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return e;
            }
        }
    }
}