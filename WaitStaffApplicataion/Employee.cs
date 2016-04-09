using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaitStaffApplicataion
{
    public class Employee
    {
        private String sEmployee; //Name for Employee
        private double dTips;     //Tips given to employee

        //Constructor
        public Employee(String name)
        {
            sEmployee = name;
            dTips = 0;
        }

        /*
         adds to the tip total as employee gets tipped.
        */
        public void updateTips(double addTip)
        {
            dTips += addTip;
        }


        /*
         Methods below are getters
        */
        public string getName()
        {
            return sEmployee;
        }

        public double getTips()
        {
            return dTips;
        }
    }
}
