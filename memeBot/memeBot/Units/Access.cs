using Discord;
using Discord.Commands;
using System.Linq;
using System.Threading.Tasks;

namespace memeBot.Units
{
    public class access : ModuleBase<SocketCommandContext>
    {
        
        [Command("access")]
        public async Task PingAsync() {
            var user = Context.User;
            var role = Context.Guild.Roles.FirstOrDefault(x => x.Name == "Human");
            await (user as IGuildUser).AddRoleAsync(role);

            await ReplyAsync("```Successfully Given Role 'Human' to you!```");
        }
    }
}

