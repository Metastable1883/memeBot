using Discord.Commands;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace memeBot.Units
{
    public class GrantQuote : ModuleBase<SocketCommandContext>
    {
        [Command("grant")]
        public async Task GrantAsync()
        {
            string user = " ";
            string[] x =
            {
                "Taking a test is kind of like running a marathon",
                "Can you read the Quote of the day",
                "VINNYYYYYYY",
                "I once owned a pizza resturant",
                "No Games",
                "Stop Playing League",
                "Hidden Grant Found",
                "Lets Take a Survey"
            };
            int index = new Random().Next(0, x.Length);
            
            user += x[index];
            await ReplyAsync("```" + user + "\n -Mr. Grant```");
        }
            
        
    }
}
