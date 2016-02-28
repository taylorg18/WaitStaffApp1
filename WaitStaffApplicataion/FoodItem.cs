namespace WaitStaffApplicataion
{
    public class FoodItem
    {
        private string sName,
                       sSpecial;
        private float fPrice;
        private bool bAvaliability = true;

        //constructor for food items
        public FoodItem(string name, string special, float price, bool avaliability)
        {
            sName = name;
            sSpecial = special;
            fPrice = price;
            bAvaliability = avaliability;
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

    }
}