namespace Health_Fitness_Tracker_App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {

                //validate the input via the helper methods below
                if (!IsValidInput(txtCalories.Text, out int calories, "Calories")) return;
                if (!IsValidInput(txtSteps.Text, out int steps, "Steps")) return;
                if (!IsValidDoubleInput(txtWater.Text, out double water, "Water")) return;

                //assign the date selected on the DateTimePicker to the Date Field
                DateTime selectedDate = dtpDate.Value.Date;

                //take all of the above & assign it to a HealthEntry object
                HealthEntry entry = new HealthEntry
                {
                    Date = selectedDate,
                    Calories = calories,
                    Steps = steps,
                    Water = water,
                };

                //add the above object to the list summary box display via the ToString()
                lstSummary.Items.Add(entry);

                //clear all the text fields
                ClearFields();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unexpected Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //Clear Fields method, date remains as selected 
        private void ClearFields()
        {
            txtCalories.Clear();
            txtSteps.Clear();
            txtWater.Clear();
        }

        //Validate input (calories, steps)
        private bool IsValidInput(string input, out int result, string fieldName)
        {
            if (string.IsNullOrWhiteSpace(input))
            {
                MessageBox.Show($"{fieldName} cannot be empty.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                result = 0;
                return false;
            }

            if (!int.TryParse(input, out result) || result < 0)
            {
                MessageBox.Show($"{fieldName} must be a non-negative number.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        //Validate the Water input ...Double
        private bool IsValidDoubleInput(string input, out double result, string fieldName)
        {
            if (string.IsNullOrWhiteSpace(input))
            {
                MessageBox.Show($"{fieldName} cannot be empty.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                result = 0;
                return false;
            }

            if (!double.TryParse(input, out result) || result < 0)
            {
                MessageBox.Show($"{fieldName} must be a non-negative number.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void btnViewDetails_Click(object sender, EventArgs e)
        {
            //ensure that something is selected from the list box
            if (lstSummary.SelectedItem is HealthEntry selectedEntry)
            {
                //pass along the selected entry to the second window >>> edit the entry 
                //need to create an instance of the Form & pass along the selected item
                Form2 editForm = new Form2(selectedEntry);

                //show the second form/window dialog
                //(block off the first window until we close the second form)
                if (editForm.ShowDialog() == DialogResult.OK)
                {
                    //get updated entry from Form2
                    HealthEntry updatedEntry = editForm.UpdatedEntry;
                    //replace the entry in the list at the same index
                    int selectedIndex = lstSummary.SelectedIndex;
                    lstSummary.Items[selectedIndex] = updatedEntry;
                }
            }
            else 
            { 
                MessageBox.Show("Please select an entry to view or edit", "No Selection",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }



            //show the second form/window dialog

            //get the updated entry from Form2

            //replace the entry in the list box as well

        }
    }

}
