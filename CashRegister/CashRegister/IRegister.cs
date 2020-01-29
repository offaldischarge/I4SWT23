using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashRegister
{
    public interface IRegister
    {
        void AddItem(double itemPrice);
        int GetNItems();
        double GetTotal();

    }
}
