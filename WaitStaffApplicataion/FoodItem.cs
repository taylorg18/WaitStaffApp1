namespace WaitStaffApplicataion
{
    public class FoodItem
    {
        private string sName,
                       sSpecial;
        private float fPrice;
        private bool bAvaliability = true;

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

    }
}