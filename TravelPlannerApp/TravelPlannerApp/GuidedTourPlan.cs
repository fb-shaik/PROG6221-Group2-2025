using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelPlannerApp
{
    public class GuidedTourPlan : TravelPlan
    {
        public double TourPrice;

        public GuidedTourPlan(double budget, double tourPrice) : base(budget)
        {
            TourPrice = tourPrice;
            Expenses.Add(new TravelExpense("Guided Tour Package", TourPrice));
        }

        public override double CalculateSavings()
        {
            double total = Expenses.Sum(e => e.Cost);
            return Budget - total;
        }
    }
}
