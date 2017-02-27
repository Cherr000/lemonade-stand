using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade
{
    class Player
    {
        public Recipe recipe;
        public Inventory inventory;
        public string playerName;
        public double Bank;
        public double LemonadePrice;
        public double CashEarn;
        public double Cashspend;
        public Random CashToBank;
        public Player()
        {
            recipe = new Recipe();
            inventory = new Inventory();
            Bank = 0.00;
            LemonadePrice = .15;
            CashEarn = 0;
            Cashspend = 0;
            CashToBank = new Random();
        }
        public void AddCashEarn()
        {
            Bank = CashEarn + Bank;
        }
        public void MakeRecipeDisplay()
        {
            Console.Clear();
            inventory.DisplayInventory();
            recipe.GetRecipe();
            Console.WriteLine("\n It Is Time To Make Your Lemonade Recipe");
            Console.WriteLine(" [1] Lemon  [2] Sugar Cube  [3] Ice Cube  [4] Exit");
            Console.Write(" Enter Here: ");
            string ChooseLetter = Console.ReadLine();
            switch (ChooseLetter)
            {
                case "1":
                    Console.WriteLine("\n How Many Lemon Will You Like To Use?");
                    Console.Write(" Enter Number Here: ");
                    recipe.recipeLemon = int.Parse(Console.ReadLine());
                    MakeRecipeDisplay();
                    break;
                case "2":
                    Console.WriteLine("\n How Many Sugar Cube Will You Like To Use?");
                    Console.Write(" Enter Number Here: ");
                    recipe.recipeSugar = int.Parse(Console.ReadLine());
                    MakeRecipeDisplay();
                    break;
                case "3":
                    Console.WriteLine("\n How Many Ice Cube Will You Like To Use?");
                    Console.Write(" Enter Number Here: ");
                    recipe.recipeIce = int.Parse(Console.ReadLine());
                    MakeRecipeDisplay();
                    break;
                case "4":
                    break;
                default:
                    MakeRecipeDisplay();
                    break;
            }

            inventory.MakePitcher(recipe);
        }
        public void DisplayCashFlow()
        {
            AddCashEarn();
            Console.WriteLine(" -------------------------------------------");
            Console.WriteLine($" Money: ${Bank.ToString("0.00")} ");
            Console.WriteLine($" Spent Today: ${Cashspend.ToString("0.00")} ");
            Console.WriteLine($" Cash Earn Today: ${CashEarn.ToString("0.00")}");
            Console.WriteLine("\n Press Enter To Exit");
            Console.ReadLine();
        }
        public void GetChange(UserInterface gameInfo)
        {
            gameInfo.ToClearScreen();
            gameInfo.DisplayGameTitle();
            Console.WriteLine($"\n Your Current Lemonade Price Is ${LemonadePrice.ToString("0.00")}");
            inventory.DisplayPitcherMade();
            gameInfo.ToContinue();
            recipe.GetRecipe();
            Console.WriteLine(" ---------------------------------------------------------------------------------------");
            Console.WriteLine("\n Will You Like To Change Your Price Or Recipe");
            Console.WriteLine(" [1]-Change Lemonade Price  [2]-Change Recipe To Make Lemonade Pitcher  [3]-Exit");
            Console.Write(" Enter Here: ");
            string ChangeChoice = Console.ReadLine();
            switch (ChangeChoice)
            {
                case "1":
                    ChangeLemonadePrice();
                    GetChange(gameInfo);
                    break;
                case "2":
                    MakeRecipeDisplay();
                    GetChange(gameInfo);
                    break;
                case "3":
                    gameInfo.ToContinue();
                    break;
                default:
                    Console.WriteLine("\n Invalid Option");
                    gameInfo.ToContinue();
                    GetChange(gameInfo);
                    break;
            }
        }
        public void GetBankTotal()
        {
            Console.WriteLine($"\n {playerName}, Have ${Bank}");
        }
        public void DisplayDifficultyOption()
        {
            Console.WriteLine("\n Difficulty Level Will Be Base On How Much Bank You Start With.");
            Console.WriteLine($"\n {playerName}, Choose Your Difficulty Level");
            Console.WriteLine(" [1]-Easy  [2]-Medium  [3]-Hard");
            Console.Write(" Please Enter Number Here: ");
            int NumberChoice = int.Parse(Console.ReadLine());
            if (NumberChoice == 1)
            {
                Bank = CashToBank.Next(10, 20);
            }
            else if (NumberChoice == 2)
            {
                Bank = CashToBank.Next(5, 10);
            }
            else if (NumberChoice == 3)
            {
                Bank = CashToBank.Next(3, 6);
            }
            else
            {
                Console.WriteLine(" Wrong Input Please Retry");
                DisplayDifficultyOption();
            }
        }
        public void GetLemonadePrice()
        {
            Console.WriteLine($"\n Your Current Lemonade Price Is ${LemonadePrice.ToString("0.00")}");
        }
        public void ChangeLemonadePrice()
        {
            Console.WriteLine($"\n Your Current Lemonade Price Is ${LemonadePrice.ToString("0.00")}");
            Console.WriteLine("\n Will You Like To Change The Lemonade Price.");
            Console.Write(" [Y] Yes Or [N] No: ");
            string PriceChange = Console.ReadLine().ToLower();
            switch (PriceChange)
            {
                case "y":
                    do
                    {
                        Console.WriteLine(" Enter The Price You Want To Set To, Your Price Max Is $2.00.");
                        Console.Write(" Enter New Price Here: ");
                        LemonadePrice = double.Parse(Console.ReadLine());
                        if (LemonadePrice >= 0 && LemonadePrice <= 2.00)
                        {
                            Console.WriteLine("\n Press Enter To Exit");
                            Console.ReadLine();
                            Console.Clear();
                        }
                        else
                        {
                            Console.WriteLine("Price Max Set Is $2.00");
                        }
                    } while (LemonadePrice > 2.00);
                    break;
                case "n":
                    Console.WriteLine(" Okay Your Price Will Stay The Same");
                    Console.WriteLine("\n Press Enter To Exit");
                    Console.ReadLine();
                    break;
                default:
                    Console.WriteLine(" That Was Not A Option");
                    ChangeLemonadePrice();
                    break;
            }
        }
        public void GetPlayerName()
        {
            Console.Write("\n Player Please Enter Your Name: ");
            playerName = Console.ReadLine();
        }
    }
}
