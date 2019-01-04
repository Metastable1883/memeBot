using Discord;
using Discord.Commands;
using System.Linq;
using System.Threading.Tasks;

namespace memeBot.Units
{
    public class deny : ModuleBase<SocketCommandContext>
    {
        
        [Command("deny")]
        public async Task PingAsync() {
            var user = Context.User;
            var role = Context.Guild.Roles.FirstOrDefault(x => x.Name == "Human");
            await (user as IGuildUser).RemoveRoleAsync(role);

            await ReplyAsync("```Successfully Removed Security Clearance!```");
        }
    }
}

