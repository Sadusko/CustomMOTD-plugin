using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Rocket.API;
using Rocket.Core;
using Rocket.Unturned;
using Rocket.Core.Plugins;
using Rocket.Unturned.Chat;
using Rocket.Core.Logging;
using SDG.Unturned;
using UnityEngine;
using SDG;

namespace CustomMOTD
{
    public class CustomMOTD : RocketPlugin<CustomMOTD_Config>
    {
        public string ExtraFolderPath = System.Environment.CurrentDirectory + "/Extra/CustomMOTD/";

        protected override void Load()
        {
            //12345

            #region Events

            
            U.Events.OnPlayerConnected += Events_OnPlayerConnected;
            #endregion
            #region Notifier
            Logger.LogError("Configuration:");
            Logger.LogWarning("");
            Logger.LogWarning("================================================================================");
            if (this.Configuration.Instance.textline1) //If textline1 is true then >
            {
                Logger.LogWarning("You have enabled text line 1!");
                Logger.LogWarning("Text line 1: " + this.Configuration.Instance.txtline1);
                Logger.LogWarning("");
            }
            else //Else if textline1 isn't true then >
            {
                Logger.LogError("You have disabled text line 1!");
                Logger.LogWarning("");
            }

            if (this.Configuration.Instance.textline2)
            {
                Logger.LogWarning("You have enabled text line 2!");
                Logger.LogWarning("Text line 2: " + this.Configuration.Instance.txtline2);
                Logger.LogWarning("");
            }
            else
            {
                Logger.LogError("You have disabled text line 2!");
                Logger.LogWarning("");
            }
            
            if (this.Configuration.Instance.textline3)
            {
                Logger.LogWarning("You have enabled text line 3!");
                Logger.LogWarning("Text line 3: " + this.Configuration.Instance.txtline3);
                Logger.LogWarning("");
            }
            else
            {
                Logger.LogError("You have disabled text line 3!");
                Logger.LogWarning("");
            }

            if (this.Configuration.Instance.onlinemsg)
            {
                Logger.LogWarning("You have enabled online messages!");
                Logger.LogWarning("Text online messages: " + this.Configuration.Instance.onlinemsgtext + " " + Steam.Players.Count() + "/" + Steam.MaxPlayers + " " + this.Configuration.Instance.onlinemsgtext2);
                /*
                 * Steam.Players are the players and .Count() will count every single player in that specific "list"
                 * You can see it as a groceries list - You will count every single item you want to buy and count the items.
                 * */

            }
            else
            {
                Logger.LogError("You have disabled online messages!");
            }
            Logger.LogWarning("");
            Logger.LogWarning("================================================================================");
            Logger.LogWarning("");
            Logger.LogError("End of your configuration file;");
            #endregion








        }

        void Events_OnPlayerConnected(Rocket.Unturned.Player.UnturnedPlayer player)
        {

           

            if (this.Configuration.Instance.textline1) //If textline1 = true then >
            {
                UnturnedChat.Say(player, this.Configuration.Instance.txtline1, UnturnedChat.GetColorFromName(this.Configuration.Instance.line1color, Color.green));
            }
            if (this.Configuration.Instance.textline2)//If textline2 = true then >
            {
                UnturnedChat.Say(player, this.Configuration.Instance.txtline2, UnturnedChat.GetColorFromName(this.Configuration.Instance.line2color, Color.green));
            }
            if (this.Configuration.Instance.textline3)//If textline3 = true then >
            {
                UnturnedChat.Say(player, this.Configuration.Instance.txtline3, UnturnedChat.GetColorFromName(this.Configuration.Instance.line3color, Color.green));
            }
            if (this.Configuration.Instance.onlinemsg) //If onlinemsg = true then >
            {
                UnturnedChat.Say(player, this.Configuration.Instance.onlinemsgtext + " " + Steam.Players.Count() + "/" + Steam.MaxPlayers + " " + this.Configuration.Instance.onlinemsgtext2, UnturnedChat.GetColorFromName(this.Configuration.Instance.onlinemsgcolor, Color.yellow));
            }

        }

        protected override void Unload()
        {

            U.Events.OnPlayerConnected -= Events_OnPlayerConnected;



        }



    }

}
