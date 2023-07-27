using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class StudentUI
    {
        public static Student TakeInputOfStudent()
        {
            Console.Write("Enter Name: ");
            string name = Console.ReadLine();
            Console.Write("Enter Roll No: ");
            int rollNo = int.Parse(Console.ReadLine());
            Console.Write("Enter Age: ");
            int age = int.Parse(Console.ReadLine());
            Console.Write("Enter Intermediate Marks: ");
            int interMarks = int.Parse(Console.ReadLine());
            Console.Write("Enter ECAT Marks: ");
            int ecatMarks = int.Parse(Console.ReadLine());

            Student student = new Student(name, age, rollNo, interMarks, ecatMarks);
            return student;
        }
    }
}
