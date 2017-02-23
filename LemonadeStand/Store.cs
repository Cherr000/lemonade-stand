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
        //---------------------
        public Store()
        {
            Lemon = .20;
            Sugar = .05;
            Ice = .05;
        }
        //---------------------
        public void DisplayStore(Player player)
        {
            Console.WriteLine(" What Will You Like To Buy");
            Console.WriteLine(" 1 = Lemon, 2 = Sugar, 3 = Ice, 4 = Exit Store");
            string Choice = Console.ReadLine();
            switch (Choice)
            {
                case "1":
                    AddLemonInventory(player);
                    DisplayStore(player);
                    break;
                case "2":
                    AddSugarInventory(player);
                    DisplayStore(player);
                    break;
                case "3":
                    AddIceInventory(player);
                    DisplayStore(player);
                    break;
                case "4":
                    // To Exit Store
                    break;
                default:
                    Console.WriteLine(" That Was Not A Option");
                    DisplayStore(player);
                    break;
            }
        }
        public void AddLemonInventory(Player player)
        {
            Console.WriteLine(" How Many Lemon Do You Want?");
            int LemonAmount = int.Parse(Console.ReadLine());
            for (int i = 0; i < LemonAmount; i++)
            {
                player.inventory.AddLemon();
            }
        }
        public void AddSugarInventory(Player player)
        {
            Console.WriteLine(" How Many Sugar Cube Do You Want?");
            int SugarAmount = int.Parse(Console.ReadLine());
            for (int i = 0; i < SugarAmount; i++)
            {
                player.inventory.AddSugar();
            }
        }
        public void AddIceInventory(Player player)
        {
            Console.WriteLine(" How Many Ice Cube Do You Want?");
            int IceAmount = int.Parse(Console.ReadLine());
            for (int i = 0; i < IceAmount; i++)
            {
                player.inventory.AddIce();
            }
        }
    }
}
