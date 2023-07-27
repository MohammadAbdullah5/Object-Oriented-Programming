using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Challenge2
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "C:\\Users\\92309\\OneDrive\\Desktop\\University\\Object Oriented Programming\\OOP 2\\Challenge2\\a.txt";
            User[] usersArray = new User[10];
            int option;
            int count = 0;

            readData(path, usersArray, ref count);
            do
            {
                Console.Clear();
                option = menu();
                if (option == '1')
                {
                    Console.WriteLine("Enter Name: ");
                    string n = Console.ReadLine();
                    Console.WriteLine("Enter Password: ");
                    string p = Console.ReadLine();
                    signIn(n, p, usersArray, count);
                }

                else if (option == '2')
                {
                    usersArray[count] = addUser();
                    count++;
                }

                else if (option == '3')
                {
                    break;
                }

                else
                {
                    Console.WriteLine("Invalid Input...Try Again!");
                }
            }
            while (option != '3');
            storeData(usersArray, count, path);
            Console.Read();
        }

        static char menu()
        {
            Console.Clear();
            Console.WriteLine("1.Sign in");
            Console.WriteLine("2.Sign Up");
            Console.WriteLine("3.Exit");
            char option;
            option = char.Parse(Console.ReadLine());
            return option;
        }

        static string ParseData(string record, int field)
        {
            int comma = 1;
            string item = "";
            for (int x = 0; x < record.Length; x++)
            {
                if (record[x] == ',')
                {
                    comma++;
                }

                else if (comma == field)
                {
                    item = item + record[x];
                }
            }
            return item;
        }

        static void readData(string path, User[] user, ref int count)
        {
            if (File.Exists(path))
            {
                StreamReader fileVariable = new StreamReader(path);
                string record;
                while ((record = fileVariable.ReadLine()) != null)
                {
                    user[count] = readUser(record);
                    Console.WriteLine(user[count].username);
                    Console.WriteLine(user[count].password);
                    if (count >= 10)
                    {
                        break;
                    }
                    count++;
                }
                fileVariable.Close();
                Console.ReadKey();
            }

            else
            {
                Console.WriteLine("File does not exists");
            }
        }

        static void signIn(string n, string p, User[] user, int count)
        {
            bool flag = false;
            for (int x = 0; x < count; x++)
            {
                if ((n == user[x].username) && (p == user[x].password))
                {
                    Console.WriteLine("Valid User");
                    flag = true;
                }
            }

            if (flag == false)
            {
                Console.WriteLine("Invalid User");
            }
            Console.ReadKey();
        }

        static void storeData(User[] user, int count, string path)
        {
            StreamWriter file = new StreamWriter(path, false);
            for (int i = 0; i < count; i++)
            {
                file.WriteLine("{0},{1}", user[i].username, user[i].password);
            }

            file.Flush();
            file.Close();
        }

        static User addUser()
        {
            User addingUser = new User();
            Console.Write("Enter Username: ");
            addingUser.username = Console.ReadLine();
            Console.Write("Enter Password: ");
            addingUser.password = Console.ReadLine();
            return addingUser;
        }

        static User readUser(string record)
        {
            User a = new User();
            a.username = ParseData(record,1);
            a.password = ParseData(record,2);
            return a;
        }
    }
}
