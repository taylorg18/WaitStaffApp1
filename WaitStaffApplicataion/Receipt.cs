using System.Collections;
using System;

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
        private FoodItem[] itemsBought = new FoodItem[40];//foods on the reciept
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
            if(iNumItems >= itemsBought.Length)
            {
                return;
            }
            fBill += newItem.getPrice();
            itemsBought[iNumItems] = new FoodItem(newItem.getName(), newItem.getPrice(), newItem.getTime());
            itemsBought[iNumItems].setAmountSold(1);
            iNumItems++;

            this.updateTotalItemBought(newItem);
        }

        /**
        * searches and updates one common item to have a total count of the number sold
        *
        * returns 0 if successful
        * returns 1 in nothing removed
        */
        public void updateTotalItemBought(FoodItem item)
        {
            for (int i = 0; i < itemsBought.Length; i++)
            {
                if (itemsBought[i] != null && itemsBought[i].getName().Equals(item.getName()))
                {
                    itemsBought[i].setAmountSold(itemsBought[i].getSold() + 1);
                    return;             
               }

            }
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

            
            for(int i = 0; i < itemsBought.Length; i++)
            {
                if(itemsBought[i] != null && itemsBought[i].getName().Equals(item.getName()))
                {
                    itemsBought[i] = null;
                    
                    return 0;
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
            ArrayList temp = new ArrayList();
            
            foreach (FoodItem list in itemsBought)
            {
                if (list != null && list.getName().Equals(item.getName()))
                {
                    list.setAmountSold(0);                  
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
            if (itemsBought != null && itemsBought.Length != 0)
            {
                foreach (FoodItem fi in itemsBought)
                {
                    if (fi != null && fi.getSold() > 0)
                    {
                        temp += fi.getName() + " " + fi.getPrice() + "\r\n";
                    }
                }
            }
                temp += "\r\n\r\n\r\n" + sDesc;
            return temp;
        }

        /**
        * gets an item in the array
        */
        public FoodItem getItem(String name)
        {
            foreach(FoodItem item in itemsBought)
            {
                if(item != null && item.getName().Equals(name))
                {
                    return item;
                }
            }
            return null;
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