using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RamadhanShop
{
    class Drinks
    {
        private DateTime expiryDate;
        private int litres;

        public DateTime ExpiryDate { get => expiryDate; set => expiryDate = value; }
        public int Litres { get => litres; set => litres = value; }
    }
}
