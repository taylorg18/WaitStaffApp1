namespace WaitStaffApplicataion
{

    public class FoodItem
    {
        private string sName, // Food Item name
                       sSpecial; 
        private float fPrice;
        //   private bool bAvaliability = true;
        private int iAmountSold,//keeps track of units of food sold
                    iTimeToPrepare;
        private bool inStock;//

        //constructor for food items
        public FoodItem(string name, float price, int prepTime)
        {
            sName = name;
           // sSpecial = special;
            fPrice = price;
          //  bAvaliability = avaliability;
            iAmountSold = 0;
            inStock = true;
            iTimeToPrepare = prepTime;
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
        public void updateSold(int sold)
        {
            iAmountSold += sold;
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