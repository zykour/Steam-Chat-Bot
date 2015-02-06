using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SteamKit2;

namespace SteamBot
{
    class ChatMsgBotAction : BotAction
    {
        protected string groupId;
        protected string friendId;

        public ChatMsgBotAction(string groupId, string friendId)
        {
            this.groupId = groupId;
            this.friendId = friendId;
        }

        public ChatMsgBotAction(SteamID groupId, SteamID friendId)
        {
            this.groupId = groupId.ToString();
            this.friendId = friendId.ToString();
        }

        public ChatMsgBotAction(string friendId)
        {
            this.friendId = friendId;
        }

        public ChatMsgBotAction(SteamID friendId)
        {
            this.friendId = friendId.ToString();
        }

        public ChatMsgBotAction()
        {
            groupId = null;
            friendId = null;
        }

        public void SetFriendID(SteamID friendId)
        {
            this.friendId = friendId.ToString();
        }

        public void SetFriendID(string friendId)
        {
            this.friendId = friendId;
        }

        public bool HasFriendID()
        {
            return ( friendId != null ) ? true : false;
        }

        public string GetFriendID()
        {
            return friendId;
        }

        public SteamID GetFriendSteamID()
        {
            return new SteamID(friendId);
        }

        public void SetGroupID(SteamID groupId)
        {
            this.groupId = groupId.ToString();
        }

        public void SetGroupID(string groupId)
        {
            this.groupId = groupId;
        }

        public bool HasGroupChatID()
        {
            return (groupId != null) ? true : false;
        }

        public string GetGroupChatID()
        {
            return groupId;
        }
        
        public SteamID GetGroupSteamID()
        {
            return new SteamID(groupId);
        }
    }
}
