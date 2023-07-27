using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class FireTrucks
    {
        protected Ladder ladder = new Ladder();
        protected HosePipes pipe;
        protected FireFighter fighter;
        protected FireChief chief;

        public void setPipe(HosePipes p)
        {
            pipe = p;
        }

        public void setFighter(FireFighter fighter)
        {
            this.fighter = fighter;
        }

        public void setChief(FireChief chief)
        {
            this.chief = chief;
        }
    }
}
