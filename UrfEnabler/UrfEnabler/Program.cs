using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeagueSharp;
using LeagueSharp.Common;
using System.Media;

namespace UrfEnabler
{
    class Program
    {
        static int moo = 1;
        private static readonly SoundPlayer Degrec = new SoundPlayer(Resource2.Degrec);
        static void Main(string[] args)
        {
            CustomEvents.Game.OnGameLoad += Game_OnGameLoad;
        }

        private static void Game_OnGameLoad(EventArgs args)
        {
            Game.OnUpdate += Game_OnGameUpdate;
        }

        private static void Game_OnGameUpdate(EventArgs args)
        {
            if (moo == 1)
            {
                moo--;
                Degrec.Play();
                Utility.DelayAction.Add(10000, () => moo++);
            }
        }
    }
}