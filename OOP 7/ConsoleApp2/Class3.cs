using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class HosePipes
    {
        private bool isSyntheticRubber;
        private bool isCylindrical;
        private int diameter;
        private double flowrate;

        public HosePipes(bool isSyntheticRubber, bool isCylindrical, int diameter, double flowrate)
        {
            this.diameter = diameter;
            this.isCylindrical = isCylindrical;
            this.isSyntheticRubber = isSyntheticRubber;
            this.flowrate = flowrate;
        }

        public string getShape()
        {
            if(isCylindrical == true)
            {
                return "cylindrical";
            }

            else
            {
                return "circular";
            }
        }

        public void setShape(string shape)
        {
            if (shape == "cylindrical")
            {
                isCylindrical = true;
            }

            else if(shape == "circular")
            {
                isCylindrical = false;                
            }
        }

        public string getMaterial()
        {
            if (isSyntheticRubber == true)
            {
                return "synthetic rubber";
            }

            else
            {
                return "soft plastic";
            }
        }

        public void setMaterial(string shape)
        {
            if (shape == "synthetic rubber")
            {
                isSyntheticRubber = true;
            }

            else if (shape == "soft plastic")
            {
                isSyntheticRubber = false;
            }
        }

        public int getDiameter()
        {
            return diameter;
        }

        public void setDiameter(int diamet)
        {
            diameter = diamet;
        }

        public double getflowrate()
        {
            return flowrate;
        }

        public void setflowrate(int diamet)
        {
            flowrate = diamet;
        }
    }
}
