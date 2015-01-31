using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SteamKit2;
using System.IO.File;

namespace SteamBot
{
    class BalanceBotAction : BotAction
    {
        public BalanceBotAction(string friendId, string chatId)
        {
            base(friendId, chatId);
        }

        public void Execute()
        {
            string[] balances = System.IO.File.ReadAllLines(@"C:\Users\zykour\Dropbox\TAP balance.txt");
            foreach (string line in lines)
            {
                string[] postSplit = line.Split(' ');
                if (postSplit.GetLength() > 0)
                {
                    if (postSplit[1].CompareTo(friendId) == 0)
                    {
                        results = postSplit[2] + ": " + postSplit[3];
                        HasMessage = true;
                        success = true;
                    }
                }
            }
        }
    }
}
