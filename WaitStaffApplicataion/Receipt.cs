using System.Collections;

namespace WaitStaffApplicataion
{

    /**
    * Name: Receipt 
    * Description:
    *   The Receipt class is used to track food perchases and payment.
    * 
    * Authors: Alex Reinemann
    * Date created: 2/20/2016
    */
    public class Receipt
    {
        private string sDesc;
        private ArrayList items = new ArrayList();//foods on the reciept
        private bool bPaymentType = false;//payed with cash or credit
        public double fTip; //tip given on bill
        private float fBill; //ammount owed by customer
        private int iNumItems = 0;

        /**
        * add an item to the reciept and its price to the bill
        * 
        * newItem the food item to add
        */
        public void addItem(FoodItem newItem)
        {
            fBill += newItem.getPrice();
            items.Add(newItem);
            iNumItems++;
        }

        /**
        * searches and removes one instance of a food item with the name of the given item
        *
        * returns 0 if successful
        * returns 1 in nothing removed
        */
        public int removeItem(FoodItem item)
        {
            fBill -= item.getPrice();

            int i = 0;
            foreach (FoodItem list in items)
            {
                if(list.getName().Equals(item.getName()))
                {
                    items.RemoveAt(i);
                    iNumItems--;
                    return 0;
                }
                else
                {
                    i++;
                }
            }
            return 1;
        }

        /**
     * searches and removes one instance of a food item with the name of the given item
     *
     * returns 0 if successful
     * returns 1 in nothing removed
     */
        public int removeAllItem(FoodItem item)
        {
            fBill -= item.getPrice();

            int i = 0;
            foreach (FoodItem list in items)
            {
                if (list.getName().Equals(item.getName()))
                {
                    items.RemoveAt(i);
                    iNumItems--;
                   
                }
                else
                {
                    i++;
                }
            }
            return 1;
        }

        /**
        * generates a text to display
        *
        * returns a list of food items
        */
        public string printReceipt()
        {
            string temp = "";
            if (items != null && items.Capacity != 0)
            {
                foreach (FoodItem fi in items)
                {
                    temp += fi.getName() + " " + fi.getPrice() + "\r\n";
                }
            }
                temp += "\r\n\r\n\r\n" + sDesc;
            return temp;
        }

        /**
        * sets the payment type of the reciept
        */
        public void setPaymentType(bool type)
        {
            bPaymentType = type;
        }

        /**
        * sets the tips given during payment
        */
        public void setTip(float tip)
        {
            fTip = tip;
        }

        /**
        * gets the total bill on the reciept
        */
        public float getBill()
        {
            return fBill;
        }

        /**
        * gets the tips added to the receipt
        */
        public double getTip()
        {
            return fTip;
        }

        /**
        * gets the payment type
        */
        public bool getPaymentType()
        {
            return bPaymentType;
        }

        /**
        * gets the discription of the reciept
        */
        public string getDesc()
        {
            return sDesc;
        }

        /**
        *sets the description of the reciept
        */
        public void setDesc(string newDesc)
        {
            sDesc = newDesc;
        }
    }
}