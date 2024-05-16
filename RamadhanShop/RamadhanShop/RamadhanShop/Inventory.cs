using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RamadhanShop
{
    // Inventory class managing the items
    class Inventory
    {
        public List<Item> RamadhanItem = new List<Item>();
        private List<Item> items;

        // Constructor
        public Inventory()
        {
            items = new List<Item>();
        }

        // Method to add an item to the inventory
        public void AddItem(Item item)
        {
            if (items.Find(listItem => listItem.ItemName == item.ItemName))
                Console.WriteLine("Item already exists");
            else
            {
                items.Add(item);
                if (item.IsRamadhan == true)
                    RamadhanItem.Add(item);
                Console.WriteLine("Item added successfully");
            }
        }

        public void RemoveItembyCode(int code)
        {
            items.Remove(items.Find(listItem => listItem.ItemCode == code));
        }
        public void RemoveItembyName(string name)
        {
            items.Remove(items.Find(listItem => listItem.ItemName == name));
        }
        public void updateQuantity(int amount)
        {
            Item.Quantity += amount;
        }
        public Item FindItembyCode(int code)
        {
            Item item = items.Find(listItem => listItem.ItemCode == code);
            return item;
        }
        public Item FindItembyName(string name)
        {
            return items.Find(listItem => listItem.ItemName == name);
        }
        // Method to get all items from the inventory
        public List<Item> GetAllItems()
        {
            return items;
        }
        public void RemoveAllItems()
        {
            items.RemoveAll();
        }
    }
}
