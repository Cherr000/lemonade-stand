using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Inventory
    {
        public List<Lemon> lemon;
        public List<Sugar> sugar;
        public List<Ice> ice;
        public List<Pitcher> pitcher;
        public Inventory()
        {
            lemon = new List<Lemon>();
            sugar = new List<Sugar>();
            ice = new List<Ice>();
            pitcher = new List<Pitcher>();
        }
        public void DisplayInventory()
        {            
            Console.WriteLine($" You Have {lemon.Count} Lemon");
            Console.WriteLine($" You Have {sugar.Count} Sugar Cube");
            Console.WriteLine($" You Have {ice.Count} Ice Cube");
            PitcherMade();
            Console.WriteLine($" You Have {pitcher.Count} Pitcher");
            Console.WriteLine("\n Press Enter To Exit");
            Console.ReadLine();
            Console.Clear();
        }
        public void AddLemon()
        {
            lemon.Add(new Lemon());
        }
        public void AddSugar()
        {
            sugar.Add(new Sugar());
        }
        public void AddIce()
        {
            ice.Add(new Ice());
        }
        public void AddPitcher()
        {
            pitcher.Add(new Pitcher());
        }
        //Console.WriteLine(" 3 Lemon, 2 Sugar, and 10 Ice equal to 1 Pitchers. 1 Pitchers can serve to 5 cup.");
        public void PitcherMade()
        {
            while (lemon.Count >= 3 && sugar.Count >= 2 && ice.Count >= 10)
            {
                for (int a = 0; a < 3; a++)
                {
                    lemon.RemoveAt(0);
                }
                for (int b = 0; b < 2; b++)
                {
                    sugar.RemoveAt(0);
                }
                for (int c = 0; c < 10; c++)
                {
                    ice.RemoveAt(0);
                }
                AddPitcher();
            }
        }
    }
}

