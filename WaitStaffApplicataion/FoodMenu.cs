namespace WaitStaffApplicataion
{
    class FoodMenu
    {
        private FoodItem[] items;

        public void setMenu()
        {

        }

        public FoodItem getMenuItem(int id)
        {
            return items[id];
        }

        public bool getItemAvaliablity(int id)
        {
            return items[id].getAvaliability();
        }
    }
}