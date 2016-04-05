namespace WaitStaffApplicataion
{
   public class Receipt
    {
        private string sDesc;
        private FoodItem[] items;
        private bool bPaymentType = false;
        public double fTip;
        private float fBill;

        public void addItem(FoodItem newItem)
        {
            fBill += newItem.getPrice();
        }

        public string printReceipt()
        {
            string temp = "";
            if (items != null && items.Length != 0)
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