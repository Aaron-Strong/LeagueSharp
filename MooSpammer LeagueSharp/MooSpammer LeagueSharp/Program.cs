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
            if (command == null)
            {
                Game.PrintChat("<font color='#00FFFF'>Add a spacebar dippy</font>")
            }
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
                case ".Lobby":
                    Game.Say($"/all Welcome to {text}'s Modded Lobby");
                    Utility.DelayAction.Add(1000, () => Game.Say($"/all Press L3 for the Mod Menu"));
                    Utility.DelayAction.Add(2000, () => Game.Say($"/all Press R3 for All Unlocks"));
                    Utility.DelayAction.Add(3000, () => Game.Say($"/all Follow {text} on TheTechGame & SevenSins @{text}"));
                    Utility.DelayAction.Add(4000, () => Game.Say($"/all Don't forget to donate for more modded lobbies!"));
                    Utility.DelayAction.Add(5000, () => Game.Say($"/all Aimbot Exploit Succesfully injected!"));
                    Utility.DelayAction.Add(6000, () => Game.Say($"/all +3Ba246218 exp"));
                    Utility.DelayAction.Add(7000, () => Game.Say($"/all Don't forget to restart the game to prestige!"));
                    Utility.DelayAction.Add(8000, () => Game.Say($"/all This lobby is sponsored by GFuel!"));
                    Utility.DelayAction.Add(9000, () => Game.Say($"/all To find out more visit their website at"));
                    Utility.DelayAction.Add(10000, () => Game.Say($"/all www.gfuel.com"));
                    Utility.DelayAction.Add(11000, () => Game.Say($"/all And incase you get banned we also sell accounts at"));
                    Utility.DelayAction.Add(12000, () => Game.Say($"/all www.moo.tokyo"));
                    break;
                default:
                    return;
            }
        }
    }
}
