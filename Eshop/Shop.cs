using System;
using System.Collections.Generic;
using System.Text;

namespace Eshop
{
    public class Shop
    {
        private List<string> shopItems = new List<string>();

        public int MyProperty { get; set; }

        public void AddItem(string itemName)
        {
            shopItems.Add(itemName);
            displayItems();
            Console.WriteLine("-------------------");
        }

        public void displayItems()
        {
            foreach (var item in shopItems)
            {
                Console.WriteLine(item);
            }
        }
    }
}