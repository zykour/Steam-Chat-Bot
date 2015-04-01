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
            // somehow parse the incoming command which is sent as a full (string) message
            // here we use a simple String.StartsWith() command for simplicity 
            
            // look to see if the message starts with a !roll or /roll command, if so
            // create a new RollAction (which inherits from ChatMsgBotAction) and return that
            // all functions created here inherit from BotAction and have an overrideable Execute function that can be called
            if (command.StartsWith("!roll") || command.StartsWith("/roll"))
                return new RollAction(userId, chatId, command);

            // as more commands are added,  parse for those as well

            // in the case that no action has been found, we choose here to return null
            return null;
        }

        public BotAction CreateBotAction(string command, string userId)
        {
            // friend msg actions here, if any
            

            // else see if there is a chat msg actions
            return CreateBotAction(command, userId, null);
        }
    }
}
