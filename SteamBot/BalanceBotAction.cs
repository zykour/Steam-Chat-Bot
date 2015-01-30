using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SteamKit2;
using System.IO.File;

namespace SteamBot
{
    class BalanceBotAction
    {
        private string steamId;

        public BalanceBotAction(string steamId)
        {
            this.steamId = steamId;
        }

        public void Execute()
        {
            string[] balances = System.IO.File.ReadAllLines(@"C:\Users\zykour\Dropbox\TAP balance.txt");
            foreach (string line in lines)
            {
                string[] postSplit = line.Split(' ');
                if (postSplit.Length > 0)
                {
                    if (postSplit[1].CompareTo(steamId) == 0)
                    {

                        //ulong TAPlong = 103582791433348587;// 103582791434637703;
                        //Console.WriteLine("Doing stuff...");
                        //SteamID TAPid = new SteamID(TAPlong);
                        // steamFriends.JoinChat(TAPid);
                        //steamFriends.SendChatRoomMessage(TAPid, EChatEntryType.ChatMsg, "Testing 1...2...3. Test complete.");

                    }
                }
            }
        }
    }
}
