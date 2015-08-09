//MikuSpammer :wub:
namespace UniversalSpammerRebornAndresurrected
{
    using System;
    using LeagueSharp;
    using LeagueSharp.Common;

    internal class Program
    {
        private static Menu Config;
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
            Config.SubMenu("Emotes").AddItem(new MenuItem("Type", "Which Emote to spam?")).SetValue(new Slider(1, 4, 1));
            Config.SubMenu("Emotes").AddItem(new MenuItem("kappa", "1 = laugh, 2 = Taunt, 3 = Joke, 4 = Mastery"));

            // Chat Spam Menu
            Config.AddSubMenu(new Menu("Chat", "Chat"));
            Config.SubMenu("Chat")
                .AddItem(new MenuItem("Press Button", "Press Button"))
                .SetValue(new KeyBind(32, KeyBindType.Press));
            Config.SubMenu("Chat")
                .AddItem(new MenuItem("Random Shitty Name", "Random Shitty Name"))
                .SetValue(new KeyBind(32, KeyBindType.Toggle));
            Config.SubMenu("Chat")
                .AddItem(new MenuItem("ChatType", "Who are you?"))
                .SetValue(
                    new StringList(
                        new[]
                        {
                            "Radi", "Royals", "Miku", "Killer", "Tim", "Sweden", "Taco", "Eldiath", "Emenike", "Finn",
                            "Oxide", "LostIt", "Broly", //"Ian", "Nathan", "Tahm", "Alfie", "Rhys"
                        },
                        0));

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

                if (Config.Item("Random Shitty Name").GetValue<KeyBind>().Active)
                {
                    all = "/all ";
                }
                else all = "";




                switch (Config.Item("ChatType").GetValue<StringList>().SelectedIndex)
                {
                    case 0:
                        Game.Say(all + "kurwa Radi");
                        break;
                    case 1:
                        Game.Say(all + "Desu");
                        break;
                    case 2:
                        Game.Say(all + "suck my balls");
                        break;
                    case 3:
                        Game.Say(all + "I can only play with relax!");
                        break;
                    case 4:
                        Game.Say(all + "Go back to SECenter");
                        break;
                    case 5:
                        Game.Say(all + "Nein!");
                        break;
                    case 6:
                        Game.Say(all + "Me encanta patatas fritas <3");
                        break;
                    case 7:
                        Game.Say(all + "wub");
                        break;
                    case 8:
                        Game.Say(all + "Go back to turkey");
                        break;
                    case 9:
                        Game.Say(all + "Hab Dich Lieb");
                        break;
                    case 10:
                        Game.Say(all + "Leeching pleb, kurwa!");
                        break;
                    case 11:
                        Game.Say(all + "Ty for L$ Crack <3");
                        break;
                    case 12:
                        Game.Say(all + ":thugdoge: never forget <3");
                        break;
                    case 13:
                        Game.Say(all + "Raise Your Dongers");
                        break;
                    case 14:
                        Game.Say(all + "Get Jingle Jangled");
                        break;
                    case 15:
                        Game.Say(all + "Tahm kench is cancer");
                        break;
                    case 16:
                        Game.Say(all + "Ermagawd that's so op");
                        break;
                    case 17:
                        Game.Say(all + "Can I touch your nipples");
                        break;
                }
            }
        }
    }
}