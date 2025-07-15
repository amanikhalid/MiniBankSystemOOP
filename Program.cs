namespace MiniBankSystemOOP
{
    internal class Program
    {
        static Dictionary<int, Account> accounts = new(); // stores accounts with account number as key
        static int lastAccountNumber = 1000; // starting account number

        static void Main(string[] args)
        {
            LoadAccounts();

            while (true) // Main loop for the menu system
            {
                {
                    Console.Clear();
                    Console.WriteLine("Mini Bank System");
                    Console.WriteLine("1. Create Account");
                    Console.WriteLine("2. Deposit");
                    Console.WriteLine("3. Withdraw");
                    Console.WriteLine("4. View Balance");
                    Console.WriteLine("5. Transaction History");
                    Console.WriteLine("0. Exit");

                    Console.Write("Choose an option: ");

                    switch (Console.ReadLine())
                    {
                        case "1": CreateAccount(); break;
                        case "2": Deposit(); break;
                        case "3": Withdraw(); break;
                        case "4": ViewBalance(); break;
                        case "5": ViewTransactionHistory(); break;
                        case "0": SaveAccounts(); return;
                        default: Console.WriteLine("Invalid option."); break;
                    }
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();

                }
            }

        }

        static void CreateAccount()
        {
            Console.Clear();
            Console.WriteLine("Create Account");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("National ID: ");
            string nationalId = Console.ReadLine();
            Console.Write("Initial Balance: ");
            double balance = double.Parse(Console.ReadLine());
            Console.Write("User Type (customer/admin): ");
            string userType = Console.ReadLine();
            Console.Write("Password: ");
            string password = Console.ReadLine();
            string hashedPassword = HashPassword(password); // Hash the password
            Console.Write("Phone: ");
            string phone = Console.ReadLine();
            Console.Write("Address: ");
            string address = Console.ReadLine();
            int accountNumber = lastAccountNumber++;
            Account newAccount = new(accountNumber, name, nationalId, balance, userType, hashedPassword, phone, address);
            accounts[accountNumber] = newAccount;
            Console.WriteLine($"Account created successfully! Account Number: {accountNumber}");
        }

        static Account Login()
        {
            Console.Clear();
            Console.WriteLine("Login");
            Console.Write("Account Number: ");
            int accountNumber = int.Parse(Console.ReadLine());
            if (accounts.TryGetValue(accountNumber, out Account account))
            {
                Console.Write("Password: ");
                string password = Console.ReadLine();
                if (account.CheckPassword(HashPassword(password)))
                {
                    return account; // Return the logged-in account
                }
                else
                {
                    Console.WriteLine("Invalid password.");
                }
            }
            else
            {
                Console.WriteLine("Account not found.");
            }
            return null; // Return null if login fails
        }

        static void Deposit()
        {
            {
                Account acc = Login();
                if (acc == null) return;

                Console.Write("Enter amount to deposit: ");
                if (double.TryParse(Console.ReadLine(), out double amount) && amount > 0)
                {
                    acc.Deposit(amount);
                    Console.WriteLine("Deposited" + amount + "successfully."); 
                }
                else
                    Console.WriteLine("Invalid amount.");
            }
        }

        static void Withdraw()
        {
            Account acc = Login();
            if (acc == null) return;
            Console.Write("Enter amount to withdraw: ");
            if (double.TryParse(Console.ReadLine(), out double amount) && amount > 0)
            {
                acc.Withdraw(amount);
                Console.WriteLine("Withdrawn " + amount + " successfully.");
            }
            else
                Console.WriteLine("Invalid amount.");
        }

        static void ViewBalance()
        {
            Account acc = Login();
            if (acc == null) return;
            Console.WriteLine("Current Balance:" + acc.Balance);
        }

        static void ViewTransactionHistory()
        {
            Account acc = Login();
            if (acc == null) return;
            Console.WriteLine("Transaction History for Account Number: " + acc.AccountNumber);
            foreach (var transaction in acc.Transactions)
            {
                Console.WriteLine(transaction);
            }
        }

        static void LoadAccounts()
        {
            if (!File.Exists("accounts.txt")) return;

            string[] lines = File.ReadAllLines("accounts.txt");
            foreach (string line in lines)
            {
                var parts = line.Split(',');
                int accNum = int.Parse(parts[0]);
                string name = parts[1];
                double balance = double.Parse(parts[2]);
                string password = parts[3];

                var acc = new Account(accNum, name, password);
                acc.Deposit(balance);
                accounts[accNum] = acc;

                if (accNum > lastAccountNumber) lastAccountNumber = accNum;
            }
        }


    }
}

