using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp2.BL;
using ConsoleApp2.UI;
using ConsoleApp2.DL;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "C:\\Users\\92309\\OneDrive\\Desktop\\University\\Object Oriented Programming\\OOP 6\\ConsoleApp2\\MenuForTCS.txt";
            string option = "";
            CoffeeShopDL.loadMenuFromFile(path);
            do
            {
                option = menu();

                if(option == "1")
                {
                    MenuItem item = CoffeeShopUI.TakeInputForItem();
                    CoffeeShopDL.addMenuItem(item);
                }

                else if (option == "2")
                {
                    string item = CoffeeShopDL.cheapestItem();
                    CoffeeShopUI.printItem(item);
                }

                else if (option == "3")
                {
                    List<string> drinks = CoffeeShopDL.drinksOnly();
                    CoffeeShopUI.viewDrinksMenu(drinks);
                }

                else if (option == "4")
                {
                    List<string> foods = CoffeeShopDL.foodOnly();
                    CoffeeShopUI.viewFoodMenu(foods);
                }

                else if (option == "5")
                {
                    string order = CoffeeShopUI.TakeInputForOrder();
                    bool flag = CoffeeShopDL.addOrder(order);
                    CoffeeShopUI.printAvailibility(flag);
                }

                else if (option == "6")
                {
                    string fulfill = CoffeeShopDL.tcs.fulfillOrder();
                    CoffeeShopUI.printFullfillOrder(fulfill);
                }

                else if (option == "7")
                {
                    CoffeeShopUI.printOrdersList(CoffeeShopDL.tcs.orders);
                }

                else if (option == "8")
                {
                    int sum = CoffeeShopDL.totalAmount();
                    CoffeeShopUI.viewTotalAmount(sum);
                }
            }
            while (option != "9");
        }

        static string menu()
        {
            Console.WriteLine("Welcome to our Coffee Shop!!!!");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("1. Add a Menu Item");
            Console.WriteLine("2. View the cheapest Item in the Menu");
            Console.WriteLine("3. View the Drinks Menu");
            Console.WriteLine("4. View the Foods Menu");
            Console.WriteLine("5. Add Order");
            Console.WriteLine("6. Fulfill Order");
            Console.WriteLine("7. View the Order's List");
            Console.WriteLine("8. Total Payable Amount");
            Console.WriteLine("9. Exit");

            string option = Console.ReadLine();
            return option;
        }
    }
}
