using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    class BillingAccount
    {
        public string Name;
        public string Surname;
        public string Account_nr;
        public string PESEL;
        public decimal Balance;


        public BillingAccount(string name, string surname, string account_nr, string pesel, decimal balance)
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

        public decimal GetBalance()
        {
            decimal Value = Balance;

            return Balance;
        }
    }
}
