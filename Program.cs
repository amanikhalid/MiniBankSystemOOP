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
                    Console.WriteLine("Welcome to Mini Bank System!");
                    Console.WriteLine("1. create New account");
                    Console.WriteLine("2. Login");
                    Console.WriteLine("0. Exit");

                    Console.WriteLine("Select Option ");
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

