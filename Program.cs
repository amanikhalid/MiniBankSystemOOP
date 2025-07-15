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
      
    }
}

