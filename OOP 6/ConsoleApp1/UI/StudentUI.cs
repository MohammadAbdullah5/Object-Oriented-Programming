using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp4.BL;
using ConsoleApp4.DL;

namespace ConsoleApp4.UI
{
    class StudentUI
    {
        public static Student TakeInputOfStudent()
        {
            Console.Write("Enter Name: ");
            string name = Console.ReadLine();
            Console.Write("Enter Age: ");
            int age = int.Parse(Console.ReadLine());
            Console.Write("Enter Intermediate Marks: ");
            int interMarks = int.Parse(Console.ReadLine());
            Console.Write("Enter ECAT Marks: ");
            int ecatMarks = int.Parse(Console.ReadLine());
            DegreeUI.viewDegreePrograms();
            List<Degree> preferences = new List<Degree>();

            Console.WriteLine("Enter how many preferences you want to add: ");
            int num = int.Parse(Console.ReadLine());

            for (int i = 0; i < num; i++)
            {
                Console.Write("Enter Preference " + i + ": ");
                string degName = Console.ReadLine();
                bool flag = false;

                foreach (Degree dp in DegreeCRUD.degrees)
                {
                    if (degName == dp.title && !(preferences.Contains(dp)))
                    {
                        preferences.Add(dp);
                        flag = true;
                    }
                }
                if (flag == false)
                {
                    Console.WriteLine("Enter Valid Degree Program Name");
                    i--;
                }
            }
                Student student = new Student(name, age, interMarks, ecatMarks, preferences);
                return student;
        }

        public static void printStudents()
        {
            foreach (Student s in StudentCRUD.students)
            {
                if (s.degree != null)
                {
                    Console.WriteLine(s.name + " got admission in " + s.degree.title);
                }

                else
                {
                    Console.WriteLine(s.name + " did not got admission");
                }
            }
        }

        public static void viewStudentInDegree(string degreeName)
        {
            foreach (Student student in StudentCRUD.students)
            {
                if (student.degree != null && degreeName == student.degree.title)
                {
                    Console.WriteLine("{0}          {1}          {2}          {3}          {4}          {5}", student.name, student.age, student.fscMarks, student.ecatMarks, student.aggregate, student.degree.title);
                }
            }
        }

        public static void viewRegisteredStudent()
        {
            foreach (Student student in StudentCRUD.students)
            {
                if (student.degree != null)
                {
                    Console.WriteLine("{0}          {1}          {2}          {3}          {4}          {5}", student.name, student.age, student.fscMarks, student.ecatMarks, student.aggregate, student.degree.title);
                }
            }
        }

        public static void calculateFeeForAll()
        {
            Console.WriteLine("Name           Fees");
            foreach (Student student in StudentCRUD.students)
            {
                if (student.degree != null)
                {
                    Console.WriteLine(student.name + "    " + student.fees());
                }
            }
        }

    }
}
