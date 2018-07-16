using Discord.Commands;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace memeBot.Units
{
    
    public class Rekt : ModuleBase<SocketCommandContext>
    {
        [Command("rekt")]
        public async Task RektAsync()
        {
            await ReplyAsync("`You need to input something to be rekt`");
        }
        [Command("rekt")]
        public async Task RektAsync([Remainder] string echo)
        {
            
            if (echo.Equals(Context.User.Mention) || echo.Contains("467921349852135426")) { await ReplyAsync("*But you refused.*");return; }
            string deathMessage = "";

            deathMessage += "" + Context.User.Mention + " ordered the termination of " + echo;

            

            deathMessage += "\n**" + echo;

            string thingtokill = echo;
            string[] part1 =
            {
                " was massacred with ",
                " was hugged with ",
                " was consumed with ",
                " was nuked with ",
                " was slain with ",
                " was burned with ",
                " was roasted with ",
                " was cracked with ",
                " was stabbed with ",
                " was blown up with ",
                " was dissolved with ",
                " was goopified with ",
                " was turned into a puddle with ",
                " was slapped with ",
                " was humiliated with ",
                " was frozen with ",
                " was taken to the grave with ",
                " was covered in BBQ sauce with ",
                " was immobilized with ",
                " was ALT+F4'd with ",
                " was forced to do chores with ",
                " was assimilated with ",
                " was shocked with ",
                " was shamed with ",
                " was exposed with ",
                " was poisoned with ",
                " was shotgun'd with ",
                " was toasted with "
            };

            deathMessage += part1[new Random().Next(0, part1.Length)];

            string[] part2 =
            {
                "knives ",
                "fruits ",
                "disease ",
                "scorpions ",
                "love ",
                "spears ",
                "flamethrowers ",
                "tears ",
                "sticks ",
                "stones ",
                "jokes ",
                "fart bombs ",
                "explosives ",
                "hacks ",
                "Identity Theft ",
                "stuxnet ",
                "The FBI's janitor ",
                "The Presidential Turkey ",
                "pineapples ",
                "hot soup ",
                "coffee ",
                "bullets ",
                "liquid nitrogen "
            };

            deathMessage += part2[new Random().Next(0, part2.Length)];

            deathMessage += "by ";

            string[] chars = { "🐶", "🐱", "🐭", "🐹", "🐰", "🦊", "🐻", "🐼", "🐨", "🐯", "🦁", "🐮", "🐷", "🐽", "🐸", "🐵", "🙈", "🙉", "🙊", "🐒", "🐔", "🐧", "🐦", "🐤", "🐣", "🐥", "🦆", "🦅", "🦉", "🦇", "🐺", "🐗", "🐴", "🦄", "🐝", "🐛", "🦋", "🐌", "🐚", "🐞", "🐜", "🦗", "🕷", "🕸", "🦂", "🐢", "🐍", "🦎", "🦖", "🦕", "🐙", "🦑", "🦐", "🦀", "🐡", "🐠", "🐟", "🐬", "🐳", "🐋", "🦈", "🐊", "🐅", "🐆", "🦓", "🦍", "🐘", "🦏", "🐪", "🐫", "🦒", "🐃", "🐂", "🐄", "🐎", "🐖", "🐏", "🐑", "🐐", "🦌", "🐕", "🐩", "🐈", "🐓", "🦃", "🕊", "🐇", "🐁", "🐀", "🐿", "🦔", "🐾", "🐉", "🐲" };



            deathMessage += chars[new Random().Next(0,chars.Length)];

            deathMessage += ".**";

            deathMessage += "\n\t[☢️] The attack dealt **" + new Random().Next(300, 1000) + " damage**";

            deathMessage += "\n[💀] " + thingtokill + " was ***#REKT!***";

            await ReplyAsync(deathMessage);
        }
    }
}
