using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SteamKit2;
using System.IO.MemoryMappedFiles;
using System.Text.RegularExpressions;

namespace SteamBot
{
    class BalanceBotAction : BotAction
    {
        public BalanceBotAction(string friendId, string chatId)
            : base(friendId, chatId)
        {
        }

        public void Execute()
        {
            string[] balances = System.IO.File.ReadAllLines(@"C:\Users\zykour\Dropbox\TAP balance.txt");

            Regex balanceCmd = new Regex(@"([^0-9]*)([0-9]+)(.*)");

            foreach (string line in balances)
            {
                Match match = balanceCmd.Match(line);


                if (match.Success)
                {
                    Console.WriteLine(match.Groups[1].ToString());
                    if (match.Groups[3].ToString().Trim().CompareTo(friendId) == 0)
                    {
                        results = match.Groups[1].ToString().Trim() + ", your Co-op Shop balance is: " + match.Groups[2].ToString().Trim();
                        messageAvailable = true;
                        success = true;
                    }
                }
            }
        }
    }
}
