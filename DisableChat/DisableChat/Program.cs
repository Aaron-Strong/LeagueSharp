//hawk didn't want to talk in chat
using System;
using LeagueSharp;
using LeagueSharp.Common;
namespace DisableChat
{
    class Program
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
            if (args.Input == "/ff" || args.Input == "/surrender")
            {
                Game.Say("/ff");
            }
            else Game.Say("");
        }
    }
}
