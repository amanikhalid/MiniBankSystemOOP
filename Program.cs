namespace MiniBankSystemOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool runAgain = true;
            while (runAgain)
            {
                try //handle the exception if the user enter invalid input
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
                    string choice = Console.ReadLine();
                    switch (choice)
                    {
                        case "1": //CreateAccount(); break;
                        case "2": //Deposit(); break;
                        case "3": //Withdraw(); break;
                        case "4": //ViewBalance(); break;
                        case "5": //ViewTransactionHistory(); break;
                        case "0": return;
                        default: Console.WriteLine("Invalid option."); break;
                    }
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                }
        

                catch (Exception e)
                {
                    Console.WriteLine(e.Message);


                    Console.WriteLine("Invalid Choice! Try again.");
                    Console.WriteLine("Press any key  ");
                    Console.ReadLine();
                }

            }
        }
    }
}

