namespace WaitStaffApplicataion
{
    internal class FoodMenu
    {
        FoodItem[] items;
        
        void setMenu()
        {

        }

        FoodItem getMenuItem(int id)
        {
            return items[id];
        }

        bool getItemAvaliablity(int id)
        {
            return items[id].getAvaliability();
        }
    }
}