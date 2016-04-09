namespace WaitStaffApplicataion
{

    public class FoodItem
    {
        private string sName, // Food Item name
                       sSpecial; 
        private float fPrice;
     //   private bool bAvaliability = true;
        private int iAmountSold,//keeps track of units of food sold
                    iAmountStock;//

        //constructor for food items
        public FoodItem(string name, float price)
        {
            sName = name;
           // sSpecial = special;
            fPrice = price;
          //  bAvaliability = avaliability;
            iAmountSold = 0;
            iAmountStock = 20;
        }

        public void setName(string name)
        {
            sName = name;
        }
        /*
        public void setSpecial(string special)
        {
            sSpecial = special;
        }
        */
        public void setPrice(int price)
        {
            fPrice = price;
        }
        /*
        public bool getAvaliability()
        {
            return bAvaliability;
        }
        */
        public float getPrice()
        {
            return fPrice;
        }

        public string getName()
        {
            return sName;
        }

        /**
         * determines if item can be sold and returns amount of order not filled without selling any if order cannot be filled
         **/
        public int updateSold(int sold)
        {
            //checks if we still have the food items needed to make the transaction in stock and makes changes if so
            if(sold <= iAmountStock)
            {
                iAmountSold += sold;
                iAmountStock -= sold;
                return 0;
            }
            else // we do not have enough and we cannot make the sell
            {
                return sold - iAmountStock;
            }
        }

        /*
           Getters for items sold and amount in stock
        */
        public int getSold()
        {
            return iAmountSold;
        }

        public int getStock()
        {
            return iAmountStock;
        }

    }
}