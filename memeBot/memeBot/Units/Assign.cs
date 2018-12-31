using Discord;
using Discord.Commands;
using Discord.WebSocket;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace memeBot.Units
{
    public class Assign : ModuleBase<SocketCommandContext>
    {
        
        [Command("Assign")]
        public async Task PingAsync() {

            if (Context.User.Id != 268928066858778624) return;

            var users = Context.Guild.Users;
            var one = Context.Guild.Roles.FirstOrDefault(x => x.Name == "Tier One");
            var two = Context.Guild.Roles.FirstOrDefault(x => x.Name == "Tier Two");
            var three = Context.Guild.Roles.FirstOrDefault(x => x.Name == "Tier Three");
            SocketRole[] roles = { one, two, three };

            foreach (IGuildUser user in users) {
                await (user as IGuildUser).RemoveRolesAsync(roles);
            }
            string msg = "```---New Roles---\n";
            foreach (IGuildUser user in users)
            {
                IGuildUser guildUser = user as IGuildUser;
                
                switch (new Random().Next(0, 3))
                {
                    case 0:
                        await guildUser.AddRoleAsync(one);
                        msg += guildUser.Username + " is now Tier I\n";
                        break;
                    case 1:
                        await guildUser.AddRoleAsync(two);
                        msg += guildUser.Username + " is now Tier II\n";
                        break;
                    case 2:
                        await guildUser.AddRoleAsync(three);
                        msg += guildUser.Username + " is now Tier III\n";
                        break;
                }


            }
            await ReplyAsync(msg + "Reassignment Complete!```");
        }
    }
}

