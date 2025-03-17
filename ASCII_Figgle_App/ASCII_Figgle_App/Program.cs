using Figgle; // Library for ASCII text rendering

namespace ASCII_Figgle_App
{
    // Represents a bank user with a name and account number
    class User
    {
        public string Name { get; set; }  // Stores the user's name
        public string AccountNumber { get; set; }  // Stores the user's account number
    }

    // Represents a bank account with balance operations
    class BankAccount
    {
        public double Balance { get; private set; }  // Read-only balance outside the class

        // Constructor ensures initial balance is not negative
        public BankAccount(double initialBalance)
        {
            if (initialBalance < 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Initial balance cannot be negative. Setting balance to $0.");
                Console.ResetColor();
                Balance = 0; // Set default balance if negative value is provided
            }
            else
            {
                Balance = initialBalance;
            }
        }

        // Deposits a positive amount into the account
        public void Deposit(double amount)
        {
            if (amount > 0)
            {
                Balance += amount;
            }
        }

        // Withdraws funds if there is enough balance
        public bool Withdraw(double amount)
        {
            if (amount > 0 && amount <= Balance)
            {
                Balance -= amount;
                return true;  // Successful withdrawal
            }
            return false;  // Insufficient funds or invalid amount
        }
    }

    class Program
    {
        // Draws a title with a border using ASCII styling
        static void DrawBorder(string title)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            string titleFormatted = FiggleFonts.Small.Render(title).TrimEnd();
            int borderLength = titleFormatted.Split('\n')[0].Length;
            Console.WriteLine(new string('=', borderLength));  // Top border
            Console.WriteLine(titleFormatted);  // ASCII-styled title
            Console.WriteLine(new string('=', borderLength));  // Bottom border
            Console.ResetColor();
        }

        // Displays the welcome screen with ASCII text
        static void ShowWelcomeScreen()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine(FiggleFonts.Small.Render("ATM System"));
            Console.ResetColor();
            Console.WriteLine("\nPress Enter to continue...");
            Console.ReadLine();
        }

        // Displays ATM menu options
        static void DisplayMenu()
        {
            DrawBorder("ATM MENU");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("1. Check Balance\n2. Deposit Money\n3. Withdraw Money\n4. Exit");
            Console.ResetColor();
            Console.Write("\nChoose an option: ");
        }

        // Handles user transactions within the ATM system
        static void ProcessATM(User user, BankAccount account)
        {
            string choice;
            do
            {
                DisplayMenu();
                choice = Console.ReadLine()?.Trim();

                // Uses switch expression for efficient title rendering
                DrawBorder(choice switch
                {
                    "1" => "Check Balance",
                    "2" => "Deposit Money",
                    "3" => "Withdraw Money",
                    "4" => "Thank You!",
                    _ => "Invalid Option"
                });

                switch (choice)
                {
                    case "1":  // Check balance
                        Console.WriteLine($"Hello {user.Name}, Your current balance is: ${account.Balance}");
                        break;

                    case "2":  // Deposit money
                        Console.Write("Enter amount to deposit: ");
                        if (double.TryParse(Console.ReadLine(), out double deposit) && deposit > 0)
                        {
                            account.Deposit(deposit);
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine($"Successfully deposited ${deposit}. New Balance: ${account.Balance}");
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Invalid deposit amount.");
                        }
                        Console.ResetColor();
                        break;

                    case "3":  // Withdraw money
                        Console.Write("Enter amount to withdraw: ");
                        if (double.TryParse(Console.ReadLine(), out double withdraw) && withdraw > 0 && account.Withdraw(withdraw))
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine($"Successfully withdrew ${withdraw}. Remaining Balance: ${account.Balance}");
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Invalid withdrawal amount or insufficient funds.");
                        }
                        Console.ResetColor();
                        break;

                    case "4":  // Exit ATM
                        Console.WriteLine("Have a great day!");
                        break;

                    default:  // Handle invalid menu input
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Invalid option, please try again.");
                        Console.ResetColor();
                        break;
                }

                Console.WriteLine("\nPress Enter to continue...");
                Console.ReadLine();
            } while (choice != "4");  // Keep running until user chooses to exit
        }

        // Main entry point of the program
        static void Main(string[] args)
        {
            try
            {
                ShowWelcomeScreen();
                DrawBorder("User Authentication");

                // Ensure a valid user name is entered
                string name;
                do
                {
                    Console.Write("Enter your name: ");
                    name = Console.ReadLine()?.Trim();
                    if (string.IsNullOrWhiteSpace(name))
                        Console.WriteLine("Name cannot be empty. Please enter a valid name.");
                } while (string.IsNullOrWhiteSpace(name));

                // Ensure a valid account number is entered
                string accountNumber;
                do
                {
                    Console.Write("Enter your account number: ");
                    accountNumber = Console.ReadLine()?.Trim();
                    if (string.IsNullOrWhiteSpace(accountNumber))
                        Console.WriteLine("Account number cannot be empty. Please enter a valid account number.");
                } while (string.IsNullOrWhiteSpace(accountNumber));

                // Create user and account with an initial balance of $500
                User user = new() { Name = name, AccountNumber = accountNumber };
                BankAccount account = new(500.00);

                // Start ATM processing
                ProcessATM(user, account);
            }
            catch (Exception ex)
            {
                // Handle unexpected errors
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"\nError: {ex.Message}");
                Console.ResetColor();
            }
            finally
            {
                // Ensure program waits before exiting
                Console.WriteLine("\nPress any key to exit...");
                Console.ReadKey();
            }
        }
    }
}
