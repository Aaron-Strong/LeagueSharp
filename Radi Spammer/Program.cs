//MikuSpammer :wub:

using System.Security.Cryptography.X509Certificates;

namespace UniversalSpammerRebornAndresurrected
{
    using System;
    using LeagueSharp;
    using LeagueSharp.Common;

    internal class Program
    {
        private static Menu Config;
        private double tick;
        private static string test = "test complete";
        private static string all = " ";

        private static void Main(string[] args)
        {
            CustomEvents.Game.OnGameLoad += Game_OnGameLoad;
        }

        private static void Game_OnGameLoad(EventArgs args)
        {
            Config = new Menu("Spammer", "EmoteSpammer", true);

            // Emote Spam Menu
            Config.AddSubMenu(new Menu("Emotes", "Emotes"));
            Config.SubMenu("Emotes")
                .AddItem(new MenuItem("EmotePress", "Emote On Key press"))
                .SetValue(new KeyBind(32, KeyBindType.Press));
            Config.SubMenu("Emotes")
                .AddItem(new MenuItem("EmoteToggable", "Toggleable Emote"))
                .SetValue(new KeyBind('h', KeyBindType.Toggle));
            Config.SubMenu("Emotes").AddItem(new MenuItem("Type", "Which Emote to spam?")).SetValue(new StringList(new []
            {
                "Laugh", "Taunt", "Joke", "Mastery"
            }
            ));
            

            //Config.SubMenu("Emotes").AddItem(new MenuItem("kappa", "1 = laugh, 2 = Taunt, 3 = Joke, 4 = Mastery"));

            // Chat Spam Menu
            Config.AddSubMenu(new Menu("Chat", "Chat"));
            Config.SubMenu("Chat")
                .AddItem(new MenuItem("Press Button", "Press Button"))
                .SetValue(new KeyBind(32, KeyBindType.Press));
            Config.SubMenu("Chat")
                .AddItem(new MenuItem("allChat", "All Chat?"))
                .SetValue(new KeyBind(32, KeyBindType.Toggle));
            Config.SubMenu("Chat")
                .AddItem(new MenuItem("ChatType", "What to Spam?"))
                .SetValue(
                    new StringList(
                        new[]
                        {
                            "Jew", "Cancer", "kurwa = fuck", "Pizda = pussy", "Suka = bitch", "Suck my dick ", "Retarded?", "jerk Off"
                        }
                        ));

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

        //TheEmoteSpam
        private static void SPAM()
        {
            switch (Config.Item("Type").GetValue<StringList>().SelectedIndex)
            {
                case 0:
                    Game.Say("/l");
                    break;
                case 1:
                    Game.Say("/t");
                    break;
                case 2:
                    Game.Say("/j");
                    break;
                case 3:
                    Game.Say("/masterybadge");
                    break;
            }
        }

        //The chatspam.
        private static void Chatspam()
        {
            {

                if (Config.Item("allChat").GetValue<KeyBind>().Active)
                {
                    all = "/all ";
                }
                else all = "";




                switch (Config.Item("ChatType").GetValue<StringList>().SelectedIndex)
                {
                    case 0:
                        Game.Say(all + "Fuck off you fucking jew!");
                        break;
                    case 1:
                        Game.Say(all + "I hope you all get cancer!");
                        break;
                    case 2:
                        Game.Say(all + "kurwa");
                        break;
                    case 3:
                        Game.Say(all + "Pizda");
                        break;
                    case 4:
                        Game.Say(all + "Suka");
                        break;
                    case 5:
                        Game.Say(all + "suck my dick");
                        break;
                    case 6:
                        Game.Say(all + "Are you fucking retarded?");
                        break;
                    case 7:
                        Game.Say(all + "jerk off");
                        break;
                }
            }
        }
    }
}