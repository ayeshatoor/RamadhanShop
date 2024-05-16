using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RamadhanShop
{
    class ShopKeeper
    {
        private static Singleton instance;
        private int shopkeeperId;
        private string name;

        private ShopKeeper()
        {

        }

        public int ShopkeeperId { get => shopkeeperId; set => shopkeeperId = value; }
        public string Name1 { get => Name; set => Name = value; }

        public void CreateShopKeeper(int id, string name)
        {
            get
            {
                if (instance == null)
                {
                    instance = new Singleton();
                }
                return instance;
            }
        }

        public ShopkeeperId() { get => shopkeeperId; set => shopkeeperId = value; }
        public Name() { get => name; set => name = value; }
    }
}
