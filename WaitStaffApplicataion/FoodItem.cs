namespace WaitStaffApplicataion
{
    public class FoodItem
    {
        private string sName,
                       sSpecial;
        private float fPrice;
        private bool bAvaliability = true;
        private int iAmountSold,
                    iAmountStock;

        //constructor for food items
        public FoodItem(string name, string special, float price, bool avaliability)
        {
            sName = name;
            sSpecial = special;
            fPrice = price;
            bAvaliability = avaliability;
            iAmountSold = 0;
            iAmountStock = 20;
        }

        public void setName(string name)
        {
            sName = name;
        }

        public void setSpecial(string special)
        {
            sSpecial = special;
        }

        public void setPrice(int price)
        {
            fPrice = price;
        }

        public bool getAvaliability()
        {
            return bAvaliability;
        }

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
            if(sold <= iAmountStock)
            {
                iAmountSold += sold;
                iAmountStock -= sold;
                return 0;
            }
            else
            {
                return sold - iAmountStock;
            }
        }

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