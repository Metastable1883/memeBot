using Discord.Commands;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace memeBot.Units
{
    public class git : ModuleBase<SocketCommandContext>
    {
        [Command("git")]
        public async Task frcAsync([Remainder] string echo)
        {
            await ReplyAsync("https://github.com/" + echo);
              
            

        }
        [Command("git")]
        public async Task PingAsync() {
            await ReplyAsync("`You Must Enter a valid user`");
            
        }
    }
}

