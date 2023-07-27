using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Student
    {
        public string name;
        public int rollNo;
        public float cgpa;
        public int matricMarks;
        public int interMarks;
        public int ecatMarks;
        public string hometown;
        public bool isHostellite;
        public bool isTakingScholarship;
        public float aggregate;

        public Student(string name, int rollNo, float cgpa, int matricMarks, int interMarks, int ecatMarks, string hometown, bool isHostellite, bool isTakingScholarship)
        {
            this.name = name;
            this.rollNo = rollNo;
            this.cgpa = cgpa;
            this.matricMarks = matricMarks;
            this.interMarks = interMarks;
            this.ecatMarks = ecatMarks;
            this.hometown = hometown;
            this.isHostellite = isHostellite;
            this.isTakingScholarship = isTakingScholarship;
        }
        
        public float calculateMerit()
        {
            float aggregate = (((float)interMarks / 1000.0F) * 60.0F) + (((float)ecatMarks / 400.0F) * 40.0F);
            this.aggregate = aggregate;
            return aggregate;
        }

        public bool isEligibleForScholarship()
        {
            if (aggregate > 80 && isHostellite == true)
            {
                return true;
            }

            else
            {
                return false;
            }
        }
    }
}
