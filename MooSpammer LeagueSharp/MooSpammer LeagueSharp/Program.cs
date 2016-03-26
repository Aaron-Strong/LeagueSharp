using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeagueSharp;
using LeagueSharp.Common;
using System.Media;
using System.Threading;

namespace MooSpammer_LeagueSharp
{
    internal class Program
    {
        private static Menu Config;
        private static string all = " ";

        static void Main(string[] args)
        {

            CustomEvents.Game.OnGameLoad += game_OnGameLoad;
        }

        private static void game_OnGameLoad(EventArgs args)
        {

            Config = new Menu("MooSpammer", "MooSpammer", true);

            Config.AddSubMenu(new Menu("ConsoleCommands", "ConsoleCommands"));
            Config.SubMenu("ConsoleCommands")
                .AddItem(new MenuItem("Available Spam:", "Available Spam:"));
            Config.SubMenu("ConsoleCommands")
                .AddItem(new MenuItem("Blank", ""));
            Config.SubMenu("ConsoleCommands")
                .AddItem(new MenuItem(".Cow", ".Cow"));
            Config.SubMenu("ConsoleCommands")
                .AddItem(new MenuItem(".Dalek", ".Dalek"));
            Config.SubMenu("ConsoleCommands")
                .AddItem(new MenuItem(".Milk", ".Milk"));
            Config.SubMenu("ConsoleCommands")
                .AddItem(new MenuItem(".Lobby", ".Lobby"));
            Config.SubMenu("ConsoleCommands")
                .AddItem(new MenuItem(".Twitch", ".Twitch"));
            Config.SubMenu("ConsoleCommands")
                .AddItem(new MenuItem(".Icy", ".Icy"));
            Config.SubMenu("ConsoleCommands")
                .AddItem(new MenuItem(".jQuery", ".jQuery"));
            Config.SubMenu("ConsoleCommands")
                .AddItem(new MenuItem(".Detection", ".Detection"));
            Config.SubMenu("ConsoleCommands")
                .AddItem(new MenuItem(".Who?", ".Who?"));
            Config.SubMenu("ConsoleCommands")
                .AddItem(new MenuItem(".Tilt", ".Tilt"));
            Config.SubMenu("ConsoleCommands")
                .AddItem(new MenuItem(".Memes", ".Memes"));
            Config.SubMenu("ConsoleCommands")
                .AddItem(new MenuItem(".Apes", ".Apes"));
            Config.SubMenu("ConsoleCommands")
                .AddItem(new MenuItem(".jQuery2", ".jQuery2"));
            Config.SubMenu("ConsoleCommands")
                .AddItem(new MenuItem(".Degrec", ".Dergec"));
            Config.SubMenu("ConsoleCommands")
                .AddItem(new MenuItem(".Suck", ".Suck"));
            Config.SubMenu("ConsoleCommands")
                .AddItem(new MenuItem(".Media", ".Media"));

            Config.AddSubMenu(new Menu("ButtonToSpam", "ButtonToSpam"));
            Config.SubMenu("ButtonToSpam")
                .AddItem(new MenuItem("Press Button", "Press Button"))
                .SetValue(new KeyBind('A', KeyBindType.Press));
            Config.SubMenu("ButtonToSpam")
                .AddItem(new MenuItem("allChat", "All Chat?"))
                .SetValue(new KeyBind('P', KeyBindType.Toggle));
            Config.SubMenu("ButtonToSpam")
                .AddItem(new MenuItem("ChatType", "What To Spam"))
                .SetValue(
                    new StringList(
                        new[]
                        {
                            "jQuery", "Detection", "MikuDidThis", "Tilted", "Memes", "Apes", "jQuery2", "Degrec", "Suck", "Media", "Exory"
                        }
                        ));



            Config.AddToMainMenu();

            Game.OnUpdate += OnUpdate;
            Game.OnInput += Game_OnGameInput;
        }

