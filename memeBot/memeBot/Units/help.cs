using Discord.Commands;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace memeBot.Units
{
    public class Help : ModuleBase<SocketCommandContext>
    {
        [Command("help")]
        public async Task HelpAsync()
        {
               
                
            await ReplyAsync("`ping [userID]`"+" Gets Someone`s attention");
            await ReplyAsync("`APWorld`" + " provides textbook");
            await ReplyAsync("`frc [team number]`" + " provides TBA info on team");
            await ReplyAsync("`git [username]`" + " returns info on github user");
            await ReplyAsync("`rekt [userID]`" + " generates a murderous statement");
            await ReplyAsync("`roast [userID]`" + " roasts a user");
            await ReplyAsync("`grantquote`" + "provides a quote from the legendary Mr. Grant");





        }
        
    }
}

