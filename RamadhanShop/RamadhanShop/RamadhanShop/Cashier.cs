using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RamadhanShop
{
    class Cashier
    {
        private int threshold;
        private Customer customer;
        // Method to generate the receipt
        public void GenerateReceipt()
        {
            Console.WriteLine("Receipt:");
            foreach (var item in shoppingCart)
            {
                Console.WriteLine($"- {item.Name} \t ${quantity} \t ${item.Price}");
            }
            Console.WriteLine($"Total Amount: ${totalAmount}");
            this.ApplyFreeGifts(totalAmount);
        }
        public void ApplyFreeGifts(int amount)
        {
            if (amount >= threshold)
            {
                Console.WriteLine("Hooray, You receive a free gift!");

                int quantity = amount / threshold;
                Array giftItems = Enum.GetValues(typeof(GiftItems));
                Random random = new Random();
                for (int item = 0; item < quantity; item++)
                {
                    int randomIndex = random.Next(0, GiftItems.Length);
                    giftItems randomItem = (giftItems)GiftItems.GaetValue(randomIndex);
                    this.AddToCart(randomItem, 1);
                    Console.WriteLine("ramadhanItem.Name");
                }

            }
        }
        public int Threshold() { get => threshold; set => threshold = value; }
    }
}
