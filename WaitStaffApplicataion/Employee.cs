using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



/*
    Class representing an employee of the waitstaff.
    Used to track their name and amount of tips recieved.
    Created By: Grayson Taylor, Michael Larios, Alex Reinemann, Michael Liao

    */
namespace WaitStaffApplicataion
{
    public class Employee
    {
        private String sEmployee; //name of employee
        private double dTips; //amount of tips

        /*
            Constructor - takes in name string and initalized the object
        */
        public Employee(String name)
        {
            sEmployee = name;
            dTips = 0;
        }

        /*
            Updatetips - adds the given amount to the total tip
        */
        public void updateTips(double addTip)
        {
            dTips += addTip;
        }

        /*
            Gets the name of the Employee
        */
        public string getName()
        {
            return sEmployee;
        }


        /*
            Gets the total amout of tips for the employee
        */
        public double getTips()
        {
            return dTips;
        }
    }
}
