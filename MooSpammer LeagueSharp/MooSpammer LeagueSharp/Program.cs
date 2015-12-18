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
            Console.WriteLine(args.Input);
            Console.WriteLine(text);

             switch (command)
            {

                case ".Cow":
                    Game.Say(@"/all . _________________");
                    Game.Say($"/all ( {text} )");
                    Game.Say(@"/all . -----------------");
                    Game.Say(@"/all .        o   ^__^");
                    Game.Say(@"/all .         o  (oO)\_______");
                    Game.Say(@"/all .            (__)\       )\/\");
                    Game.Say(@"/all .             U  ||----w |");
                    Game.Say(@"/all .                ||     ||");
                    break;
                case ".Dalek":
                    Game.Say(@"/all .              ___");
                    Game.Say(@"/all .      D>=G==='   '.");
                    Game.Say(@"/all .            |======|");
                    Game.Say(@"/all .            |======|");
                    Game.Say(@"/all .        )--/]IIIIII]");
                    Game.Say(@"/all .           |_______|");
                    Game.Say(@"/all .           C O O O D");
                    Game.Say(@"/all .          C O  O  O D");
                    Game.Say(@"/all .         C  O  O  O  D");
                    Game.Say(@"/all .         C__O__O__O__D");
                    Game.Say(@"/all .        [_____________]");
                    break;
                case ".Milk":
                    Game.Say($"/all ( {text}");
                    Game.Say(@"/all . o   /////////////\\\\");
                    Game.Say(@"/all .  o /___________/___/|");
                    Game.Say(@"/all .    |          |     |");
                    Game.Say(@"/all .    | ==\\ /== |     |");
                    Game.Say(@"/all .    |   O   O  | \\ \\ |");
                    Game.Say(@"/all .    |     <    |  \\ \\|");
                    Game.Say(@"/all .   /|          |   \\ \\");
                    Game.Say(@"/all .  / |  \\_____/ |   / /");
                    Game.Say(@"/all . / /|          |  / /|");
                    Game.Say(@"/all ./||\\---------- | /||\\/");
                    break;
                default:
                    return;
            }
        }
    }
}
