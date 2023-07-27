using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_2
{
    class Program
    {
        class Product
        {
            public Product()
            {
                name = "Product A";
                category = "Category B";
                price = 0;
                quantity = 0;
                minQuantity = 5;
            }

            public float tax()
            {
                float salesTax;

                if (category == "Grocery")
                {
                    salesTax = 0.1F * price;
                }

                else if (category == "Fruit")
                {
                    salesTax = 0.05F * price;
                }

                else
                {
                    salesTax = 0.15F * price;
                }

                return salesTax;
            }

            public string name;
            public string category;
            public int price;
            public int quantity;
            public int minQuantity;
        }

            static void Main()
        {
            string option;
            List <Product> products = new List<Product>();
            do
            {
                Console.Clear();
                option = Menu();

                if(option == "1")
                {
                    products.Add(AddProduct());
                    Console.ReadKey();
                }

                else if (option == "2")
                {
                    Console.WriteLine("Name       Category       Price       Quantity       Minimum Quantity");
                    foreach (var p in products)
                    {
                        Console.WriteLine(p.name + "   " + p.category + "   " + p.price + "       " + p.quantity + "       " + p.minQuantity);
                    }
                    Console.ReadKey();
                }

                else if (option == "3")
                {
                    int largestPrice = -1000;
                    int idx = 0;
                    for (int i = 0; i < products.Count; i++)
                    {
                        if(products[i].price > largestPrice)
                        {
                            largestPrice = products[i].price;
                            idx = i;
                        }
                    }

                    Console.WriteLine("Name: " + products[idx].name);
                    Console.WriteLine("Category: " + products[idx].category);
                    Console.WriteLine("Price: " + products[idx].price);
                    Console.WriteLine("Quantity: " + products[idx].quantity);
                    Console.WriteLine("Minimum Quantity: " + products[idx].minQuantity);
                    Console.ReadKey();
                }

                else if (option == "4")
                {
                    foreach(Product p in products)
                    {
                        Console.WriteLine("Name: " + p.name + "      " + "Sales Tax: " + p.tax());
                    }
                    Console.ReadKey();
                }

                else if (option == "5")
                {
                    Console.WriteLine("Products to be Ordered");
                    int idx = 1;
                    foreach(Product p in products)
                    {
                        if(p.quantity < p.minQuantity)
                        {
                            Console.WriteLine(idx + ". " + p.name);
                            idx++;
                        }
                    }
                    Console.ReadKey();
                }
            }
            while (option != "6");
        } 

        static string Menu()
        {
            Console.WriteLine("          1. Add a product.");
            Console.WriteLine("          2. View all products.");
            Console.WriteLine("          3. Find Product with highest unit price.");
            Console.WriteLine("          4. View Sales Tax of All products.");
            Console.WriteLine("          5. Products to be ordered.");
            Console.WriteLine("          6. Exit.");
            Console.Write("          Enter your option...");

            string option;
            option = Console.ReadLine();
            return option;
        }
        
        static Product AddProduct()
        {
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Category: ");
            string category = Console.ReadLine();
            Console.Write("Price: ");
            int price = int.Parse(Console.ReadLine());
            Console.Write("Quantity: ");
            int quantity = int.Parse(Console.ReadLine());
            Console.Write("Minimum Quantity: ");
            int minQuantity = int.Parse(Console.ReadLine());
            Product product = new Product(name, category, price, quantity, minQuantity);
            return product;
        }
    }
}