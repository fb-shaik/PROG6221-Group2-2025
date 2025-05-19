namespace Health_Fitness_Tracker_App
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtCalories = new TextBox();
            txtSteps = new TextBox();
            txtWater = new TextBox();
            dtpDate = new DateTimePicker();
            btnSubmit = new Button();
            lstSummary = new ListBox();
            btnViewDetails = new Button();
            label5 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(64, 61);
            label1.Name = "label1";
            label1.Size = new Size(87, 25);
            label1.TabIndex = 0;
            label1.Text = "Calories: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(67, 116);
            label2.Name = "label2";
            label2.Size = new Size(61, 25);
            label2.TabIndex = 1;
            label2.Text = "Steps:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(64, 167);
            label3.Name = "label3";
            label3.Size = new Size(66, 25);
            label3.TabIndex = 2;
            label3.Text = "Water:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(68, 225);
            label4.Name = "label4";
            label4.Size = new Size(60, 25);
            label4.TabIndex = 3;
            label4.Text = "Date: ";
            // 
            // txtCalories
            // 
            txtCalories.Location = new Point(158, 61);
            txtCalories.Name = "txtCalories";
            txtCalories.Size = new Size(150, 31);
            txtCalories.TabIndex = 4;
            // 
            // txtSteps
            // 
            txtSteps.Location = new Point(158, 116);
            txtSteps.Name = "txtSteps";
            txtSteps.Size = new Size(150, 31);
            txtSteps.TabIndex = 5;
            // 
            // txtWater
            // 
            txtWater.Location = new Point(158, 167);
            txtWater.Name = "txtWater";
            txtWater.Size = new Size(150, 31);
            txtWater.TabIndex = 6;
            // 
            // dtpDate
            // 
            dtpDate.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dtpDate.Location = new Point(158, 225);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(300, 31);
            dtpDate.TabIndex = 7;
            // 
            // btnSubmit
            // 
            btnSubmit.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSubmit.Location = new Point(560, 118);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(112, 34);
            btnSubmit.TabIndex = 8;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // lstSummary
            // 
            lstSummary.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lstSummary.FormattingEnabled = true;
            lstSummary.ItemHeight = 25;
            lstSummary.Location = new Point(67, 299);
            lstSummary.Name = "lstSummary";
            lstSummary.Size = new Size(544, 129);
            lstSummary.TabIndex = 9;
            // 
            // btnViewDetails
            // 
            btnViewDetails.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnViewDetails.Location = new Point(287, 469);
            btnViewDetails.Name = "btnViewDetails";
            btnViewDetails.Size = new Size(171, 34);
            btnViewDetails.TabIndex = 10;
            btnViewDetails.Text = "View Details";
            btnViewDetails.UseVisualStyleBackColor = true;
            btnViewDetails.Click += btnViewDetails_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Black", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.MenuHighlight;
            label5.Location = new Point(180, 18);
            label5.Name = "label5";
            label5.Size = new Size(378, 28);
            label5.TabIndex = 11;
            label5.Text = "HEALTH AND FITNESS TRACKER APP";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 547);
            Controls.Add(label5);
            Controls.Add(btnViewDetails);
            Controls.Add(lstSummary);
            Controls.Add(btnSubmit);
            Controls.Add(dtpDate);
            Controls.Add(txtWater);
            Controls.Add(txtSteps);
            Controls.Add(txtCalories);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Health And Fitness Tracker";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtCalories;
        private TextBox txtSteps;
        private TextBox txtWater;
        private DateTimePicker dtpDate;
        private Button btnSubmit;
        private ListBox lstSummary;
        private Button btnViewDetails;
        private Label label5;
    }
}
