using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniBankSystemOOP
{
    class Account
    {
        public int Number { get; }
        public string Name { get; }
        public double Balance { get; private set; }
        public string Password { get; }
        public List<string> Transactions { get; }
        public int AccountNumber { get; private set; }
        
        public string NationalId { get; private set; }
        
        public string UserType { get; set; }
        public bool IsLocked { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }

        string HashedPassword;

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
            Number = number;
            Name = name;
            Password = Password;
            Balance = 0;
            Transactions = new List<string> { $"Account created for {name}." };
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

        public void LockAccount() // method to lock the account
        {
            IsLocked = true;
            Console.WriteLine("Account has been locked.");
        }

        public void UnlockAccount() // method to unlock the account
        {
            IsLocked = false;
            Console.WriteLine("Account has been unlocked.");
        }
        public void DisplayAccountInfo() // method to display account information
        {
            Console.WriteLine($"Account Number: {AccountNumber}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"National ID: {NationalId}");
            Console.WriteLine($"Balance: {Balance:C}");
            Console.WriteLine($"User Type: {UserType}");
            Console.WriteLine($"Phone: {Phone}");
            Console.WriteLine($"Address: {Address}");
            Console.WriteLine($"Account Locked: {IsLocked}");
        }


        public void UpdatePhone(string newPhone) // method to update the phone number
        {
            Phone = newPhone;
            Console.WriteLine("Phone number updated successfully.");
        }

        public void UpdateAddress(string newAddress) // method to update the address
        {
            Address = newAddress;
            Console.WriteLine("Address updated successfully.");
        }


    }
}
