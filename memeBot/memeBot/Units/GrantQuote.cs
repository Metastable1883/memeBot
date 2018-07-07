using Discord.Commands;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace memeBot.Units
{
    class GrantQuote : ModuleBase<SocketCommandContext>
    {
        [Command("grant")]
        public async Task GrantAsync()
        {
            string user = " ";

            int part1 = new Random().Next(0, 7);

            switch (part1)
            {
                case 0:
                    user += "Taking a test is kind of like running a marathon";
                    break;
                case 1:
                    user += "Can you read the Quote of the day";
                    break;
                case 2:
                    user += "VINNYYYYYYY";
                    break;
                case 3:
                    user += "I once owned a pizza resturant";
                    break;
                case 4:
                    user += "No Games";
                    break;
                case 5:
                    user += "Stop Playing League";
                    break;
                case 6:
                    user += "Hidden Grant Found";
                    break;
                case 7:
                    user += "Lets Take a Survey";
                    break;

                   
            }
            await ReplyAsync(user + "");
        }
    }
}
