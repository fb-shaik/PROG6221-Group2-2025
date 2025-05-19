using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Health_Fitness_Tracker_App
{
    public partial class Form2 : Form
    {
        //allow this form to accept objects for the Health Entry class
        public HealthEntry UpdatedEntry { get; set; }

        public Form2(HealthEntry entry)
        {
            InitializeComponent();

            //populate the fields with the selected entry from Form1
            txtCalories.Text = entry.Calories.ToString();
            txtSteps.Text = entry.Steps.ToString();
            txtWater.Text = entry.Water.ToString();
            dtpDate.Value = entry.Date;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate and set new values
                if (!int.TryParse(txtCalories.Text, out int calories) || calories < 0)
                {
                    MessageBox.Show("Calories must be a non-negative number.");
                    return;
                }

                if (!int.TryParse(txtSteps.Text, out int steps) || steps < 0)
                {
                    MessageBox.Show("Steps must be a non-negative number.");
                    return;
                }

                if (!double.TryParse(txtWater.Text, out double water) || water < 0)
                {
                    MessageBox.Show("Water must be a non-negative number.");
                    return;
                }

                // Create new entry with updated values
                UpdatedEntry = new HealthEntry
                {
                    Date = dtpDate.Value.Date,
                    Calories = calories,
                    Steps = steps,
                    Water = water
                };

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving changes: " + ex.Message);
            }
        }
    }
    }

