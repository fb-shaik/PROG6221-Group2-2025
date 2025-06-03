using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking_System_App
{
    /// <summary>
    /// Provides a static method to retrieve initial room data.
    /// </summary>
    public static class RoomService
    {
        public static List<Room> GetDefaultRooms() => new List<Room>
        {
            new Room { RoomNumber = 101, RoomType = "Single", Status = RoomStatus.Available, PricePerNight = 100 },
            new Room { RoomNumber = 102, RoomType = "Double", Status = RoomStatus.Booked, PricePerNight = 150 },
            new Room { RoomNumber = 103, RoomType = "Suite", Status = RoomStatus.Available, PricePerNight = 200 },
            new Room { RoomNumber = 104, RoomType = "Deluxe", Status = RoomStatus.Booked, PricePerNight = 250 }
        };
    }
}