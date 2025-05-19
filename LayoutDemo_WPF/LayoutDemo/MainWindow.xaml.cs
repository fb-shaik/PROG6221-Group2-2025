using System.Windows;
using System.Windows.Controls;

namespace LayoutDemo
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent(); // Initializes the XAML layout
        }

        // Shared button click handler for all buttons in all layouts
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (sender is Button button)
            {
                string layoutName = GetActiveLayoutName(); // Determine which tab is active
                MessageBox.Show($"You clicked '{button.Content}' in the {layoutName} layout.",
                                "Button Click",
                                MessageBoxButton.OK,
                                MessageBoxImage.Information);
            }
        }

        // Helper to get the header text of the selected tab (layout name)
        private string GetActiveLayoutName()
        {
            if (this.Content is TabControl tabControl &&
                tabControl.SelectedItem is TabItem tabItem &&
                tabItem.Header is string header)
            {
                return header;
            }

            return "Unknown";
        }
    }
}
