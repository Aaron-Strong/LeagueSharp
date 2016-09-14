using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeagueSharp;
using LeagueSharp.Common;
namespace MooLeeSin
{
    class Start
    {
        static void Main(string[] args)
        {
            
            CustomEvents.Game.OnGameLoad += OnGameLoad;
        }

        private static void OnGameLoad(EventArgs args)
        {
            if (ObjectManager.Player.ChampionName != "LeeSin") return;
            MenuConfig.init();
            Spells.init();
            Game.OnUpdate += OnGameUpdate;
        }

        private static void OnGameUpdate(EventArgs args)
        {
            Combo.init();
            Harass.init();
            Farm.init();
            Wardhop.init();
            Insec.init();
            Drawings.init();
        }
    }
}
