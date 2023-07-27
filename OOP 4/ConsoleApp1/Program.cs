using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = null;
            string option = "";
            do
            {
                Console.Clear();
                option = menu();

                if(option == "1")
                {
                    Console.Clear();
                    s1 = TakeInputOfStudent();
                }

                else if (option == "2")
                {
                    Console.Clear();
                    float merit = s1.calculateMerit();
                    Console.Write("Merit: " + merit);
                    Console.ReadKey();
                }

                else if (option == "3")
                {
                    bool isEligible = s1.isEligibleForScholarship();

                    if(isEligible == true)
                    {
                        Console.WriteLine("Eligible !!!");
                    }

                    else if (isEligible == false)
                    {
                        Console.WriteLine("Not Eligible !!!");
                    }
                    Console.ReadKey();
                }
            }
            while (option != "4");
        }

        static Student TakeInputOfStudent()
        {
            Console.Write("Enter Name: ");
            string name = Console.ReadLine();
            Console.Write("Enter Roll No: ");
            int rollNo = int.Parse(Console.ReadLine());
            Console.Write("Enter CGPA: ");
            float cgpa = float.Parse(Console.ReadLine());
            Console.Write("Enter Matric Marks: ");
            int matricMarks = int.Parse(Console.ReadLine());
            Console.Write("Enter Intermediate Marks: ");
            int interMarks = int.Parse(Console.ReadLine());
            Console.Write("Enter ECAT Marks: ");
            int ecatMarks = int.Parse(Console.ReadLine());
            Console.Write("Enter City: ");
            string hometown = Console.ReadLine();
            Console.Write("Is Hostellite: ");
            bool isHostellite = false;

            if(Console.ReadLine() == "Yes")
            {
                isHostellite = true;
            }

            else if (Console.ReadLine() == "No")
            {
                isHostellite = false;
            }

            Console.Write("Is Taking Scholarship: ");
            bool isTakingScholarship = false;

            if (Console.ReadLine() == "Yes")
            {
                isTakingScholarship = true;
            }

            else if (Console.ReadLine() == "No")
            {
                isTakingScholarship = false;
            }

            Student student = new Student(name, rollNo, cgpa, matricMarks, interMarks, ecatMarks, hometown, isHostellite, isTakingScholarship);
            return student;
        }


        static string menu()
        {
            Console.WriteLine("1. Add a Student");
            Console.WriteLine("2. Calculate Merit");
            Console.WriteLine("3. Check Eligibility For Scholarship");
            Console.WriteLine("4. Exit");
            string option = Console.ReadLine();
            return option;
        }


    }
}
