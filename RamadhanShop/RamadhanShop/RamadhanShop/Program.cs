using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RamadhanShop
{
    public enum ItemCategory { Food, Drinks, Electronics, Clothing }

    class Program
    {
        static void Main(string[] args)
        {
            // Initialize the inventory
            Inventory inventory = new Inventory();
            inventory.AddItem(new Item("Dates", "Ramadhan", 5.99m, 10));
            inventory.AddItem(new Item("Rooh Afza", "Ramadhan", 3.49m, 20));
            inventory.AddItem(new Item("Tea Bags", "Beverages", 4.99m, 15));
            inventory.AddItem(new Item("Rice", "Food", 12.99m, 8));

            // Simulate customer shopping
            Customer customer = new Customer();
            customer.AddToCart(inventory.GetAllItems()[0]); // Add Dates to the cart
            customer.AddToCart(inventory.GetAllItems()[1]); // Add Rooh Afza to the cart

            // Generate receipt
            customer.GenerateReceipt();
        }
    }
}
