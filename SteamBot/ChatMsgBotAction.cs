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
        // holds the group chat ID of the group from which the incoming message came
        protected string groupId;

        // holds the steam user ID of the user who sent the message
        protected string friendId;

        public ChatMsgBotAction(string friendId, string groupId)
        {
            this.groupId = groupId;
            this.friendId = friendId;
        }

        public ChatMsgBotAction(SteamID friendId, SteamID groupId)
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

        public override void SetFriendID(SteamID friendId)
        {
            this.friendId = friendId.ToString();
        }

        public override void SetFriendID(string friendId)
        {
            this.friendId = friendId;
        }

        public override bool HasFriendID()
        {
            return ( friendId != null ) ? true : false;
        }

        public override string GetFriendID()
        {
            return friendId;
        }

        public override SteamID GetFriendSteamID()
        {
            return new SteamID(UInt64.Parse(friendId));
        }

        public override void SetGroupChatSteamID(SteamID groupId)
        {
            this.groupId = groupId.ToString();
        }

        public override void SetGroupChatSteamID(string groupId)
        {
            this.groupId = groupId;
        }

        public override bool HasGroupChatID()
        {
            return (groupId != null) ? true : false;
        }

        public override string GetGroupChatID()
        {
            return groupId;
        }
        
        public override SteamID GetGroupChatSteamID()
        {
            return new SteamID(UInt64.Parse(groupId));
        }
    }
}
