using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class CustomerUI
    {
        public static string customerMenu()
        {
            Console.WriteLine("1.View all Products.");
            Console.WriteLine("2.Buy Product");
            Console.WriteLine("3.Generate Invoice.");
            Console.WriteLine("4.Exit.");
            string option;
            Console.WriteLine("Enter your option...");
            option = Console.ReadLine();
            return option;
        }

        public static void buyProduct(Customer c)
        {
            Console.WriteLine("Enter the name of Product: ");
            string name = Console.ReadLine();
            Product p = ProductCRUD.isProduct(name);
            if (p != null)
            {
                c.addProduct(p);
                ProductCRUD.buyProduct(name);
            }

        }

        public static void generateInvoice(Customer c)
        {
            Console.WriteLine("Enter the name of Customer: ");
            c.name = Console.ReadLine();

            Console.Clear();
            Console.WriteLine("Invoice...");
            Console.WriteLine("Name: " + c.name);
            Console.WriteLine("Products.... ");
            Console.WriteLine("Name         Price after Tax");

            List<Product> products1 = c.GetProducts();
            foreach (Product p in products1)
            {
                p.getTax();
                Console.WriteLine(p.name + "   " + p.tax);
            }
        }
    }
}
