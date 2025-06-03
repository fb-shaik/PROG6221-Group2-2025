using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NPL_ChatApp_WPF
{

    //Delegate for keyword detection
    public delegate void KeywordDetectedEventHandler(object sender, string keyword);
    public class ChatProcessor
    {
        //create a list of type string to hold keywords, private so it can only be accessed within this class
        private List<string> _keywords;

        //Event to notify when a keyword is detected, this is based on the delegate defined above
        public event KeywordDetectedEventHandler KeywordDetected;

        public ChatProcessor(List<string> keywords) 
        { 
            _keywords = keywords ?? throw new ArgumentNullException(nameof(keywords), "Keywords cannot be null");

        }

        //Method to simulate the NPL processing of a chat message with string operations

        public void Analyze(string message)
        {
            if (string.IsNullOrWhiteSpace(message))
            {
                throw new ArgumentException("Message cannot be null or empty", nameof(message));
            }
            //Check if any keyword is present in the message
            foreach (var keyword in _keywords)
            {
                if (message.Contains(keyword, StringComparison.OrdinalIgnoreCase))
                {
                    //If a keyword is detected, raise the event
                    KeywordDetected?.Invoke(this, keyword);
                }
            }
        }


    }

}
