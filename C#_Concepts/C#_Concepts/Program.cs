namespace C__Concepts
{
    class Program
    {
      
        static void Main(string[] args)
        {
            // Display welcome message 
            Console.WriteLine("Welcome to the C# Concept Tutorial!\n");

            // Infinite loop to keep the menu running until the user chooses to exit.
            // This pattern allows continuous interaction without restarting the program.
            while (true)
            {
                // Display menu options with numbered choices for different C# concepts
                Console.WriteLine("Choose a topic to learn about:");
                Console.WriteLine("1 - var (Implicitly Typed Variables)");
                Console.WriteLine("2 - Nullable Types");
                Console.WriteLine("3 - Anonymous Types");
                Console.WriteLine("4 - Dynamic Types");
                Console.WriteLine("5 - Value Types");
                Console.WriteLine("6 - Null Coalescing (??) Operator");
                Console.WriteLine("7 - Exit");
                Console.Write("Enter your choice: ");

                // Read user input as a string to determine which concept to explore
                string choice = Console.ReadLine();
                Console.WriteLine();

                // Switch statement to route to the appropriate method based on user selection
                // Each case corresponds to a different C# concept demonstration
                switch (choice)
                {
                    case "1":
                        LearnVarType();
                        break;
                    case "2":
                        LearnNullableTypes();
                        break;
                    case "3":
                        LearnAnonymousTypes();
                        break;
                    case "4":
                        LearnDynamicTypes();
                        break;
                    case "5":
                        LearnValueTypes();
                        break;
                    case "6":
                        LearnNullCoalescing();
                        break;
                    case "7":
                        Console.WriteLine("Thanks for learning! Goodbye");
                        return; // Exit the program by returning from the Main method
                    default:
                        // Handle invalid input with a user-friendly error message
                        Console.WriteLine("Invalid choice, please try again.\n");
                        break;
                }
            }
        }

        /// <summary>
        /// Demonstrates the 'var' keyword which enables implicit type inference by the compiler
        /// </summary>
        static void LearnVarType()
        {
            Console.WriteLine("var (Implicitly Typed Variables):");
            Console.WriteLine("The 'var' keyword lets the compiler infer the variable's type.\n");

            // Demonstrate how the compiler infers different types from initialization expressions
            var num = 10; // Compiler infers 'int' based on the literal value
            var text = "Hello"; // Compiler infers 'string' based on the string literal
            var list = new List<string> { "Apple", "Banana", "Cherry" }; // Compiler infers 'List<string>' from constructor

            // Display the types that were inferred, using GetType() to show the actual runtime type
            Console.WriteLine($"Example: var num = 10; // Type: {num.GetType()}");
            Console.WriteLine($"Example: var text = \"Hello\"; // Type: {text.GetType()}");
            Console.WriteLine($"Example: var list = new List<string> {{ \"Apple\", \"Banana\" }};");

            // Note about when to use this feature
            Console.WriteLine("Use Case: Simplifies complex type declarations.\n");
        }

        /// <summary>
        /// Demonstrates nullable value types using the '?' syntax, which allows value types to hold null
        /// </summary>
        static void LearnNullableTypes()
        {
            Console.WriteLine("Nullable Types:");
            Console.WriteLine("Nullable types allow value types (e.g., int, double) to hold 'null'.\n");

            // Declare nullable variables with the '?' syntax
            int? age = null; // A nullable integer initialized to null
            double? price = 99.99; // A nullable double with a value

            // Demonstrate how to safely work with nullable types using HasValue and Value properties
            if (age.HasValue)
            {
                // This code won't execute because age is null
                Console.WriteLine($"Age has a value: {age.Value}");
            }
            else
            {
                // This will execute since age is null
                Console.WriteLine("Age is null.");
            }

            // Demonstrate using null coalescing with nullable types
            Console.WriteLine($"Price: {price ?? 0} (Using ?? to provide default value)");

            // Note about common applications
            Console.WriteLine("Use Case: Useful for database fields or optional values.\n");
        }

        /// <summary>
        /// Demonstrates anonymous types which allow creating objects without explicitly defining a class
        /// </summary>
        static void LearnAnonymousTypes()
        {
            Console.WriteLine("Anonymous Types:");
            Console.WriteLine("Anonymous types allow you to create objects without defining a class.\n");

            // Create an object with a compiler-generated type containing Name and Age properties
            var person = new { Name = "Alice", Age = 25 };

            // Display the example code and the properties of the anonymous type
            Console.WriteLine($"Example: var person = new {{ Name = \"Alice\", Age = 25 }};");
            Console.WriteLine($"Generated: Name = {person.Name}, Age = {person.Age}");

            // Note about when anonymous types are useful
            Console.WriteLine("Use Case: Great for temporary data storage.\n");
        }

        /// <summary>
        /// Demonstrates dynamic types which bypass compile-time type checking
        /// </summary>
        static void LearnDynamicTypes()
        {
            Console.WriteLine("Dynamic Types:");
            Console.WriteLine("The 'dynamic' keyword allows a variable to change its type at runtime.\n");

            // Initialize a dynamic variable - type checking happens at runtime, not compile time
            dynamic variable = 10; // Initially an integer
            Console.WriteLine($"Initially: {variable} (Type: {variable.GetType()})");

            // Change the type of the variable at runtime - not possible with statically typed variables
            variable = "Hello"; // Now a string
            Console.WriteLine($"Now: {variable} (Type: {variable.GetType()})");

            // Note about common use cases for dynamic typing
            Console.WriteLine("Use Case: Useful when working with unknown types (e.g., JSON, COM objects).\n");
        }

        /// <summary>
        /// Demonstrates how value types store and copy their data 
        /// </summary>
        static void LearnValueTypes()
        {
            Console.WriteLine("Value Types:");
            Console.WriteLine("Value types store their data directly in memory.\n");

            // Demonstrate how value types create independent copies when assigned
            int x = 5; // Create initial value
            int y = x; // Create a completely separate copy with the same value
            x = 10;    // Modify x without affecting y

            // Show that modifying the original doesn't affect the copy
            Console.WriteLine($"int x = 5; int y = x;");
            Console.WriteLine($"Changing x to 10 does NOT change y (y = {y})");

            // Note about when value types are most appropriate
            Console.WriteLine("Use Case: Efficient for small data types (int, float, bool, char).\n");
        }

        /// <summary>
        /// Demonstrates the null coalescing operator which provides default values for null expressions
        /// </summary>
        static void LearnNullCoalescing()
        {
            Console.WriteLine("Null Coalescing (??) Operator:");
            Console.WriteLine("This operator provides a default value when a variable is null.\n");

            // Set up a nullable int with null value
            int? number = null;

            // Use the null coalescing operator to provide a default when number is null
            int result = number ?? 100; // If number is null, use 100 instead

            // Display the example code and result
            Console.WriteLine("Example: int? number = null;");
            Console.WriteLine($"Using '??', result = number ?? 100 => {result}");

            // Note about common scenarios where null coalescing is helpful
            Console.WriteLine("Use Case: Avoids null reference errors when dealing with optional values.\n");
        }
    }
}