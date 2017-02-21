using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Store
    {
        Game game;
        Wallet wallet;
        public double lemonPrice = 0.10;
        public double IcePrice = 1.00;
        public double SugarCluePrice = .20;
        public double WaterPrice = 1.50;
        public double CupPrice = 1.50;
        public double lemonPriceTotal = 0.00;
        public double subTotal = 0;
        public double Newcash = 0;
        public double Cash = 15.00;
        public double pitcherBuyTotal = 0;

        public void GetLemons()
        {
            Console.WriteLine(" Will You Like To Buy Some Lemons. Y | N");
            string OptionToBuyLemons = Console.ReadLine();
            switch (OptionToBuyLemons)
            {
                case "Y":
                    Console.WriteLine(" Lemons Price 10 Cent Each. Enter The Amount You Want");
                    double LemonPick = double.Parse(Console.ReadLine());
                    lemonPriceTotal = LemonPick * lemonPrice;
                    Console.WriteLine($" ${lemonPriceTotal.ToString("0.00")} Is How Much You Pay");
                    break;
                case "N":
                    // Go Back To Game Mode
                    break;
                default:
                    Console.WriteLine("NOT A VALID ANSWER");
                    GetLemons();
                    break;
            }
        }
        public void PitcherPreMade()
        {
            subTotal = lemonPrice * 5 + IcePrice * 1 + SugarCluePrice * 5 + WaterPrice * 1 + CupPrice * 1;
        }
        public void PitcherBuy()
        {
            pitcherBuyTotal = subTotal * game.PickPitchers;
        }
        public void MoneyLeftOver()
        {
            Newcash = subTotal - Cash;
        }
    }
}
