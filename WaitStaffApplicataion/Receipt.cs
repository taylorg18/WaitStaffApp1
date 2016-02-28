namespace WaitStaffApplicataion
{
   public class Receipt
    {
        private string sDesc;
        private FoodItem[] items;
        private bool bPaymentType = false;
        private float fTip,
                      fBill;

        public void addItem(FoodItem newItem)
        {
            fBill += newItem.getPrice();
        }

        public string printReceipt()
        {
            return sDesc;
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

        public float getTip()
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
    }
}