        private static void OnUpdate(EventArgs args)
        {
            if (Config.Item("Press Button").GetValue<KeyBind>().Active)
            {
                if (Config.Item("allChat").GetValue<KeyBind>().Active)
                {
                    all = "/all ";
                }
                else all = "";

                switch (Config.Item("ChatType").GetValue<StringList>().SelectedIndex)
                {
                    case 0:
                        Game.Say($"{all} jQuery is an adorable cutie but remember she is only 15 years old. How can you post your s... picture named by her name ?? ");
                        Game.Say($"{all} Well if you're under 18y old, I could agree the fact you need to be medically suived but I will never agree to post those shit ... ");
                        Game.Say($"{all} Just stay away, you're probably banned at this moment ... ");
                        break;
                    case 1:
                        Game.Say($"{all} SERVERSIDE DETECTION?");
                        break;
                    case 2:
                        Game.Say($"{all} MIKU DID ALL OF THIS");
                        break;
                    case 3:
                        Game.Say($"{all} Media tilt me");
                        break;
                    case 4:
                        Game.Say($"{all} Memes?:feelsgoodman:");
                        break;
                    case 5:
                        Game.Say($"{all} Can you  A P E S start trying to play good? This game is boring the S H I T out of me. F U C K Y O U E A T M Y D I C K");
                        break;
                    case 6:
                        Game.Say($"{all} I want is more .jQuery moo");
                        break;
                    case 7:
                        Game.Say($"{all} Hola mi nombre es degrec and I use cracked script");
                        break;
                    case 8:
                        Game.Say($"{all} jajajajaja");
                        Game.Say($"{all} You suck more than a suck machine set on 'suck a lot'");
                        Game.Say($"{all} I'm the whup, you're the ass.");
                        Game.Say($"{all} Get better, not bitter.");
                        Game.Say($"{all} Want a tissue? ;)");
                        break;
                    case 9:
                        Game.Say($"{all} I suggest you building Stinger.");
                        break;
                    case 10:
                        Game.Say($"{all} I would clap at my brain after pulling off such a masterpiece of a phrase, if it wasn't shit.");
                        break;
                    default:
                        break;
                }
            }
        }

        private static void Chatspam()
        {
            throw new NotImplementedException();
        }

