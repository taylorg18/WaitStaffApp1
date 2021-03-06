﻿using System;
using System.Collections;
using System.Globalization;
using System.IO;



namespace WaitStaffApplicataion
{
    public class FoodMenu
    {
        private FoodItem[] items;
        private int numFoods;

        public FoodMenu(int numItems)
        {
            items = new FoodItem[numItems];
            numFoods = 0;
        }

        public void addItem(FoodItem item)
        {
            items[numFoods] = item;
            numFoods++;
        }

        public FoodItem getFoodItem(int index)
        {
            return items[index];
        }

        public FoodItem getFoodItem(string itemName)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i].getName().Equals(itemName))
                {
                    return items[i];
                }
            }

            return null;
        }

        public int getNumItems()
        {
            return numFoods;
        }

        public void buyItem(int index, int amountSold)
        {
            items[index].updateSold(amountSold);
        }
        
        public void undoBuy(FoodItem item, int undo)
        {
            for(int i = 0; i < items.Length; i++)
            {
               if (items[i].getName().Equals(item.getName()))
                {
                    items[i].undoSold(undo);
                 }
            }
        }

        public bool getAvaliable(int index)
        {
            return items[index].getStock();
        }

        public void outOfStock(int index)
        {
            items[index].setStock(false);
        }

        public void outOfStock(string itemName)
        {
            for(int i = 0; i < items.Length; i++)
            {
                if(items[i].getName().Equals(itemName))
                {
                    items[i].setStock(false);
                }
            }
        }
    }
}