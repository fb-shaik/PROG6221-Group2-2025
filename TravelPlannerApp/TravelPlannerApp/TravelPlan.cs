using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelPlannerApp
{
    public abstract class TravelPlan
    {
        public double Budget;
        public List<TravelExpense> Expenses = new List<TravelExpense>();

        public TravelPlan(double budget)
        {
            Budget = budget;
        }

        public abstract double CalculateSavings();
    }
}
