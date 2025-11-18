using AccountPolymorphismApp.Domain;

namespace AccountPolymorphismApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SavingAccount sa=new SavingAccount(101,"Arnika",1000);
            CurrentAccount ca = new CurrentAccount(102, "Vidushi", 8000);

            PrintBalance(sa);
            PrintBalance(ca);
        }
        static void PrintBalance(Account acc)
        {
            Console.WriteLine("Current Amount " + acc.Accountno);
            Console.WriteLine("Name " + acc.Name);
            Console.WriteLine("Balance is"+acc.Balance);
        }
    }
}
