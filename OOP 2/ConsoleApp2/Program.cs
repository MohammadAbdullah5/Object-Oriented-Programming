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
            Task1();
            Console.ReadKey();
            Task2();
            Console.ReadKey();
            Task3();
            Console.ReadKey();
            Task4();
            Console.ReadKey();
        }

        static void Task1()
        {
            Student s1 = new Student();
            s1.name = "JACK";
            s1.rollNo = 155;
            s1.cgpa = 3.3F;

            Console.WriteLine("Name: {0}, Roll-Number: {1}, CGPA: {2} ", s1.name, s1.rollNo, s1.cgpa);
        }

        static void Task2()
        {
            Student s1 = new Student();
            Student s2 = new Student();

            s1.name = "JACK";
            s1.rollNo = 155;
            s1.cgpa = 3.3F;

            s2.name = "JILL";
            s2.rollNo = 120;
            s2.cgpa = 3.5F;

            Console.WriteLine("Name: {0}, Roll-Number: {1}, CGPA: {2} ", s1.name, s1.rollNo, s1.cgpa);
            Console.WriteLine("Name: {0}, Roll-Number: {1}, CGPA: {2} ", s2.name, s2.rollNo, s2.cgpa);
        }

        static void Task3()
        {
            Student s1 = new Student();

            Console.Write("Enter Name: ");
            s1.name = Console.ReadLine();

            Console.Write("Enter Roll Number: ");
            s1.rollNo = int.Parse(Console.ReadLine());

            Console.Write("Enter CGPA: ");
            s1.cgpa = float.Parse(Console.ReadLine());

            Console.WriteLine("Name: {0}, Roll-Number: {1}, CGPA: {2} ", s1.name, s1.rollNo, s1.cgpa);
        }

        static void Task4()
        {
            students[] s = new students[10];
            char option;
            int count = 0;
            do
            {
                option = menu();
                if(option == 1)
                {
                    s[count] = addStudent();
                    count++;
                }

                else if(option == 2)
                {
                    viewStudents(s, count);
                }

                else if(option == 3)
                {
                    topStudent(s, count);
                }

                else if(option == 4)
                {
                    break;
                }

                else
                {
                    Console.Write("Invalid Option.Try Again....");
                    Console.ReadKey();
                }
            }
            while (option != 4);
        }

        static char menu()
        {
            Console.Clear();
            Console.WriteLine("Press 1 for adding a student.");
            Console.WriteLine("Press 2 for to view students.");
            Console.WriteLine("Press 3 for Top 3 students.");
            Console.WriteLine("Press 4 to exit.");
            char choice;
            choice = char.Parse(Console.ReadLine());
            return choice;
        }

        static students addStudent()
        {
            students s1 = new students();

            Console.Write("Enter Name:");
            s1.name = Console.ReadLine(); 
            Console.Write("Enter Roll Number:");
            s1.rollNo = int.Parse(Console.ReadLine());
            Console.Write("Enter CGPA:");
            s1.cgpa = float.Parse(Console.ReadLine());
            Console.Write("Enter Marks:");
            s1.marks = int.Parse(Console.ReadLine());
            Console.Write("Is Hostelite:");
            s1.isHostelide = Console.ReadLine();

            return s1;
        }

        static void viewStudents(students[] x, int count)
        {
            Console.Clear();

            for(int i = 0; i < count; i++)
            {
                Console.WriteLine("Name: {0}, Roll Number: {1}, CGPA: {2}, Marks: {3}, Is Hostellite: {4}", x[i].name, x[i].rollNo, x[i].cgpa, x[i].marks, x[i].isHostelide);
            }
            Console.WriteLine("Press any key to continue...");
        }

        static void topStudent(students[] s, int count)
        {
            Console.Clear();

            if(count == 0)
            {
                Console.WriteLine("No Record Present");
            }

            else if(count == 1)
            {
                viewStudents(s, 1);
            }

            else if (count == 2)
            {
                for(int x = 0; x < count; x++)
                {
                    int index = largest(s, x, count);
                    students temp = s[index];
                    s[index] = s[x];
                    s[x] = temp;
                }
            }

            else
            {
                for (int x = 0; x < 3; x++)
                {
                    int index = largest(s, x, count);
                    students temp = s[index];
                    s[index] = s[x];
                    s[x] = temp;
                }
            }
        }

        static int largest(students[] s, int start, int end)
        {
            int index = start;
            float large = s[start].cgpa;
            for(int x = 0; x < end; x++)
            {
                if(large < s[x].cgpa)
                {
                    large = s[x].cgpa;
                    index = x;
                }
            }
            return index;
        }
    }
}
