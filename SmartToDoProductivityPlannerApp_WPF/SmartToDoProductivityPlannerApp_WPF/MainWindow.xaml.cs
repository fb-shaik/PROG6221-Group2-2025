using SmartToDoProductivityPlannerApp_WPF;
using System;
using System.Collections.Generic;
using System.Windows;

namespace SmartToDoProductivityPlannerApp
{
    // Delegate that defines a method signature for tagging tasks
    public delegate string TaskTagHandler(string taskDescription);

    public partial class MainWindow : Window
    {
        // List to keep track of all tasks
        private List<TaskItem> taskList = new List<TaskItem>();

        // Maps keywords to tags (e.g., "email" - "Communication")
        private Dictionary<string, string> keywordTags;

        // Rotating list of motivational tips
        private List<string> productivityTips;

        // Random instance for selecting tips
        private Random rand = new Random();

        // Delegate instance to assign tagging logic dynamically
        private TaskTagHandler tagResolver;

        public MainWindow()
        {
            InitializeComponent();
            InitializeData();
            tagResolver = DetectTaskTag; // Assign method to delegate
        }

        // Initialize keyword dictionary and tip list
        private void InitializeData()
        {
            keywordTags = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
            {
                { "email", "Communication" },
                { "meeting", "Collaboration" },
                { "call", "Communication" },
                { "report", "Documentation" },
                { "presentation", "Documentation" },
                { "code", "Development" },
                { "test", "Testing" },
                { "review", "Feedback" },
                { "write", "Creative-work"}
            };
            productivityTips = new List<string>
            { 
                "Remeber: Done is better than perfect!",
                "Focus on one task at a time.",
                "Break tasks into smaller chunks.",
                "Set specific goals for each task.",
                "Use the Pomodoro technique: work for 25 minutes, then take a 5-minute break.",
                "Start with the hardest task first.",
            };
        }

        // Triggered when Add Task button is clicked
        private void AddTaskButton_Click(object sender, RoutedEventArgs e)
        {//validate input
            string userInput = TaskInputTextBox.Text.Trim();
            if (string.IsNullOrEmpty(userInput))
            {
                MessageBox.Show("Please enter a task description.", "Input Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            //trigger the delegate to detect the tag
            string tag = tagResolver(userInput); // Call the delegate to get the tag
            
            //create a Task object with the detected tag & add the task to the list
            TaskItem newTask = new TaskItem
            {
                Description = userInput,
                Tag = tag,
                Timestamp = DateTime.Now,
                isCompleted = false
            };
            taskList.Add(newTask);
            RefreshTaskList(); // Refresh the display list

            //Random tip selection for display after evry 3rd task captured
            if (taskList.Count % 3 == 0)
            {
                int randomIndex = rand.Next(productivityTips.Count);
                string randomTip = productivityTips[randomIndex];
                DisplayMessage(randomTip); // Display a random tip
            }
            TaskInputTextBox.Clear(); // Clear the input box after adding a task

        }

        // Detects a tag based on keywords
        private string DetectTaskTag(string input)
        {
            foreach (var keyword in keywordTags.Keys)
            {
                if (input.Contains(keyword, StringComparison.OrdinalIgnoreCase))
                {
                    return keywordTags[keyword]; // Return the corresponding tag
                }
            }
            return "General"; // Default tag if no keywords match
        }

        // Display system messages/tips
        private void DisplayMessage(string message)
        {
         OutputBox.Items.Add($"[Tip] {message}"); // Add message to output box
         OutputBox.ScrollIntoView(OutputBox.Items[OutputBox.Items.Count - 1]); // Scroll to the last item   
        }

        // Refreshes the list display
        private void RefreshTaskList()
        {
            TaskListBox.Items.Clear(); // Clear the current list
            foreach (var task in taskList)
            {
                TaskListBox.Items.Add(task); // Add each task to the list, calls override ToString() method
            }
        }

        // Context Menu Option: Mark as complete
        private void MarkAsComplete_Click(object sender, RoutedEventArgs e)
        {
            if (TaskListBox.SelectedItem is TaskItem selectedTask)
            {
                selectedTask.isCompleted = true; // Mark the task as completed
                RefreshTaskList(); // Refresh the display list
            }
        }

        // Context Menu Option: Delete task
        private void DeleteTask_Click(object sender, RoutedEventArgs e)
        {
            if (TaskListBox.SelectedItem is TaskItem selectedTask)
            {
                taskList.Remove(selectedTask); // Remove the selected task from the list
                RefreshTaskList(); // Refresh the display list
            }
        }

        // Context Menu Option: Edit task description
        private void EditTask_Click(object sender, RoutedEventArgs e)
        {
           if (TaskListBox.SelectedItem is TaskItem selectedTask)
            {
                string newDescription = Microsoft.VisualBasic.Interaction.InputBox("Edit Task Description:", "Edit Task", selectedTask.Description);
                if (!string.IsNullOrEmpty(newDescription))
                {
                    selectedTask.Description = newDescription; // Update the task description
                    RefreshTaskList(); // Refresh the display list
                    
                }
            }

        }

    }

}
