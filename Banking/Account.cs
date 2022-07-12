using System;

namespace Banking
{
    class Account
    {
        // Fields / state
        // (access modifier) (type) (name) (initial value)
        protected double balance;
        public int accountNumber { get; }  // this is the shortcut for several lines of codes
        private string owner;

        private static int accountNumberSeed = 345667890; // means theres only one Seed number being shared

        // Constructor - the set of instructions on how to create an object of this type.
        // (access modifier) (Class-name) (Parameter list)
        public Account(double inititalBalance, string owner)
        {
            this.accountNumber = accountNumberSeed;
            accountNumberSeed++;

            MakeDeposit(inititalBalance);
            this.owner = owner;
        }



        // Methods / behavior
        // (access modifier) (return type) (name) (parameters)
        public string DisplayBalance()
        {
            string balanceString = balance.ToString();
            return balanceString;
        }
         
         public void MakeDeposit(double amount)
         {
            if (amount <=0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Amount must be greater than zero")
            }
            else
            {
                balance += amount;
            }
            
         }

        public void MakeWithdrawal(double amount)
        {
            if (amount <=0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Amount must be greater than zero")
            }
            else if (balance - amount < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Insufficient funds.")
            }
            else
            {
                balance -= amount;
            }
  
                
        }
            
    }
}
