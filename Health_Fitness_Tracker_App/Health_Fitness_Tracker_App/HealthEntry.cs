using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Health_Fitness_Tracker_App
{
    public class HealthEntry
    {
        // all the inputs seen on Form1.cs as fields
        public DateTime Date {  get; set; }
        public int Calories { get; set; }
        public int Steps { get; set; }

        public double Water { get; set; }


        //method over-ride for the ToString() to generate the entry seen in the listbox
        public override string ToString()
        {
            return $"{Date.ToShortDateString()} - Calories: {Calories}, Steps: {Steps}, Water: {Water}L";
        }
    }
}
