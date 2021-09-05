namespace Docs_Event
{
    public class Account
    {
        public double Total { get; private set; }
        
        public event EventAmountHandler EventAmountAdding;
        public event EventAmountHandler EventAmountAdded;
        public event EventAmountHandler EventAmountRemoving;
        public event EventAmountHandler EventAmountRemovingCancelled;
        public event EventAmountHandler EventAmountRemoved;

        public void Add(double amount)
        {
            EventAmountAdding?.Invoke(this, new AccountEventArgs(amount));

            Total += amount;

            EventAmountAdded?.Invoke(this, new AccountEventArgs(amount));
        }

        public void Remove(double amount)
        {
            EventAmountRemoving?.Invoke(this, new AccountEventArgs(amount));

            if (amount >= Total)
            {
                EventAmountRemovingCancelled?.Invoke(this, new AccountEventArgs(amount));
                return;
            }

            Total -= amount;

            EventAmountRemoved?.Invoke(this, new AccountEventArgs(amount));
        }
    }
}