using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Wallet
    {
        public double Cash;
        public double Price;
        public double CashEarnToday;
        public double CashSpentToday;
        public double TotalCashAmountToday;
        public double CashAmountEndOfTheWeek;

        public Wallet()
        {
            Cash = 20.00;
            Price = .25;
            CashEarnToday = 0;
            CashSpentToday = 0;
            TotalCashAmountToday = 0;
            CashAmountEndOfTheWeek = Cash + TotalCashAmountToday;
        }
        public void GetCash()
        {
            Console.WriteLine($"\n Money: ${Cash} ");
            Console.WriteLine($" Spent Today: ${CashSpentToday} ");
            Console.WriteLine($" Cash Earn Today: ${CashEarnToday}");
        }
        public void GetPricePerCup()
        {
            Console.WriteLine($"\n Lemonade Price Set To ${Price}");
        }
        public void ChangeLemonadePrice()
        {
            Console.WriteLine(" Will You Like To Change The Lemonade Price. Y|N");
            string PriceChange = Console.ReadLine().ToLower();
            switch (PriceChange)
            {
                case "y":
                    Console.WriteLine(" Enter The Price You Want To Set Too");
                    Price = double.Parse(Console.ReadLine());
                    break;
                case "n":
                    Console.WriteLine(" Okay Your Price We Stay The Same");
                    break;
                default:
                    Console.WriteLine(" That Was Not A Option");
                    ChangeLemonadePrice();
                    break;
            }
        }
    }
}
