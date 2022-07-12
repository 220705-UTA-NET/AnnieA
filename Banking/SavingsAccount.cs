namespace Banking
{
    class SavingsAccount : Account // the :Account means we are extending the Account class (it inherited the parent Account class)
        {
            // Fields / state
            private double interestRate;

            // Constructor

            // Methods / behavior
            public void ApplyInterest()
            {
                int payment = this.balance * this.interestRate;
                this.MakeDeposit(payment);

            }
        }
}