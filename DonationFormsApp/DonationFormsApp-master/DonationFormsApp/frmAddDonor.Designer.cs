namespace DonationFormsApp
{
    partial class frmAddDonor
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
            this.txbName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.txbSurname = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txbPhone = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txbEmail = new System.Windows.Forms.TextBox();
            this.btnAddDonor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txbName
            // 
            this.txbName.Location = new System.Drawing.Point(125, 32);
            this.txbName.Name = "txbName";
            this.txbName.Size = new System.Drawing.Size(145, 23);
            this.txbName.TabIndex = 0;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(35, 35);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(39, 15);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name";
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Location = new System.Drawing.Point(35, 64);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(54, 15);
            this.lblSurname.TabIndex = 3;
            this.lblSurname.Text = "Surname";
            // 
            // txbSurname
            // 
            this.txbSurname.Location = new System.Drawing.Point(125, 61);
            this.txbSurname.Name = "txbSurname";
            this.txbSurname.Size = new System.Drawing.Size(145, 23);
            this.txbSurname.TabIndex = 2;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(35, 93);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(41, 15);
            this.lblPhone.TabIndex = 5;
            this.lblPhone.Text = "Phone";
            // 
            // txbPhone
            // 
            this.txbPhone.Location = new System.Drawing.Point(125, 90);
            this.txbPhone.Name = "txbPhone";
            this.txbPhone.Size = new System.Drawing.Size(145, 23);
            this.txbPhone.TabIndex = 4;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(35, 122);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(36, 15);
            this.lblEmail.TabIndex = 7;
            this.lblEmail.Text = "Email";
            // 
            // txbEmail
            // 
            this.txbEmail.Location = new System.Drawing.Point(125, 119);
            this.txbEmail.Name = "txbEmail";
            this.txbEmail.Size = new System.Drawing.Size(145, 23);
            this.txbEmail.TabIndex = 6;
            // 
            // btnAddDonor
            // 
            this.btnAddDonor.Location = new System.Drawing.Point(35, 158);
            this.btnAddDonor.Name = "btnAddDonor";
            this.btnAddDonor.Size = new System.Drawing.Size(235, 23);
            this.btnAddDonor.TabIndex = 8;
            this.btnAddDonor.Text = "Add Donor";
            this.btnAddDonor.UseVisualStyleBackColor = true;
            this.btnAddDonor.Click += new System.EventHandler(this.btnAddDonor_Click);
            // 
            // frmAddDonor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 276);
            this.Controls.Add(this.btnAddDonor);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txbEmail);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.txbPhone);
            this.Controls.Add(this.lblSurname);
            this.Controls.Add(this.txbSurname);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txbName);
            this.Name = "frmAddDonor";
            this.Text = "Add a Donor";            
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txbName;
        private Label lblName;
        private Label lblSurname;
        private TextBox txbSurname;
        private Label lblPhone;
        private TextBox txbPhone;
        private Label lblEmail;
        private TextBox txbEmail;
        private Button btnAddDonor;
    }
}