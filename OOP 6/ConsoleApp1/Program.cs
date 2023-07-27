using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp4.DL;
using ConsoleApp4.BL;
using ConsoleApp4.UI;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            string subjectPath = "C:\\Users\\92309\\OneDrive\\Desktop\\University\\Object Oriented Programming\\OOP 6\\ConsoleApp1\\Subjects.txt";
            string degreePath = "C:\\Users\\92309\\OneDrive\\Desktop\\University\\Object Oriented Programming\\OOP 6\\ConsoleApp1\\Degrees.txt";
            string studentPath = "C:\\Users\\92309\\OneDrive\\Desktop\\University\\Object Oriented Programming\\OOP 6\\ConsoleApp1\\Students.txt";

            if (SubjectCRUD.readFromFile(subjectPath))
            {
                Console.WriteLine("Subject Data Loaded Successfully");
            }

            if (DegreeCRUD.readFromFile(subjectPath))
            {
                Console.WriteLine("Degree Data Loaded Successfully");
            }

            if (StudentCRUD.loadFromFile(subjectPath))
            {
                Console.WriteLine("Student Data Loaded Successfully");
            }
            string option = "";
            do
            {
                option = MenuUI.menu();
                if (option == "1")
                {
                    Student student = StudentUI.TakeInputOfStudent();
                    StudentCRUD.addIntoStudentsList(student);
                    StudentCRUD.storeInFile(studentPath, student);
                }

                else if (option == "2")
                {
                    Degree degree = DegreeUI.TakeInputOfDegree();
                    DegreeCRUD.addIntoFile(degreePath, degree);
                    DegreeCRUD.addIntoDegreeList(degree);
                }

                else if (option == "3")
                {
                    List<Student> sortedStudents = new List<Student>();
                    sortedStudents = StudentCRUD.sortstudentsByMerit();
                    StudentCRUD.giveAdmission(sortedStudents);
                    StudentUI.printStudents();
                }

                else if (option == "4")
                {
                    StudentUI.viewRegisteredStudent();
                }

                else if (option == "5")
                {
                    string degreeName;
                    Console.Write("Enter name of degree: ");
                    degreeName = Console.ReadLine();
                    StudentUI.viewStudentInDegree(degreeName);
                }

                else if (option == "6")
                {
                    Console.Write("Enter the name of student: ");
                    string name = Console.ReadLine();
                    Student s = StudentCRUD.studentPresent(name);

                    if (s != null)
                    {
                        SubjectUI.viewSubjects(s);
                        SubjectUI.registerSubject(s);
                    }
                }

                else if (option == "7")
                {
                    StudentUI.calculateFeeForAll();
                }
                MenuUI.clrScreen();
            }
            while (option != "8");
        }




    }
}
