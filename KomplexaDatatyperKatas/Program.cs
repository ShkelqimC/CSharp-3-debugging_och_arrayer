using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using KomplexaDatatyperKata;
using System.Threading;

namespace KomplexaDatatyperKatas
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Order> listOfOrders = new List<Order>();
            List<String> allItemsList = new List<string>();
            List<string> uniqueList = new List<string>();

            bool b = true;
            while (true)
            {
                int choice = 0;
                Console.WriteLine("1: Add an electric bicycle");
                Console.WriteLine("2: Add a trampoline");
                Console.WriteLine("3: Add a bouquet");
                Console.WriteLine("4: Add something else");
                Console.WriteLine("5: Show orders");
                Console.WriteLine("6: Print different items and amounts that was ordered");
                Console.WriteLine("7: Exit without placing order");
                Console.WriteLine("8: Get amount of orders");
                Console.WriteLine("9: Time wich last order was created:");

                Console.Write("Type option and press enter:");
                while (true)
                {
                    try
                    {
                        choice = int.Parse(Console.ReadLine());
                        break;
                    }
                    catch
                    {
                        
                        Console.WriteLine("\nInvalid choice. Please retry.");
                        Console.Write("Type option and press enter:");
                    }
                } 

                Console.Clear();

                if (choice == 1)
                {
                    listOfOrders.Add(new Order("electric bicycle"));
                    allItemsList.Add("electric bicycle");
                    if (!uniqueList.Contains("electric bicycle"))
                    {
                        uniqueList.Add("electric bicycle");
                    }

                }
                else if (choice == 2)
                {
                    listOfOrders.Add(new Order("trampoline"));
                    allItemsList.Add("trampoline");
                    if (!uniqueList.Contains("trampoline"))
                    {
                        uniqueList.Add("trampoline");
                    }


                }
                else if (choice == 3)
                {
                    listOfOrders.Add(new Order("bouquet"));
                    allItemsList.Add("bouquet");
                    if (!uniqueList.Contains("bouquet"))
                    {
                        uniqueList.Add("bouquet");
                    }

                }
                else if (choice == 4)
                {
                    Console.WriteLine("What would u like to order? ");
                    Console.WriteLine("(0) to return to menu.");
                    var t = Convert.ToString(Console.ReadLine());
                    if (t == "0")
                    {
                        continue;
                    }
                    else if (!uniqueList.Contains(t.ToLower()))
                    {
                        uniqueList.Add(t.ToLower());
                        listOfOrders.Add(new Order(t.ToLower()));
                        allItemsList.Add(t.ToLower());
                    }
                    else
                    Console.Clear();
                }
                else if (choice == 5)
                {
                    Console.WriteLine("List of ordered items: ");
                   listOfOrders.ForEach(x=> Console.WriteLine(x.Name));
                   Console.WriteLine();
                }
                else if (choice == 6)
                {
                    
                    foreach (var VARIABLE in uniqueList)
                    {
                       var count = allItemsList.FindAll(x => x.Contains(VARIABLE)).Count;
                        Console.WriteLine($"{count} orders of {VARIABLE} has been made!");
                       
                    }
                   
                }

                else if (choice == 7)
                {
                    Console.WriteLine("Are you sure? ");
                    var answer = Convert.ToString(Console.ReadLine());
                    if (answer.ToLower() == "yes" || answer.ToLower() == "ye" || answer.ToLower() == "y")
                    {
                        break;
                    }
                
                }
                else if (choice==8)
                {
                    Console.WriteLine(Order.amountOfOrders);
                    Console.ReadKey();
                    
                }
                else
                {
                    Console.WriteLine("Invalid choice, retry.");

                }

            }
        }

    }
}
