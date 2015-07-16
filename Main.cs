using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Rocket.API;
using Rocket.Unturned.Plugins;
using Rocket.Unturned.Events;
using Rocket.Core;
using Rocket.Unturned;
using UnityEngine;
using SDG.Unturned;
using Rocket.Core.Logging;


namespace CustomMOTD
{
    public class CustomMOTD : RocketPlugin<CustomMOTD_Config>
    {
        public string ExtraFolderPath = System.Environment.CurrentDirectory + "/Extra/CustomMOTD/";

        protected override void Load()
        {


            #region Events
            

            Rocket.Unturned.Events.RocketServerEvents.OnPlayerConnected += new RocketServerEvents.PlayerConnected(RocketServerEvents_OnPlayerConnected);
            #endregion

            #region Notifier
            Rocket.Core.Logging.Logger.LogError("Configuration:");
            Rocket.Core.Logging.Logger.LogWarning("");
            Logger.LogWarning("================================================================================");
            if (this.Configuration.textline1) //If textline1 is true then >
            {
                Rocket.Core.Logging.Logger.LogWarning("You have enabled text line 1!");
                Rocket.Core.Logging.Logger.LogWarning("Text line 1: " + this.Configuration.txtline1);
                Rocket.Core.Logging.Logger.LogWarning("");
            }
            else //Else if textline1 isn't true then >
            {
                Rocket.Core.Logging.Logger.LogError("You have disabled text line 1!");
                Rocket.Core.Logging.Logger.LogWarning("");
            }

            if (this.Configuration.textline2)
            {
                Rocket.Core.Logging.Logger.LogWarning("You have enabled text line 2!");
                Rocket.Core.Logging.Logger.LogWarning("Text line 2: " + this.Configuration.txtline2);
                Rocket.Core.Logging.Logger.LogWarning("");
            }
            else
            {
                Rocket.Core.Logging.Logger.LogError("You have disabled text line 2!");
                Rocket.Core.Logging.Logger.LogWarning("");
            }

            if (this.Configuration.textline3)
            {
                Rocket.Core.Logging.Logger.LogWarning("You have enabled text line 3!");
                Rocket.Core.Logging.Logger.LogWarning("Text line 3: " + this.Configuration.txtline3);
                Rocket.Core.Logging.Logger.LogWarning("");
            }
            else
            {
                Rocket.Core.Logging.Logger.LogError("You have disabled text line 3!");
                Rocket.Core.Logging.Logger.LogWarning("");
            }

            if (this.Configuration.onlinemsg)
            {
                Rocket.Core.Logging.Logger.LogWarning("You have enabled online messages!");
                Rocket.Core.Logging.Logger.LogWarning("Text online messages: " + this.Configuration.onlinemsgtext + " " + Steam.Players.Count() + "/" + Steam.MaxPlayers + " " + this.Configuration.onlinemsgtext2);
                /*
                 * Steam.Players are the players and .Count() will count every single player in that specific "list"
                 * You can see it as a groceries list - You will count every single item you want to buy and count the items.
                 * */

            }
            else
            {
                Rocket.Core.Logging.Logger.LogError("You have disabled online messages!");
            }
            Rocket.Core.Logging.Logger.LogWarning("");
            Logger.LogWarning("================================================================================");
            Rocket.Core.Logging.Logger.LogWarning("");
            Logger.LogError("End of your configuration file;");
            #endregion








        }

        void RocketServerEvents_OnPlayerConnected(Rocket.Unturned.Player.RocketPlayer player)
        {


            if (this.Configuration.textline1) //If textline1 = true then >
            {
                RocketChat.Say(player, this.Configuration.txtline1, RocketChat.GetColorFromName(this.Configuration.line1color, Color.green));
            }
            if (this.Configuration.textline2)//If textline2 = true then >
            {
                RocketChat.Say(player, this.Configuration.txtline2, RocketChat.GetColorFromName(this.Configuration.line2color, Color.green));
            }
            if (this.Configuration.textline3)//If textline3 = true then >
            {
                RocketChat.Say(player, this.Configuration.txtline3, RocketChat.GetColorFromName(this.Configuration.line3color, Color.green));
            }
            if (this.Configuration.onlinemsg) //If onlinemsg = true then >
            {
                RocketChat.Say(player, this.Configuration.onlinemsgtext + " " + Steam.Players.Count() + "/" + Steam.MaxPlayers + " " + this.Configuration.onlinemsgtext2, RocketChat.GetColorFromName(this.Configuration.onlinemsgcolor, Color.yellow));
            }






        }




    }

}
