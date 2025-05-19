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

namespace WPF_Demo_App
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ButtonAddName_Click(object sender, RoutedEventArgs e)
        {
            //Make sure that the text box contains a name
            //Validate that the name entered does not exist in the list already
            //Add name to the list box

            if (!string.IsNullOrWhiteSpace(txtName.Text))
            {
                if (!lstNames.Items.Contains(txtName.Text))
                {
                    lstNames.Items.Add(txtName.Text);
                    txtName.Clear();
                }
                else
                {
                    MessageBox.Show("This name already exists in the list.", "Duplicate Name", 
                        MessageBoxButton.OK, MessageBoxImage.Warning);
                }
            }
            else
            {
                MessageBox.Show("Please enter a name.", "Invalid Input", 
                    MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }
    }
}