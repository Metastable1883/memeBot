using Discord.Commands;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace memeBot.Units
{
    public class MetaQuote : ModuleBase<SocketCommandContext>
    {
        [Command("meta")]
        public async Task MetaAsync()
        {
            ///DEFINITELY NOT A COPY OF SKYQUOTE
            string text = " ";
            string[] x =
            {
                "oof",
                "Only one thing makes life more meaningful; realizing what that thing is",
                "Tenacity isn't a gift. Its a skill",
                "Dont waste time thinking about regrets. Someday you'll regret it",
                "Life is like a race. Whoever wins feels the most pain",
                "Fail, but remember that history often repeats it self",
                "Ignorance is bliss, but bliss is temporary. Ignorance is permanent"

            };
            int index = new Random().Next(0, x.Length);
            text += "```" + x[index] + "\n -metastable```";
            await ReplyAsync(text);
        }
            
        
    }
}
