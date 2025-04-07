// Define a namespace for organizing classes and interfaces
namespace Abstract_Interface_Combined_App
{
    using System; // Import the System namespace to use built-in functionalities like Console and Exception handling.

    // Define an interface for tracking capability
    interface ITrackable
    {
        void TrackLocation(); // Method to track delivery location, to be implemented by concrete classes.
    }

    // Abstract class representing a general delivery
    abstract class Delivery : ITrackable
    {
        // Properties to store order details
        public string OrderID { get; private set; } // Unique identifier for the order
        public string Destination { get; private set; } // Delivery destination

        // Constructor to initialize order details
        public Delivery(string orderId, string destination)
        {
            OrderID = orderId;
            Destination = destination;
        }

        // Abstract method that must be implemented by derived classes
        public abstract void Deliver();

        // Common method to print order details
        public void PrintOrderDetails()
        {
            Console.WriteLine($"\nOrder {OrderID} is headed to {Destination}.");
        }

        // Abstract method for tracking (Implemented by derived classes)
        public abstract void TrackLocation();
    }

    // Concrete class for bike delivery, inheriting from Delivery
    class BikeDelivery : Delivery
    {
        public BikeDelivery(string orderId, string destination) : base(orderId, destination) { }

        public override void Deliver()
        {
            Console.WriteLine($"A bike courier is delivering order {OrderID} to {Destination}.");
        }

        public override void TrackLocation()
        {
            Console.WriteLine($"Tracking: Bike delivery for {OrderID} is en route.");
        }
    }

    // Concrete class for drone delivery, inheriting from Delivery
    class DroneDelivery : Delivery
    {
        public DroneDelivery(string orderId, string destination) : base(orderId, destination) { }

        public override void Deliver()
        {
            Console.WriteLine($"A drone is autonomously delivering order {OrderID} to {Destination}.");
        }

        public override void TrackLocation()
        {
            Console.WriteLine($"Tracking: Drone delivery for {OrderID} is in the air.");
        }
    }

    // Main program class
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to the Delivery System!");

            bool continueOrdering = true;
            while (continueOrdering)
            {
                try
                {
                    string orderId = GetValidOrderId();
                    string destination = GetValidDestination();
                    Delivery deliveryOrder = GetDeliveryMethod(orderId, destination);

                    deliveryOrder.PrintOrderDetails();
                    deliveryOrder.Deliver();
                    deliveryOrder.TrackLocation();

                    Console.Write("\nWould you like to place another order? (y/n): ");
                    continueOrdering = Console.ReadLine().Trim().ToLower() == "y";
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
            }

            Console.WriteLine("\nThank you for using our delivery system! Have a great day.");
        }

        // Helper Methods for Improved Code Clarity
        static string GetValidOrderId()
        {
            while (true)
            {
                Console.Write("\nEnter Order ID (Numbers only): ");
                string input = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(input) && int.TryParse(input, out _))
                {
                    return input;
                }
                Console.WriteLine("Invalid Order ID. Please enter numeric values only.");
            }
        }

        static string GetValidDestination()
        {
            while (true)
            {
                Console.Write("Enter Destination: ");
                string input = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(input))
                {
                    return input;
                }
                Console.WriteLine("Destination cannot be empty.");
            }
        }

        static Delivery GetDeliveryMethod(string orderId, string destination)
        {
            while (true)
            {
                Console.Write("\nChoose Delivery Method (1: Bike, 2: Drone): ");
                string choice = Console.ReadLine();
                return choice switch
                {
                    "1" => new BikeDelivery(orderId, destination),
                    "2" => new DroneDelivery(orderId, destination),
                    _ => throw new ArgumentException("Invalid choice. Please enter 1 for Bike or 2 for Drone."),
                };
            }
        }
    }
}
