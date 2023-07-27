using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buisness_Application.BL
{
    class Schedule
    {
        protected string date;
        protected string time;

        public Schedule(string date, string time)
        {
            this.date = date;
            this.time = time;
        }

        public void setDate(string date)
        {
            this.date = date;
        }

        public void setTime(string time)
        {
            this.time = time;
        }

        public string getDate()
        {
            return date;
        }

        public string getTime()
        {
            return time;
        }

        public virtual string toString()
        {
            return "Schedule";
        }
    }
}
