using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Degree
    {
        public string title;
        public int duration;
        public int seats;
        public List<Subject> subjects = new List<Subject>();

        public Degree(string title, int duration, int seats)
        {
            this.title = title;
            this.duration = duration;
            this.seats = seats;
        }

        public bool addSubject(Subject subject)
        {
            int creditHours = calculateCredits();
            if (creditHours + subject.creditHours <= 20)
            {
                subjects.Add(subject);
                return true;
            }
            else
            {
                return false;
            }

        }

        public int calculateCredits()
        {
            int count = 0;
            for(int i = 0; i < subjects.Count; i++)
            {
                count += subjects[i].creditHours;
            }
            return count;
        }

        public List<Subject> subjectsOfDegree()
        {
            return subjects;
        }

        public bool isSubjectExists(Subject s)
        {
            foreach(Subject subject in subjects)
            {
                if(subject.name == s.name)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
