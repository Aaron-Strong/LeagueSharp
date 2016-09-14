using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeagueSharp;
using LeagueSharp.Common;

namespace MooLeeSin
{
    internal class Combo
    {
        public static void init()
        {
            if (MenuConfig.MenuMoochanics.Item("Insec").GetValue<KeyBind>().Active)
            {
                Game.PrintChat("Insec");
            }
            if (Spells.Orbwalker.ActiveMode == Orbwalking.OrbwalkingMode.Combo)
            {
                Game.PrintChat("Combo");
            }
        }
    }
}