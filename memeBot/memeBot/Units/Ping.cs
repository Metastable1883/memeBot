using Discord.Commands;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace memeBot.Units
{
    public class Ping : ModuleBase<SocketCommandContext>
    {
        public static int pings = 0;
        private int repeat = 3;
        [Command("ping")]
        public async Task PingAsync([Remainder] string echo)
        {
            string result = "";
            pings+=repeat;
            for (int i = 0; i < repeat; i++)
            {
                result += echo + "\n";
            }
            await ReplyAsync(result + "```Thank you for using PingService(TM) - " + pings + " delivered since reboot!```");
            
        }
        [Command("ping")]
        public async Task PingAsync() {
            await ReplyAsync("```You Must Enter a Parameter to ping```");
            
        }
    }
}

