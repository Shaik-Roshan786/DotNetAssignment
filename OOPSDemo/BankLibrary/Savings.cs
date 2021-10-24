using System;

namespace BankLibrary
{
    public class Savings : Bank , IIntrest
    {
        public Savings()
        {
        }
        public Savings(string name, double amt) : base(name, amt)
        {
        }
        public double CalculateInterest()
        {
            return Balance * .1;

        }
        public sealed override void Withdraw(double amount)
        {
            if ((Balance - amount) > 0)
            {
                Balance -= amount;
            }
            else
            {
                throw new BalanceException("Balance not Enough.cannot withdraw");
            }
        }
    }
}











public class Current : BankLibrary
{
    public override void Withdraw(double amount)
    {
        throw new NotImplementedException();
    }
}






