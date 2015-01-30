using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SteamBot
{
    class CommandFactory
    {
        string commandName;
        string[] extras;
        bool hasExtras;

        public CommandFactory(string commandName, string[] extras)
        {
            this.commandName = commandName;
            this.extras = extras;
            hasExtras = true;
        }

        public CommandFactory(string commandName)
        {
            this.commandName = commandName;
            hasExtras = false;
        }

        public BotAction CreateBotAction()
        {
            switch (commandName.ToLower())
            {
                case "!balance":
                    return new BalanceBotAction(extras);
                    break;
                default:
                    break;
            }
            return null;
        }
        }
    }
}
