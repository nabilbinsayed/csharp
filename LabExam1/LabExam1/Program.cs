using System;
using Microsoft.VisualBasic;
namespace Exam
{
    public class Account
    {
        double balance;
        public Account(double balance)
        {
            this.balance = balance;
        }
        public double Deposit(double deposit)
        {
            balance += deposit;
            return balance;
        }
    }
    public class SavingAccount : Account
    {
        double interestRate;
        double interestEarned;
        public void SavingAccount(double interestRate)
        {
            this.interestRate = .05;
        }
        public double CalcInterest()
        {
            interestEarned = Acc1.balance * interestRate;
            return interestEarned;
        }
    }
    public class CheckingAccount : Account
    {
        double TransactionFee = 2;
        double newBalance = Acc1.balance - TransactionFee;
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            Account Acc1 = new Account(2000);
            Console.WriteLine("Savings Account: ");
            Console.WriteLine($"Balance: ${Account.balance}");
            Acc1.Deposit(500);
            Console.WriteLine($"Interest Earned: ${Acc1.CalcInterest()}");
            Console.WriteLine("Checking Account: ");
            Acc1.Deposit(300);
            Console.WriteLine("");


        }
    }
}

