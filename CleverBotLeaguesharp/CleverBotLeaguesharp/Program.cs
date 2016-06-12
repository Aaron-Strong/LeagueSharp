using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeagueSharp;
using LeagueSharp.Common;
using LeagueSharp.Common.Data;
namespace CleverBotLeaguesharp
{
    class Program
    {
        public static int count = 0;
        public static string lastSender = "Error, sender name hasn't changed!";
        public static bool newTyper = true;
        public static string me = ObjectManager.Player.Name;
        public static string message = "";
        static void Main(string[] args)
        {
            CustomEvents.Game.OnGameLoad += on_game_load;
        }

        private static void on_game_load(EventArgs args)
        {
            Game.OnChat += on_game_chat;
        }

        private static void on_game_chat(GameChatEventArgs args)
        {
            message = args.Message.ToLower();
            if (args.Sender.Name != me)
            {
                if (lastSender != args.Sender.Name)
                {
                    count = 1;
                    newTyper = true;
                    Game.Say("Ahh i see {} else has decided to type, what a fucking moron");
                }
                if (count == 0 && !newTyper)
                {
                    count++;
                    Game.Say($"This game I'm going to troll so... Fuck off typing {args.Sender.ChampionName} you useless scum!");
                    lastSender = args.Sender.Name;
                }
                if (count == 1)
                {
                    count++;
                    Game.Say($"{args.Sender.ChampionName} WILL YOU FUCK OFF TYPING!");
                    lastSender = args.Sender.Name;
                }
                if (count == 2)
                {
                    count++;
                    Game.Say($"I'M GOING TO DDOS YOUR FUCKING GAME IF YOU DON'T STOP TYPING PIECE OF SHIT!");
                    lastSender = args.Sender.Name;
                }
                if (count > 2)
                {
                    Game.Say($"BLA BLA BLA NO ONE FUCKING CARES {args.Sender.ChampionName}");
                    lastSender = args.Sender.Name;
                    return;
                }
                switch (message)
                {
                    case "gg":
                        Game.Say("GG MY ASS GO FUCK YOURSELF!");
                        break;
                    case "ggez":
                    case "ez":
                        Game.Say("ONLY EASY CUZ MY TEAM SUCKS FUCKING DICK!");
                        break;
                    case "can we surr":
                    case "can we surr?":
                    case "can we surrender":
                    case "can we surrender?":
                        Game.Say("CAN WE SURR? CAN WE FUCKING SURRENDER? NO, GO FUCK YOURSELF!");
                        break;
                    case "moo":
                        Game.Say($"DID SOMEONE SAY MOO ERMAGAWD I LOVE YOU {args.Sender.ChampionName}");
                        break;
                    default:
                        Game.Say("");
                        break;
                    
                }
                    

                if (args.Message.ToLower() ==  "ggez" || args.Message.ToLower() == "ez")
                {
                    Game.Say("ONLY EASY CUZ MY TEAM SUCKS FUCKING DICK!");
                }
                if (args.Message.ToLower() == "can we surr" || args.Message.ToLower() == "can we surrender")
                {
                    Game.Say("CAN WE SURR? CAN WE FUCKING SURRENDER? NO, GO FUCK YOURSELF!");
                }

                lastSender = args.Sender.Name;
            }
        }
    }
}
