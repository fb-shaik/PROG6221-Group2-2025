using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelPlannerApp
{
    public class TravelExpense
    {
        public string Name { get; set; }
        public double Cost { get; set; }

        public TravelExpense(string name, double cost)
        {
            Name = name;
            Cost = cost;
        }

        public override string ToString()
        {
            return $"{Name}: ${Cost}";
        }
    }
}