namespace DonationFormsApp
{
    partial class frmCaptureDonation
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
            this.btnCaptueDonation = new System.Windows.Forms.Button();
            this.lblCause = new System.Windows.Forms.Label();
            this.txbCause = new System.Windows.Forms.TextBox();
            this.lblAmount = new System.Windows.Forms.Label();
            this.txbAmount = new System.Windows.Forms.TextBox();
            this.lblDonor = new System.Windows.Forms.Label();
            this.cmbDonor = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnCaptueDonation
            // 
            this.btnCaptueDonation.Location = new System.Drawing.Point(31, 130);
            this.btnCaptueDonation.Name = "btnCaptueDonation";
            this.btnCaptueDonation.Size = new System.Drawing.Size(235, 23);
            this.btnCaptueDonation.TabIndex = 17;
            this.btnCaptueDonation.Text = "Capture Donation";
            this.btnCaptueDonation.UseVisualStyleBackColor = true;
            this.btnCaptueDonation.Click += new System.EventHandler(this.btnCaptueDonation_Click);
            // 
            // lblCause
            // 
            this.lblCause.AutoSize = true;
            this.lblCause.Location = new System.Drawing.Point(31, 94);
            this.lblCause.Name = "lblCause";
            this.lblCause.Size = new System.Drawing.Size(39, 15);
            this.lblCause.TabIndex = 14;
            this.lblCause.Text = "Cause";
            // 
            // txbCause
            // 
            this.txbCause.Location = new System.Drawing.Point(121, 91);
            this.txbCause.Name = "txbCause";
            this.txbCause.Size = new System.Drawing.Size(145, 23);
            this.txbCause.TabIndex = 13;
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(31, 65);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(51, 15);
            this.lblAmount.TabIndex = 12;
            this.lblAmount.Text = "Amount";
            // 
            // txbAmount
            // 
            this.txbAmount.Location = new System.Drawing.Point(121, 62);
            this.txbAmount.Name = "txbAmount";
            this.txbAmount.Size = new System.Drawing.Size(145, 23);
            this.txbAmount.TabIndex = 11;
            // 
            // lblDonor
            // 
            this.lblDonor.AutoSize = true;
            this.lblDonor.Location = new System.Drawing.Point(31, 36);
            this.lblDonor.Name = "lblDonor";
            this.lblDonor.Size = new System.Drawing.Size(40, 15);
            this.lblDonor.TabIndex = 10;
            this.lblDonor.Text = "Donor";
            // 
            // cmbDonor
            // 
            this.cmbDonor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDonor.FormattingEnabled = true;
            this.cmbDonor.Location = new System.Drawing.Point(121, 33);
            this.cmbDonor.Name = "cmbDonor";
            this.cmbDonor.Size = new System.Drawing.Size(145, 23);
            this.cmbDonor.TabIndex = 18;
            // 
            // frmCaptureDonation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 276);
            this.Controls.Add(this.cmbDonor);
            this.Controls.Add(this.btnCaptueDonation);
            this.Controls.Add(this.lblCause);
            this.Controls.Add(this.txbCause);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.txbAmount);
            this.Controls.Add(this.lblDonor);
            this.Name = "frmCaptureDonation";
            this.Text = "Capture a Donation";
            this.Load += new System.EventHandler(this.frmCaptureDonation_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnCaptueDonation;
        private Label lblCause;
        private TextBox txbCause;
        private Label lblAmount;
        private TextBox txbAmount;
        private Label lblDonor;
        private ComboBox cmbDonor;
    }
}