using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SteamBot
{
    class CommandFactory
    {
        public BotAction CreateBotAction(string command, string userId, string chatId)
        {
            if (command.StartsWith("!balance"))
                return new BalanceBotAction(userId, chatId);
            if (command.StartsWith("!queen"))
                return new QueenBotAction(userId, chatId);

            return null;
        }

        public BotAction CreateBotAction(string command, string userId)
        {
            // friend msg actions here, if any, else see if there is a chat msg actions
            return CreateBotAction(command, userId, null);
        }
    }
}
