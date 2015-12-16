using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeagueSharp;
using LeagueSharp.Common;
namespace MooSpammer_LeagueSharp
{
    internal class Program
    {

        static void Main(string[] args)
        {

            CustomEvents.Game.OnGameLoad += game_OnGameLoad;
        }

        private static void game_OnGameLoad(EventArgs args)
        {

            Game.OnInput += Game_OnGameInput;

        }

        private static void Game_OnGameInput(GameInputEventArgs args)
        {
            string command = args.Input.Split(' ').First();
            string text = args.Input.Substring(args.Input.IndexOf(' '));
            
            if (args.Input.StartsWith("/"))
            {
                args.Process = false;
            }
            Console.WriteLine(args.Input);
            Console.WriteLine(text);
             switch (command)
            {

                case ".Cow":
                    Game.Say(@". _________________");
                    Game.Say($"( {text} )");
                    Game.Say(@". -----------------");
                    Game.Say(@".        o   ^__^");
                    Game.Say(@".         o  (oO)\_______");
                    Game.Say(@".            (__)\       )\/\");
                    Game.Say(@".             U  ||----w |");
                    Game.Say(@".                ||     ||");
                    break;
                default:
                    return;
            }
        }
    }
}
