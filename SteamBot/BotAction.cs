using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SteamKit2;

namespace SteamBot
{

    // a class from which all action commands inherit

    class BotAction
    {
        // if there is any message for the bot to send, it will be saved to results, all children classes will have the results variable inherently
        protected string results;

        // holds whether or not this action executed as intended
        protected bool success;

        // holds whether there is a message to be sent by the Bot to the chat/user, stored in the results variable
        protected bool messageAvailable;

        public BotAction()
        {
            results = "";
            success = false;
            messageAvailable = false;
        }

        public virtual void SetFriendID(SteamID friendId)
        {
        }

        public virtual void SetFriendID(string friendId)
        {
        }

        public virtual bool HasFriendID()
        {
            return false;
        }

        public virtual string GetFriendID()
        {
            return null;
        }

        public virtual SteamID GetFriendSteamID()
        {
            return null;
        }

        public virtual void SetGroupChatSteamID(SteamID groupId)
        {
        }

        public virtual void SetGroupChatSteamID(string groupId)
        {
        }

        public virtual bool HasGroupChatID()
        {
            return false;
        }

        public virtual string GetGroupChatID()
        {
            return null;
        }

        public virtual SteamID GetGroupChatSteamID()
        {
            return null;
        }

        public override string ToString()
        {
            return results;
        }

        public bool IsSuccessful()
        {
            return success;
        }

        public bool HasMessage()
        {
            return messageAvailable;
        }

        // overrideable function from which the logic of a bot action will be run

        public virtual void Execute()
        {
        }
    }
}
