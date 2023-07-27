using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static List<Student> students = new List<Student>();
        static List<Degree> degrees = new List<Degree>();
        static void Main(string[] args)
        {

            string option = "";
            do
            {
                option = menu();
                if (option == "1")
                {
                    Student student = TakeInputOfStudent();

                    Console.WriteLine("Available Degree Programs...");
                    foreach (Degree degree in degrees)
                    {
                        if (degree.seats > 0 && degrees.Count > 0)
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
                        Degree degree = preferenceDegree(degrees, name);
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
                    addIntoStudentsList(student);
                }

                else if (option == "2")
                {
                    Degree degree = TakeInputOfDegree();
                    int num = 0;
                    Console.WriteLine("Enter number of subjects in this degree: ");
                    num = int.Parse(Console.ReadLine());

                    for (int i = 0; i < num; i++)
                    {
                        Subject subject = TakeInputOfSubject();
                        degree.addSubject(subject);
                    }
                    degrees.Add(degree);
                }

                else if (option == "3")
                {
                    List<Student> sortedStudents = new List<Student>();
                    sortedStudents = sortstudentsByMerit();
                    giveAdmission(sortedStudents);
                    printStudents();
                }

                else if (option == "4")
                {
                    viewRegisteredStudent();
                }

                else if (option == "5")
                {
                    string degreeName;
                    Console.Write("Enter name of degree: ");
                    degreeName = Console.ReadLine();
                    viewStudentInDegree(degreeName);
                }

                else if (option == "6")
                {
                    Console.Write("Enter the name of student: ");
                    string name = Console.ReadLine();
                    Student s = studentPresent(name);

                    if(s != null)
                    {
                        viewSubjects(s);
                        registerSubject(s);
                    }
                }

                else if (option == "7")
                {
                    calculateFeeForAll();
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

        static Student TakeInputOfStudent()
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

        static Degree preferenceDegree(List<Degree> degrees, string name)
        {
            foreach (Degree degree in degrees)
            {
                if (name == degree.title)
                {
                    return degree;
                }
            }
            return null;
        }

        static Degree TakeInputOfDegree()
        {
            Console.Write("Enter Name: ");
            string name = Console.ReadLine();
            Console.Write("Enter Duration: ");
            int code = int.Parse(Console.ReadLine());
            Console.Write("Enter Seats: ");
            int seats = int.Parse(Console.ReadLine());

            Degree degree = new Degree(name, code, seats);
            return degree;
        }

        static Subject TakeInputOfSubject()
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

        static void addIntoDegreeList(Degree degree)
        {
            degrees.Add(degree);
        }

        static void addIntoStudentsList(Student student)
        {
            students.Add(student);
        }

        static Student studentPresent(string name)
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

        static void calculateFeeForAll()
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

        static void registerSubject(Student s)
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

        static List<Student> sortstudentsByMerit()
        {
            List<Student> sortedStudents = new List<Student>();
            foreach (Student s in students)
            {
                s.aggregateCalculate();
            }
            sortedStudents = students.OrderByDescending(o => o.aggregate).ToList();
            return sortedStudents;
        }

        static void giveAdmission(List<Student> sortedStudentList)
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

        static void printStudents()
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

        static void viewStudentInDegree(string degreeName)
        {
            foreach (Student student in students)
            {
                if (student.degree != null && degreeName == student.degree.title)
                {
                    Console.WriteLine("{0}          {1}          {2}          {3}          {4}          {5}          {6}", student.name, student.rollNo, student.age, student.fscMarks, student.ecatMarks, student.aggregate, student.degree);
                }
            }
        }

        static void viewRegisteredStudent()
        {
            foreach (Student student in students)
            {
                Console.WriteLine("{0}          {1}          {2}          {3}          {4}          {5}          {6}", student.name, student.rollNo, student.age, student.fscMarks, student.ecatMarks, student.aggregate, student.degree);
            }
        }

        static void clrScreen()
        {
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
            Console.Clear();
        }

        static void viewDegrees()
        {
            foreach(Degree degree in degrees)
            {
                Console.WriteLine(degree.title);
            }
        }

        static void viewSubjects(Student s)
        {
            if(s.degree != null)
            {
                foreach(Subject sub in s.degree.subjects)
                {
                    Console.WriteLine(sub.code + "  " + sub.name);
                }
            }
        }
    }
}
