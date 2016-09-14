using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeagueSharp;
using LeagueSharp.Common;
using SharpDX;

namespace MooLeeSin
{
    internal class Spells
    {
        public static Orbwalking.Orbwalker Orbwalker;
        // TODO: Add item support here
        public static Spell Q, W, E, R;
        public static void init()
        {
            Q = new Spell(SpellSlot.Q, 1060f);
            Q.SetSkillshot(0.25f, 70f, 1800f, true, SkillshotType.SkillshotLine);
            W = new Spell(SpellSlot.W, 670f);
            E = new Spell(SpellSlot.E, 430f);
            E.SetSkillshot(0.25f, 350f, 0.25f, false, SkillshotType.SkillshotCircle);
            R = new Spell(SpellSlot.R, 375f);
        }
    }
}