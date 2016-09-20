using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeagueSharp;
using LeagueSharp.SDK;
using LeagueSharp.SDK.Enumerations;
using LeagueSharp.SDK.UI;

namespace MooLeeSin
{
    internal class Combo
    {
        public static void init()
        {
            if (MenuConfig.MenuHome["Moochanics"]["Insec"].GetValue<MenuKeyBind>().Active)
            {
                Game.PrintChat("Insec");
            }
            if (Variables.Orbwalker.ActiveMode == OrbwalkingMode.Combo)
            {
                Game.PrintChat("Combo");
            }
        }
    }
}