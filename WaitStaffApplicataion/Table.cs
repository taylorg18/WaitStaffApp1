using System;
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
        int iNumPeople,
            iTableStatus,
            iFoodStatus;
        Receipt receipt;
        String sSpecial;
        Menu menu;

        void updateTableStatus()
        {
            iTableStatus++;

            if (iTableStatus > 2)
                iTableStatus = 0;
        }

        void updateFoodStatus(int newStatus)
        {
            iFoodStatus = newStatus;
        }

        //setter methods

        void setNumPeople(int people)
        {
            iNumPeople = people;
        }

        //getter methods

        int getTableStatus()
        {
            return iTableStatus;
        }

        int getFoodStatus()
        {
            return iFoodStatus;
        }
    }
}
