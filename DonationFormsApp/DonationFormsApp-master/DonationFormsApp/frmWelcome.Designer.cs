namespace DonationFormsApp
{
    partial class frmWelcome
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
            this.btnAddDonor = new System.Windows.Forms.Button();
            this.btnCaptureDonation = new System.Windows.Forms.Button();
            this.btnDonorReport = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAddDonor
            // 
            this.btnAddDonor.Location = new System.Drawing.Point(128, 51);
            this.btnAddDonor.Name = "btnAddDonor";
            this.btnAddDonor.Size = new System.Drawing.Size(75, 23);
            this.btnAddDonor.TabIndex = 0;
            this.btnAddDonor.Text = "Add Donor";
            this.btnAddDonor.UseVisualStyleBackColor = true;
            this.btnAddDonor.Click += new System.EventHandler(this.btnAddDonor_Click);
            
            // 
            // btnCaptureDonation
            // 
            this.btnCaptureDonation.Location = new System.Drawing.Point(100, 90);
            this.btnCaptureDonation.Name = "btnCaptureDonation";
            this.btnCaptureDonation.Size = new System.Drawing.Size(127, 23);
            this.btnCaptureDonation.TabIndex = 1;
            this.btnCaptureDonation.Text = "Capture Donation";
            this.btnCaptureDonation.UseVisualStyleBackColor = true;
            this.btnCaptureDonation.Click += new System.EventHandler(this.btnCaptureDonation_Click);
            // 
            // btnDonorReport
            // 
            this.btnDonorReport.Location = new System.Drawing.Point(100, 133);
            this.btnDonorReport.Name = "btnDonorReport";
            this.btnDonorReport.Size = new System.Drawing.Size(127, 23);
            this.btnDonorReport.TabIndex = 2;
            this.btnDonorReport.Text = "Donor Report";
            this.btnDonorReport.UseVisualStyleBackColor = true;
            this.btnDonorReport.Click += new System.EventHandler(this.btnDonorReport_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(128, 176);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmWelcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 274);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnDonorReport);
            this.Controls.Add(this.btnCaptureDonation);
            this.Controls.Add(this.btnAddDonor);
            this.Name = "frmWelcome";
            this.Text = "Donation App";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnAddDonor;
        private Button btnCaptureDonation;
        private Button btnDonorReport;
        private Button btnExit;
    }
}