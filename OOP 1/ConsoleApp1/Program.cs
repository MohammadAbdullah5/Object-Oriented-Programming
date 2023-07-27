using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp1
{
    class Program
    {
        static void Task1()
        {
            Console.Write("Hello World!");
            Console.Write("Hello World!");
        }



        static void Task2()
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Hello World!");
        }

        static void Task3()
        {
            float length;
            float area;
            String str;
            Console.Write("Enter length of one side: ");
            Console.WriteLine("");
            str = Console.ReadLine();
            length = float.Parse(str);
            area = length * length;
            Console.WriteLine(area);
        }

        static void Task4()
        {
            int number;
            String str;

            Console.Write("Enter your marks: ");
            str = Console.ReadLine();
            Console.WriteLine("");
            number = int.Parse(str);

            if (number > 50)
            {
                Console.WriteLine("You are Passed");
            }

            else
            {
                Console.WriteLine("You are failed");
            }
        }

        static void Task5()
        {
            for (int idx = 0; idx < 5; idx++)
            {
                Console.WriteLine("Welcome Jack");
            }
        }

        static void Task6()
        {
            int number;
            string str;
            int sum = 0;

            Console.Write("Enter a number: ");
            Console.WriteLine("");
            str = Console.ReadLine();
            number = int.Parse(str);

            while (number != -1)
            {
                sum = sum + number;
                Console.Write("Enter a number: ");
                Console.WriteLine("");
                str = Console.ReadLine();
                number = int.Parse(str);
            }
            Console.Write("Sum is {0}", sum);
        }

        static void Task7()
        {
            int number;
            int sum = 0;

            do
            {
                Console.Write("Enter a number: ");
                Console.WriteLine("");
                number = int.Parse(Console.ReadLine());
                sum = sum + number;
            }
            while (number != -1);
            sum = sum + 1;
            Console.WriteLine("The total sum is {0}", sum);

        }

        static void Task8()
        {
            int[] numbers = new int[3];
            for (int idx = 0; idx < 3; idx++)
            {
                Console.Write("Enter the Number {0}: ", idx + 1);
                numbers[idx] = int.Parse(Console.ReadLine());
            }

            int largest = -100;

            for (int idx = 0; idx < 3; idx++)
            {
                if (numbers[idx] > largest)
                {
                    largest = numbers[idx];
                }
            }

            Console.WriteLine("The largest number is {0}", largest);
        }

        static void Task9()
        {
            int age, priceOfGift;
            float money, priceOfMachine;

            age = int.Parse(Console.ReadLine());
            priceOfGift = int.Parse(Console.ReadLine());
            priceOfMachine = float.Parse(Console.ReadLine());

            int moneyTotal;
            int digits = 0;
            int toyMoney = 0;
            int gift = 10;
            int number = 1;
            int giftMoney = 0;


            for (int idx = 1; idx <= age; idx = idx + 2)
            {
                digits = digits + 1;
                toyMoney = priceOfGift * digits;
                Console.WriteLine("a{0} + b{1}", toyMoney, digits);
            }

            for (int x = 2; x <= age; x = x + 2)
            {
                moneyTotal = gift * number;
                moneyTotal = moneyTotal - 1;
                giftMoney = giftMoney + moneyTotal;
                number = number + 1;
            }
            money = toyMoney + giftMoney;

            if (money > priceOfMachine)
            {
                money = money - priceOfMachine;
                Console.WriteLine("Yes!!! Remaining: {0}", money);
            }

            else
            {
                money = priceOfMachine - money;
                Console.WriteLine("No!!! Needed: {0}", money);
            }

            Console.ReadKey();
        }

        static void Task10()
        {
            int num1, num2, sum;
            Console.Write("Enter 1st number: ");
            num1 = int.Parse(Console.ReadLine());
            Console.Write("Enter 2nd number: ");
            num2 = int.Parse(Console.ReadLine());
            sum = Add(num1, num2);
            Console.WriteLine("Sum is {0}", sum);
        }

        static int Add(int n1, int n2)
        {
            return n1 + n2;
        }

        static void Task11()
        {
            string path = "C:\\Users\\92309\\OneDrive\\Desktop\\University\\Object Oriented Programming\\OOP 1\\ConsoleApp1\\file.txt";
            if (File.Exists(path))
            {
                StreamReader fileVariable = new StreamReader(path);
                String record;
                while ((record = fileVariable.ReadLine()) != null)
                {
                    Console.WriteLine(record);
                }
                fileVariable.Close();
            }

            else
            {
                Console.Write("File does not exists!");
            }
        }

        static void Task12()
        {
            string path = "C:\\Users\\92309\\OneDrive\\Desktop\\University\\Object Oriented Programming\\OOP 1\\ConsoleApp1\\file.txt";
            StreamWriter filevariable = new StreamWriter(path, true);
            filevariable.WriteLine("Hello");
            filevariable.Flush();
            filevariable.Close();

        }

        static int menu()
        {
            int option;
            Console.WriteLine("1. Sign In");
            Console.WriteLine("2. Sign Up");
            Console.WriteLine("Enter option...");
            option = int.Parse(Console.ReadLine());
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

        static void readData(string path, string[] names, string[] passwords)
        {
            int x = 0;
            if (File.Exists(path))
            {
                StreamReader fileVariable = new StreamReader(path);
                string record;
                while ((record = fileVariable.ReadLine()) != null)
                {
                    names[x] = ParseData(record, 1);
                    passwords[x] = ParseData(record, 2);
                    x++;
                    if (x >= 5)
                    {
                        break;
                    }
                }
                fileVariable.Close();

            }

            else
            {
                Console.WriteLine("File does not exists");
            }
        }

        static void signIn(string n, string p, string[] names, string[] passwords)
        {
            bool flag = false;
            for (int x = 0; x < 5; x++)
            {
                if ((n == names[x]) && (p == passwords[x]))
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

        static void signUp(string path, string n, string p)
        {
            StreamWriter file = new StreamWriter(path, true);
            file.WriteLine(n + "," + p);
            file.Flush();
            file.Close();
        }

        static void signInSignUp()
        {
            string path = "C:\\Users\\92309\\OneDrive\\Desktop\\University\\Object Oriented Programming\\OOP 1\\ConsoleApp1\\b.txt";
            string[] names = new string[5];
            string[] passwords = new string[5];
            int option;
            do
            {
                readData(path, names, passwords);
                Console.Clear();
                option = menu();
                Console.Clear();
                if (option == 1)
                {
                    Console.WriteLine("Enter Name: ");
                    string n = Console.ReadLine();
                    Console.WriteLine("Enter Password: ");
                    string p = Console.ReadLine();
                    signIn(n, p, names, passwords);
                }
                else if (option == 2)
                {
                    Console.WriteLine("Enter Name: ");
                    string n = Console.ReadLine();
                    Console.WriteLine("Enter Password: ");
                    string p = Console.ReadLine();
                    signUp(path, n, p);
                }
            }
            while (option < 3);
            Console.Read();
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Task 1");
            Task1();
            Console.ReadKey();
            Console.WriteLine("Task 2");
            Task2();
            Console.ReadKey();
            Console.WriteLine("Task 3");
            Task3();
            Console.ReadKey();
            Console.WriteLine("Task 4");
            Task4();
            Console.ReadKey();
            Console.WriteLine("Task 5");
            Task5();
            Console.ReadKey();
            Console.WriteLine("Task 6");
            Task6();
            Console.ReadKey();
            Console.WriteLine("Task 7");
            Task7();
            Console.ReadKey();
            Console.WriteLine("Task 8");
            Task8();
            Console.ReadKey();
            Console.WriteLine("Task 9");
            Task9();
            Console.ReadKey();
            Console.WriteLine("Task 10");
            Task10();
            Console.ReadKey();
            Console.WriteLine("Task 11");
            Task11();
            Console.ReadKey();
            Console.WriteLine("Task 12");
            Task12();
            Console.ReadKey();
            Console.WriteLine("Sign In Sign Up Application");
            signInSignUp();
            Console.ReadKey();
        }
    }
}
