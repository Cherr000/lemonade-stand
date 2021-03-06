﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade
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
        public Store()
        {
            Lemon = .25;
            Sugar = .25;
            Ice = .25;
            LemonPriceTotal = 0;
            SugarPriceTotal = 0;
            IcePriceTotal = 0;
            TotalAllItem = 0;
        }
        public void GetStoreName(UserInterface gameInfo, Player player)
        {
            gameInfo.DisplayGameTitle();
            Console.WriteLine("\n Welcome To Pick-n-Buy");
            Console.WriteLine(" ---------------------");
            Console.WriteLine($" Lemon Price ${Lemon.ToString("0.00")}  |  Sugar Cube Price ${Sugar.ToString("0.00")}  |  Ice Cube Price ${Ice.ToString("0.00")}");
            Console.WriteLine(" ---------------------------------------------------------------------");
            Console.WriteLine($"\n You Have {player.inventory.lemon.Count} Lemon");
            Console.WriteLine($" You Have {player.inventory.sugar.Count} Sugar Cube");
            Console.WriteLine($" You Have {player.inventory.ice.Count} Ice Cube");
        }
        public void GoShopping(Player player, UserInterface gameInfo)
        {
            gameInfo.ToClearScreen();
            GetStoreName(gameInfo, player);
            Console.WriteLine($"\n Bank ${player.Bank.ToString("0.00")}");
            Console.WriteLine(" What will you like to buy?");
            Console.WriteLine(" [1] Lemon  [2] Sugar  [3] Ice  [4] Checkout/EXit");
            Console.Write(" Enter Number Here: ");
            string Choice = Console.ReadLine();
            switch (Choice)
            {
                case "1":
                    Console.WriteLine("\n How Many Lemon Do You Want?");
                    BuyLemon(player);
                    GoShopping(player, gameInfo);
                    break;
                case "2":
                    Console.WriteLine("\n How Many Sugar Cube Do You Want?");
                    BuySugar(player);
                    GoShopping(player, gameInfo);
                    break;
                case "3":
                    Console.WriteLine("\n How Many Ice Cube Do You Want?");
                    BuyIce(player);
                    GoShopping(player, gameInfo);
                    break;
                case "4":
                    TotalItemBuy(player);
                    Console.WriteLine($"\n Your Total Is ${TotalAllItem.ToString("0.00")}");
                    Console.WriteLine(" Press Enter To Buy");
                    Console.ReadLine();
                    break;
                default:
                    Console.WriteLine(" Invalid Option");
                    GoShopping(player, gameInfo);
                    break;
            }
        }
        public void BuyLemon(Player player)
        {
            try
            {
                int LemonAmount = int.Parse(Console.ReadLine());
                if (player.Bank < LemonAmount * Lemon)
                {
                    Console.WriteLine(" Sorry Not Enough Money");
                }
                else if (player.Bank >= LemonAmount * Lemon)
                {
                    for (int i = 0; i < LemonAmount; i++)
                    {
                        player.inventory.AddLemon();
                    }
                    LemonPriceTotal = LemonAmount * Lemon;
                    player.Bank = player.Bank - LemonPriceTotal;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(" Please Enter A Number");
                BuyLemon(player);
            }
        }
        public void BuySugar(Player player)
        {
            try
            {
                int SugarAmount = int.Parse(Console.ReadLine());
                if (player.Bank < SugarAmount * Sugar)
                {
                    Console.WriteLine(" Sorry Not Enough Money");
                }
                else if (player.Bank >= SugarAmount * Sugar)
                {
                    for (int i = 0; i < SugarAmount; i++)
                    {
                        player.inventory.AddSugar();
                    }
                    SugarPriceTotal = SugarAmount * Sugar;
                    player.Bank = player.Bank - SugarPriceTotal;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(" Please Enter A Number");
                BuyLemon(player);
            }
        }
        public void BuyIce(Player player)
        {
            try
            {
                int IceAmount = int.Parse(Console.ReadLine());
                if (player.Bank < IceAmount * Ice)
                {
                    Console.WriteLine(" Sorry Not Enough Money");
                }
                else if (player.Bank >= IceAmount * Ice)
                {
                    for (int i = 0; i < IceAmount; i++)
                    {
                        player.inventory.AddIce();
                    }
                    IcePriceTotal = IceAmount * Ice;
                    player.Bank = player.Bank - IcePriceTotal;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(" Please Enter A Number");
                BuyLemon(player);
            }
        }
        public void TotalItemBuy(Player player)
        {
            TotalAllItem = LemonPriceTotal + SugarPriceTotal + IcePriceTotal;
            player.Cashspend = TotalAllItem + player.Cashspend;
        }
    }
}
