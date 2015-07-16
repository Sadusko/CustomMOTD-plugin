using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Rocket.API;
using Rocket.Unturned.Plugins;
using Rocket.Unturned.Events;
using Rocket.Core;
using Rocket.Unturned;

namespace CustomMOTD
{
    public class CustomMOTD_Config : IRocketPluginConfiguration
    {
        public static CustomMOTD_Config Instance;
        public bool textline1;
        public string line1color;
        public bool textline2;
        public string line2color;
        public bool textline3;
        public string line3color;
        public bool onlinemsg;
        public string onlinemsgcolor;
        public string txtline1;
        public string txtline2;
        public string txtline3;
        public string onlinemsgtext;
        public string onlinemsgtext2;

        public IRocketPluginConfiguration DefaultConfiguration
        {
            get
            {
                return new CustomMOTD_Config()
                {
                    textline1 = true,
                    line1color = "yellow",
                    textline2 = true,
                    line2color = "red",
                    textline3 = true,
                    line3color = "blue",
                    onlinemsg = true,
                    onlinemsgcolor = "yellow",
                    txtline1 = "Hey, Welcome to the server!",
                    txtline2 = "The staff welcomes you to the server!",
                    txtline3 = "We are glad to have you here! Now get rid of those zombies! :)",
                    onlinemsgtext = "There are",
                    onlinemsgtext2 = "players online right now!",

                };

            }
        }

    }
}
