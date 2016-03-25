using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaitStaffApplicataion
{
    public class Employee
    {
        String sEmployee;
        double dTips;

        public Employee(String name)
        {
            sEmployee = name;
            dTips = 0;
        }

        public void updateTips(double addTip )
        {
            dTips += addTip;
        }
    }
}
