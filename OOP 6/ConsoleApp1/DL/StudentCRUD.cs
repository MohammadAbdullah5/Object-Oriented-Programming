using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp4.BL;
using System.IO;

namespace ConsoleApp4.DL
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
                        degree1.seats--;
                        break;
                    }
                }
            }
        }


        public static void storeInFile(string path, Student s)
        {
            StreamWriter file = new StreamWriter(path, true);
            string degreeNames = "";
            for (int i = 0; i < s.Preferences.Count; i++)
            {
                degreeNames += s.Preferences[i].title + ";";
            }

            degreeNames += s.Preferences[s.Preferences.Count - 1].title;
            file.WriteLine(s.name + "," + s.age + "," + s.fscMarks + "," + s.ecatMarks + "," + degreeNames);
            file.Flush();
            file.Close();
        }

        public static bool loadFromFile(string path)
        {
            StreamReader file = new StreamReader(path, true);
            string record;
            if(File.Exists(path))
            {
                while((record = file.ReadLine()) != null)
                {
                    string[] splittedRecord = record.Split(',');
                    string name = splittedRecord[0];
                    int age = int.Parse(splittedRecord[1]);
                    int fsc = int.Parse(splittedRecord[2]);
                    int ecat = int.Parse(splittedRecord[3]);
                    string[] splittedPreference = splittedRecord[4].Split(';');
                    List<Degree> preference = new List<Degree>();
                    
                    for(int i = 0; i < preference.Count; i++)
                    {
                        Degree d = DegreeCRUD.isDegreeExists(splittedPreference[i]);
                        if(d != null)
                        {
                            if(!(preference.Contains(d)))
                            {
                                preference.Add(d);
                            }
                        }
                    }
                    Student s = new Student(name, age, fsc, ecat, preference);
                    students.Add(s);
                }
                file.Close();
                return true;
            }

            else
            {
                return false;
            }
        }

        
        
    }
}
