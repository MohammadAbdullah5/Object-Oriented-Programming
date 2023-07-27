using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Customer> customers = new List<Customer>();
            string option = "";
            do
            {
                option = menu();
		Console.Clear();
                if (option == "1")
                {
                    Customer customer = TakeInputForAddingCustomer();
                    customers.Add(customer);
                }

                else if (option == "2")
                {
                    Console.Write("Enter the contact of customer: ");
                    string contact = Console.ReadLine();

                    foreach (Customer customer in customers)
                    {
                        if (contact == customer.customerContact)
                        {
                            Console.Write("Enter Name of Product: ");
                            string name = Console.ReadLine();
                            Console.Write("Enter Category of Product: ");
                            string category = Console.ReadLine();
                            Console.Write("Enter Price of Product: ");
                            int price = int.Parse(Console.ReadLine());

                            Product product = new Product(name, category, price);
                            customer.addProduct(product);
                            break;
                        }
                    }
                }

                else if (option == "3")
                {
                    Console.Write("Enter the contact of customer: ");
                    string contact = Console.ReadLine();
                    Console.WriteLine("Name         Category         Price");
                    foreach (Customer customer in customers)
                    {
                        if(contact == customer.customerContact)
                        {
                            List <Product> customerProducts = customer.getAllPurchasedProducts();
                            foreach(Product product in customerProducts)
                            {
                                Console.WriteLine(product.name + "         " + product.category + "         " + product.price);
                            }
                            break;
                        }
                    }
                }

                else if (option == "4")
                {
                    Console.Write("Enter the contact of customer: ");
                    string contact = Console.ReadLine();
                    Console.WriteLine("Name         Tax");
                    foreach (Customer customer in customers)
                    {
                        if (contact == customer.customerContact)
                        {
                            List<Product> customerProducts = customer.getAllPurchasedProducts();
                            foreach (Product product in customerProducts)
                            {
                                Console.WriteLine(product.name + "         " + product.calculateTax());
                            }
                            break;
                        }
                    }
                }
            }
            while (option != "5");
        }

        static string menu()
        {
            Console.WriteLine("1. Add a Customer");
            Console.WriteLine("2. Add a product to a customer");
            Console.WriteLine("3. View all purchased products of a customer");
            Console.WriteLine("4. Calculate Tax of all purchased products of a customer");
            Console.WriteLine("5. Exit");
            string option = Console.ReadLine();
            return option;
        }

        static Customer TakeInputForAddingCustomer()
        {
            Console.Write("Enter Name: ");
            string name = Console.ReadLine();
            Console.Write("Enter Contact: ");
            string contact = Console.ReadLine();
            Console.Write("Enter Address: ");
            string address = Console.ReadLine();
            Customer customer = new Customer(name, address, contact);
            return customer;
        }
    }
}
