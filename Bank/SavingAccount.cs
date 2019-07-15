using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    class SavingAccount
    {
        public string Name;
        public string Surname;
        public string Account_nr;
        public string PESEL;
        public decimal Balance;

        public  SavingAccount(string account_nr, decimal balance, string name, string surname, string pesel)
        {
            Name = name;
            Surname = surname;
            Balance = balance;
            Account_nr = account_nr;
            PESEL = pesel;
        }

        public string GetFullName()
        {
            string FullName = string.Format(Name +" "+ Surname);

            return FullName;

        }
    }
}
