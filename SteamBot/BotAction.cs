using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SteamKit2;

namespace SteamBot
{
    class BotAction
    {
        protected string results;
        protected bool success;
        protected bool messageAvailable;

        public BotAction()
        {
            results = "";
            success = false;
            messageAvailable = false;
        }

        public bool HasFriendID()
        {
            return false;
        }

        public string GetFriendID()
        {
            return null;
        }

        public bool HasGroupChatID()
        {
            return false;
        }

        public string GetGroupChatID()
        {
            return null;
        }

        public string ToString()
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

        public void Execute()
        {

        }
    }
}
