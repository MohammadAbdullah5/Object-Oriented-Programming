using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Student
    {
        public string stuName;
        public int matricMarks;
        public int fscMarks;
        public int ecatMarks;
        public float aggregate;
    }

    class Students
    {
        public Students()
        {
            Console.WriteLine("Default Constructor called");
        }

        public Students(Students s1)
        {
            stuName = s1.stuName;
            matricMarks = s1.matricMarks;
            fscMarks = s1.fscMarks;
            ecatMarks = s1.ecatMarks;
            aggregate = s1.aggregate;
        }

        public string stuName;
        public int matricMarks;
        public int fscMarks;
        public int ecatMarks;
        public float aggregate;
    }

    class Students1
    {
        public Students1()
        {
            stuName = "Jill";
        }

        public string stuName;
        public int matricMarks;
        public int fscMarks;
        public int ecatMarks;
        public float aggregate;
    }

    class Students2
    {
        public Students2()
        {
            stuName = "Jill";
            matricMarks = 300;
            fscMarks = 400;
            ecatMarks = 200;
            aggregate = 75.9F;
        }

        public Students2(string n)
        {
            stuName = n;
        }

        public Students2(string n, int m, int f, int e, float a)
        {
            stuName = n;
            matricMarks = m;
            fscMarks = f;
            ecatMarks = e;
            aggregate = a;
        }

        public string stuName;
        public int matricMarks;
        public int fscMarks;
        public int ecatMarks;
        public float aggregate;
    }
}
