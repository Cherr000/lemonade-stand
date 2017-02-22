using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Game
    {
        Player player;
        Store store;
        Day day;
        Customer customer;
        Weather weather;
        bool Meun;
        //---------------------------
        public Game()
        {
            player = new Player();
            store = new Store();
            day = new Day();
            customer = new Customer();
            weather = new Weather();
        }
        //---------------------------
        public void RunGame()
        {
            // Make a Welcome Screen
            DisplayWelcomeScreen();
            // Game Tilte And Rule
            DisplayGameTitle();
            DisplayGameRule();
            // Have Player Enter There Name
            player.GetPlayerName();
            Console.Clear();
            // Display Game Title and Weather
            DisplayGameTitle();
            DisplayWeather();
            // player menu
            DisplayMenu();
            // End The Game
        }
        private void DisplayWelcomeScreen()
        {
            Console.WriteLine("\n Welcome To The Lemonade Stand Game");
            Console.WriteLine(" ----------------------------------");
        }
        private void DisplayPlayOption()
        {
            Console.WriteLine("\n Are You Sure You Want To Quit \n   Y = Yes | N = NO");
            string playChoice = Console.ReadLine().ToLower();
            switch (playChoice)
            {
                case "y":
                    Environment.Exit(0);
                    break;
                case "n":
                    Console.Clear();
                    break;
                default:
                    Console.WriteLine(" That Was Not A Option");
                    DisplayPlayOption();
                    break;
            }
        }
        private void DisplayGameTitle()
        {
            Console.WriteLine("\n ------------------");
            Console.WriteLine(" | Lemonade Stand |");
            Console.WriteLine(" ------------------");
        }
        private void DisplayGameRule()
        {
            Console.WriteLine("\n Introduction ");
            Console.WriteLine(" ____________");
            Console.WriteLine("\n   You will have 7 day to make as much money as you can. By the end of the week you’ll see how much profit you made. \n You’ll also have complete control over your business, including pricing, quality control, inventory control, and \n purchasing supplies. Buy your ingredients, set your recipe, and start selling. One more thing you should know \n the forecast will affect your business.");
            Console.WriteLine("\n --------------------------------------------------------------------------------------------------------------------");
        }
        private void DisplayWeather()
        {
            weather.GetTodayForecast();
            Console.WriteLine(" ------------------------");
        }
        private void DisplayMenu()
        {
            player.wallet.GetPricePerCup();
            Console.WriteLine(" 3 Lemon, 2 Sugar, and 10 Ice equal to 1 Pitchers. 1 Pitchers can serve to 5 cup.");
            Console.WriteLine($"\n Hi {player.name} Will You Like To:");
            Console.Write(" 1 = Start Day, 2 = Store, 3 = Change Price, \n 4 = See Inventory, 5 = Cash, 6 = Quit: ");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    // method to start the day
                    break;
                case "2":
                    // method to go shopping at the store
                    Console.WriteLine();
                    break;
                case "3":
                    // method to change price
                    player.wallet.ChangeLemonadePrice();
                    DisplayMenu();
                    break;
                case "4":
                    // method to see inventory
                    break;
                case "5":
                    // method to see cash flow
                    player.wallet.GetCash();
                    DisplayMenu();
                    break;
                case "6":
                    //method to quit game
                    DisplayPlayOption();
                    DisplayMenu();
                    break;
                default:
                    Console.WriteLine(" Invalid Answer");
                    DisplayMenu();
                    break;
            }
        }
    }
}
