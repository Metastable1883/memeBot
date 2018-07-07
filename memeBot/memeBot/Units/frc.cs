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
            await ReplyAsync("https://www.thebluealliance.com/team/"+echo);
              
            

        }
        [Command("frc")]
        public async Task PingAsync() {
            await ReplyAsync("`You Must Enter a team number`");
            
        }
    }
}

