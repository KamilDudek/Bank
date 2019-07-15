using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    class Program
    {
        static void Main(string[] args)
        {

            string name ="Nazwa: Bank";
            string author = "Autor: KD";
            
            Console.WriteLine(name);
            Console.WriteLine(author+"\n");

            //pierwsze konto oszczednosciowe
            SavingAccount savingAccount = new SavingAccount("940000000031", 12.2M, "Patryk", "Majchrzak", "07010909122");
            SavingAccount secondsavingAccount = new SavingAccount("940000000001", 0.0M, "Kamil", "Dudek", "92010133333");
            BillingAccount billingAccount = new BillingAccount("Kamil","Dudek", "940000000001", "92010133333", 0.2M);
       
            string fullName = savingAccount.GetFullName();
            Console.WriteLine("Pierwsze konto w systemie dostał(-a): {0}", fullName);
            string secondFullName = billingAccount.GetFullName();
            Console.WriteLine("Drugie konto w systemie dostał(-a): {0}", secondFullName);

            decimal value = billingAccount.GetBalance();
            Console.WriteLine("Balans konta: {0}", value);

            Printer printer = new Printer();
            printer.Print(savingAccount);
            printer.Print(secondsavingAccount);
            printer.Print(billingAccount);


            Console.ReadKey();



        }
    }
}
