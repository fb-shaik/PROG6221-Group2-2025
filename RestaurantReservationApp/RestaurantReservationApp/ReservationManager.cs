using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantReservationApp
{
    // Class to handle reservation management
    class ReservationManager
    {
        private List<Reservation> reservations = new List<Reservation>(); // List to store reservations

        // Method to add a reservation
        public void AddReservation(Reservation reservation)
        {
            reservations.Add(reservation);
            Console.WriteLine("Reservation successfully added!\n");
        }

        // Method to display all reservations
        public void DisplayReservations()
        {
            if (reservations.Count == 0)
            {
                Console.WriteLine("No reservations found.\n");
                return;
            }

            Console.WriteLine("\nCurrent Reservations:");
            foreach (var reservation in reservations)
            {
                reservation.Display();
            }
        }
    }

}
