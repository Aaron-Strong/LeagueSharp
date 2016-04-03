using LeagueSharp;
using LeagueSharp.Common;
using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace MooSpammer_LeagueSharp
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            CustomEvents.Game.OnGameLoad += game_OnGameLoad;
        }

        private static void game_OnGameLoad(EventArgs args)
        {
            Game.OnInput += Game_OnGameInput;
        }

        private static void Game_OnGameInput(GameInputEventArgs args)
        {
            string arg = args.Input;
            string text = ("");
            string command = ("");
            if (arg.Contains(" "))
            {
                command = args.Input.Split(' ').First();
                text = args.Input.Substring(args.Input.IndexOf(' '));
            }
            else

            {
                command = args.Input;
            }

            switch (command)

            {
                case ".Custom":
                    Console.WriteLine("Command =" + command);
                    Console.WriteLine("Text =" + text);
                    customSpam(text);
                    break;

                case ".ClearConsole":
                    Console.Clear();
                    Game.PrintChat("ConsoleCleared");
                    break;

                default:
                    return;
            }
        }

        public static void customSpam(string customText)
        {
            int Lines = 0;
            string spam = "Error";
            Match regexMatch = Regex.Match(customText, "\\d");

            if (regexMatch.Success)
            {
                int digitStartIndex = regexMatch.Index;
                spam = customText.Substring(0, digitStartIndex);
                Lines = Convert.ToInt32(customText.Substring(digitStartIndex));
            }
            Console.WriteLine($"customText ={customText}");
            Console.WriteLine($"Spam ={spam}");
            Console.WriteLine($"Lines ={Lines}");

            for (int L = Lines; L >= 1; L--)
            {
                Game.Say($"spam - {Lines}");
                Game.PrintChat($"<font color='#00FFFF'>spam</font> - {Lines}");
                Console.WriteLine("spam");
                
            }
        }
    }
}