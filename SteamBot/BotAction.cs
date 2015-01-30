using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SteamKit2;

namespace SteamBot
{
    class BotAction
    {
        private string results;
        private bool success;

        public BotAction()
        {
            results = "";
            success = false;
        }

        public string ToString()
        {
            return results;
        }

        public bool IsSuccessful()
        {
            return success;
        }

        public void Execute()
        {

        }
    }
}
