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
        public List<Transaction> Transactions { get; }
        public int AccountNumber { get; private set; }
        
        public string NationalId { get; private set; }
        
        public string UserType { get; set; }
        public bool IsLocked { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }

        public string HashedPassword;

        public Account(int number, string name, double balance, string hashedPassword)
        {
            AccountNumber = number;
            Name = name;
            Balance = balance;
            HashedPassword = hashedPassword;
            NationalId = "";
            UserType = "customer";
            Phone = "";
            Address = "";
            IsLocked = false;
            Transactions = new List<Transaction>();

        }


        public bool CheckPassword(string hashedInput) // compares the hashed input with the stored hashed password
        {
            return hashedInput == HashedPassword;

        }

        public void Deposit(double amount) 
        {
            Balance += amount;
            Transactions.Add(new Transaction("Deposit", amount, Balance));
        }

        public bool Withdraw(double amount)
        {
            if (Balance >= amount)
            {
                Balance -= amount;
                Transactions.Add(new Transaction("Withdraw", amount, Balance));
                return true;
            }
            return false;
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
