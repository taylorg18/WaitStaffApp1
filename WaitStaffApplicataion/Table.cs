using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


/**
* Name: Table 
* Description:
*   The Table class is used to track one tables status and receipts.
* 
* Authors: Alex Reinemann
* Date created: 2/20/2016
*/
namespace WaitStaffApplicataion
{
    public class Table
    {
        private int iNumPeople,
                    iTableNum,
                    iTableStatus,
                    iFoodStatus,
                    iNumReciepts = -1,
                    iTableMerged = -1; //tableMergedTo
        private string sSpecial;
        private FoodMenu menu;
        private ArrayList receipts = new ArrayList();
        private Employee employee;

        public void updateTableStatus()
        {
            iTableStatus++;

            if (iTableStatus > 1)
            {
                iTableStatus = 0;
                iNumPeople = 0;
                iFoodStatus = 0;
                sSpecial = "";
                receipts.Add(new Receipt());
                iNumReciepts++;
            }
        }

        public void setTableMerged(int table)
        {
            iTableMerged = table;
        }

        public void setMerged()
        {
            iTableStatus = 3;
        }

        public void updateFoodStatus(int newStatus)
        {
            iFoodStatus = newStatus;
        }

        public void updateMenu()
        {
            menu.setMenu();
        }

        //setter methods

        public void setNumPeople(int people)
        {
            iNumPeople = people;
        }

        public void setEmployee(Employee newEmployee)
        {
            employee = newEmployee;
        }

        public void setTableNum(int num)
        {
            iTableNum = num;
        }


        public void setSpecial(string special)
        {
            sSpecial = special;
        }

        //getter methods

        public int getTableNum()
        {
            return iTableNum;
        }

        public int getTableStatus()
        {
            return iTableStatus;
        }

        public Employee getEmployee()
        {
            return employee;
        }

        public int getTableMerged()
        {
            return iTableMerged;
        }

        public int getFoodStatus()
        {
            return iFoodStatus;
        }

        public string getSpecial()
        {
            return sSpecial;
        }

        public Receipt getReceipt()
        {
            if (iNumReciepts == -1)
            {
                receipts.Add(new Receipt());
                iNumReciepts = 0;
            }

            return (Receipt) receipts[iNumReciepts];
        }

        public int getNumPeople()
        {
            return iNumPeople;
        }

        public FoodMenu getMenu()
        {
            return menu;
        }
    }
}
