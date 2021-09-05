using System;

namespace Docs_Event
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("start");

            var account = new Account();

            account.EventAmountAdding += Amount_Adding;
            account.EventAmountAdded += Amount_Added;
            account.EventAmountRemoving += Amount_Removing;
            account.EventAmountRemovingCancelled += Amount_RemovingCancelled;
            account.EventAmountRemoved += Amount_Removed;

            account.Add(3);
            account.Add(4);
            account.Remove(5);
            account.Remove(7);

            Console.WriteLine("finished");

            Console.ReadKey();
        }

        private static void Amount_Adding(object sender, AccountEventArgs e)
        {
            var account = (Account) sender;
            Console.WriteLine($"amount adding, total: {account.Total}, amount: {e.Amount}");
        }
        public static void Amount_Added(object sender, AccountEventArgs e)
        {
            var account = (Account)sender;
            Console.WriteLine($"amount added, total: {account.Total}, amount: {e.Amount}");
        }
        private static void Amount_Removing(object sender, AccountEventArgs e)
        {
            var account = (Account)sender;
            Console.WriteLine($"amount removing, total: {account.Total}, amount: {e.Amount}");
        }
        private static void Amount_RemovingCancelled(object sender, AccountEventArgs e)
        {
            var account = (Account)sender;
            Console.WriteLine($"amount removing cancelled, total: {account.Total}, amount: {e.Amount}");
        }
        private static void Amount_Removed(object sender, AccountEventArgs e)
        {
            var account = (Account)sender;
            Console.WriteLine($"amount removed, total: {account.Total}, amount: {e.Amount}");
        }
    }
}