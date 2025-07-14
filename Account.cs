using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniBankSystemOOP
{
    class Account
    {
        public int AccountNumber { get; private set; }
        public string Name { get; private set; }
        public string NationalId { get; private set; }
        public double Balance { get; private set; }
        public string UserType { get; set; }
        public bool IsLocked { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }

        private string HashedPassword;

        public Account(int number, string name, string nid, double balance, string userType, string passwordHash, string phone, string address) 
        {
            AccountNumber = number; // unique identifier for the account
            Name = name; // account holder's name
            NationalId = nid; // account holder's national ID
            Balance = balance; // initial balance of the account
            UserType = userType; // type of user (e.g., customer, admin)
            HashedPassword = passwordHash; // hashed password for security
            Phone = phone; // account holder's phone number
            Address = address; // account holder's address
            IsLocked = false; // indicates if the account is locked
        }

        
        public bool CheckPassword(string hashedInput) // compares the hashed input with the stored hashed password
        {
            return hashedInput == HashedPassword;

        }

        public void Deposit(double amount) // method to deposit money into the account
        {
            if (amount <= 0)
            {
                Console.WriteLine("Deposit amount must be positive.");
            }
            Balance += amount;
        }

        public void Withdraw(double amount) // method to withdraw money from the account
        {
            if (amount <= 0)
            {
                Console.WriteLine("Withdrawal amount must be positive.");
                return;
            }
            if (amount > Balance)
            {
                Console.WriteLine("Insufficient funds for withdrawal.");
                return;
            }
            Balance -= amount;
        }




    }
}
