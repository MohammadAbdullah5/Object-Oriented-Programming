using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product[] product = new Product[10];
            int count = 0;
            char option;

            do
            {
                option = Menu();

                if(option == '1')
                {
                    product[count] = addProduct();
                    count++;
                }

                else if (option == '2')
                {
                    showProducts(product, count);
                }

                else if (option == '3')
                {
                    totalStoreWorth(product, count);
                }

                else if (option == '4')
                {
                    break;
                }

                else
                {
                    Console.WriteLine("Invalid Input...Try Again!");
                    Console.ReadKey();
                }
            }
            while (option != 4);
            Console.WriteLine("Press Enter to Exit.");
            Console.Read();
        }

        static Product addProduct()
        {
            Console.Clear();
            Product product = new Product();

            Console.WriteLine("Enter Id: ");
            product.id = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Name: ");
            product.name = Console.ReadLine();
            Console.WriteLine("Enter Price: ");
            product.price = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Category: ");
            product.category = Console.ReadLine();
            Console.WriteLine("Enter Brand: ");
            product.Brand = Console.ReadLine();
            Console.WriteLine("Enter Country: ");
            product.Country = Console.ReadLine();

            return product;
        }

        static void showProducts(Product[] p, int count)
        {
            Console.Clear();
            for(int i = 0; i < count; i++)
            {
                Console.WriteLine("Name: {0} ID: {1} Price: {2} Category: {3} Brand: {4} Country: {5} ", p[i].name, p[i].id, p[i].price, p[i].category, p[i].Brand, p[i].Country);
            }
            Console.ReadKey();
        }

        static void totalStoreWorth(Product[] p, int count)
        {
            Console.Clear();
            int sum = 0;
            for(int i = 0; i < count; i++)
            {
                sum += p[i].price;
            }

            Console.WriteLine("Total Store Worth: {0}", sum);
            Console.ReadKey();
        }

        static char Menu()
        {
            Console.Clear();
            Console.WriteLine("1.Add Product.");
            Console.WriteLine("2.Show Products.");
            Console.WriteLine("3.Total Store Worth.");
            Console.WriteLine("4.Exit.");
            char option;
            Console.WriteLine("Enter your option...");
            option = char.Parse(Console.ReadLine());
            return option;
        }
    }
}
