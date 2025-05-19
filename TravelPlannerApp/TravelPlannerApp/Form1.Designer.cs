namespace TravelPlannerApp
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
            lblInsurance = new Label();
            txtInsurance = new TextBox();
            grpExpenses = new GroupBox();
            txtFlight = new TextBox();
            lblFlight = new Label();
            lblTransport = new Label();
            txtHotel = new TextBox();
            txtTransport = new TextBox();
            lblFood = new Label();
            lblHotel = new Label();
            txtFood = new TextBox();
            btnAddExpense = new Button();
            txtBudget = new TextBox();
            lblBudget = new Label();
            grpMode = new GroupBox();
            txtTourPrice = new TextBox();
            lblTourPrice = new Label();
            rdoDIY = new RadioButton();
            rdoGuided = new RadioButton();
            btnCheckBudget = new Button();
            lstExpenses = new ListBox();
            lblResult = new Label();
            pictureBox1 = new PictureBox();
            grpExpenses.SuspendLayout();
            grpMode.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblInsurance
            // 
            lblInsurance.AutoSize = true;
            lblInsurance.Location = new Point(6, 204);
            lblInsurance.Name = "lblInsurance";
            lblInsurance.Size = new Size(87, 25);
            lblInsurance.TabIndex = 0;
            lblInsurance.Text = "Insurance";
            // 
            // txtInsurance
            // 
            txtInsurance.Location = new Point(98, 201);
            txtInsurance.Name = "txtInsurance";
            txtInsurance.Size = new Size(177, 31);
            txtInsurance.TabIndex = 1;
            // 
            // grpExpenses
            // 
            grpExpenses.Controls.Add(txtInsurance);
            grpExpenses.Controls.Add(txtFlight);
            grpExpenses.Controls.Add(lblInsurance);
            grpExpenses.Controls.Add(lblFlight);
            grpExpenses.Controls.Add(lblTransport);
            grpExpenses.Controls.Add(txtHotel);
            grpExpenses.Controls.Add(txtTransport);
            grpExpenses.Controls.Add(lblFood);
            grpExpenses.Controls.Add(lblHotel);
            grpExpenses.Controls.Add(txtFood);
            grpExpenses.Location = new Point(32, 137);
            grpExpenses.Name = "grpExpenses";
            grpExpenses.Size = new Size(339, 271);
            grpExpenses.TabIndex = 2;
            grpExpenses.TabStop = false;
            grpExpenses.Text = "Travel Expenses";
            // 
            // txtFlight
            // 
            txtFlight.Location = new Point(98, 43);
            txtFlight.Name = "txtFlight";
            txtFlight.Size = new Size(177, 31);
            txtFlight.TabIndex = 12;
            // 
            // lblFlight
            // 
            lblFlight.AutoSize = true;
            lblFlight.Location = new Point(6, 49);
            lblFlight.Name = "lblFlight";
            lblFlight.Size = new Size(60, 25);
            lblFlight.TabIndex = 11;
            lblFlight.Text = "Flight:";
            // 
            // lblTransport
            // 
            lblTransport.AutoSize = true;
            lblTransport.Location = new Point(6, 164);
            lblTransport.Name = "lblTransport";
            lblTransport.Size = new Size(86, 25);
            lblTransport.TabIndex = 3;
            lblTransport.Text = "Transport";
            // 
            // txtHotel
            // 
            txtHotel.Location = new Point(98, 81);
            txtHotel.Name = "txtHotel";
            txtHotel.Size = new Size(177, 31);
            txtHotel.TabIndex = 10;
            // 
            // txtTransport
            // 
            txtTransport.Location = new Point(98, 158);
            txtTransport.Name = "txtTransport";
            txtTransport.Size = new Size(177, 31);
            txtTransport.TabIndex = 6;
            // 
            // lblFood
            // 
            lblFood.AutoSize = true;
            lblFood.Location = new Point(6, 127);
            lblFood.Name = "lblFood";
            lblFood.Size = new Size(54, 25);
            lblFood.TabIndex = 5;
            lblFood.Text = "Food";
            // 
            // lblHotel
            // 
            lblHotel.AutoSize = true;
            lblHotel.Location = new Point(6, 87);
            lblHotel.Name = "lblHotel";
            lblHotel.Size = new Size(55, 25);
            lblHotel.TabIndex = 7;
            lblHotel.Text = "Hotel";
            // 
            // txtFood
            // 
            txtFood.Location = new Point(98, 121);
            txtFood.Name = "txtFood";
            txtFood.Size = new Size(177, 31);
            txtFood.TabIndex = 8;
            // 
            // btnAddExpense
            // 
            btnAddExpense.Location = new Point(153, 445);
            btnAddExpense.Name = "btnAddExpense";
            btnAddExpense.Size = new Size(177, 41);
            btnAddExpense.TabIndex = 14;
            btnAddExpense.Text = "Add Expense";
            btnAddExpense.UseVisualStyleBackColor = true;
            btnAddExpense.Click += btnAddExpense_Click;
            // 
            // txtBudget
            // 
            txtBudget.Location = new Point(198, 72);
            txtBudget.Name = "txtBudget";
            txtBudget.Size = new Size(218, 31);
            txtBudget.TabIndex = 4;
            // 
            // lblBudget
            // 
            lblBudget.AutoSize = true;
            lblBudget.Location = new Point(38, 72);
            lblBudget.Name = "lblBudget";
            lblBudget.Size = new Size(115, 25);
            lblBudget.TabIndex = 9;
            lblBudget.Text = "Total Budget:";
            // 
            // grpMode
            // 
            grpMode.Controls.Add(txtTourPrice);
            grpMode.Controls.Add(lblTourPrice);
            grpMode.Controls.Add(rdoDIY);
            grpMode.Controls.Add(rdoGuided);
            grpMode.Location = new Point(400, 153);
            grpMode.Name = "grpMode";
            grpMode.Size = new Size(348, 255);
            grpMode.TabIndex = 13;
            grpMode.TabStop = false;
            grpMode.Text = "Travel Mode";
            // 
            // txtTourPrice
            // 
            txtTourPrice.Location = new Point(111, 163);
            txtTourPrice.Name = "txtTourPrice";
            txtTourPrice.Size = new Size(177, 31);
            txtTourPrice.TabIndex = 3;
            // 
            // lblTourPrice
            // 
            lblTourPrice.AutoSize = true;
            lblTourPrice.Location = new Point(19, 166);
            lblTourPrice.Name = "lblTourPrice";
            lblTourPrice.Size = new Size(83, 25);
            lblTourPrice.TabIndex = 2;
            lblTourPrice.Text = "TourPrice";
            // 
            // rdoDIY
            // 
            rdoDIY.AutoSize = true;
            rdoDIY.Location = new Point(37, 101);
            rdoDIY.Name = "rdoDIY";
            rdoDIY.Size = new Size(65, 29);
            rdoDIY.TabIndex = 1;
            rdoDIY.TabStop = true;
            rdoDIY.Text = "DIY";
            rdoDIY.UseVisualStyleBackColor = true;
            // 
            // rdoGuided
            // 
            rdoGuided.AutoSize = true;
            rdoGuided.Location = new Point(34, 49);
            rdoGuided.Name = "rdoGuided";
            rdoGuided.Size = new Size(133, 29);
            rdoGuided.TabIndex = 0;
            rdoGuided.TabStop = true;
            rdoGuided.Text = "Guided Tour";
            rdoGuided.UseVisualStyleBackColor = true;
            // 
            // btnCheckBudget
            // 
            btnCheckBudget.Location = new Point(468, 441);
            btnCheckBudget.Name = "btnCheckBudget";
            btnCheckBudget.Size = new Size(174, 49);
            btnCheckBudget.TabIndex = 15;
            btnCheckBudget.Text = "Check Budget";
            btnCheckBudget.UseVisualStyleBackColor = true;
            btnCheckBudget.Click += btnCheckBudget_Click;
            // 
            // lstExpenses
            // 
            lstExpenses.FormattingEnabled = true;
            lstExpenses.ItemHeight = 25;
            lstExpenses.Location = new Point(128, 545);
            lstExpenses.Name = "lstExpenses";
            lstExpenses.Size = new Size(560, 204);
            lstExpenses.TabIndex = 16;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Location = new Point(311, 767);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(176, 25);
            lblResult.TabIndex = 17;
            lblResult.Text = "(for result messages)";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo;
            pictureBox1.Location = new Point(541, 22);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(220, 125);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 18;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 827);
            Controls.Add(pictureBox1);
            Controls.Add(lblResult);
            Controls.Add(lstExpenses);
            Controls.Add(btnCheckBudget);
            Controls.Add(btnAddExpense);
            Controls.Add(grpMode);
            Controls.Add(lblBudget);
            Controls.Add(txtBudget);
            Controls.Add(grpExpenses);
            Name = "Form1";
            Text = "Travel Planner App";
            Load += Form1_Load;
            grpExpenses.ResumeLayout(false);
            grpExpenses.PerformLayout();
            grpMode.ResumeLayout(false);
            grpMode.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblInsurance;
        private TextBox txtInsurance;
        private GroupBox grpExpenses;
        private TextBox txtBudget;
        private Label lblTransport;
        private TextBox txtTransport;
        private Label lblFood;
        private TextBox txtFood;
        private Label lblHotel;
        private TextBox txtHotel;
        private Label lblBudget;
        private TextBox txtFlight;
        private Label lblFlight;
        private GroupBox grpMode;
        private TextBox txtTourPrice;
        private Label lblTourPrice;
        private RadioButton rdoDIY;
        private RadioButton rdoGuided;
        private Button btnAddExpense;
        private Button btnCheckBudget;
        private ListBox lstExpenses;
        private Label lblResult;
        private PictureBox pictureBox1;
    }
}
