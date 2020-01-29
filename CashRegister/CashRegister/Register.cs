using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashRegister
{
    public class Register : IRegister
    {
        public int NoOfItems { get; private set; }

        private double _total;
        public Register()
        {
            NoOfItems = 0;
            _total = 0.0;
        }

        public void AddItem(double itemPrice)
        {
            if (itemPrice < 0)
                throw new ArgumentException("Item er mindre end nul");
            _total += itemPrice;
            NoOfItems++;
        }

        public int GetNItems()
        {
            return NoOfItems;
        }

        public double GetTotal()
        {
            return _total;
        }

    }
}
