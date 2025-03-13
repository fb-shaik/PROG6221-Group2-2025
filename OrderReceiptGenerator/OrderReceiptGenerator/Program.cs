using System;
using System.Text;

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
            //continues to prompt should an invalid value be captured
            while (true)
            { //loop body
                //reads the input as a string & attempt to parse it into an integer
                string input = Console.ReadLine();

                //int.TryParse method attempts to parse the string 
                //used along with the decision structure to valid the input
                if (int.TryParse(input, out age))
                {
                    break; //exit the loop if the input is valid
                }
                else
                {
                    //letting the user know that they had captured a non valid value
                    Console.WriteLine("Please enter a valid age (numerical value):");
                }
            }
            //Using string interpolation to construct & display a msg that combines both name & 
            //age input captured $"Sting statement {variable name} " 
            Console.WriteLine($"Hello, {name}! You are {age} years old!");



           
        }
    }
}
