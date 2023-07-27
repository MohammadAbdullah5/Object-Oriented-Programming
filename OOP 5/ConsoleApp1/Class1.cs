using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Student
    {
        public string name;
        public Degree degree;
        public int age;
        public int rollNo;
        public int fscMarks;
        public int ecatMarks;
        public bool isAdmitted;
        public float aggregate;
        public List<Degree> Preferences = new List<Degree>();
        public List<Subject> Courses = new List<Subject>();

        public Student(string name, int age, int rollNo, int fscMarks, int ecatMarks)
        {
            this.name = name;
            this.age = age;
            this.rollNo = rollNo;
            this.fscMarks = fscMarks;
            this.ecatMarks = ecatMarks;
        }

        public bool addPreference(Degree degree)
        {
            if (getPreferences() < 9)
            {
                Preferences.Add(degree);
                return true;
            }

            else
            {
                return false;
            }
        }

        public void aggregateCalculate()
        {
            aggregate = (((float)fscMarks / 1100.0F) * 45.0F) + (((float)ecatMarks / 400.0F) * 55.0F);
        }

        

        public int getCreditHours()
        {
            int creditHours = 0;
            foreach(Subject subject in Courses)
            {
                creditHours += subject.creditHours;
            }

            return creditHours;
        }

        public int getPreferences()
        {
            int preferences = 1;
            foreach (Degree degree in Preferences)
            {
                preferences += 1;
            }

            return preferences;
        }

        public bool regStudentSubject(Subject s)
        {
            int stCH = getCreditHours();
            if (degree != null && degree.isSubjectExists(s) && stCH + s.creditHours <= 9)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public int fees()
        {
            int sum = 0;
            foreach(Subject subject in Courses)
            {
                sum += subject.fees;
            }
            return sum;
        }
    }
}
