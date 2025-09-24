
namespace Bank.WebApi.Models
{
    public class BankAccount
    {
        private readonly double _balance;

        public BankAccount(double balance)
        {
            _balance = balance;
        }

        public double Balance
        {
            get { return _balance; }
        }
    }
}
