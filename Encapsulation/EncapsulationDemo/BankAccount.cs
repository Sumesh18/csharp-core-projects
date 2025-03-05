using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulationDemo
{
    public class BankAccount
    {
        private readonly string _accountNumber;
        private string _accountHolder;
        private decimal _balance;

        // Constructor
        public BankAccount(string accountNumber, string accountHolder, decimal initialBalance)
        {
            _accountNumber = accountNumber;
            _accountHolder = accountHolder;
            _balance = initialBalance > 0 ? initialBalance : throw new ArgumentException("Initial balance must be positive");
        }

        // Encapsulated property with validation
        public string AccountHolder
        {
            get => _accountHolder;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Account holder name cannot be empty.");
                _accountHolder = value;
            }
        }

        // Read-only property
        public string AccountNumber => _accountNumber;

        // Read-only balance property (no public setter)
        public decimal Balance => _balance;

        // Encapsulated method for deposit
        public void Deposit(decimal amount)
        {
            if (amount <= 0)
                throw new ArgumentException("Deposit amount must be positive.");

            _balance += amount;
            Console.WriteLine($"Deposited: {amount:C}, New Balance: {_balance:C}");
        }

        // Encapsulated method for withdrawal with validation
        public bool Withdraw(decimal amount)
        {
            if (amount <= 0)
                throw new ArgumentException("Withdrawal amount must be positive.");

            if (amount > _balance)
            {
                Console.WriteLine("Insufficient balance.");
                return false;
            }

            _balance -= amount;
            Console.WriteLine($"Withdrawn: {amount:C}, Remaining Balance: {_balance:C}");
            return true;
        }

        // Encapsulated method to display account details
        public void DisplayAccountInfo()
        {
            Console.WriteLine($"Account Number: {AccountNumber}, Holder: {AccountHolder}, Balance: {Balance:C}");
        }
    }

    class Program
    {
        static void Main()
        {
            // Creating an encapsulated BankAccount object
            var account = new BankAccount("1234567890", "John Doe", 5000);
            account.DisplayAccountInfo();

            account.Deposit(1500);
            account.Withdraw(2000);

            // Trying to set an invalid name (this will throw an exception)
            try
            {
                account.AccountHolder = "";
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }

            // Trying to withdraw an amount greater than balance
            account.Withdraw(10000);

            account.DisplayAccountInfo();
        }
    }
}
