using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashRegister
{
    class Program
    {
        static void Main(string[] args)
        {
            Register reg = new Register();

            reg.AddItem(23.52);

            if (reg.GetNItems() == 1)
            {
                System.Console.WriteLine("Der er registreret en vare - OK");
            }
            else
            {
                System.Console.WriteLine("Der burde være registreret 1 vare, og det var der ikke");
            }

            if (reg.GetTotal() == 23.52)
            {
                System.Console.WriteLine("Der er registreret varer for 23.52 - OK");
            }
            else
            {
                System.Console.WriteLine("Der burde være registreret varer for 23.52, og det var der ikke");
            }

            System.Console.WriteLine("Der er registreret {0} varer til en samlet pris af {1}", reg.GetNItems(), reg.GetTotal());

            System.Console.WriteLine($"Der er registreret {reg.GetNItems()} varer til en samlet pris af {reg.GetTotal()}");

            System.Console.WriteLine($"Der er registreret {reg.NoOfItems} varer til en samlet pris af {reg.GetTotal()}");

            try
            {
                reg.AddItem(-12.50);
                // Hvis jeg kommer hertil, var der ingen exception
                System.Console.WriteLine("Exception blev ikke udløst!");
            }
            catch (Exception e)
            {
                System.Console.WriteLine($"Exception blev udløst som forventet med indhold: {e.Message}");
            }

        }
    }
}
