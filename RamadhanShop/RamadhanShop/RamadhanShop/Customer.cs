using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RamadhanShop
{
    // Customer class managing the shopping process
    class Customer
    {
        private Dictionary<Item, double, int> shoppingCart;
        private decimal totalAmount;

        // Constructor
        public Customer()
        {
            shoppingCart = new Dictionary<Item, double, int>();
            totalAmount = 0;
        }

        // Method to add an item to the shopping cart
        public void AddToCart(Item item, int quantity)
        {
            if (shoppingCart.ContainsKey(item))
                shoppingCart[item] += quantity;
            else
            {
                if (item.IsRamadhan)
                {
                    shoppingCart.Add(item, ApplyDiscount(item.Price), quantity);
                }
                else
                {
                    shoppingCart.Add(item, item.Proce, quantity);
                }
            }
        }

        public void RemoveFromCart(Item item, int quantity)
        {
            if (shoppingCart.ContainsKey(item))
            {
                if (shoppingCart[item] >= quantity)
                {
                    shoppingCart[item] - quantity;
                    if (shoppingCart[item] == 0)
                        shoppingCart.Remove[item];
                }
                else
                    Console.WriteLine("The amount of item you're trying to remove is not applicable");
            }
            public double ApplyDiscounts()
            {
                return this.Price - discount * 0.01;
            }
            public Discount() { get => discount; set => discount = value; }
        }
    }
}
