namespace UniversalSpammerRebornAndresurrected
{
    using System;

    using LeagueSharp;
    using LeagueSharp.Common;

    /// <summary>
    /// Emote Spammer Made By TheKushStyle (https://github.com/TheKushStyle)- Updated For Mastery Emote By Miku
    /// Chat Spammer completely made by Miku (https://github.com/aaronspong)
    /// Shoutout to lostit for the L$ Crack <3
    /// #nno
    /// </summary>
    internal class Program
    {

        private static Menu Config;

        private double tick;

        private static void Main(string[] args)
        {
            CustomEvents.Game.OnGameLoad += Game_OnGameLoad;
        }

        private static void Game_OnGameLoad(EventArgs args)
        {
            Config = new Menu("Spammer", "EmoteSpammer", true);

            //Emote Spam
            Config.AddSubMenu(new Menu("Emotes", "Emotes"));
            Config.SubMenu("Emotes")
                .AddItem(new MenuItem("EmotePress", "Emote On Key press"))
                .SetValue(new KeyBind(32, KeyBindType.Press));
            Config.SubMenu("Emotes")
                .AddItem(new MenuItem("EmoteToggable", "Toggleable Emote"))
                .SetValue(new KeyBind('h', KeyBindType.Toggle));
            Config.SubMenu("Emotes").AddItem(new MenuItem("Type", "Which Emote to spam?")).SetValue(new Slider(1, 4, 1));
            Config.SubMenu("Emotes").AddItem(new MenuItem("kappa", "1 = laugh, 2 = Taunt, 3 = Joke, 4 = Mastery"));

            //Chat Spam
            Config.AddSubMenu(new Menu("Chat", "Chat"));
            Config.SubMenu("Chat")
                .AddItem(new MenuItem("Press Button", "Press Button"))
                .SetValue(new KeyBind(32, KeyBindType.Press));
            Config.SubMenu("Chat")
                .AddItem(new MenuItem("ChatType", "Who are you?"))
                .SetValue(new StringList(new[] {"Radi", "Royals", "Miku", "Killer", "Tim", "Sweden", "Taco", "Eldiath", "Emenike", "Finn", "Oxide", "LostIt", "Broly"}, 0));

            Config.AddToMainMenu();

            Game.OnUpdate += OnUpdate;
        }

        private static void OnUpdate(EventArgs args)
        {
            double tick = 0;
            tick = TimeSpan.FromSeconds(Environment.TickCount).Minutes;

            if (ObjectManager.Player.HasBuff("Recall"))
            {
                return;
            }
            {
                if (Config.Item("EmotePress").GetValue<KeyBind>().Active && tick == 59)
                {
                    SPAM();
                }

                if (Config.Item("EmoteToggable").GetValue<KeyBind>().Active && tick == 59)
                {
                    SPAM();
                }
                
                if (Config.Item("Press Button").GetValue<KeyBind>().Active)
                {
                    Chatspam();
                }
            }
        }

        private static void SPAM()
        {
            if (Config.Item("Type").GetValue<Slider>().Value == 1)
            {
                Game.Say("/l");
            }

            if (Config.Item("Type").GetValue<Slider>().Value == 2)
            {
                Game.Say("/t");
            }

            if (Config.Item("Type").GetValue<Slider>().Value == 3)
            {
                Game.Say("/j");
            }

            if (Config.Item("Type").GetValue<Slider>().Value == 4)
            {
                Game.Say("/masterybadge");
            }
        }

        private static void Chatspam()
        {
            if (Config.Item("ChatType").GetValue<StringList>().SelectedValue == "Radi")
            {
                Game.Say("/all Kurwa Radi");
            }
            if (Config.Item("ChatType").GetValue<StringList>().SelectedValue == "Miku")
            {
                Game.Say("/all Desu");
            }
            if (Config.Item("ChatType").GetValue<StringList>().SelectedValue == "Royals")
            {
                Game.Say("/all Suck My Balls");
            }
            if (Config.Item("ChatType").GetValue<StringList>().SelectedValue == "Killer")
            {
                Game.Say("/all I can only play with relax!");
            }
            if (Config.Item("ChatType").GetValue<StringList>().SelectedValue == "Tim")
            {
                Game.Say("/all Go back to SECenter");
            }
            if (Config.Item("ChatType").GetValue<StringList>().SelectedValue == "Sweden")
            {
                Game.Say("/all Nein!");
            }
            if (Config.Item("ChatType").GetValue<StringList>().SelectedValue == "Taco")
            {
                Game.Say("/all Me encanta patatas fritas <3");
                            }
            if (Config.Item("ChatType").GetValue<StringList>().SelectedValue == "Eldiath")
            {
                Game.Say("/all :wub:");
            }
            if (Config.Item("ChatType").GetValue<StringList>().SelectedValue == "Emenike")
            {
                Game.Say("/all Go back to turkey <3");
            }
            if (Config.Item("ChatType").GetValue<StringList>().SelectedValue == "Finn")
            {
                Game.Say("/all Hab dich lieb");
            }
            if (Config.Item("ChatType").GetValue<StringList>().SelectedValue == "Oxide")
            {
                Game.Say("/all Leaching pleb, kurwa!");
            }
            if (Config.Item("ChatType").GetValue<StringList>().SelectedValue == "LostIt")
            {
                Game.Say("/all Ty for L$ Crack <3");
            }
            if (Config.Item("ChatType").GetValue<StringList>().SelectedValue == "Broly")
            {
                Game.Say("/all :thugdoge: never forget <3");
            }


        }
    }
}