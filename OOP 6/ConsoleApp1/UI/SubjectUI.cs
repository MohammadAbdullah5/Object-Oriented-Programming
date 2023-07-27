using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp4.BL;

namespace ConsoleApp4.UI
{
    class SubjectUI
    {
        public static Subject TakeInputOfSubject()
        {
            Console.Write("Enter Name: ");
            string name = Console.ReadLine();
            Console.Write("Enter Code: ");
            string code = Console.ReadLine();
            Console.Write("Enter Credit Hours: ");
            int creditHours = int.Parse(Console.ReadLine());
            Console.Write("Enter Fees: ");
            int fees = int.Parse(Console.ReadLine());

            Subject subject = new Subject(name, code, creditHours, fees);
            return subject;
        }


        public static void viewSubjects(Student s)
        {
            if (s.degree != null)
            {
                Console.WriteLine("Subject Code  " + "Subject Name");
                foreach (Subject sub in s.degree.subjects)
                {
                    Console.WriteLine(sub.code + "  " + sub.name);
                }
            }
        }

        public static void registerSubject(Student s)
        {
            Console.WriteLine("Enter number of subjects to register....");
            int count = int.Parse(Console.ReadLine());
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine("Enter subject code: ");
                string code = Console.ReadLine();
                bool flag = false;
                foreach (Subject sub in s.degree.subjects)
                {
                    if (code == sub.code && !(s.Courses.Contains(sub)))
                    {
                        if (s.regStudentSubject(sub))
                        {
                            flag = true;
                            break;
                        }

                        else
                        {
                            Console.WriteLine("A student cannot have more than 9 Credit Hours");
                            flag = true;
                            break;
                        }
                    }
                }

                if (flag == false)
                {
                    i--;
                    Console.WriteLine("Enter Valid Code");
                }
            }
        }
    }
}
