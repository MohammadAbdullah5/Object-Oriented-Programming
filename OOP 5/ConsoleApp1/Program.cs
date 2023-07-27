using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            string option = "";
            do
            {
                option = menu();
                if (option == "1")
                {
                    Student student = StudentUI.TakeInputOfStudent();

                    Console.WriteLine("Available Degree Programs...");
                    foreach (Degree degree in DegreeCRUD.degrees)
                    {
                        if (degree.seats > 0 && DegreeCRUD.degrees.Count > 0)
                        {
                            Console.WriteLine(degree.title);
                        }
                    }

                    Console.WriteLine("Enter how many preferences you want to add: ");
                    int num = int.Parse(Console.ReadLine());

                    for (int i = 0; i < num; i++)
                    {
                        Console.Write("Enter Preference " + i + ": ");
                        string name = Console.ReadLine();
                        Degree degree = DegreeCRUD.preferenceDegree(name);
                        if (degree != null)
                        {
                            bool flag;
                            flag = student.addPreference(degree);

                            if (flag == false)
                            {
                                Console.WriteLine("You have entered maximum number of preferneces");
                            }
                        }

                        else
                        {
                            Console.WriteLine("Wrong Input..Try Again");
                            i--;
                            Console.ReadKey();
                        }

                    }
                    student.aggregateCalculate();
                    StudentCRUD.addIntoStudentsList(student);
                }

                else if (option == "2")
                {
                    Degree degree = DegreeUI.TakeInputOfDegree();
                    int num = 0;
                    Console.WriteLine("Enter number of subjects in this degree: ");
                    num = int.Parse(Console.ReadLine());

                    for (int i = 0; i < num; i++)
                    {
                        Subject subject = SubjectUI.TakeInputOfSubject();
                        degree.addSubject(subject);
                    }
                    DegreeCRUD.degrees.Add(degree);
                }

                else if (option == "3")
                {
                    List<Student> sortedStudents = new List<Student>();
                    sortedStudents = StudentCRUD.sortstudentsByMerit();
                    StudentCRUD.giveAdmission(sortedStudents);
                    StudentCRUD.printStudents();
                }

                else if (option == "4")
                {
                    StudentCRUD.viewRegisteredStudent();
                }

                else if (option == "5")
                {
                    string degreeName;
                    Console.Write("Enter name of degree: ");
                    degreeName = Console.ReadLine();
                    StudentCRUD.viewStudentInDegree(degreeName);
                }

                else if (option == "6")
                {
                    Console.Write("Enter the name of student: ");
                    string name = Console.ReadLine();
                    Student s = StudentCRUD.studentPresent(name);

                    if (s != null)
                    {
                        SubjectCRUD.viewSubjects(s);
                        SubjectCRUD.registerSubject(s);
                    }
                }

                else if (option == "7")
                {
                    StudentCRUD.calculateFeeForAll();
                }
                clrScreen();
            }
            while (option != "8");
        }


        static string menu()
        {
            Console.WriteLine("1. Add Student");
            Console.WriteLine("2. Add Degree Program");
            Console.WriteLine("3. Generate Merit");
            Console.WriteLine("4. View Registered Students");
            Console.WriteLine("5. View Students of a specific program");
            Console.WriteLine("6. Register Subjects for a specific student");
            Console.WriteLine("7. Calculate Fees for all registered students");
            Console.WriteLine("8. Exit");
            Console.Write("   Enter your option...");
            string option = Console.ReadLine();
            return option;
        }

        static void clrScreen()
        {
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
            Console.Clear();
        }

    }
}
