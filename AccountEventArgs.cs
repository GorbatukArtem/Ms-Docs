namespace Docs_Event
{
    public class AccountEventArgs
    {
        public double Amount { get; }
        public AccountEventArgs(double amount)
        {
            Amount = amount;
        }
    }
}