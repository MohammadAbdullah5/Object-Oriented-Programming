using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using ConsoleApp4.BL;

namespace ConsoleApp4.DL
{
    class SubjectCRUD
    {
        public static List<Subject> subjects = new List<Subject>();

        public static void addSubjectsInList(Subject s)
        {
            subjects.Add(s);
        }

        public static Subject isSubjectExists(string name)
        {
            foreach (Subject subject in subjects)
            {
                if (subject.name == name)
                {
                    return subject;
                }
            }

            return null;
        }

        public static bool readFromFile(string path)
        {
            StreamReader file = new StreamReader(path);
            string record;
            if(File.Exists(path))
            {
                while((record = file.ReadLine()) != null)
                {
                    string[] splittedRecord = record.Split(',');
                    string code = splittedRecord[0]; 
                    string name = splittedRecord[1]; 
                    int creditHours = int.Parse(splittedRecord[2]); 
                    int fees = int.Parse(splittedRecord[3]);
                    Subject s = new Subject(name, code, creditHours, fees);
                    addSubjectsInList(s);
                }

                file.Close();
                return true;
            }

            else
            {
                return false;
            }
        }

        public static void addIntoFile(string path, Subject s)
        {
            StreamWriter file = new StreamWriter(path, true);
            file.WriteLine(s.code + "," + s.name + "," + s.creditHours + "," + s.fees);
            file.Flush();
            file.Close();
        }
    }
}