        private static void Game_OnGameInput(GameInputEventArgs args)
        {
            string arg = args.Input;
            string text = ("");
            string command = ("");
            if (arg.Contains(" "))
            {
                command = args.Input.Split(' ').First();
                text = args.Input.Substring(args.Input.LastIndexOf(' '));
            }
            else
            {
                command = args.Input;
            }

            Console.WriteLine(text);
            Console.WriteLine(args.Input);



                switch (command)

                {

                    case ".Cow":
                        Game.Say($"/all ( {text} )");
                        Game.Say(@"/all ........o....^__^");
                        Game.Say(@"/all ..........o..(oO)\_______");
                        Game.Say(@"/all .............(__)\ ######)\/\");
                        Game.Say(@"/all ..............U  ||----w |");
                        Game.Say(@"/all .................||.....||");
                        break;

                    case ".Dalek":
                        Game.Say($"/all .( {text} )");
                        Game.Say(@"/all ....o...D>=G==='   '.");
                        Game.Say(@"/all .............|======|");
                        Game.Say(@"/all ......o......|======|");
                        Game.Say(@"/all .........)--/]IIIIII]");
                        Game.Say(@"/all ............|_______|");
                        Game.Say(@"/all ............C O O O D");
                        Game.Say(@"/all ...........C O  O  O D");
                        Game.Say(@"/all ..........C  O  O  O  D");
                        Game.Say(@"/all ..........C__O__O__O__D");
                        Game.Say(@"/all .........[_____________]");
                        break;

                    case ".Milk":
                        Game.Say($"/all ( {text}");
                        Game.Say(@"/all . o   /////////////\\\\");
                        Game.Say(@"/all .  o /___________/___/|");
                        Game.Say(@"/all .....|##########|");
                        Game.Say(@"/all .....| ==\\ /== |.....|");
                        Game.Say(@"/all .....|# O---O # |.\\ \\ |");
                        Game.Say(@"/all .....|### O ####|...\\ \\|");
                        Game.Say(@"/all ..../|##########|...\\ \\");
                        Game.Say(@"/all .../ | \\_____/ |.../ /");
                        Game.Say(@"/all ../ /|##########|../ /|");
                        Game.Say(@"/all ./||\\----------|./||\\/");
                        break;

                    case ".Lobby":
                        Game.Say($"/all Welcome to {text}'s Modded Lobby");
                        Utility.DelayAction.Add(1000, () => Game.Say($"/all Press L3 for the Mod Menu"));
                        Utility.DelayAction.Add(2000, () => Game.Say($"/all Press R3 for All Unlocks"));
                         Utility.DelayAction.Add(3000, () => Game.Say($"/all Follow {text} on TheTechGame & SevenSins @{text}"));
                        Utility.DelayAction.Add(4000, () => Game.Say($"/all Don't forget to donate for more modded lobbies!"));
                        Utility.DelayAction.Add(5000, () => Game.Say($"/all Aimbot Exploit Succesfully Injected!"));
                        Utility.DelayAction.Add(6000, () => Game.Say($"/all You Earned +3Ba246218 EXP!"));
                        Utility.DelayAction.Add(7000, () => Game.Say($"/all Don't forget to restart the game to prestige!"));
                        Utility.DelayAction.Add(8000, () => Game.Say($"/all This lobby is sponsored by GFuel!"));
                        Utility.DelayAction.Add(9000, () => Game.Say($"/all To find out more visit their website at"));
                        Utility.DelayAction.Add(10000, () => Game.Say($"/all www.gfuel.com"));
                        Utility.DelayAction.Add(11000, () => Game.Say($"/all And incase you get banned we also sell accounts at"));
                        Utility.DelayAction.Add(12000, () => Game.Say($"/all www.moo.tokyo"));
                        break;

                    case ".Twitch":
                        Game.Say($"/all Be sure to watch my stream at");
                        Utility.DelayAction.Add(1000, () => Game.Say($"/all http://twitch.tv/{text}"));
                        Utility.DelayAction.Add(2000, () => Game.Say($"/all We stream high quality league of legends"));
                        Utility.DelayAction.Add(3000, () => Game.Say($"/all We have chalenger mechanics"));
                        Utility.DelayAction.Add(4000, () => Game.Say($"/all And a tonne of cool marcos"));
                        Utility.DelayAction.Add(5000, () => Game.Say($"/all I hope you will come visit us"));
                        //Utility.DelayAction.Add(6000, () => Game.Say($"/all Love from {text}"));
                        break;

                    //https://www.youtube.com/watch?v=8ok-m6UEBig
                    case ".Icy":
                        Game.Say($"/all  Hi guys it's Icy");
                        Utility.DelayAction.Add(2000, () => Game.Say($"/all I mean it's your boy icy "));
                        Utility.DelayAction.Add(3000, () => Game.Say($"/all back with another video "));
                        Utility.DelayAction.Add(4000, () => Game.Say($"/all and today we're going to be doing an "));
                        Utility.DelayAction.Add(5000, () => Game.Say($"/all ASMR or whatever it's called. "));
                        Utility.DelayAction.Add(6000, () => Game.Say($"/all uhh, and i'm gonna be um "));
                        Utility.DelayAction.Add(7000, () => Game.Say($"/all I'm gonna be pressing spacebar "));
                        Utility.DelayAction.Add(8000, () => Game.Say($"/all in 3 different modes "));
                        Utility.DelayAction.Add(9000, () => Game.Say($"/all um, so i really wanna capture "));
                        Utility.DelayAction.Add(10000, () => Game.Say($"/all you know, the relaxation sounds spacebar actually gives off "));
                        Utility.DelayAction.Add(11000, () => Game.Say($"/all also you know what you can do with a spacebar, which if you have leaguesharp is a lot. "));
                        Utility.DelayAction.Add(12000, () => Game.Say($"/all So i'm just gonna go and get this started. "));
                        Utility.DelayAction.Add(13000, () => Game.Say($"/all Uhh we gonna go for the first mode. "));
                        Utility.DelayAction.Add(14000, () => Game.Say($"/all This one is like a slow mode. "));
                        Utility.DelayAction.Add(15000, () => Game.Say($"/all Hope you guys can here this. "));
                        Utility.DelayAction.Add(16000, () => Game.Say($"/all *slow spacebar sounds"));
                        Utility.DelayAction.Add(17000, () => Game.Say($"/all see there we go and now i'll do it again "));
                        Utility.DelayAction.Add(18000, () => Game.Say($"/all *slow spacebar sounds* "));
                        Utility.DelayAction.Add(19000, () => Game.Say($"/all there we go "));
                        Utility.DelayAction.Add(20000, () => Game.Say($"/all you know uhh, it just sounds so great and "));
                        Utility.DelayAction.Add(21000, () => Game.Say($"/all the sound is just so amazing."));
                        Utility.DelayAction.Add(22000, () => Game.Say($"/all ight, so the second one we gonna do is we're gonna"));
                        Utility.DelayAction.Add(23000, () => Game.Say($"/all we're gonna "));
                        Utility.DelayAction.Add(24000, () => Game.Say($"/all keep repeating basically the first mode"));
                        Utility.DelayAction.Add(25000, () => Game.Say($"/all so it'll sound a bit like this "));
                        Utility.DelayAction.Add(26000, () => Game.Say($"/all *repeated slow spacebar noises* "));
                        Utility.DelayAction.Add(27000, () => Game.Say($"/all and uhh like i said i hope you guys can here this honestly. "));
                        Utility.DelayAction.Add(28000, () => Game.Say($"/all *cough* "));
                        Utility.DelayAction.Add(29000, () => Game.Say($"/all sorry i uhh, had to cough. "));
                        Utility.DelayAction.Add(30000, () => Game.Say($"/all uhm so yeah uhm "));
                        Utility.DelayAction.Add(31000, () => Game.Say($"/all that mode if i was you i'd use it"));
                        Utility.DelayAction.Add(32000, () => Game.Say($"/all you know when you need to, say harass an enemy "));
                        Utility.DelayAction.Add(33000, () => Game.Say($"/all or you could hold the C key. "));
                        Utility.DelayAction.Add(34000, () => Game.Say($"/all Let me just go and hold the C key for you guys "));
                        Utility.DelayAction.Add(35000, () => Game.Say($"/all so you can hear the difference in keys "));
                        Utility.DelayAction.Add(36000, () => Game.Say($"/all okay so this one again is the spacebar "));
                        Utility.DelayAction.Add(37000, () => Game.Say($"/all *spacebar noises* "));
                        Utility.DelayAction.Add(38000, () => Game.Say($"/all and this is the C key "));
                        Utility.DelayAction.Add(39000, () => Game.Say($"/all *C key noises* "));
                        Utility.DelayAction.Add(40000, () => Game.Say($"/all See, there's a different, there's a different pitch. "));
                        Utility.DelayAction.Add(41000, () => Game.Say($"/all The C key has a lower pitch "));
                        Utility.DelayAction.Add(42000, () => Game.Say($"/all *C key noises* "));
                        Utility.DelayAction.Add(43000, () => Game.Say($"/all and the spacebar "));
                        Utility.DelayAction.Add(44000, () => Game.Say($"/all *spacebar noises* "));
                        Utility.DelayAction.Add(45000, () => Game.Say($"/all C Key "));
                        Utility.DelayAction.Add(46000, () => Game.Say($"/all *C key noises* "));
                        Utility.DelayAction.Add(47000, () => Game.Say($"/all Spacebar "));
                        Utility.DelayAction.Add(48000, () => Game.Say($"/all *Spacebar Noises* "));
                        Utility.DelayAction.Add(49000, () => Game.Say($"/all C key, spacebar, C key, spacebar, spacebar, spacebar (etc etc) "));
                        Utility.DelayAction.Add(50000, () => Game.Say($"/all Okay so the third mode is "));
                        Utility.DelayAction.Add(51000, () => Game.Say($"/all i'm gonna basically be spamming the spacebar "));
                        Utility.DelayAction.Add(52000, () => Game.Say($"/all as much as possible "));
                        Utility.DelayAction.Add(52000, () => Game.Say($"/all for you guys t..to hear it "));
                        Utility.DelayAction.Add(53000, () => Game.Say($"/all k so let's go. "));
                        Utility.DelayAction.Add(54000, () => Game.Say($"/all *rapid fire spacebar sounds* "));
                        Utility.DelayAction.Add(55000, () => Game.Say($"/all Okay so i'm gonna speed up a little now. "));
                        Utility.DelayAction.Add(56000, () => Game.Say($"/all *Super speed spacebar sounds* "));
                        Utility.DelayAction.Add(57000, () => Game.Say($"/all and this, that mode, awhh it just sounds great, "));
                        Utility.DelayAction.Add(58000, () => Game.Say($"/all This sounds is so relaxin' .  "));
                        Utility.DelayAction.Add(59000, () => Game.Say($"/all It's so relaxin' . "));
                        Utility.DelayAction.Add(60000, () => Game.Say($"/all So i'm just gonna quickly tap the C key "));
                        Utility.DelayAction.Add(61000, () => Game.Say($"/all as fast as possible aswell "));
                        Utility.DelayAction.Add(62000, () => Game.Say($"/all Super speed C key sounds "));
                        Utility.DelayAction.Add(63000, () => Game.Say($"/all Anyway, i hope you enjoyed this video, "));
                        Utility.DelayAction.Add(64000, () => Game.Say($"/all and I hope you guys are all feeling relaxed"));
                        Utility.DelayAction.Add(65000, () => Game.Say($"/all if you're not feeling relaxed then i don't know what to tell you really."));
                        Utility.DelayAction.Add(66000, () => Game.Say($"/all Uhh I would like to thank Tony Bomboni"));
                        Utility.DelayAction.Add(67000, () => Game.Say($"/all for uhh, what's the word again... "));
                        Utility.DelayAction.Add(68000, () => Game.Say($"/all For inspiring me to do an ASMR video  "));
                        Utility.DelayAction.Add(69000, () => Game.Say($"/all Once again it's been your boy icy have a good night and peace. "));
                        break;

                    //https://www.joduska.me/forum/topic/195945-jquery-exposed/?p=1517490
                    case ".jQuery":
                        Game.Say($"/all jQuery is an adorable cutie but remember she is only 15 years old. How can you post your s... picture named by her name ?? ");
                        Utility.DelayAction.Add(2000, () => Game.Say($"/all Well if you're under 18y old, I could agree the fact you need to be medically suived but I will never agree to post those shit ... "));
                        Utility.DelayAction.Add(3000, () => Game.Say($"/all Just stay away, you're probably banned at this moment ... "));
                        break;

                    //https://www.joduska.me/forum/topic/196137-gib-me-memes-pls/?p=1518754
                    case ".Detection":
                        Game.Say($"/all SERVERSIDE DETECTION?");
                        Utility.DelayAction.Add(2000, () => Game.Say($"/all SERVERSIDE DETECTION?"));
                        Utility.DelayAction.Add(3000, () => Game.Say($"/all SERVERSIDE DETECTION?"));
                        break;

                    //https://www.joduska.me/forum/topic/196137-gib-me-memes-pls/?p=1518758
                    case ".Who?":
                        Game.Say($"/all MIKU DID ALL OF THIS");
                        Utility.DelayAction.Add(2000, () => Game.Say($"/all MIKU DID ALL OF THIS"));
                        Utility.DelayAction.Add(3000, () => Game.Say($"/all MIKU DID ALL OF THIS"));
                        break;

                    //https://www.joduska.me/forum/topic/196137-gib-me-memes-pls/?p=1518759
                    case ".Tilt":
                        Game.Say($"/all Media tilt me");
                        Utility.DelayAction.Add(2000, () => Game.Say($"/all Media tilt me"));
                        Utility.DelayAction.Add(3000, () => Game.Say($"/all Media tilt me"));
                        break;

                    //https://www.joduska.me/forum/topic/196137-gib-me-memes-pls/?p=1518761
                    case ".Memes":
                        Game.Say($"/all Memes?:feelsgoodman:");
                        Utility.DelayAction.Add(2000, () => Game.Say($"/all Memes?:feelsgoodman:"));
                        Utility.DelayAction.Add(3000, () => Game.Say($"/all Memes?:feelsgoodman:"));
                        break;

                    //https://www.joduska.me/forum/topic/196137-gib-me-memes-pls/?p=1518763
                    case ".Apes":
                        Game.Say($"/all Can you  A P E S start trying to play good? This game is boring the S H I T out of me. F U C K Y O U E A T M Y D I C K");
                        Utility.DelayAction.Add(2000, () => Game.Say($"/all Can you  A P E S start trying to play good? This game is boring the S H I T out of me. F U C K Y O U E A T M Y D I C K"));
                        Utility.DelayAction.Add(3000, () => Game.Say($"/all Can you  A P E S start trying to play good? This game is boring the S H I T out of me. F U C K Y O U E A T M Y D I C K"));
                        break;

                    //https://www.joduska.me/forum/topic/196137-gib-me-memes-pls/?p=1518764
                    case ".jQuery2":
                        Game.Say($"/all I want more .jQuery moo");
                        Utility.DelayAction.Add(2000, () => Game.Say($"/all I want more .jQuery moo"));
                        Utility.DelayAction.Add(3000, () => Game.Say($"/all I want more .jQuery moo"));
                        break;

                    //https://www.joduska.me/forum/topic/196137-gib-me-memes-pls/?p=1518785
                    case ".Degrec":
                        Game.Say($"/all Hola me nombrë my name is degrec and i use great cracked script");
                        Utility.DelayAction.Add(2000, () => Game.Say($"/all Hola me nombrë my name is degrec and i use great cracked script"));
                        Utility.DelayAction.Add(3000, () => Game.Say($"/all Hola me nombrë my name is degrec and i use great cracked script"));
                        break;

                    //https://www.joduska.me/forum/topic/196137-gib-me-memes-pls/?p=1518787
                    case ".Suck":
                        Game.Say($"/all jajajajaja");
                        Utility.DelayAction.Add(2000, () => Game.Say($"/all You suck more than a suck machine set on 'suck a lot'"));
                        Utility.DelayAction.Add(3000, () => Game.Say($"/all I'm the whup, you're the ass."));
                        Utility.DelayAction.Add(3000, () => Game.Say($"/all Get better, not bitter."));
                        Utility.DelayAction.Add(4000, () => Game.Say($"/all Want a tissue? ;)"));
                        break;

                    //https://www.joduska.me/forum/topic/196137-gib-me-memes-pls/?p=1518797
                    case ".Media":
                        Game.Say($"/all I suggest you building Stinger.");
                        Utility.DelayAction.Add(2000, () => Game.Say($"/all I suggest you building Stinger."));
                        Utility.DelayAction.Add(3000, () => Game.Say($"/all I suggest you building Stinger."));
                        break;

                    default:
                        return;
                
            }
        }
    }
}
