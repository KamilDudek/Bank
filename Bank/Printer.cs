using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    class Printer
    {
        public void Print(SavingAccount account)
        {
            Console.WriteLine("Dane konta:");
            Console.WriteLine("Imię właściciela: {0}", account.Name);
            Console.WriteLine("Nazwisko właściciela: {0} ", account.Surname);
            Console.WriteLine("Stan konta: {0}", account.Balance);
            Console.WriteLine("Numer konta: {0}", account.Account_nr);
            Console.WriteLine("Pesel właściciela: {0}", account.PESEL + "\n");

        }

        public void Print(BillingAccount account)
        {
            Console.WriteLine("Dane konta:");
            Console.WriteLine("Imię właściciela: {0}", account.Name);
            Console.WriteLine("Nazwisko właściciela: {0} ", account.Surname);
            Console.WriteLine("Stan konta: {0}", account.Balance);
            Console.WriteLine("Numer konta: {0}", account.Account_nr);
            Console.WriteLine("Pesel właściciela: {0}", account.PESEL + "\n");

        }
    }
}
