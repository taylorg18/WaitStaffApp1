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
        private ArrayList receipts = new ArrayList();
        private Employee employee;

        /**
        * changes the state of the table
        * 0 is open
        * 1 is occupied
        * 2 is merged
        */
        public void updateTableStatus()
        {
            iTableStatus++;

            //check if table is being cleared
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

        /**
        * sets the table that this table is merged with
        */
        public void setTableMerged(int table)
        {
            iTableMerged = table;
            iTableStatus = 3;
        }

        /**
        * sets the table as merged
        */
        public void setMerged()
        {
            iTableStatus = 3;
        }

        /**
        * updates the status of orders
        */
        public void updateFoodStatus(int newStatus)
        {
            iFoodStatus = newStatus;
        }

        /**
        * adds a new reciept to the table
        */
        public void addNewReciept()
        {
            iNumReciepts++;
            receipts.Add(new Receipt());
        }

        //setter methods

        /**
        * sets the number of people seated at the table
        */
        public void setNumPeople(int people)
        {
            iNumPeople = people;
        }

        /**
        * sets the server for the table
        */
        public void setEmployee(Employee newEmployee)
        {
            employee = newEmployee;
        }

        /**
        * sets the tables number
        */
        public void setTableNum(int num)
        {
            iTableNum = num;
        }

        /**
        * sets the special requests
        */
        public void setSpecial(string special)
        {
            sSpecial = special;
        }

        //getter methods

            /**
            * gets the table's number
            */
        public int getTableNum()
        {
            return iTableNum;
        }

        /**
        * gets the table status
        */
        public int getTableStatus()
        {
            return iTableStatus;
        }

        /**
        * gets the server
        */
        public Employee getEmployee()
        {
            return employee;
        }

        /**
        * gets the table that is merged 
        */
        public int getTableMerged()
        {
            return iTableMerged;
        }

        /**
        * gets the status of the food
        */
        public int getFoodStatus()
        {
            return iFoodStatus;
        }

        /**
        * gets the special requests
        */
        public string getSpecial()
        {
            return sSpecial;
        }

        /**
        * gets the current reciept of the table
        */
        public Receipt getReceipt()
        {
            //check if a reciept exists
            if (iNumReciepts == -1)
            {
                receipts.Add(new Receipt());
                iNumReciepts = 0;
            }

            return (Receipt) receipts[iNumReciepts];
        }

        /**
        * gets the number of people seated at the table
        */
        public int getNumPeople()
        {
            return iNumPeople;
        }
    }
}
