using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SteamKit2;

namespace SteamBot
{
    class FriendMsgBotAction
    {
        protected string friendId;

        public FriendMsgBotAction(string friendId)
        {
            this.friendId = friendId;
        }

        public FriendMsgBotAction(SteamID groupId, SteamID friendId)
        {
            this.friendId = friendId.ToString();
        }

        public FriendMsgBotAction()
        {
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
            return (friendId != null) ? true : false;
        }

        public string GetFriendID()
        {
            return friendId;
        }

        public SteamID GetFriendSteamID()
        {
            return new SteamID(friendId);
        }
    }
}
