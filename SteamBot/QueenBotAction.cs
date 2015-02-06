﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SteamKit2;
using System.IO;
using System.Text.RegularExpressions;

namespace SteamBot
{
    class QueenBotAction : ChatMsgBotAction {
        
        public QueenBotAction(string friendId, string chatId) 
            : base(friendId, chatId)
        {
        }

        
        public override void Execute()
        {
            // General format for balances is: Name     ##      SteamID
            Regex balanceCmd = new Regex(@"([^0-9]*)([0-9]+)\s+([0-9]+)");

            try
            {
                using (StreamReader sr = new StreamReader(@"C:\Users\zykour\Dropbox\TAP balance.txt"))
                {
                    String line;
                    int max = 0;
                    string highestPoints = "";

                    while ((line = sr.ReadLine()) != null)
                    {
                        Match match = balanceCmd.Match(line);

                        if (match.Success)
                        {
                            if (max < Int32.Parse(match.Groups[2].ToString().Trim())) 
                            {
                                max = Int32.Parse(match.Groups[2].ToString().Trim());
                                highestPoints = match.Groups[1].ToString().Trim();
                                highestPoints = highestPoints.Substring(1);
                            }
                        }
                    }

                    results = "Queen " + highestPoints + ", is winning with " + max + " points!";
                    messageAvailable = true;
                    success = true;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }
        }
    }
}
