using Discord.Commands;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace memeBot.Units
{
    public class APWorld : ModuleBase<SocketCommandContext>
    {
        
        [Command("APWorld")]
        public async Task PingAsync() {
            await ReplyAsync("```https://www.longbranch.k12.nj.us/cms/lib/NJ01001766/Centricity/Domain/635/AP%20World%20History/The%20Earth%20and%20its%20Peoples%203rd%20Edition%20Online%20Textbook.pdf```");
            
        }
    }
}

