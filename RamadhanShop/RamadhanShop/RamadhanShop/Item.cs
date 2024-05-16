using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RamadhanShop
{
    // Item class representing items in the inventory
    class Item
    {
        private int itemCode;
        private string itemName;
        private ItemCategory category;
        private decimal price;
        private int quantity;
        private bool isRamadhan;


        // Constructor
        public Item(int code, string name, string category, decimal price, int quantity)
        {
            ItemCode = code;
            ItemName = name;
            Category = category;
            Price = price;
            Quantity = quantity;
        }
        public Item(int code, string name, string category, decimal price, int quantity, bool isRamadhan)
        {
            ItemCode = code;
            ItemName = name;
            Category = category;
            Price = price;
            Quantity = quantity;
            this.IsRamadhan = isRamadhan;
        }

        public int ItemCode { get => itemCode; set => itemCode = value; }
        public string ItemName { get => itemName; set => itemName = value; }
        public ItemCategory Category { get => category; set => category = value; }
        public decimal Price { get => price; set => price = value; }
        public int Quantity { get => quantity; set => quantity = value; }
        public bool IsRamadhan { get => isRamadhan; set => isRamadhan = value; }
    }
}
