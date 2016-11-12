using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colonel.Games
{
    class GameHandle
    {
        public static void launchGame(string x)
        {
            switch (x)
            {
                case "war": War.play(); break;
                default: Console.WriteLine("Sorry, we don\'t have that game."); break;
            }
        }
    }
}
