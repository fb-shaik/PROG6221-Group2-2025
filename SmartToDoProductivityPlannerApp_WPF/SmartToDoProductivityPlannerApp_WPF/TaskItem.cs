using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartToDoProductivityPlannerApp_WPF
{
    // Custom class to represent a task entry
    class TaskItem
    {
        public string Description { get; set; }
        public string Tag { get; set; }           // Tag for categorization
        public DateTime Timestamp { get; set; } // Timestamp for task creation  
        public bool isCompleted { get; set; } // Flag to indicate if task is completed  


        public override string ToString()
        {
            string status = isCompleted ? "[X]" : "[ ]"; // Display completed status
            return $"{status} [{Tag}] {Description}: {Timestamp:HH:mm})";
        }
    }

}