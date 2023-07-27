using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp4.BL;
using System.IO;

namespace ConsoleApp4.DL
{
    class DegreeCRUD
    {
        public static List<Degree> degrees = new List<Degree>();

        public static Degree preferenceDegree(string name)
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

        public static void addIntoDegreeList(Degree degree)
        {
            degrees.Add(degree);
        }

        public static void viewDegrees()
        {
            foreach (Degree degree in degrees)
            {
                Console.WriteLine(degree.title);
            }
        }

        public static bool readFromFile(string path)
        {
            StreamReader file = new StreamReader(path);
            string record;
            if (File.Exists(path))
            {
                while ((record = file.ReadLine()) != null)
                {
                    string[] splittedRecord = record.Split(',');
                    string degreeName = splittedRecord[0];
                    int duration = int.Parse(splittedRecord[1]);
                    int seats = int.Parse(splittedRecord[2]);
                    string[] splittedSubjects = splittedRecord[3].Split(';');
                    Degree d = new Degree(degreeName, duration, seats);
                    for (int i = 0; i < splittedSubjects.Length; i++)
                    {
                        Subject s = SubjectCRUD.isSubjectExists(splittedSubjects[i]);
                        if (splittedSubjects != null)
                        {
                            d.addSubject(s);
                        }
                    }
                    addIntoDegreeList(d);
                    return true;
                }

                file.Close();
                return true;
            }

            else
            {
                return false;
            }
        }

        public static void addIntoFile(string path, Degree d)
        {
            StreamWriter file = new StreamWriter(path, true);
            string subjectNames = "";
            for(int i = 0; i < d.subjects.Count; i++)
            {
                subjectNames += d.subjects[i].name + ";";
            }

            subjectNames += d.subjects[d.subjects.Count - 1].name;
            file.WriteLine(d.title + "," + d.duration + "," + d.seats + "," + subjectNames);
            file.Flush();
            file.Close();
        }

        public static Degree isDegreeExists(string degreeName)
        {
            foreach(Degree degree in degrees)
            {
                if(degree.title == degreeName)
                {
                    return degree;
                }
            }
            return null;
        }
    }
}
