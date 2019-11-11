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

            List<string> names = new List<string>();
            
            foreach (IGuildUser user in users) {
                if (user.Id == 268928066858778624) { continue; }
                names.Add(user.Username);
                await (user as IGuildUser).RemoveRolesAsync(roles);
            }
            string msg = "```---New Roles---\n";
            foreach (IGuildUser user in users)
            {
                IGuildUser guildUser = user as IGuildUser;
                if (guildUser.Id == 268928066858778624) { continue; }
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

                int index = new Random().Next(0, names.Count);
                await guildUser.ModifyAsync(x =>//to this day this symbol befuddles me
                {
                    x.Nickname = names[index];// this is how you get, instead of a method, but...
                }
                );
                names.RemoveAt(index);//this is for some reason how you remove
            }
            await ReplyAsync(msg + "Reassignment Complete!```");
        }
    }
}

