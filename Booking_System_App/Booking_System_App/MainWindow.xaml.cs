using System.Collections.ObjectModel;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Booking_System_App
{
    /// <summary>
    /// Main window displaying the list of rooms and booking interface.
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<Room> Rooms { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            Rooms = new ObservableCollection<Room>(RoomService.GetDefaultRooms());
            RoomListView.ItemsSource = Rooms; // Bind room list to ListView
        }

        /// <summary>
        /// Opens the booking window and hides the main window temporarily.
        /// </summary>
        private void OpenBookingWindow_Click(object sender, RoutedEventArgs e)
        {
            var bookingWindow = new BookingWindow(Rooms, this);
            bookingWindow.ShowDialog(); // Modal behavior
        }

        /// <summary>
        /// Refreshes the room list view to reflect status changes.
        /// </summary>
        public void RefreshRoomList()
        {
            RoomListView.Items.Refresh();
        }
    }
}