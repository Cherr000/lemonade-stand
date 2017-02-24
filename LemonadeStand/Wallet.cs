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
            Cash = 10.00;
            Price = .25;
            CashEarnToday = 0;
            CashSpentToday = 0;
            TotalCashAmountToday = 0;
            CashAmountEndOfTheWeek = Cash + TotalCashAmountToday;
        }
        public void GetCash()
        {
            SubtractCashAndCashSpent();
            Console.WriteLine($"\n Money: ${Cash.ToString("0.00")} ");
            Console.WriteLine($" Spent Today: ${CashSpentToday.ToString("0.00")} ");
            Console.WriteLine($" Cash Earn Today: ${CashEarnToday.ToString("0.00")}");
            Console.WriteLine("\n Press Enter To Exit");
            Console.ReadLine();
            Console.Clear();
        }
        public void GetPricePerCup()
        {
            Console.WriteLine($"\n Lemonade Price Set To ${Price.ToString("0.00")}");
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
                    Console.WriteLine("\n Press Enter To Exit");
                    Console.Clear();
                    break;
                case "n":
                    Console.WriteLine(" Okay Your Price We Stay The Same");
                    Console.WriteLine("\n Press Enter To Exit");
                    Console.Clear();
                    break;
                default:
                    Console.WriteLine(" That Was Not A Option");
                    ChangeLemonadePrice();
                    break;
            }
        }
        public void SubtractCashAndCashSpent()
        {
            Cash = Cash - CashSpentToday;
        }
    }
}
