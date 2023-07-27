using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.UI
{
    class CoffeeShopUI
    {
        public static MenuItem TakeInputForItem()
        {
            Console.WriteLine("Enter the name of item: ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter the type of item(Food/Drink): ");
            string typeFood = Console.ReadLine();
            bool type = false;

            if(typeFood == "Food")
            {
                type = true;
            }

            if (typeFood == "Drink")
            {
                type = false;
            }
            Console.WriteLine("Enter the price of item: ");
            int price = int.Parse(Console.ReadLine());
            MenuItem item = new MenuItem(name, type, price);
            return item;
        }

        public static void printItem(string item)
        {
            Console.WriteLine("Cheapest Item: " + item);
        }

        public static string TakeInputForOrder()
        {
            Console.WriteLine("Enter the name of item: ");
            string name = Console.ReadLine();
            return name;
        }

        public static void printOrdersList(List<string> orders)
        {
            int idx = 1;
            foreach (string order in orders)
            {
                Console.WriteLine(idx + ". " + order);
                idx++;
            }
        }

        public static void printFullfillOrder(string orders)
        {
            if(orders == null)
            {
                Console.WriteLine("All orders have been fulfilled");
            }

            else
            {
                Console.WriteLine("The {0} is ready!", orders);
            }
        }

        public static void printAvailibility(bool flag)
        {
            if (flag == false)
            {
                Console.WriteLine("This item is currently unavailable");
            }

            else
            {
                Console.WriteLine("Order added");
            }
        }

        public static void viewDrinksMenu(List<string> drinks)
        {
            int idx = 1;
            foreach (var drink in drinks)
            {
                Console.WriteLine(idx + ". " + drink);
                idx++;
            }
        }

        public static void viewFoodMenu(List<string> foods)
        {
            int idx = 1;
            foreach (var food in foods)
            {
                Console.WriteLine(idx + ". " + food);
                idx++;
            }
        }

        public static void viewTotalAmount(int amount)
        {
            Console.WriteLine("Total Order Amount: " + amount);
        }
    }
}
