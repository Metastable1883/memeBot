using Discord.Commands;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace memeBot.Units
{
    public class Roast : ModuleBase<SocketCommandContext>
    {
        [Command("roast")]
        public async Task RektAsync([Remainder] string echo)
        {
            string user = echo;

            int part1 = new Random().Next(0, 5);

            switch (part1)
            {
                case 0:
                    user += "has silly kneecaps";
                    break;
                case 1:
                    user += "no u";
                    break;
                case 2:
                    user += "needs Serious help";
                    break;
                case 3:
                    user += "is the reason the gene pool needs a lifeguard";
                    break;
                case 4:
                    user += "plays fortnite";
                    break;
                case 5:
                    user += "needs to go home and rethink their life";
                    break;

            }
            await ReplyAsync(user + "");

        }
    }
}
