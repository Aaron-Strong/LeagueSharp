using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using LeagueSharp;
using LeagueSharp.Common;
using Newtonsoft.Json;

namespace MooSpammer
{
    internal class Champs
    {
        #region champNames

        private static readonly string[] champNames =
        {
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

        public static readonly string LSDir = Config.AppDataDirectory;
        public static readonly string MooSpammerDir = Path.Combine(LSDir, "MooSpammer");
        public static readonly string ChampionsDir = Path.Combine(MooSpammerDir, "ChampionSpam");
        public static readonly string CustomDir = Path.Combine(MooSpammerDir, "Custom");

        public static void Init()
        {
            CreateDir();
        }

        private static void CreateDir()
        {
            if (!Directory.Exists(MooSpammerDir) && !Directory.Exists(ChampionsDir) && !Directory.Exists(CustomDir))
            {
                Game.PrintChat("[MooSpammer] First time loaded...");
                Console.WriteLine("[MooSpammer] First time loaded...");
                Game.PrintChat($"[MooSpammer] Creating files in {MooSpammerDir}");
                Console.WriteLine($"[MooSpammer] Creating files in {MooSpammerDir}");
                MakeFolder(MooSpammerDir);
                MakeFolder(ChampionsDir);
                MakeFolder(CustomDir);
            }
            else
            {
                if (!Directory.Exists(MooSpammerDir)) MakeFolder(MooSpammerDir);
                if (!Directory.Exists(ChampionsDir)) MakeFolder(ChampionsDir);
                if (!Directory.Exists(CustomDir)) MakeFolder(CustomDir);
            }
            foreach (var champ in champNames)
                if (!File.Exists(Path.Combine(ChampionsDir, champ + ".json")))
                {
                    Console.WriteLine("[MooSpammer] File for " + champ + " not found, creating...");
                    File.Create(Path.Combine(ChampionsDir, champ + ".json")).Close();
                    Console.WriteLine("[MooSpammer]  for " + champ + " created");
                }
            if (!File.Exists(Path.Combine(CustomDir, "default.json")))
            {
                Console.WriteLine("[MooSpammer] Default custom file not found, creating...");
                File.Create(Path.Combine(CustomDir, "default.json")).Close();
                File.WriteAllText(Path.Combine(CustomDir, "default.json"), "{\n\n}");
                Console.WriteLine("[MooSpammer] Default custom file created");
            }
            if (!File.Exists(Path.Combine(CustomDir, "saved.json")))
            {
                Console.WriteLine("[MooSpammer] Default custom file not found, creating...");
                File.Create(Path.Combine(CustomDir, "saved.json")).Close();
                File.WriteAllText(Path.Combine(CustomDir, "saved.json"), "{\n\n}");
                Console.WriteLine("[MooSpammer] Default custom file created");
            }
        }

        private static void MakeFolder(string Dir)
        {
            Console.WriteLine($"[MooSpammer] {Dir} Does Not Exist, Creating...");
            Directory.CreateDirectory(Dir);
            Console.WriteLine($"[MooSpammer] {Dir} Created");
        }


        public static Dictionary<string, string> LoadJsonChamps()
        {
            var currentChamp = ObjectManager.Player.ChampionName;
            if (new FileInfo(ChampionsDir + "\\" + currentChamp + ".json").Length == 0)
            {
                Game.PrintChat($"[MooSpammer] Champion {ObjectManager.Player.ChampionName} not yet Supported");
                //Game.PrintChat("[MooSpammer] Feel free to add spam to the github!");
                //Game.PrintChat("[MooSpammer] Till then... i guess you got nothing special");
                return null;
            }
            using (var r = new StreamReader(ChampionsDir + "\\" + currentChamp + ".json"))
            {
                var json = r.ReadToEnd();
                try
                {
                    var Spam = JsonConvert.DeserializeObject<Dictionary<string, string>>(json);
                    return Spam;
                }
                catch (Exception)
                {
                    Game.PrintChat("[MooSpammer] ERROR - Json file is in the wrong format!");
                    Game.PrintChat("[MooSpammer] Turning Off Champ Menu");
                    Game.PrintChat("[MooSpammer] See \"Example.json\" for formatting help!");
                    return null;
                }
            }
        }

        public static Dictionary<string, string> LoadJsonCustom()
        {
            var allFiles = Directory.GetFiles(CustomDir);
            var fileCount = allFiles.Length;
            var Spam = new Dictionary<string, string>();
            var FinalSpam = new Dictionary<string, string>();
            if (fileCount == 0)
            {
                Console.WriteLine("[MooSpammer] No files found in customDir");
                Console.WriteLine("[MooSpammer] Disabling CustomJson function...");
                return null;
            }

            foreach (var filename in allFiles)
                if (!filename.EndsWith(".json"))
                {
                    Console.WriteLine("[MooSpammer] Invalid file type found in customDir");
                    Console.WriteLine($"[MooSpammer] {filename}");
                }

                //json file open login thingy moo
                else if (filename.EndsWith(".json"))
                {
                    try
                    {
                        using (var r = new StreamReader(filename))
                        {
                            var json = r.ReadToEnd();
                            try
                            {
                                Spam = JsonConvert.DeserializeObject<Dictionary<string, string>>(json);
                                FinalSpam = FinalSpam.Concat(Spam)
                                    .GroupBy(d => d.Key)
                                    .ToDictionary(d => d.Key, d => d.First().Value);
                                Program.counter = Program.counter + File.ReadAllLines(filename).Count() - 2;
                                Console.WriteLine($"CustomSpam file {filename} found and loaded");
                            }
                            catch (Exception Ex)
                            {
                                Game.PrintChat("[MooSpammer] ERROR - Json file formatting");
                                Game.PrintChat("[MooSpammer] Check console for more info");
                                Console.WriteLine($"[MooSpammer] Json formatting error at {filename}");
                                Console.WriteLine($"[MooSpammer] {Ex}");
                                //return null;
                            }
                        }
                    }
                    catch
                        (Exception Ex)
                    {
                        Console.WriteLine("[MooSpammer] Exception whilst making custom json: " + Ex);
                        Game.PrintChat(
                            "<font color='#ff0000'>Something went wrong with MooSpammer. Press F5(reload hotkey) to fix!</font>");
                    }
                }

                else
                {
                    Console.WriteLine("[MooSpammer] No files found in CustomDir");
                    Console.WriteLine("[MooSpammer] Disabling json custom spam...");
                    return null;
                }
            return FinalSpam;
        }
    }
}