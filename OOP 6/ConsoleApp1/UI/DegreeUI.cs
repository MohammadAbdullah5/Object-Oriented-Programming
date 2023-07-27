using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp4.BL;
using ConsoleApp4.DL;

namespace ConsoleApp4.UI
{
    class DegreeUI
    {
        public static Degree TakeInputOfDegree()
        {
            Console.Write("Enter Name: ");
            string name = Console.ReadLine();
            Console.Write("Enter Duration: ");
            int code = int.Parse(Console.ReadLine());
            Console.Write("Enter Seats: ");
            int seats = int.Parse(Console.ReadLine());

            int num = 0;
            Console.WriteLine("Enter number of subjects in this degree: ");
            num = int.Parse(Console.ReadLine());
            Degree degree = new Degree(name, code, seats);

            for (int i = 0; i < num; i++)
            {
                Subject subject = SubjectUI.TakeInputOfSubject();
                if (degree.addSubject(subject))
                {
                    if (!(SubjectCRUD.subjects.Contains(subject)))
                    {
                        SubjectCRUD.addSubjectsInList(subject);
                        SubjectCRUD.addIntoFile("C:\\Users\\92309\\OneDrive\\Desktop\\University\\Object Oriented Programming\\OOP 6\\ConsoleApp1\\Subjects.txt", subject);
                    }
                    Console.WriteLine("Subject Added!");
                }

                else
                {
                    Console.WriteLine("Subject Not Added");
                    Console.WriteLine("20 Credit Hours Limit exceeded");
                    i--;
                }
            }
            return degree;
        }

        public static void viewDegreePrograms()
        {
            foreach (Degree degree in DegreeCRUD.degrees)
            {
                Console.WriteLine(degree.title);
            }
        }
    }
}
