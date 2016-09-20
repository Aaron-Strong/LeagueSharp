using System;
using LeagueSharp;
using LeagueSharp.SDK;
namespace MooLeeSin
{
    class Start
    {
        static void Main(string[] args)
        {
            Bootstrap.Init(); 
            Events.OnLoad += OnGameLoad;
        }

        private static void OnGameLoad(object sender, EventArgs args)
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
