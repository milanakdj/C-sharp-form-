using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormsApp1
{
    class FoodItem
    {
        private string itemCode;
        private string itemName;
        private float itemPrice;
        private string itemDescription;

        public FoodItem(string itemCode, string itemName, float price, string description)
        {
            this.itemCode = itemCode;
            this.itemName = itemName;
            this.itemPrice = price;
            this.itemDescription = description;
        }

        public string getItemCode()
        {
            return itemCode;
        }
        public string getItemName()
        {
            return itemName;
        }
        public float getPrice()
        {
            return itemPrice;
        }
        public string getDescription()
        {
            return itemDescription;
        }
    }
}
