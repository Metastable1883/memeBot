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
    public class Status : ModuleBase<SocketCommandContext>
    {
        
        [Command("Status")]
        public async Task PingAsync() {

            if (Context.User.Id != 268928066858778624) return;

            string[] chars = { "🌧", "☀", "⛅" , "⚡" };
            string[] wind = { "low" , "medium", "high" };
            string[] direction = { "south" , "west" , "east" , "north" };
            string[] fog = { "clear" , "hazy" , "obfuscated"};
            string[] mystery = { "water" , "fire" , "ice" , "earth" , "wind" };



            string msg = DateTime.Now.ToString("h:mm:ss tt") + "\n";
            msg += "Weather: " + chars[new Random().Next(0, chars.Length)] + "\n";
            msg += "Wind: " + wind[new Random().Next(0, wind.Length)] + "\n";
            msg += "Direction: " + direction[(new Random().Next(0, wind.Length))] + "\n";
            msg += "Fog: " + fog[(new Random().Next(0, fog.Length))] + "\n";
            msg += "Prone to: " + mystery[(new Random().Next(0, mystery.Length))] + "";
            await ReplyAsync("```" + msg + "```" + "");
        }
    }
}

