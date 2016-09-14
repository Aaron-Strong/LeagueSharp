using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using LeagueSharp;
using LeagueSharp.Common;
using SharpDX;
using Color = System.Drawing.Color;


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
            MenuDrawings; //, MenuDebug;


        public static void init()
        {
            MenuHome = new Menu("MooLeeSin", "MooLeeSin" ,true);

            MenuOrbwalker = MenuHome.AddSubMenu(new Menu("Orbwalking", "Orbwalking"));
            {
                Spells.Orbwalker = new Orbwalking.Orbwalker(MenuOrbwalker);
            }

            MenuCombo = MenuHome.AddSubMenu(new Menu("Combo", "Combo"));
            {
                MenuCombo.AddItem(new MenuItem("wGapCloser", "Use W as gapcloser"))
                    .SetValue(false)
                    .SetTooltip("Turning this off will save W for passive or spellvamp if low hp");
                // TODO: Combo menu
            }

            MenuHarass = MenuHome.AddSubMenu(new Menu("Harass", "Harass"));
            {
                MenuHarass.AddItem(new MenuItem("wShield", "Use W as shield"))
                    .SetValue(false)
                    .SetTooltip("Turning this off will save W for passive");
                MenuHarass.AddItem(new MenuItem("qPoke", "Q poke and run"))
                    .SetValue(new KeyBind('Y', KeyBindType.Press))
                    .SetTooltip("Will use both Q activations and then use W to run to the nearest object");
                // TODO: Harass menu
            }

            MenuFarm = MenuHome.AddSubMenu(new Menu("Farm", "Farm"));
            {
                MenuFarm.AddItem(new MenuItem("useQ", "Use Q")).SetValue(true);
                MenuFarm.AddItem(new MenuItem("useW", "Use W")).SetValue(true);
                MenuFarm.AddItem(new MenuItem("useE", "Use E")).SetValue(true);
                MenuFarm.AddItem(new MenuItem("usePassive", "Use Passive")).SetValue(true);
                // TODO: Farm menu
            }

            MenuMoochanics = MenuHome.AddSubMenu(new Menu("Moochanics", "Moochanics"))
                .SetFontStyle(FontStyle.Bold, SharpDX.Color.IndianRed);
            {
                MenuMoochanics.AddItem(new MenuItem("Insec", "Insec"))
                    .SetValue(new KeyBind('T', KeyBindType.Press));
                MenuMoochanics.AddItem(new MenuItem("StarCombo", "StarCombo"))
                    .SetValue(new KeyBind('G', KeyBindType.Press));
                // TODO: Moochanics menu
            }

            MenuWardhop = MenuHome.AddSubMenu(new Menu("Wardhop", "Wardhop"));
            {
                MenuWardhop.AddItem(new MenuItem("Wardhop", "Wardhop"))
                    .SetValue(new KeyBind('Z', KeyBindType.Press));
                // TODO: Wardhop menu
            }

            MenuDrawings = MenuHome.AddSubMenu(new Menu("Drawings", "Drawings"));
            {
                MenuDrawings.AddItem(new MenuItem("DrawQ", "Draw Q"))
                    .SetValue(new Circle(true, Color.DarkOliveGreen));
                MenuDrawings.AddItem(new MenuItem("DrawE", "Draw E"))
                    .SetValue(new Circle(false, Color.DarkOliveGreen));
                MenuDrawings.AddItem(new MenuItem("DrawWardhop", "Draw Wardhop Range"))
                    .SetValue(new Circle(true, Color.DarkOliveGreen));
                // TODO: Drawings menu
            }

            //MenuDebug = MenuHome.AddSubMenu(new Menu("Debug", "Debug"));
            //{
            //    MenuDebug.AddItem(new MenuItem("spamMoo", "Spam Moo")).SetValue(new KeyBind('T', KeyBindType.Press));
            //}

            MenuHome.AddToMainMenu();
        }
    }
}