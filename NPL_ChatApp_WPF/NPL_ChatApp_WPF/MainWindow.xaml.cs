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

namespace NPL_ChatApp_WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private ChatProcessor processor;
        private ActivityLog<string> logger;

        public MainWindow()
        {
            InitializeComponent();

            // Initialize the chat processor with a list of keywords
            processor = new ChatProcessor(new List<string> { "deadline", "meeting", "assignment", "follow-up", "urgent", "project" });
            logger = new ActivityLog<string>();

            // Subscribe to the KeywordDetected event
            processor.KeywordDetected += Processor_KeywordDetected;

        }

        // Event handler for keyword detection
        private void Processor_KeywordDetected(object sender, string keyword)
        {
            KeywordList.Items.Add($"Keyword Detected: {keyword}");
            // Log the detected keyword
            logger.Log($"Keyword detected: {keyword}");

        }

        // Button click event to analyze the input text
        private void AnalyzeMessage_Click(object sender, RoutedEventArgs e)
        {
            string message = InputBox.Text.Trim();
            if (string.IsNullOrEmpty(message))
            {
                MessageBox.Show("Please enter a message");
                return;
            }
            try
            {
                // Analyze the message using the chat processor
                processor.Analyze(message);
                // Clear the input box after processing
                InputBox.Clear();
                //Update the activity log with the message
                UpdateLog();
            }
            catch (Exception ex)
            {
                // Show an error message if something goes wrong
                logger.Log($"Error: {ex.Message}");
                UpdateLog();
            }
        }

        //Update the UI with the activity log
        private void UpdateLog()
        {
            ActivityLogBox.Items.Clear();
            foreach (var log in logger.GetLogs())
            {
                ActivityLogBox.Items.Add(log);
            }
        }
    }
}