using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NPL_ChatApp_WPF
{
    // Generic class for activity logging
    public class ActivityLog<T>
    {
        private List<T> logs = new List<T>();

        public void Log(T item)
        {
            logs.Add(item);
        }

        public List<T> GetLogs()
        {
            return new List<T>(logs); // Return a copy to preserve encapsulation
        }
    }
}
