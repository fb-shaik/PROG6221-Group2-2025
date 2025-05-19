namespace Health_Fitness_Tracker_App
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnSaveChanges = new Button();
            dtpDate = new DateTimePicker();
            txtWater = new TextBox();
            txtSteps = new TextBox();
            txtCalories = new TextBox();
            lblDate = new Label();
            lblWater = new Label();
            lblSteps = new Label();
            lblCalories = new Label();
            lblTitle = new Label();
            SuspendLayout();
            // 
            // btnSaveChanges
            // 
            btnSaveChanges.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSaveChanges.Location = new Point(233, 373);
            btnSaveChanges.Name = "btnSaveChanges";
            btnSaveChanges.Size = new Size(163, 34);
            btnSaveChanges.TabIndex = 17;
            btnSaveChanges.Text = "Save Changes";
            btnSaveChanges.UseVisualStyleBackColor = true;
            btnSaveChanges.Click += btnSaveChanges_Click;
            // 
            // dtpDate
            // 
            dtpDate.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dtpDate.Location = new Point(190, 292);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(300, 31);
            dtpDate.TabIndex = 16;
            // 
            // txtWater
            // 
            txtWater.Location = new Point(190, 234);
            txtWater.Name = "txtWater";
            txtWater.Size = new Size(150, 31);
            txtWater.TabIndex = 15;
            // 
            // txtSteps
            // 
            txtSteps.Location = new Point(190, 183);
            txtSteps.Name = "txtSteps";
            txtSteps.Size = new Size(150, 31);
            txtSteps.TabIndex = 14;
            // 
            // txtCalories
            // 
            txtCalories.Location = new Point(190, 128);
            txtCalories.Name = "txtCalories";
            txtCalories.Size = new Size(150, 31);
            txtCalories.TabIndex = 13;
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDate.Location = new Point(100, 292);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(60, 25);
            lblDate.TabIndex = 12;
            lblDate.Text = "Date: ";
            // 
            // lblWater
            // 
            lblWater.AutoSize = true;
            lblWater.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblWater.Location = new Point(96, 234);
            lblWater.Name = "lblWater";
            lblWater.Size = new Size(66, 25);
            lblWater.TabIndex = 11;
            lblWater.Text = "Water:";
            // 
            // lblSteps
            // 
            lblSteps.AutoSize = true;
            lblSteps.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSteps.Location = new Point(99, 183);
            lblSteps.Name = "lblSteps";
            lblSteps.Size = new Size(61, 25);
            lblSteps.TabIndex = 10;
            lblSteps.Text = "Steps:";
            // 
            // lblCalories
            // 
            lblCalories.AutoSize = true;
            lblCalories.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCalories.Location = new Point(96, 128);
            lblCalories.Name = "lblCalories";
            lblCalories.Size = new Size(87, 25);
            lblCalories.TabIndex = 9;
            lblCalories.Text = "Calories: ";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI Black", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = SystemColors.HotTrack;
            lblTitle.Location = new Point(190, 49);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(179, 28);
            lblTitle.TabIndex = 18;
            lblTitle.Text = "Edit Entry Screen";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(625, 487);
            Controls.Add(lblTitle);
            Controls.Add(btnSaveChanges);
            Controls.Add(dtpDate);
            Controls.Add(txtWater);
            Controls.Add(txtSteps);
            Controls.Add(txtCalories);
            Controls.Add(lblDate);
            Controls.Add(lblWater);
            Controls.Add(lblSteps);
            Controls.Add(lblCalories);
            Name = "Form2";
            Text = "Edit Entry";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSaveChanges;
        private DateTimePicker dtpDate;
        private TextBox txtWater;
        private TextBox txtSteps;
        private TextBox txtCalories;
        private Label lblDate;
        private Label lblWater;
        private Label lblSteps;
        private Label lblCalories;
        private Label lblTitle;
    }
}