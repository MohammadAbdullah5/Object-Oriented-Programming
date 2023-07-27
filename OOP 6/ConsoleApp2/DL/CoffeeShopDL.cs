using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using ConsoleApp2.BL;

namespace ConsoleApp2.DL
{
    class CoffeeShopDL
    {
        public static CoffeeShop tcs = new CoffeeShop("Tesha's Coffee Shop");

        public static List<MenuItem> menu = new List<MenuItem>();

        public static void loadMenuFromFile(string path)
        {
            StreamReader file = new StreamReader(path);
            string record = "";
            if (File.Exists(path))
            {
                while ((record = file.ReadLine()) != null)
                {
                    string[] splittedRecord = record.Split(',');
                    string name = splittedRecord[0];
                    bool type = false;
                    if (splittedRecord[1] == "drink")
                    {
                        type = false;
                    }

                    if (splittedRecord[1] == "food")
                    {
                        type = true;
                    }
                    int price = int.Parse(splittedRecord[2]);
                    MenuItem menuItem = new MenuItem(name, type, price);
                    menu.Add(menuItem);
                }
            }
        }

        public static void addMenuItem(MenuItem item)
        {
            menu.Add(item);
        }

        public static MenuItem doesItemExists(string name)
        {
            foreach (MenuItem item in menu)
            {
                if (item.name == name)
                {
                    return item;
                }
            }
            return null;
        }

        public static bool addOrder(string name)
        {
            MenuItem item = CoffeeShopDL.doesItemExists(name);
            if (item != null)
            {
                tcs.orders.Add(item.name);
                return true;
            }

            else
            {
                return false;
            }
        }

        public static int totalAmount()
        {
            int sum = 0;
            foreach (var order in tcs.orders)
            {
                foreach (var menuItem in menu)
                {
                    if (menuItem.name == order)
                    {
                        sum += menuItem.price;
                    }
                }
            }
            return sum;
        }

        public static string cheapestItem()
        {
            int smallest = 10000;
            string cheapest = "";
            foreach (var menuItem in menu)
            {
                if (menuItem.price < smallest)
                {
                    smallest = menuItem.price;
                    cheapest = menuItem.name;
                }

            }
                return cheapest;
        }

            public static List<string> drinksOnly()
            {
                List<string> drinks = new List<string>();
                foreach (var menuItems in menu)
                {
                    if (menuItems.type == false)
                    {
                        drinks.Add(menuItems.name);
                    }
                }
                return drinks;
            }

            public static List<string> foodOnly()
            {
                List<string> foods = new List<string>();
                foreach (var menuItems in menu)
                {
                    if (menuItems.type == true)
                    {
                        foods.Add(menuItems.name);
                    }
                }
                return foods;
            }
        }
    }
