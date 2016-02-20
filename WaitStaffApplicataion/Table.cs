﻿using System;
using System.Collections.Generic;
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
    class Table
    {
        private int iNumPeople,
                    iTableStatus,
                    iFoodStatus;
        private Receipt receipt;
        private string sSpecial;
        private FoodMenu menu;


        public void updateTableStatus()
        {
            iTableStatus++;

            if (iTableStatus > 2)
                iTableStatus = 0;
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

        public void setSpecial(string special)
        {
            sSpecial = special;
        }

        //getter methods

        public int getTableStatus()
        {
            return iTableStatus;
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
            return receipt;
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