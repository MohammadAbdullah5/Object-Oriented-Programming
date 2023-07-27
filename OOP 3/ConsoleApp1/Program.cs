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
            Console.WriteLine("Task 1");
            Task1();
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Task 2");
            Task2();
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Task 3");
            Task3();
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Task 4");
            Task4();
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Task 5");
            Task5();
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Task 6");
            Task6();
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Task 7");
            Task7();
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Task 8");
            Task8();
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Task 9");
            Task9();
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Task 10");
            Task10();
            Console.ReadKey();
            Console.Clear();
        }

        static void Task1()
        {
            Student s1 = new Student();
            Console.WriteLine(s1.stuName);
            Console.WriteLine(s1.matricMarks);
            Console.WriteLine(s1.fscMarks);
            Console.WriteLine(s1.ecatMarks);
            Console.WriteLine(s1.aggregate);
        }

        static void Task2()
        {
            Students s1 = new Students();
        }

        static void Task3()
        {
            Students1 s1 = new Students1();
            Console.WriteLine(s1.stuName);
        }

        static void Task4()
        {
            Students2 s1 = new Students2();
            Console.WriteLine(s1.stuName);
            Console.WriteLine(s1.matricMarks);
            Console.WriteLine(s1.fscMarks);
            Console.WriteLine(s1.ecatMarks);
            Console.WriteLine(s1.aggregate);
        }

        static void Task5()
        {
            Console.WriteLine("Student 1:- ");
            Students2 s1 = new Students2();
            Console.WriteLine(s1.stuName);
            Console.WriteLine(s1.matricMarks);
            Console.WriteLine(s1.fscMarks);
            Console.WriteLine(s1.ecatMarks);
            Console.WriteLine(s1.aggregate);

            Console.WriteLine("Student 2:- ");
            Students2 s2 = new Students2();
            Console.WriteLine(s2.stuName);
            Console.WriteLine(s2.matricMarks);
            Console.WriteLine(s2.fscMarks);
            Console.WriteLine(s2.ecatMarks);
            Console.WriteLine(s2.aggregate);
        }

        static void Task6()
        {            
            Students2 s1 = new Students2("John");
            Console.WriteLine(s1.stuName);
            Students2 s2 = new Students2("Jack");
            Console.WriteLine(s2.stuName);
        }

        static void Task7()
        {
            Students2 s1 = new Students2("John", 967, 990, 204, 79.867F);
            Console.WriteLine(s1.stuName);
            Console.WriteLine(s1.matricMarks);
            Console.WriteLine(s1.fscMarks);
            Console.WriteLine(s1.ecatMarks);
            Console.WriteLine(s1.aggregate);
        }

        static void Task8()
        {
            Students2 s1 = new Students2("John", 967, 990, 204, 79.867F);
            Console.WriteLine(s1.stuName);
            Console.WriteLine(s1.matricMarks);
            Console.WriteLine(s1.fscMarks);
            Console.WriteLine(s1.ecatMarks);
            Console.WriteLine(s1.aggregate);

            Students2 s2 = new Students2("Jack", 750, 880, 150, 73.7F);
            Console.WriteLine(s2.stuName);
            Console.WriteLine(s2.matricMarks);
            Console.WriteLine(s2.fscMarks);
            Console.WriteLine(s2.ecatMarks);
            Console.WriteLine(s2.aggregate);
        }

        static void Task9()
        {
            Students s1 = new Students();
            s1.stuName = "John";
            Students s2 = new Students(s1);
            Console.WriteLine(s1.stuName);
            Console.WriteLine(s2.stuName);
        }

        static void Task10()
        {
            List<int> numbers = new List<int>() {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};

            foreach(var i in numbers)
            {
                Console.WriteLine(i);
            }
        }
    }
}
