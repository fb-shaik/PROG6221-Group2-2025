using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelPlannerApp
{
    public class DIYTravelPlan : TravelPlan
    {
        public DIYTravelPlan(double budget) : base(budget) { }

        public override double CalculateSavings()
        {
            double total = Expenses.Sum(e => e.Cost);
            return Budget - total;
        }
    }
}
