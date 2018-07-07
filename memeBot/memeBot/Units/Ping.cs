using Discord.Commands;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace memeBot.Units
{
    public class Ping : ModuleBase<SocketCommandContext>
    {
        [Command("ping")]
        public async Task PingAsync([Remainder] string echo)
        {
               
                for (int i = 0; i < 10; i++)
                {
                    await ReplyAsync(echo);
                }
            

        }
        [Command("ping")]
        public async Task PingAsync() {
            await ReplyAsync("`You Must Enter a Parameter to ping`");
            
        }
    }
}

