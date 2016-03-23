using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeagueSharp;
using LeagueSharp.Common;
using System.Media;
using System.Threading;

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
                    Game.Say($"/all .( {text} )");
                    Game.Say(@"/all .   o   D>=G==='   '.");
                    Game.Say(@"/all .            |======|");
                    Game.Say(@"/all .     o      |======|");
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
                case ".Hack":
                    Game.Say($"/all Welcome to Miku's Modded Lobby");
                    Game.Say($"/all Press L3 for the Mod Menu");
                    Game.Say($"/all Press R3 for All Unlocks");
                    Game.Say($"/all Follow Miku on THeTechHame & SevenSins");
                    Game.Say($"/all Don't forget to donate for more modded lobbies!");
                    Game.Say($"/all Aimbot Exploit Succesfully injected!");
                    Game.Say($"/all +3Ba246218 exp");
                    Game.Say($"/all Don't forget to restart the game and prestige!");
                    break;
                default:
                    return;
            }
        }
    }
}
