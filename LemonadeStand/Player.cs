using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Player
    {
        public Wallet wallet;
        public Inventory inventory;
        public string name;

        //--------------------------
        public Player()
        {
            wallet = new Wallet();
            inventory = new Inventory();
        }
        //--------------------------
        public void GetPlayerName()
        {
            Console.Write("\n Player Please Enter Your Name: ");
            name = Console.ReadLine();
        }
        public void DisplayWallet()
        {
            wallet.GetCash();
            wallet.GetPricePerCup();
        }
    }
}
