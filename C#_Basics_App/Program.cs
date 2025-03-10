namespace C__Basics_App;
using System;

class Program
{
    static void Main(string[] args)
    {
        // Welcome message
        Console.WriteLine("Welcome to the C# Learning Console Application!");
        Console.WriteLine("This application will teach you about sequence, decisions, and loops in programming.");
        Console.WriteLine("Let's start with sequences.\n");

        // Sequence Section
        // Explanation of sequence
        Console.WriteLine("Sequence in programming refers to the order in which instructions are executed.");
        // Example: Displaying numbers from 1 to 5
        Console.WriteLine("Example: Displaying numbers from 1 to 5 in sequence.");
        for (int i = 1; i <= 5; i++)
        {
            Console.WriteLine(i);
        }
        // Prompt user for a sequence of characters
        Console.WriteLine("Now, try entering a sequence of any five characters:");
        for (int i = 0; i < 5; i++)
        {
            // Read user input character by character and display
            char userChar = Console.ReadKey().KeyChar;
            Console.WriteLine($"\nYou entered: {userChar}");
        }

        // Decisions Section
        // Explanation of decisions
        Console.WriteLine("\nNext, we'll learn about decisions using if, else if, and else statements.");
        // Prompt user to choose weather condition
        Console.WriteLine("Imagine you're choosing what to wear based on the weather.");
        Console.WriteLine("Enter 'sunny', 'rainy', or 'snowy':");
        string weather = Console.ReadLine();
        // Decision-making based on weather input
        if (weather == "sunny")
        {
            Console.WriteLine("Wear a t-shirt and sunglasses!");
        }
        else if (weather == "rainy")
        {
            Console.WriteLine("Don't forget your umbrella and a raincoat!");
        }
        else if (weather == "snowy")
        {
            Console.WriteLine("You'll need a warm coat and gloves.");
        }
        else
        {
            // Default message for invalid input
            Console.WriteLine("Sorry, I don't have advice for that weather.");
        }

        // Loops Section
        // Explanation of loops
        Console.WriteLine("\nFinally, let's explore loops. Loops allow us to repeat actions easily.");
        // Example: Counting from 1 to a number chosen by the user
        Console.WriteLine("For example, we'll count from 1 to a number you choose.");
        Console.WriteLine("Please enter a number:");
        int userNumber;
        // Validate user input to ensure it's a positive number
        while (!int.TryParse(Console.ReadLine(), out userNumber) || userNumber < 1)
        {
            Console.WriteLine("Please enter a valid positive number:");
        }
        // Counting from 1 to the user-specified number
        Console.WriteLine($"Counting to {userNumber}:");
        for (int i = 1; i <= userNumber; i++)
        {
            Console.WriteLine(i);
        }

        // Conclusion
        Console.WriteLine("Congratulations! You've completed the basic introduction to sequence, decisions, and loops in C#.");
    }
}
