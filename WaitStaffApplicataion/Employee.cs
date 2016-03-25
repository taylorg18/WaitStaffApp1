using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaitStaffApplicataion
{
    public class Employee
    {
        private String sEmployee;
        private double dTips;

        public Employee(String name)
        {
            sEmployee = name;
            dTips = 0;
        }

        public void updateTips(double addTip)
        {
            dTips += addTip;
        }

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
