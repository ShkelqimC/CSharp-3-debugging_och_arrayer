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
            List<String> diffItems = new List<string>();
            


            while (true)
            {
                Console.WriteLine("1: Add an electric bicycle");
                Console.WriteLine("2: Add a trampoline");
                Console.WriteLine("3: Add a bouquet");
                Console.WriteLine("4: Add something else");
                Console.WriteLine("5: Show orders");
                Console.WriteLine("6: Print different items that was ordered");
                Console.WriteLine("7: Exit without placing order");
                Console.WriteLine("8: Get amount of orders");
                Console.WriteLine("9: Time wich last order was created:");

                Console.Write("Type option and press enter:");
                int choice = int.Parse(Console.ReadLine());

                Console.Clear();

                if (choice == 1)
                {
                    listOfOrders.Add(new Order("electric bicycle"));
                    if (!diffItems.Contains("electric bicycle"))
                    {
                        diffItems.Add("electric bicycle");
                    }
                }
                else if (choice == 2)
                {
                    listOfOrders.Add(new Order("trampoline"));
                    if (!diffItems.Contains("trampoline"))
                    {
                        diffItems.Add("trampoline");
                    }
                }
                else if (choice == 3)
                {
                    listOfOrders.Add(new Order("bouquet"));
                    if (!diffItems.Contains("bouquet"))
                    {
                        diffItems.Add("bouquet");
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
                    else
                        listOfOrders.Add(new Order(t.ToLower()));
                    if (!diffItems.Contains(t.ToLower()))
                    {
                        diffItems.Add(t.ToLower());
                    }
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
                    diffItems.ForEach(x => Console.WriteLine(x));
                    Console.WriteLine();
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
            //bool b =true;
            //while (b)
            //{
            //    switch (choice)
            //    {
            //        case 1:
            //            listOfOrders.Add(new Order("electric bicycle"));
            //            break;
            //        case 2:
            //            listOfOrders.Add(new Order("trampoline"));
            //            break;
            //        case 3:
            //            listOfOrders.Add(new Order("bouquet"));
            //            break;
            //        case 4:
            //            Console.WriteLine("What would you like to order?");
            //            var item = Console.ReadLine();
            //            listOfOrders.Add(new Order(item.ToString()));
            //            break;
            //        case 5:
            //            listOfOrders.ForEach(x => Console.WriteLine(x));
            //            break;
            //        case 6:
            //            Console.WriteLine("??????");
            //            break;
            //        case 7:
            //            b = false;
            //            break;
            //        default:
            //            Console.WriteLine("Cannot understand ur choice");
            //            break;

            //    }
            //}
        }

    }
}
