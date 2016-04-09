using System;
using System.Collections;
using System.Globalization;
using System.IO;



namespace WaitStaffApplicataion
{
    public class FoodMenu
    {
        private FoodItem[] items;

        //initializing the arraylist of fooditems
        //  public ArrayList FoodItem Menu = new ArrayList();
        public ArrayList Menu = new ArrayList();

        public FoodMenu()
        {
            //default values for FoodItem Objects
            string sName = "temp";
           // string sSpecial = "temp";
            float fPrice = 9001.13F;
           // bool bAvaliability = true;

            int counter = 0;
            string line;
            FoodItem temp;

            // Read the file and display it line by line.
            System.IO.StreamReader file =
               new System.IO.StreamReader("c:/waitData/menu.txt");

            //reading the file for every line
            /*
            format in the file:
            name (line 0)
            special request (line 1)

            */
            while ((line = file.ReadLine()) != null)
            {
                // Console.WriteLine (line);
                if (counter % 2 == 0)
                {
                    sName = line;

                    // The second line for a particular card is cardWord.
                }
                /*
                else if (counter % 5 == 1)
                {
                    sSpecial = line;

                    // The third line for a particular card is
                    // cardDescription.
                }
                */
                else if (counter % 2 == 1)
                {
                    //converts the string that contains the price to a float
                    fPrice = float.Parse(line, CultureInfo.InvariantCulture.NumberFormat);

                    // The fourth line for a particular card is cardTag.
                }
                /*
                else if (counter % 3 == 2)
                {
                    bool tempBool;
                    if (line == "1")
                    {
                        tempBool = false;

                    }
                    else
                    {
                        tempBool = false;

                    }

                    bAvaliability = tempBool;

                    // The fifth line will be an empty space, meaning it
                    // reach the end of the item.
                    // because it is at the end of the item, we want to
                    // create a item object with the information we just
                    // collected.
                }
                */
                else {
                    temp = new FoodItem(sName, fPrice);
                    // add the item to the arraylist
                    this.Menu.Add((FoodItem)temp);
                }

                counter++;
            }

            file.Close();
        }



        public void setMenu()
        {


        }

        public FoodItem getMenuItem(int id)
        {
            return items[id];
        }
        /*
        public bool getItemAvaliablity(int id)
        {
            return items[id].getAvaliability();
        }
        */
    }
}