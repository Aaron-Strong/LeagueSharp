using System;
using System.IO;
using LeagueSharp;
using LeagueSharp.Common;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MooSpammer
{
    class Champs {
        #region champNames
        static string[] champNames = new string[] {
        "Aatrox",
        "Ahri",
        "Akali",
        "Alistar",
        "Amumu",
        "Anivia",
        "Annie",
        "Ashe",
        "AurelionSol",
        "Azir",
        "Bard",
        "Blitzcrank",
        "Brand",
        "Braum",
        "Caitlyn",
        "Cassiopeia",
        "Cho'Gath",
        "Corki",
        "Darius",
        "Diana",
        "Dr.Mundo",
        "Draven",
        "Ekko",
        "Elise",
        "Evelyn",
        "Ezreal",
        "Fiddlesticks",
        "Fiora",
        "Fizz",
        "Galio",
        "Gangplank",
        "Garen",
        "Gnar",
        "Gragas",
        "Graves",
        "Hecarim",
        "Heimerdinger",
        "Illaoi",
        "Irelia",
        "Janna",
        "JarvenIV",
        "Jax",
        "Jayce",
        "Jax",
        "Jayce",
        "Jhin",
        "Jinx",
        "Kalista",
        "Karma",
        "Karthus",
        "Kassadiin",
        "Katarina",
        "Kayle",
        "Kennen",
        "Kha'Zix",
        "Kindred",
        "Kog'Maw",
        "LeBlanc",
        "LeeSin",
        "Leona",
        "Lissandra",
        "Lucian",
        "Lulu",
        "Lux",
        "Malphite",
        "Malzahar",
        "Maokai",
        "MasterYi",
        "MissFortune",
        "Mordekaiser",
        "Morgana",
        "MonkeyKing",
        "Nami",
        "Nasus",
        "Nautilus",
        "Nocturne",
        "Nunu",
        "Olaf",
        "Orianna",
        "Pantheon",
        "Poppy",
        "Quinn",
        "Rammus",
        "Rek'Sai",
        "Renekton",
        "Rengar",
        "Riven",
        "Rumble",
        "Ryze",
        "Sejuani",
        "Shaco",
        "Shen",
        "Shyvana",
        "Singed",
        "Sion",
        "Sivir",
        "Skarner",
        "Sona",
        "Soraka",
        "Swain",
        "Syndra",
        "TahmKench",
        "Taliyah",
        "Talon",
        "Taric",
        "Teemo",
        "Thresh",
        "Tristana",
        "Trundle",
        "Tryndamere",
        "TwistedFate",
        "Twitch",
        "Udyr",
        "Urgot",
        "Varus",
        "Vayne",
        "Veigar",
        "Vel'Koz",
        "Vi",
        "Viktor",
        "Vladimir",
        "Volibear",
        "Warwick",
        "Xerath",
        "XinZhao",
        "Yasuo",
        "Yorick",
        "Zac",
        "Zed",
        "Ziggs",
        "Zilean",
        "Zyra"
        };




        #endregion
        private static string LSDir = Config.AppDataDirectory;
        private static string MooSpammerDir = Path.Combine(LSDir, "MooSpammer");
        private static string ChampionsDir = Path.Combine(MooSpammerDir, "ChampionSpam");
        private static string CustomDir = Path.Combine(MooSpammerDir, "Custom");

        public static void Init()
        {
            CreateDir();
            //WriteJson();
        }

        static private void CreateDir()
        {
            if (! Directory.Exists(MooSpammerDir))
            {
                Console.WriteLine("[MooSpamer] MooSpammerDir Does Not Exist, Creating...");
                Directory.CreateDirectory(MooSpammerDir);
                Console.WriteLine("[MooSpamer] MooSPammerDir Created");
            }
            if (!Directory.Exists(ChampionsDir))
            {
                Console.WriteLine("[MooSpamer] ChampionsDir Does Not Exist, Creating...");
                Directory.CreateDirectory(ChampionsDir);
                Console.WriteLine("[MooSpamer] ChampionsDir Created");
            }
            if (!Directory.Exists(CustomDir))
            {
                Console.WriteLine("[MooSpamer] CustomDir Does Not Exist, Creating...");
                Directory.CreateDirectory(CustomDir);
                Console.WriteLine("[MooSpamer] Created CustomDir");
            }
            foreach (var champ in champNames)
            {
                if (!File.Exists(Path.Combine(ChampionsDir, champ + ".json")))
                {
                    Console.WriteLine("[MooSpamer] File for " + champ + " not found, creating...");
                    File.Create(Path.Combine(ChampionsDir, champ + ".json"));
                    Console.WriteLine("[MooSpamer]  for " + champ + " created");
                    Console.WriteLine("[MooSpamer] Created file for" + champ);
                }
            }
            if (!File.Exists(Path.Combine(CustomDir, "default.json")))
            {
                Console.WriteLine("[MooSpamer] Default custom file not found, creating...");
                File.Create(Path.Combine(CustomDir, "default.json"));
                Console.WriteLine("[MooSpamer] Default custom file created");
            }
            Game.PrintChat("[MooSpamer] Finished checking files!");
            Game.PrintChat("[MooSpamer] Files located at...");
            Game.PrintChat(MooSpammerDir);
            Console.WriteLine("[MooSpamer] Files located at...");
            Console.WriteLine(MooSpammerDir);
        }
        
         /*
        static private void WriteJson()
        {

        }
        */

        static public Dictionary<string, string> LoadJsonChamps()
        {
            string currentChamp = ObjectManager.Player.ChampionName;
            if (new FileInfo(ChampionsDir + "\\" +  currentChamp  + ".json").Length == 0)
            {
                Game.PrintChat($"[MooSpamer] Champion {ObjectManager.Player.ChampionName} not yet Supported");
                Game.PrintChat("[MooSpamer] Feel free to add spam to the github!");
                Game.PrintChat("[MooSpamer] Till then... i guess you got nothing special");
                return null;
            }
            else
            using (StreamReader r = new StreamReader(ChampionsDir + "\\" + currentChamp + ".json"))
            {
                
                string json = r.ReadToEnd();
                    try
                    {
                        Dictionary<string, string> Spam = JsonConvert.DeserializeObject<Dictionary<string, string>>(json);
                        return Spam;
                    }
                    catch (Exception)
                    {
                        Game.PrintChat("[MooSpamer] ERROR - Json file is in the wrong format!");
                        Game.PrintChat("[MooSpamer] Turning Off Champ Menu");
                        Game.PrintChat("[MooSpamer] See \"Example.json\" for formatting help!");
                        return null;
                    }
                
            }   
        }

        static public Dictionary<string, string> LoadJsonCustom()
        {
            string[] allFiles = Directory.GetFiles(CustomDir);
            foreach (string filename in allFiles)
            {
                if (!filename.EndsWith(".json"))
                {
                    Console.WriteLine("[MooSpammer] Invalid file type found in customDir");
                    Console.WriteLine($"[MooSpammer] {filename}");
                    return null;
                }
                else if (filename.EndsWith(".json"))
                {
                    if (allFiles.Length == 1) { 
                        using (StreamReader r = new StreamReader(filename))
                        {
                            string json = r.ReadToEnd();
                            try
                            {
                                Dictionary<string, string> Spam = JsonConvert.DeserializeObject<Dictionary<string, string>>(json);
                                return Spam;
                            }
                            catch (Exception)
                            {
                                Game.PrintChat("[MooSpamer] ERROR - Json file is in the wrong format!");
                                Game.PrintChat("[MooSpamer] Turning off CustomJson menu");
                                Game.PrintChat("[MooSpamer] See \"Example.json\" for formatting help!");
                                return null;
                            }
                        }
                    }
                    else
                    {
                        //Multiple Files Logic (dictionary of dictionaries) :S
                        //use filename.GetFileName for the short name.
                        return null;  //delete
                    }
                }
                else
                {
                    Console.WriteLine("[MooSpammer] No files found in CustomDir");
                    Game.PrintChat("[MooSpammer] No files found in CustomDir");
                    Game.PrintChat("[MooSpammer] Disabling json custom spam...");
                    return null;
                }
            }
           return null;
        }

    }
}
