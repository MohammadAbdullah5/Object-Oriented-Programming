using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class StudentCRUD
    {
        public static List<Student> students = new List<Student>();

        public static void addIntoStudentsList(Student student)
        {
            students.Add(student);
        }

        public static Student studentPresent(string name)
        {
            foreach (Student s in students)
            {
                if (name == s.name && s.degree != null)
                {
                    return s;
                }
            }
            return null;
        }

        public static void calculateFeeForAll()
        {
            Console.WriteLine("Name           Fees");
            foreach (Student student in students)
            {
                if (student.isAdmitted == true && student.degree != null)
                {
                    Console.WriteLine(student.name + "    " + student.fees());
                }
            }
        }

        public static List<Student> sortstudentsByMerit()
        {
            List<Student> sortedStudents = new List<Student>();
            foreach (Student s in students)
            {
                s.aggregateCalculate();
            }
            sortedStudents = students.OrderByDescending(o => o.aggregate).ToList();
            return sortedStudents;
        }

        public static void giveAdmission(List<Student> sortedStudentList)
        {
            foreach (Student s in sortedStudentList)
            {
                foreach (Degree degree1 in s.Preferences)
                {
                    if (degree1.seats > 0 && s.degree == null)
                    {
                        s.degree = degree1;
                        s.isAdmitted = true;
                        degree1.seats--;
                        break;
                    }
                }
            }
        }

        public static void printStudents()
        {
            foreach (Student s in students)
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
            foreach (Student student in students)
            {
                if (student.degree != null && degreeName == student.degree.title)
                {
                    Console.WriteLine("{0}          {1}          {2}          {3}          {4}          {5}          {6}", student.name, student.rollNo, student.age, student.fscMarks, student.ecatMarks, student.aggregate, student.degree.title);
                }
            }
        }

        public static void viewRegisteredStudent()
        {
            foreach (Student student in students)
            {
                if (student.degree != null)
                {
                    Console.WriteLine("{0}          {1}          {2}          {3}          {4}          {5}          {6}", student.name, student.rollNo, student.age, student.fscMarks, student.ecatMarks, student.aggregate, student.degree.title);
                }
            }
        }

        
    }
}
