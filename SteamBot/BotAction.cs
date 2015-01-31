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
        protected string groupId;
        protected string friendId;
        protected string results;
        protected bool success;
        protected bool messageAvailable;

        public BotAction()
        {
            results = "";
            success = false;
            messageAvailable = false;
        }

        public BotAction(string groupId)
        {
            this.groupId = groupId;
            results = "";
            success = false;
            messageAvailable = false;
        }

        public BotAction(string friendId, string groupId)
        {
            this.friendId = friendId;
            this.groupdId = groupId;
            results = "";
            success = false;
            messageAvailable = false;
        }

        public bool HasFriendID()
        {
            return ( friendId != null ) ? true : false;
        }

        public string GetFriendID()
        {
            return friendId;
        }

        public bool HasGroupChatID()
        {
            return (groupId != null) ? true : false;
        }

        public string GetGroupChatID()
        {
            return groupId;
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
