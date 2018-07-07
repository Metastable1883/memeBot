using Discord;
using Discord.Commands;
using Discord.Net;
using Discord.WebSocket;
using System;
using System.Collections.Generic;
using System.Text;



namespace memeBot
{
    class MyBot
    {
        DiscordSocketClient Discord;

        public MyBot() {
            Discord = new DiscordSocketClient(x =>
            {
                x.LogLevel = LogSeverity.Info;
            }
                
                );

                }


    }
}   
