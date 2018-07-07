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
            string deathMessage = echo;

            int part1 = new Random().Next(0, 4);

            switch (part1)
            {
                case 0:
                    deathMessage += " was massacred with ";
                    break;
                case 1:
                    deathMessage += " was hugged with ";
                    break;
                case 2:
                    deathMessage += " was consumed with ";
                    break;
                case 3:
                    deathMessage += " was nuked with ";
                    break;
                case 4:
                    deathMessage += " was slain with ";
                    break;
            }

            int part2 = new Random().Next(0, 4);
            switch (part2)
            {
                case 0:
                    deathMessage += "knives ";
                    break;
                case 1:
                    deathMessage += "fruits ";
                    break;
                case 2:
                    deathMessage += "disease ";
                    break;
                case 3:
                    deathMessage += "scorpions ";
                    break;
                case 4:
                    deathMessage += "love ";
                    break;
            }

            deathMessage += "by ";

            int part3 = new Random().Next(0, 4);
            switch (part3)
            {
                case 0:
                    deathMessage += "Kim Jong Un ";
                    break;
                case 1:
                    deathMessage += "Donald Trump ";
                    break;
                case 2:
                    deathMessage += "Vladimir Putin ";
                    break;
                case 3:
                    deathMessage += "Me ";
                    break;
                case 4:
                    deathMessage += "You ";
                    break;
            }
            
            await ReplyAsync(deathMessage + "");
        }
    }
}
