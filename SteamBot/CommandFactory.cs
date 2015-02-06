using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SteamBot
{
    class CommandFactory
    {
        public BotAction CreateBotAction(string command, string userId)
        {
            return CreateBotAction(command, userId, null);
        }

        public BotAction CreateBotAction(string command, string userId, string chatId)
        {
            if (command.StartsWith("!balance") == true)
                return new BalanceBotAction(userId, chatId);
            return null;
        }
    }
}
