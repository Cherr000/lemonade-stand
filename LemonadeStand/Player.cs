using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Player
    {
        public string name;

        public void GetPlayerName()
        {
            Console.WriteLine("\n Enter your player name to start!");
            name = Console.ReadLine();
        }
    }
}
