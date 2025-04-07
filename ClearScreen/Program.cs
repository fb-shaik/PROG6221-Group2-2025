namespace ClearScreen
{

    class Program
    {
        static void Main(string[] args)
        {
            // Initial screen
            Console.WriteLine("Welcome to My Console App!");
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();

            // Clear the console before displaying the next screen
            Console.Clear();

            // Second screen
            Console.WriteLine("This is the second screen.");
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }

}
