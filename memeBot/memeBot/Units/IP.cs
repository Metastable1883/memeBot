using Discord.Commands;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace memeBot.Units
{
    public class IP : ModuleBase<SocketCommandContext>
    {
        [Command("ip")]
        public async Task ipAsync()
        {

            string externalip = new WebClient().DownloadString("http://icanhazip.com");
            await ReplyAsync("```" + externalip + "```");

        }
    }
}

