using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Revise the BankAccount class of Example 5.1 to overload the Withdraw method.
//Include a withdraw method with no parameters, which will withdraw $40 if available,
//and display a message otherwise.Add tests of this new method to Example 5.2.

namespace Exercise5_10
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount myAccount = new BankAccount(25.00);

            Console.WriteLine("My balance = {0:C}", myAccount.GetBalance());
            myAccount.Deposit(700.00);
            Console.WriteLine("My balance = {0:C}", myAccount.GetBalance());

            if (myAccount.Withdraw(300.00) < 0)
                Console.WriteLine("Insufficient funds");

            Console.WriteLine("My balance = {0:C}", myAccount.GetBalance());

            if (myAccount.Withdraw(450.00) < 0)
                Console.WriteLine("Insufficient funds");
            Console.WriteLine("My balance = {0:C}", myAccount.GetBalance());

            BankAccount yourAccount = new BankAccount();
            yourAccount.Deposit(1234.56);
            Console.WriteLine("Your balance = {0:C}", yourAccount.GetBalance());

            BankAccount krisTestAccount = new BankAccount();
            Console.WriteLine(krisTestAccount.Withdraw());

        }

        /* Declares a BankAccount class with an account balance,
        * two constructors, and GetBalance, Deposit, and
        * Withdraw operations.
        */
        public class BankAccount
        {
            private double balance;
                                    
            // Creates a Bank Account with a balance of 0
            public BankAccount()
            {
                balance = 0;
            }
            // Creates a Bank Account with a balance of initialAmount
            public BankAccount(double initialAmount)
            {
                balance = initialAmount;
            }
            // Returns the balance
            public double GetBalance()
            {
                return balance;
            }
            // Increases balance by amount
            public void Deposit(double amount)
            {
                balance += amount;
            }
            // Reduces balance by amount, if possible
            public double Withdraw(double amount)
            {
                if (balance >= amount)
                {
                    balance -= amount;
                    return balance;
                }
                else
                    return -1.0;
            }
            //Reduces balance by $40, if possible
            public String Withdraw()
            {
                if (balance >= 40)
                {
                    balance -= 40;
                    return "Successfully withdrew $40.00";
                }
                else
                    return "Insufficient funds";
            }
        }
■

    }
}
