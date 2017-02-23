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
            Console.WriteLine($" You Have {pitcher.Count} Pitcher");
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
    }
}

