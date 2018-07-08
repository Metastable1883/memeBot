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
        public async Task RektAsync([Remainder] string echo)
        {
            string deathMessage = "```Incoming Transmission:```\n" + echo;

            string[] part1 =
            {
                " was massacred with ",
                " was hugged with ",
                " was consumed with ",
                " was nuked with ",
                " was slain with "
            };

            deathMessage += part1[new Random().Next(0, part1.Length)];

            string[] part2 =
            {
                "knives ",
                "fruits ",
                "disease ",
                "scorpions ",
                "love "
            };

            deathMessage += part2[new Random().Next(0, part2.Length)];

            deathMessage += "by *";

            string[] part3 =
            {
                "Kim Jong Un ",
                "Donald Trump ",
                "Vladimir Putin ",
                "Me ",
                "You ",
                "that guy over there",
                "a turtle"
            };

            deathMessage += part3[new Random().Next(0, part3.Length)] + "*.";

            await ReplyAsync(deathMessage + "");
        }
    }
}
