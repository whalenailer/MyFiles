using System;
using System.Collections.Generic;
using System.Text;
using Discord;
using Discord.Commands;

namespace ConsoleApp1
{
    class MyBot
    {
        DiscordClient discord;

        public MyBot()
        {
            Discord = new discordclient(x =>
            {
                x.loglevel = logseverity.info;
                x.loghandler = log;
            });


            discord.ExecuteAndWait(async() =>
            {
                await discord.connect("MzQzNDM5NzA1OTI2NTMzMTIx.DGeNgg.ZLPFwcqNikeQ2wUxlar1CPwMG9U");
            });
        } 
    private void log(object sender, LogMessageEventArgs)
    {
        Console.WriteLine(e.message);
    }
}

}
