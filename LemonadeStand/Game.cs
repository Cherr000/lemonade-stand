using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Game
    {
        Player player = new Player();
        Wallet wallet = new Wallet();
        Weather weather = new Weather();
        Store store = new Store();

        public void GetRule()
        {
            Console.WriteLine("\n ------------------");
            Console.WriteLine(" | Lemonade Stand |");
            Console.WriteLine(" ------------------");
            Console.WriteLine(" \n | Rules | ");
            Console.WriteLine(" You Will Run Your Own Lemonade Stand By The End Of The Day Or Week You Should Make A Profit If Not You Lost. \n To Start You Off You'll Get $15.00 To Spent. So Shop Smart.");
            Console.WriteLine("\n ------------------------------------------------------------------------------------------------------------");
        }
        public void GameLogIn()
        {
            Console.WriteLine("\n Will You Like To Play The Game. \n   Type: Y = Yes | N = No");
            string getMoreInfo = Console.ReadLine();
            switch (getMoreInfo)
            {
                case "Y":
                    player.GetPlayerName();
                    Console.WriteLine($"\n {player.name} Get Ready To Play");
                    Console.WriteLine(" -------------------------------------");
                    weather.WeatherRandomPick();
                    Console.WriteLine($"Today Weather Will Be {weather.choice}");
                    GetStarted();
                    break;
                case "N":
                    Console.WriteLine("\n GoodBye Press Enter To Exit");
                    break;
                default:
                    Console.WriteLine("NOT A VALID ANSWER");
                    GameLogIn();
                    break;
            }
        }
        public void GetStarted()
        {
            Console.WriteLine($"\n {player.name} You Have ${wallet.Cash.ToString("0.00")}");
            Console.WriteLine(" Will You Like To Buy Pitchers Of Lemonade Or Make Your Own. A = Buy Pitcher Or B = Built Your Own List");
            string InventorySetUp = Console.ReadLine();
            switch (InventorySetUp)
            {
                case "A":
                    store.PitcherPreMade();
                    Console.WriteLine($"\n Pitchers Cost {store.subTotal.ToString("0.00")} Each, How Many Pitchers Will You Like To Buy? 1 - 10 Pitchers Max Buy");
                    double PickPitchers = double.Parse(Console.ReadLine());
                    store.MoneyLeftOver();
                    Console.WriteLine($" You Have ${store.Newcash.ToString("0.00")} To Spent");
                    break;
                case "B":
                    store.GetLemons();
                    // Add Buy Function in here
                    break;
                default:
                    GetStarted();
                    break;
            }
        }

    }
}
