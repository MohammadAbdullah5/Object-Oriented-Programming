using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class SubjectCRUD
    {
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
                    if (code == sub.code)
                    {
                        s.regStudentSubject(sub);
                        flag = true;
                        s.Courses.Add(sub);
                        break;
                    }
                }

                if (flag == false)
                {
                    i--;
                    Console.WriteLine("Enter Valid Code");
                }
            }
        }

        public static void viewSubjects(Student s)
        {
            if (s.degree != null)
            {
                foreach (Subject sub in s.degree.subjects)
                {
                    Console.WriteLine(sub.code + "  " + sub.name);
                }
            }
        }
    }
}
