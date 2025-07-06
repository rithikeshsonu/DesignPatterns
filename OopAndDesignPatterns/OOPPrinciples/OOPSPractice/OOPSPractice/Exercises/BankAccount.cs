//🔹 1.Encapsulation Exercise
//🧠 Problem:
//Create a BankAccount class with the following:

//A private balance field

//Deposit(decimal amount) and Withdraw(decimal amount) methods

//GetBalance() method

//Ensure the balance can’t be directly modified from outside.
// ✅ 1. Encapsulation - BankAccount
namespace OOPSPractice.Exercises
{
    public class BankAccount
    {
        private decimal balance;
        public void Deposit(decimal amount)
        {
            if(amount > 0)
            {
                balance += amount;
            }
        }
        public void Withdraw(decimal amount)
        {
            balance -= amount;
        }
        public decimal GetBalance() => balance;
    }
}
