﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SteamBot
{
    class CommandFactory
    {
        bool hasExtras;

        public CommandFactory()
        {
            hasExtras = false;
        }

        public BotAction CreateBotAction(string[] arguments, string userId, string chatId)
        {

            if (arguments.GetLength(1) > 1)
            {
                hasExtras = true;
            }

            switch (arguments[1].ToLower().Trim())
            {
                case "/balance":
                case "!balance":
                    return new BalanceBotAction(userId, chatId);
                default:
                    break;
            }
         
            return null;
        }
    }
}
