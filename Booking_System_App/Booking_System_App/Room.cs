using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking_System_App
{
    public class Room : INotifyPropertyChanged
    {
        public int RoomNumber { get; set; }
        public string RoomType { get; set; }

        private RoomStatus status;
        public RoomStatus Status
        {
            get => status;
            set
            {
                if (status != value)
                {
                    status = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Status)));
                }
            }
        }

        public decimal PricePerNight { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}