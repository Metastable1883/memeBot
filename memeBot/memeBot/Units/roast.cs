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
            string user = "```" + echo;

            int part1 = new Random().Next(0, 7);

            switch (part1)
            {
                case 0:
                    user += " has silly kneecaps";
                    break;
                case 1:
                    user += " no u";
                    break;
                case 2:
                    user += " needs Serious help";
                    break;
                case 3:
                    user += " is the reason the gene pool needs a lifeguard";
                    break;
                case 4:
                    user += " plays fortnite";
                    break;
                case 5:
                    user += " needs to go home and rethink their life";
                    break;
                case 6:
                    user += " drinks too much soda";
                    break;
                case 7:
                    user += " uses a sniper rifle in GTA";
                    break;
            }
            await ReplyAsync(user + "```");

        }
        [Command("roast")]
        public async Task RektAsync()
        {
            await ReplyAsync("`You Must Enter a valid user to roast`");

        }
    }
}
