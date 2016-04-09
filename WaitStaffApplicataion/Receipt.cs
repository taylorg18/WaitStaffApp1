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

        public string printReceipt()
        {
            string temp = "";
            if (items != null && items.Capacity != 0)
            {
                foreach (FoodItem fi in items)
                {
                    temp += fi.getName() + " " + fi.getPrice() + "/n";
                }
            }
                temp += "\r\n\r\n\r\n" + sDesc;
            return temp;
        }

        public void setPaymentType(bool type)
        {
            bPaymentType = type;
        }

        public void setTip(float tip)
        {
            fTip = tip;
        }

        public float getBill()
        {
            return fBill;
        }

        public double getTip()
        {
            return fTip;
        }

        public bool getPaymentType()
        {
            return bPaymentType;
        }

        public string getDesc()
        {
            return sDesc;
        }

        public void setDesc(string newDesc)
        {
            sDesc = newDesc;
        }
    }
}