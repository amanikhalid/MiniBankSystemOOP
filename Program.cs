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
                        case "1":
                            //CreateNewAccount();
                            break;
                        case "2":
                            //Login();
                            break;
                        case "0":
                            Console.WriteLine("Exiting system...");
                            Console.WriteLine("Thank you for using Mini Bank System!");
                            Console.WriteLine("Press any key to exit.");
                            Console.ReadKey();
                            runAgain = false;
                            break;

                        default:
                            Console.WriteLine("Invalid choice, please try again.");
                            break;
                    }


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

