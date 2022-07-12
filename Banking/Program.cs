using System;

namespace Banking
{
    class Program
    {
        static void Main(string [] args)
        {
            Account newAccount = new Account(1000, "Eunice");
            Account secondAccount = new Account(500, "James");
            Console.WriteLine(newAccount.accountNumber.ToString());
            Console.WriteLine(secondAccount.accountNumber.ToString());
        }
    }
}
