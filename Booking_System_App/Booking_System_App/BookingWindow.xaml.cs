using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;

namespace Booking_System_App
{
    /// <summary>
    /// Interaction logic for BookingWindow.xaml
    /// </summary>
    public partial class BookingWindow : Window
    {
        private ObservableCollection<Room> rooms; // Collection of room data shared with MainWindow
        private MainWindow mainWindow; // Reference to MainWindow for refreshing data

        public BookingWindow(ObservableCollection<Room> rooms, MainWindow mainWindow)
        {
            InitializeComponent();
            this.rooms = rooms;
            this.mainWindow = mainWindow;
            BookingListView.ItemsSource = rooms;

            // Initially disable action buttons until a room is selected
            BookButton.IsEnabled = false;
            CancelButton.IsEnabled = false;
        }

        /// <summary>
        /// Handles selection change in the room list to enable/disable action buttons accordingly.
        /// </summary>
        private void BookingListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (BookingListView.SelectedItem is Room selectedRoom)
            {
                // Enable or disable buttons based on the selected room's current status
                BookButton.IsEnabled = selectedRoom.Status == RoomStatus.Available;
                CancelButton.IsEnabled = selectedRoom.Status == RoomStatus.Booked;
            }
            else
            {
                BookButton.IsEnabled = false;
                CancelButton.IsEnabled = false;
            }
        }

        /// <summary>
        /// Triggered when the user clicks the Book button.
        /// Books a room only if it is currently available.
        /// </summary>
        private void BookButton_Click(object sender, RoutedEventArgs e)
        {
            if (BookingListView.SelectedItem is Room selectedRoom)
            {
                if (selectedRoom.Status == RoomStatus.Available)
                {
                    var result = MessageBox.Show(
                        $"Book Room {selectedRoom.RoomNumber}?",
                        "Confirm Booking", MessageBoxButton.YesNo);

                    if (result == MessageBoxResult.Yes)
                    {
                        selectedRoom.Status = RoomStatus.Booked;
                        mainWindow.RefreshRoomList(); // Refresh list in main window
                    }
                }
                else
                {
                    MessageBox.Show("Room is already booked.");
                }
            }
            else
            {
                MessageBox.Show("Please select a room.");
            }
        }

        /// <summary>
        /// Triggered when the user clicks the Cancel button.
        /// Cancels a booking only if the room is currently booked.
        /// </summary>
        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            if (BookingListView.SelectedItem is Room selectedRoom)
            {
                if (selectedRoom.Status == RoomStatus.Booked)
                {
                    var result = MessageBox.Show(
                        $"Cancel booking for Room {selectedRoom.RoomNumber}?",
                        "Confirm Cancellation", MessageBoxButton.YesNo);

                    if (result == MessageBoxResult.Yes)
                    {
                        selectedRoom.Status = RoomStatus.Available;
                        mainWindow.RefreshRoomList(); // Refresh list in main window
                    }
                }
                else
                {
                    MessageBox.Show("Room is not currently booked.");
                }
            }
            else
            {
                MessageBox.Show("Please select a room.");
            }
        }
    }
}