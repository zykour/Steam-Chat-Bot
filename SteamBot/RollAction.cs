using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SteamKit2;
using System.IO;
using System.Text.RegularExpressions;

namespace SteamBot
{

    // A simple example action
    // This Bot action has the following behavior
    //
    // If the user types /roll or !roll, it will select a random number between 1 and 100 inclusive. 
    // if the user specifies a valid integer range as an argument such as: !roll 1-50
    // then the action will select a number between that range (inclusive)

    class RollAction : ChatMsgBotAction
    {

        protected string msg;

        public RollAction(string friendId, string chatId, string msg) 
            : base(friendId, chatId)
        {
            this.msg = msg;
        }

        public override void Execute() 
        {
            Regex rollFormat = new Regex(@"[!/](roll )([0-9]+)\-([0-9]+)");
        
            Match match = rollFormat.Match(msg);

            int lower = 1;
            int upper = 100;

            if (match.Success)
            {
                lower = Int32.Parse(match.Groups[2].ToString().Trim());
                upper = Int32.Parse(match.Groups[3].ToString().Trim());
            }

            // if the user specifies the first value of the range to be larger than the second number, such as !roll 100-1
            // then we take the liberty to reverse the order

            if (lower > upper)
            {
                int temp = lower;
                lower = upper;
                upper = temp;
            }

            Random rg = new Random();
            int randomNum = rg.Next(lower, upper + 1);

            // save what the Bot will message the chat. In this case what the bot rolled as a random number
            results = "Rolled a " + randomNum;
            
            // we want to confirm that there is an available message for the bot to send
            messageAvailable = true;

            // the execute command ran as intended
            success = true;
        }
    }
}
