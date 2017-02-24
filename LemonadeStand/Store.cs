using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Store
    {
        public double Lemon;
        public double Sugar;
        public double Ice;
        public double LemonPriceTotal;
        public double SugarPriceTotal;
        public double IcePriceTotal;
        public double TotalAllItem;
        //---------------------
        public Store()
        {
            Lemon = .20;
            Sugar = .05;
            Ice = .05;
            LemonPriceTotal = 0;
            SugarPriceTotal = 0;
            IcePriceTotal = 0;
            TotalAllItem = 0;
        }
        //---------------------
        public void DisplayStore(Player player)
        {
            Console.WriteLine(" --------------------------------------------");
            Console.WriteLine("\n 3 Lemon, 2 Sugar, and 10 Ice equal to 1 Pitchers. 1 Pitchers can serve to 5 cup.");
            Console.WriteLine(" What Will You Like To Buy");
            Console.WriteLine(" 1 = Lemon, 2 = Sugar, 3 = Ice, 4 = Exit Store");
            string Choice = Console.ReadLine();
            switch (Choice)
            {
                case "1":
                    Console.WriteLine(" How Many Lemon Do You Want?");
                    AddLemonInventory(player);
                    Console.WriteLine($"Your Lemon Total ${LemonPriceTotal.ToString("0.00")}");
                    DisplayStore(player);
                    break;
                case "2":
                    Console.WriteLine(" How Many Sugar Cube Do You Want?");
                    AddSugarInventory(player);
                    Console.WriteLine($" Your Sugar Cube Total ${SugarPriceTotal.ToString("0.00")}");
                    DisplayStore(player);
                    break;
                case "3":
                    Console.WriteLine(" How Many Ice Cube Do You Want?");
                    AddIceInventory(player);
                    Console.WriteLine($" Your Ice Cube Total ${IcePriceTotal.ToString("0.00")}");
                    DisplayStore(player);
                    break;
                case "4":
                    TotalItem(player);
                    Console.WriteLine($" Your Total Is ${TotalAllItem.ToString("0.00")}");
                    Console.WriteLine(" Press Enter To Buy");
                    Console.ReadLine();
                    Console.Clear();
                    break;
                default:
                    Console.WriteLine(" That Was Not A Option");
                    DisplayStore(player);
                    break;
            }
        }
        public void AddLemonInventory(Player player)
        {
            int LemonAmount = int.Parse(Console.ReadLine());
            if (player.wallet.Cash < LemonAmount * Lemon)
            {
                Console.WriteLine(" Sorry Not Enough Money");
            }
            else if (player.wallet.Cash >= LemonAmount * Lemon)
            {
                for (int i = 0; i < LemonAmount; i++)
                {
                    player.inventory.AddLemon();
                }
            }
            LemonPriceTotal = LemonAmount * Lemon;
        }
        public void AddSugarInventory(Player player)
        {
            int SugarAmount = int.Parse(Console.ReadLine());
            if (player.wallet.Cash < SugarAmount * Sugar)
            {
                Console.WriteLine(" Sorry Not Enough Money");
            }
            else if (player.wallet.Cash >= SugarAmount * Sugar)
            {
                for (int i = 0; i < SugarAmount; i++)
                {
                    player.inventory.AddSugar();
                }
            }
            SugarPriceTotal = SugarAmount * Sugar;
        }
        public void AddIceInventory(Player player)
        {
            int IceAmount = int.Parse(Console.ReadLine());
            if (player.wallet.Cash < IceAmount * Ice)
            {
                Console.WriteLine(" Sorry Not Enough Money");
            }
            else if (player.wallet.Cash >= IceAmount * Ice)
            {
                for (int i = 0; i < IceAmount; i++)
                {
                    player.inventory.AddIce();
                }
            }
            IcePriceTotal = IceAmount * Ice;
        }
        public void TotalItem(Player player)
        {
            TotalAllItem = LemonPriceTotal + SugarPriceTotal + IcePriceTotal;
            player.wallet.CashSpentToday = TotalAllItem;
        }
    }
}
