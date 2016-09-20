using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using LeagueSharp;
using LeagueSharp.SDK;
using LeagueSharp.SDK.Enumerations;
using LeagueSharp.SDK.UI;
using SharpDX;
using Color = System.Drawing.Color;
using Menu = LeagueSharp.SDK.UI.Menu;
using MenuItem = LeagueSharp.SDK.UI.MenuItem;

namespace MooLeeSin
{
    internal class MenuConfig
    {
        public static Menu MenuHome,
            MenuOrbwalker,
            MenuCombo,
            MenuHarass,
            MenuFarm,
            MenuMoochanics,
            MenuWardhop,
            MenuDrawings;


        public static void init()
        {
            MenuHome = new Menu("MooLeeSin", "MooLeeSin",true);
            

            MenuCombo = MenuHome.Add(new Menu("Combo", "Combo"));
            {
                MenuCombo.Add(new MenuBool("wGapCloser", "Use W as gapcloser", true));
                // TODO: Combo menu
            }
            MenuHarass = MenuHome.Add(new Menu("Harass", "Harass"));
            {
                MenuHarass.Add(new MenuBool("wShield", "Use W as shield", true));
                MenuHarass.Add(new MenuKeyBind("qPoke", "Q poke and run", 
                    System.Windows.Forms.Keys.Space, KeyBindType.Press));
                // TODO: Harass menu
            }
            MenuFarm = MenuHome.Add(new Menu("Farm", "Farm"));
            {
                MenuFarm.Add(new MenuBool("useQ", "Use Q", true));
                MenuFarm.Add(new MenuBool("useW", "Use W", true));
                MenuFarm.Add(new MenuBool("useE", "Use E", true));
                MenuFarm.Add(new MenuBool("usePassive", "Use Passive", true));
                // TODO: Farm menu
            }
            MenuMoochanics = MenuHome.Add(new Menu("Moochanics", "Moochanics"));
            {
                MenuMoochanics.Add(new MenuKeyBind("Insec", "Insec", Keys.T, KeyBindType.Press));
                MenuMoochanics.Add(new MenuKeyBind("StarCombo", "StarCombo", Keys.G, KeyBindType.Press));
                // TODO: Moochanics menu
            }

            MenuWardhop = MenuHome.Add(new Menu("Wardhop", "Wardhop"));
            {
                MenuWardhop.Add(new MenuKeyBind("Wardhop", "Wardhop", Keys.Z, KeyBindType.Press));
                // TODO: Wardhop menu
            }

            MenuDrawings = MenuHome.Add(new Menu("Drawings", "Drawings"));
            {
                MenuDrawings.Add(new MenuColor("DrawQ", "Draw Q", SharpDX.Color.LightCyan));
                MenuDrawings.Add(new MenuColor("DrawE", "Draw E", SharpDX.Color.DarkOliveGreen));
                MenuDrawings.Add(new MenuColor("DrawWardhop", "Draw Wardhop Range", SharpDX.Color.ForestGreen));
                // TODO: Drawings menu
            }
            MenuHome.Add(new MenuSeparator("Version", "Version: " + Globals.version));
            MenuHome.Add(new MenuSeparator("Credits", "Made By Miku"));
            MenuHome.Attach();
        }
    }
}