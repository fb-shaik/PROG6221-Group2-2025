using System;
using System.Collections.Generic;
using Figgle;

namespace SnackShackApp
{
    // Represents an individual snack with price and stock
    public class Snack
    {
        public string Name { get; }
        public decimal Price { get; }
        public int Stock { get; private set; }

        public Snack(string name, decimal price)
        {
            Name = name;
            Price = price;
            Stock = 0;
        }

        // Adds to current stock
        public void Restock(int amount)
        {
            Stock += amount;
        }

        // Serves one unit if available
        public bool Serve()
        {
            if (Stock > 0)
            {
                Stock--;
                return true;
            }
            return false;
        }
    }

    // Represents a single customer's order of multiple snack items
    public class CustomerOrder
    {
        public List<string> SnackNames { get; }

        public CustomerOrder(List<string> snackNames)
        {
            SnackNames = snackNames;
        }
    }

    // Main logic and data store for the app
    public class SnackShack
    {
        private Dictionary<string, Snack> snacks = new();
        private Queue<CustomerOrder> customerQueue = new();
        private int customersServed = 0;

        // Adds a new snack to the menu
        public void AddSnack(string name, decimal price)
        {
            if (snacks.ContainsKey(name))
            {
                PrintError("Snack already exists.");
                return;
            }

            snacks[name] = new Snack(name, price);
            PrintSuccess($"{name} added to the menu at R{price:F2}.");
        }

        // Displays the snack menu
        public void ShowMenu()
        {
            if (snacks.Count == 0)
            {
                PrintInfo("No snacks on the menu yet.");
                return;
            }

            Console.WriteLine("\nSnack Menu:");
            foreach (var snack in snacks.Values)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"- {snack.Name} (R{snack.Price:F2}) - {snack.Stock} in stock");
            }
            Console.ResetColor();
        }

        // Restocks a specific snack
        public void RestockSnack(string name, int amount)
        {
            if (!snacks.ContainsKey(name))
            {
                PrintError("Snack not found.");
                return;
            }

            snacks[name].Restock(amount);
            PrintSuccess($"{name} restocked. New stock: {snacks[name].Stock}");
        }

        // Takes an order with multiple snacks
        public void TakeOrder(List<string> snackNames)
        {
            foreach (var snackName in snackNames)
            {
                if (!snacks.ContainsKey(snackName))
                {
                    PrintError($"Snack '{snackName}' is not on the menu.");
                    return;
                }
            }

            customerQueue.Enqueue(new CustomerOrder(snackNames));
            PrintSuccess("Order added to the queue.");
        }

        // Serves the next customer in the queue
        public void ServeCustomer()
        {
            if (customerQueue.Count == 0)
            {
                PrintInfo("No customers in line.");
                return;
            }

            var order = customerQueue.Dequeue();
            Console.WriteLine("Serving customer...");

            decimal total = 0;
            foreach (var snackName in order.SnackNames)
            {
                var snack = snacks[snackName];
                if (snack.Serve())
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"- Served 1 {snack.Name} (R{snack.Price:F2})");
                    total += snack.Price;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"- Sorry! {snack.Name} is out of stock.");
                }
                Console.ResetColor();
            }

            customersServed++;
            Console.WriteLine($"\nCustomer served. Total: R{total:F2}");
            Console.WriteLine($"Total customers served: {customersServed}");
        }

        // Utility print methods
        private void PrintError(string msg)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("" + msg);
            Console.ResetColor();
        }

        private void PrintSuccess(string msg)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("" + msg);
            Console.ResetColor();
        }

        private void PrintInfo(string msg)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("" + msg);
            Console.ResetColor();
        }
    }

    // Main class handling UI and menu logic
    class Program
    {
        static void Main(string[] args)
        {
            SnackShack shack = new SnackShack();

            while (true)
            {
                try
                {
                    ShowHeader();

                    Console.WriteLine("What would you like to do?\n");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("1. Add snack to menu");
                    Console.WriteLine("2. Show menu");
                    Console.WriteLine("3. Restock snack");
                    Console.WriteLine("4. Take customer order");
                    Console.WriteLine("5. Serve next customer");
                    Console.WriteLine("6. Exit");
                    Console.ResetColor();

                    Console.Write("\nEnter option number: ");
                    string input = Console.ReadLine();

                    if (!int.TryParse(input, out int choice))
                    {
                        PrintError("Please enter a valid number.");
                        Pause();
                        continue;
                    }

                    switch (choice)
                    {
                        case 1:
                            ShowHeader("Add Snack");
                            Console.Write("Enter snack name: ");
                            string name = Console.ReadLine().Trim();
                            Console.Write("Enter snack price: ");
                            if (decimal.TryParse(Console.ReadLine(), out decimal price))
                            {
                                shack.AddSnack(name, price);
                            }
                            else
                            {
                                PrintError("Invalid price.");
                            }
                            break;

                        case 2:
                            ShowHeader("Snack Menu");
                            shack.ShowMenu();
                            break;

                        case 3:
                            ShowHeader("Restock Snack");
                            Console.Write("Enter snack name: ");
                            string snackName = Console.ReadLine().Trim();
                            Console.Write("Enter restock amount: ");
                            if (int.TryParse(Console.ReadLine(), out int amount))
                            {
                                shack.RestockSnack(snackName, amount);
                            }
                            else
                            {
                                PrintError("Invalid number.");
                            }
                            break;

                        case 4:
                            ShowHeader("Take Order");
                            Console.WriteLine("Enter snack names separated by commas (e.g., chips,cookies,soda):");
                            string inputOrder = Console.ReadLine().Trim();
                            var snackList = new List<string>(inputOrder.Split(',', StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries));
                            if (snackList.Count > 0)
                            {
                                shack.TakeOrder(snackList);
                            }
                            else
                            {
                                PrintError("No valid snacks entered.");
                            }
                            break;

                        case 5:
                            ShowHeader("Serve Customer");
                            shack.ServeCustomer();
                            break;

                        case 6:
                            ShowHeader("Goodbye!");
                            Console.ForegroundColor = ConsoleColor.Magenta;
                            Console.WriteLine("Thanks for visiting Snack Shack!");
                            Console.ResetColor();
                            return;

                        default:
                            PrintError("Invalid choice. Try again.");
                            break;
                    }

                    Pause();
                }
                catch (Exception ex)
                {
                    PrintError($"Something went wrong: {ex.Message}");
                    Pause();
                }
            }
        }

        // Clears screen and shows Figgle banner
        static void ShowHeader(string title = "Snack Shack")
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(FiggleFonts.Slant.Render(title));
            Console.ResetColor();
        }

        // Waits for user to press Enter before returning to main menu
        static void Pause()
        {
            Console.WriteLine("\nPress Enter to return to menu...");
            Console.ReadLine();
        }

        // Static method to show errors from Program class
        static void PrintError(string msg)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("" + msg);
            Console.ResetColor();
        }
    }
}
