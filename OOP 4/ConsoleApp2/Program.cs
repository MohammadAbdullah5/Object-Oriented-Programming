using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Book s1 = null;
            string option = "";
            do
            {
                Console.Clear();
                option = menu();

                if (option == "1")
                {
                    Console.Clear();
                    s1 = TakeInputOfBook();
                }

                else if (option == "2")
                {
                    Console.Clear();
                    Console.Write("Enter bookmark page: ");
                    int num = int.Parse(Console.ReadLine());
                    s1.setBookMark(num);
                }

                else if (option == "3")
                {
                    Console.Clear();
                    Console.Write("Enter book price: ");
                    int num = int.Parse(Console.ReadLine());
                    s1.setBookPrice(num);
                }

                else if (option == "4")
                {
                    Console.Clear();
                    int num = s1.getBookPrice();
                    Console.Write("Book price: " + num);
                }

                else if (option == "5")
                {
                    Console.Clear();
                    int num = s1.getBookMark();
                    Console.Write("Book price: " + num);
                }

                else if (option == "6")
                {
                    Console.Clear();
                    bool flag = s1.isBorrowedOrNot();
                    if(flag == false)
                    {
                        Console.WriteLine("Available!!!");
                    }

                    if (flag == true)
                    {
                        Console.WriteLine("Borrowed!!!");
                    }
                }
            }
            while (option != "7");
        }

        static Book TakeInputOfBook()
        {
            Console.Write("Enter Title: ");
            string title = Console.ReadLine();
            Console.Write("Enter Author: ");
            string author = Console.ReadLine();
            Console.Write("Enter Pages: ");
            int pages = int.Parse(Console.ReadLine());
            Console.Write("Enter Price: ");
            int price = int.Parse(Console.ReadLine());

            Book student = new Book(title, author,  pages, price);
            return student;
        }


        static string menu()
        {
            Console.WriteLine("1. Add a Book");
            Console.WriteLine("2. Set BookMark");
            Console.WriteLine("3. Set Book Price");
            Console.WriteLine("4. Get Book Price");
            Console.WriteLine("5. Check BookMark");
            Console.WriteLine("6. Check Borrowed or Not");
            Console.WriteLine("7. Exit");
            string option = Console.ReadLine();
            return option;
        }
    }
}
