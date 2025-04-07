namespace RestaurantReservationApp
{

    // Enum for seating preferences
    enum SeatingPreference
    {
        Indoor = 1,  // Assigning values for easy user selection
        Outdoor,
        Window
    }

    // Struct to hold reservation details
    struct Reservation
    {
        public string CustomerName; // Stores the name of the customer
        public DateTime ReservationTime; // Stores the reservation time
        public SeatingPreference Seating; // Stores the seating preference

        // Constructor to initialize reservation details
        public Reservation(string name, DateTime time, SeatingPreference seating)
        {
            CustomerName = name;
            ReservationTime = time;
            Seating = seating;
        }

        // Method to display reservation details
        public void Display()
        {
            Console.WriteLine($"   Reservation for: {CustomerName}");
            Console.WriteLine($"   Time: {ReservationTime}");
            Console.WriteLine($"   Seating: {Seating}");
            Console.WriteLine("---------------------------------");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ReservationManager manager = new ReservationManager(); // Create an instance of ReservationManager

            while (true)
            {
                Console.WriteLine("Welcome to the Restaurant Reservation System!");
                Console.WriteLine("1️.Make a Reservation");
                Console.WriteLine("2️.View Reservations");
                Console.WriteLine("3️.Exit");
                Console.Write("Enter your choice (1-3): ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        MakeReservation(manager); // Calls method to create a reservation
                        break;

                    case "2":
                        manager.DisplayReservations(); // Calls method to view reservations
                        break;

                    case "3":
                        Console.WriteLine("Exiting the system. Have a great day!");
                        return; // Ends the program

                    default:
                        Console.WriteLine("Invalid choice. Please enter 1, 2, or 3.\n");
                        break;
                }
            }
        }

        // Method to handle user input and create a reservation
        static void MakeReservation(ReservationManager manager)
        {
            Console.Write("\nEnter your name: ");
            string name = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(name))
            {
                Console.WriteLine("Name cannot be empty.\n");
                return;
            }

            Console.Write("Enter reservation time (HH:mm format, e.g., 19:30): ");
            string timeInput = Console.ReadLine();

            if (!DateTime.TryParseExact(timeInput, "HH:mm", null, System.Globalization.DateTimeStyles.None, out DateTime reservationTime))
            {
                Console.WriteLine("Invalid time format. Please enter in HH:mm format.\n");
                return;
            }

            Console.WriteLine("\nChoose your seating preference:");
            foreach (var seating in Enum.GetValues(typeof(SeatingPreference)))
            {
                Console.WriteLine($"{(int)seating}. {seating}");
            }

            Console.Write("Enter your choice (1-3): ");
            string seatingChoice = Console.ReadLine();

            if (!Enum.TryParse(typeof(SeatingPreference), seatingChoice, out object seatingResult) || !Enum.IsDefined(typeof(SeatingPreference), seatingResult))
            {
                Console.WriteLine("Invalid seating choice. Please select from the available options.\n");
                return;
            }

            SeatingPreference seatingPreference = (SeatingPreference)seatingResult;

            // Create reservation and add it
            Reservation newReservation = new Reservation(name, reservationTime, seatingPreference);
            manager.AddReservation(newReservation);
        }
    }
}