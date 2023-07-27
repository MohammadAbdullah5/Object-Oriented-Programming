using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            string option = "";

            do
            {
                option = Menu();

                if (option == "1")
                {
                    Credentials user = CredentialsUI.TakeInputWithoutRole();
                    user = CredentialsCRUD.login(user);
                    if (user != null)
                    {

                        if (user.role == "Admin")
                        {
                            Console.Clear();
                            adminInterface();
                        }

                        else
                        {
                            Console.Clear();
                            coachInterface();
                        }
                    }

                    if (user == null)
                    {
                        Console.Write("Wrong Credentials.Try Again!!!");
                        Console.ReadKey();
                    }
                }

                if (option == "2")
                {
                    Credentials user = CredentialsUI.TakeInputWithRole();
                    CredentialsCRUD.storeDataInList(user);
                }
            }
            while (option != "3");
            Console.WriteLine("Press Enter to Exit.");
            Console.ReadKey();
        }

        static void adminInterface()
        {
            string option = "";
            do
            {
                option = adminMenu();

                if (option == "1")
                {
                    ProductCRUD.addProduct();
                }

                else if (option == "2")
                {
                    ProductUI.showProducts();
                }

                else if (option == "3")
                {
                    ProductUI.showHighestPriceProduct();
                }

                else if (option == "4")
                {
                    ProductUI.showProductsToOrder();
                }

                else if (option == "5")
                {
                    ProductUI.showTaxOfAllProducts();
                }

                else if (option == "6")
                {
                    ProductUI.showTotalStoreWorth();
                }

                else
                {
                    Console.WriteLine("Invalid Input...Try Again!");
                    Console.ReadKey();
                }
                Console.ReadKey();
            }
            while (option != "7");
        }

        static void coachInterface()
        {
            string option = "";
            Console.WriteLine("Enter the name of customer: ");
            Customer customer = new Customer();
            customer.name = Console.ReadLine();
            do
            {
                option = CustomerUI.customerMenu();

                if (option == "1")
                {
                    ProductUI.showProducts();
                }

                else if (option == "2")
                {
                    //Buy Product
                    CustomerUI.buyProduct(customer);
                }

                else if (option == "3")
                {
                    // Generate Invoice
                    CustomerUI.generateInvoice(customer);
                }

                else
                {
                    Console.WriteLine("Invalid Input...Try Again!");
                    Console.ReadKey();
                }
                Console.ReadKey();
            }
            while (option != "4");
        }

        static string adminMenu()
        {
            Console.Clear();
            Console.WriteLine("1.Add Product.");
            Console.WriteLine("2.Show Products.");
            Console.WriteLine("3.Highest Price Product.");
            Console.WriteLine("4.Total Store Worth.");
            Console.WriteLine("5.Sales Tax of All Products.");
            Console.WriteLine("6.Exit.");
            string option;
            Console.WriteLine("Enter your option...");
            option = Console.ReadLine();
            return option;
        }


        static string Menu()
        {
            Console.Clear();
            Console.WriteLine("1.Sign In.");
            Console.WriteLine("2.Sign Up.");
            Console.WriteLine("3.Exit.");
            string option;
            Console.WriteLine("Enter your option...");
            option = Console.ReadLine();
            return option;
        }
    }

}
