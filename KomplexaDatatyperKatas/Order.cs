using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic.CompilerServices;

namespace KomplexaDatatyperKata
{
    public class Order
    {
        private int _orderNumber = 0;
        public string Name;
        private DateTime timeOfOrder;
        public static int amountOfOrders;


        public DateTime _TimeOfOrder
        {
            get { return timeOfOrder;}
        }



        public Order(string name)
        {
            Name = name;
            timeOfOrder = DateTime.Now;
            amountOfOrders++;
            Console.WriteLine($"{amountOfOrders} total order(s) made!\n");
            _orderNumber = amountOfOrders;
        }
        //public static int GenerateOrderNumber()
        //{
        //    int k;
        //    bool b = true;
        //    do
        //    {
        //        int min = 0000;
        //        int max = 9999;
        //        Random orderNumberGenerator = new Random();
        //        k = orderNumberGenerator.Next(min, max);
        //        if (!listOfOrderNumbers.Contains(k))
        //        {
        //            listOfOrderNumbers.Add(k);
        //            b = false;
        //        }
        //    } while (b);

        //    return k;
        //}

        //public Order NewOrder(string name)
        //{
        //    List<string> listOfOrders = new List<string>();
        //    int countOfItems = 0;
        //    while (true)
        //    {
        //        Console.Clear();

        //        Console.WriteLine("1: Add an electric bicycle");
        //        Console.WriteLine("2: Add a trampoline");
        //        Console.WriteLine("3: Add a bouquet");
        //        Console.WriteLine("4: Add something else");
        //        Console.WriteLine("5: Show my order");
        //        Console.WriteLine("6: Finish my order");
        //        Console.WriteLine("7: Exit without placing order");

        //        Console.Write("Type option and press enter:");
        //        int choice = int.Parse(Console.ReadLine());

        //        Console.Clear();

        //        if (choice == 1)
        //        {
        //            listOfOrders.Add("electric bycycle");
        //            countOfItems++;
        //        }
        //        else if (choice == 2)
        //        {
        //            listOfOrders.Add("trampoline");
        //            countOfItems++;
        //        }
        //        else if (choice == 3)
        //        {
        //            listOfOrders.Add("bouquet");
        //            countOfItems++;
        //        }
        //        else if (choice == 4)
        //        {
        //            Console.WriteLine("What would u like to order? ");
        //            Console.WriteLine("(0) to return to menu.");
        //            var t = Convert.ToString(Console.ReadLine());
        //            if (t == "0")
        //            {
        //                continue;
        //            }
        //            else
        //                listOfOrders.Add(t);
        //        }
        //        else if (choice == 5)
        //        {
        //            Console.WriteLine($"Total amount of items: {countOfItems}.");
        //            listOfOrders.ForEach(i => Console.WriteLine(i));
        //            Console.WriteLine("Press any key to continue.");
        //            Console.ReadKey();
        //        }
        //        else if (choice == 6)
        //        {
        //            Console.WriteLine("Are you sure? ");
        //            var answer = Convert.ToString(Console.ReadLine());
        //            if (answer.ToLower() == "yes" || answer.ToLower() == "ye" || answer.ToLower() == "y")
        //            {
        //                return new Order(listOfOrders, name);
        //            }

        //        }
        //        else if (choice == 7)
        //        {
        //            Console.WriteLine("Are you sure? ");
        //            var answer = Convert.ToString(Console.ReadLine());
        //            if (answer.ToLower() == "yes" || answer.ToLower() == "ye" || answer.ToLower() == "y")
        //            {
        //                break;
        //            }
        //        }

        //    }

        //    return null;
        //}

    }

}

