namespace TravelPlannerApp
{

    public partial class Form1 : Form
    {
        List<TravelExpense> expenseList = new List<TravelExpense>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAddExpense_Click(object sender, EventArgs e)
        {
            try
            {
                expenseList.Clear();
                lstExpenses.Items.Clear();

                expenseList.Add(new TravelExpense("Flight", double.Parse(txtFlight.Text)));
                expenseList.Add(new TravelExpense("Hotel", double.Parse(txtHotel.Text)));
                expenseList.Add(new TravelExpense("Food", double.Parse(txtFood.Text)));
                expenseList.Add(new TravelExpense("Transport", double.Parse(txtTransport.Text)));
                expenseList.Add(new TravelExpense("Insurance", double.Parse(txtInsurance.Text)));

                foreach (var exp in expenseList)
                {
                    lstExpenses.Items.Add(exp.ToString());
                }

                // Add Travel Mode info
                if (rdoGuided.Checked)
                {
                    double tourPrice = double.Parse(txtTourPrice.Text);
                    var tourExpense = new TravelExpense("Guided Tour Package", tourPrice);
                    lstExpenses.Items.Add(tourExpense.ToString());
                }
                else if (rdoDIY.Checked)
                {
                    lstExpenses.Items.Add("Mode: DIY Travel");
                }

                lblResult.Text = "Expenses added.";
            }
            catch
            {
                lblResult.Text = "Please enter valid expense amounts.";
            }
        }

        private void btnCheckBudget_Click(object sender, EventArgs e)
        {
            try
            {
                double budget = double.Parse(txtBudget.Text);
                TravelPlan plan;

                if (rdoGuided.Checked)
                {
                    double tourPrice = double.Parse(txtTourPrice.Text);
                    plan = new GuidedTourPlan(budget, tourPrice);
                }
                else
                {
                    plan = new DIYTravelPlan(budget);
                }

                foreach (var exp in expenseList)
                    plan.Expenses.Add(exp);

                double savings = plan.CalculateSavings();
                lblResult.Text = $"Remaining budget: ${savings:F2}";
            }
            catch
            {
                lblResult.Text = "Invalid input. Please check your values.";
            }
        }
    }
}