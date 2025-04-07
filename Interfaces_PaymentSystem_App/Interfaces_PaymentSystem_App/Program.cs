using System;

namespace Interfaces_PaymentSystem_App
{
    
    public class Program
    {
        public static void Main(string[] args)
        {
            // Infinite loop to keep the program running until the user decides to exit
            while (true)
            {
                // Display available payment options
                Console.WriteLine("\nSelect your payment option:");
                Console.WriteLine("1. Credit Card");
                Console.WriteLine("2. PayPal");
                Console.WriteLine("3. Cryptocurrency");
                Console.WriteLine("4. Exit");
                Console.Write("Enter your choice: ");

                // Capture the user's choice
                string choice = Console.ReadLine();
                IPayment paymentMethod = null;  // Interface reference to hold the selected payment method

                // Switch statement to determine which payment method the user selected
                switch (choice)
                {
                    case "1":
                        paymentMethod = new CreditCardPayment(); // Create CreditCardPayment instance
                        break;
                    case "2":
                        paymentMethod = new PayPalPayment(); // Create PayPalPayment instance
                        break;
                    case "3":
                        paymentMethod = new CryptoPayment(); // Create CryptoPayment instance
                        break;
                    case "4":
                        Console.WriteLine("Exiting the program. Good Day!"); // Exit message
                        return; // Exit the application
                    default:
                        // Handle invalid input
                        Console.WriteLine("Error: Invalid choice entered. Please try again.");
                        continue; // Restart the loop for valid input
                }

                // Prompt the user to enter the amount to pay
                Console.Write("Enter the amount to pay: ");
                if (double.TryParse(Console.ReadLine(), out double amount) && amount > 0)
                {
                    // Instantiate the PaymentProcessor with the selected payment method
                    PaymentProcessor processor = new PaymentProcessor(paymentMethod);
                    processor.ProcessPay(amount); // Process the entered payment amount
                }
                else
                {
                    // Handle invalid payment amount
                    Console.WriteLine("Error: Invalid amount entered. Please enter a positive number.");
                }
            }
        }
    }
}
