﻿namespace WaitStaffApplicataion
{

    public class FoodItem
    {
        private string sName; // Food Item name
                       //sSpecial; 
        private float fPrice;
        private int iAmountSold,//keeps track of units of food sold
                    iTimeToPrepare;
        private bool inStock;//

        //constructor for food items
        public FoodItem(string name, float price, int prepTime)
        {
            sName = name;
           // sSpecial = special;
            fPrice = price;
            iAmountSold = 0;
            inStock = true;
            iTimeToPrepare = prepTime;
        }

        public void setName(string name)
        {
            sName = name;
        }
       
        public void setPrice(int price)
        {
            fPrice = price;
        }

        public float getPrice()
        {
            return fPrice;
        }

        public string getName()
        {
            return sName;
        }

        public int getTime()
        {
            return iTimeToPrepare;
        }

        public void setAmountSold(int sold)
        {
            this.iAmountSold = sold;
        }
        /**
         * determines if item can be sold and returns amount of order not filled without selling any if order cannot be filled
         **/
        public void updateSold(int sold)
        {
            iAmountSold += sold;
        }


        /**
            removes the amount from the sold
            **/
        public void undoSold(int sold)
        {
            iAmountSold -= sold;
        }
        /*
           Getters for items sold and amount in stock
        */
        public int getSold()
        {
            return iAmountSold;
        }

        public bool getStock()
        {
            return inStock;
        }

        public void setStock(bool stock)
        {
            inStock = stock;
        }

    }
}