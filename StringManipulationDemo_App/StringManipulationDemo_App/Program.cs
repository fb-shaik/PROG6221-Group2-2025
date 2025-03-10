namespace StringManipulationDemo_App
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine() method: Outputs text to the console followed by a newline character.
            // This method is often used to display a string or other data followed by moving the cursor to a new line.
            Console.WriteLine("Example 1: String Interpolation");

            // Prompting the user to enter their name. The input cursor will be on the next line.
            Console.WriteLine("Enter your name: ");

            // Console.ReadLine() method: Reads a line of characters from the console input stream and returns it as a string.
            // This method reads the input until the Enter key is pressed.
            string name = Console.ReadLine();

            // Prompting the user to enter their age with the cursor on the next line.
            Console.WriteLine("Enter your age: ");
            int age;

            // A while loop to ensure the age entered is a valid integer.
            // This loop will continue to prompt the user until a valid integer is input.
            while (true)
            {
                // Reading the input as a string to attempt parsing it into an integer.
                string input = Console.ReadLine();

                // int.TryParse method attempts to parse the string as an integer.
                // It returns 'true' if successful and 'false' otherwise, assigning the parsed integer to 'age' if successful.
                if (int.TryParse(input, out age))
                {
                    break; // Exit the loop if the input is a valid integer.
                }
                else
                {
                    // Informing the user of the invalid input and prompting for a valid numerical value.
                    // The cursor will move to a new line after this text.
                    Console.WriteLine("Please enter a valid age (numerical value):");
                }
            }

            // Using string interpolation to construct and display a message incorporating the user's name and age.
            // String interpolation: ($ {variable});
            Console.WriteLine($"Hello, {name}! You are {age} years old.");

            // Prompt to press any key to exit to prevent the console from closing immediately.
            // This allows the user to see the output before the program ends.
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();

            // Console.ReadKey() method: Obtains the next character or function key pressed by the user.
            // The pressed key is displayed in the console window, and the program does not continue until a key is pressed.
        }
    }
}
