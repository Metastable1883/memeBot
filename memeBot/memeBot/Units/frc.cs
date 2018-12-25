using Discord.Commands;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace memeBot.Units
{
    public class frc : ModuleBase<SocketCommandContext>
    {
        [Command("frc")]
        public async Task frcAsync([Remainder] string echo)
        {
            var isNumeric = int.TryParse(echo, out int n);

            if (isNumeric && n < 10000)
            {

                await ReplyAsync("```https://www.thebluealliance.com/team/" + n +"```");

            }
            else
            {
                await ReplyAsync("```NaN or not valid team```");
            }

        }
        [Command("frc")]
        public async Task PingAsync() {
            await ReplyAsync("```You Must Enter a team number```");
            
        }
    }
}

