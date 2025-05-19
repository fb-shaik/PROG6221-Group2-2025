namespace DonationFormsApp
{
    partial class frmDonorReport
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
            this.cmbDonor = new System.Windows.Forms.ComboBox();
            this.lblDonor = new System.Windows.Forms.Label();
            this.btnGenerateReport = new System.Windows.Forms.Button();
            this.lstDonationReport = new System.Windows.Forms.ListBox();
            this.dtaDonationReport = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtaDonationReport)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbDonor
            // 
            this.cmbDonor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDonor.FormattingEnabled = true;
            this.cmbDonor.Location = new System.Drawing.Point(127, 24);
            this.cmbDonor.Name = "cmbDonor";
            this.cmbDonor.Size = new System.Drawing.Size(251, 23);
            this.cmbDonor.TabIndex = 20;
            // 
            // lblDonor
            // 
            this.lblDonor.AutoSize = true;
            this.lblDonor.Location = new System.Drawing.Point(25, 27);
            this.lblDonor.Name = "lblDonor";
            this.lblDonor.Size = new System.Drawing.Size(40, 15);
            this.lblDonor.TabIndex = 19;
            this.lblDonor.Text = "Donor";
            // 
            // btnGenerateReport
            // 
            this.btnGenerateReport.Location = new System.Drawing.Point(424, 24);
            this.btnGenerateReport.Name = "btnGenerateReport";
            this.btnGenerateReport.Size = new System.Drawing.Size(110, 23);
            this.btnGenerateReport.TabIndex = 21;
            this.btnGenerateReport.Text = "Generate Report";
            this.btnGenerateReport.UseVisualStyleBackColor = true;
            this.btnGenerateReport.Click += new System.EventHandler(this.btnGenerateReport_Click);
            // 
            // lstDonationReport
            // 
            this.lstDonationReport.FormattingEnabled = true;
            this.lstDonationReport.ItemHeight = 15;
            this.lstDonationReport.Location = new System.Drawing.Point(25, 73);
            this.lstDonationReport.Name = "lstDonationReport";
            this.lstDonationReport.Size = new System.Drawing.Size(509, 139);
            this.lstDonationReport.TabIndex = 22;
            // 
            // dtaDonationReport
            // 
            this.dtaDonationReport.AllowUserToAddRows = false;
            this.dtaDonationReport.AllowUserToDeleteRows = false;
            this.dtaDonationReport.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dtaDonationReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtaDonationReport.Location = new System.Drawing.Point(25, 224);
            this.dtaDonationReport.Name = "dtaDonationReport";
            this.dtaDonationReport.ReadOnly = true;
            this.dtaDonationReport.RowHeadersVisible = false;
            this.dtaDonationReport.RowTemplate.Height = 25;
            this.dtaDonationReport.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtaDonationReport.ShowEditingIcon = false;
            this.dtaDonationReport.Size = new System.Drawing.Size(509, 150);
            this.dtaDonationReport.TabIndex = 23;
            // 
            // frmDonorReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 400);
            this.Controls.Add(this.dtaDonationReport);
            this.Controls.Add(this.lstDonationReport);
            this.Controls.Add(this.btnGenerateReport);
            this.Controls.Add(this.cmbDonor);
            this.Controls.Add(this.lblDonor);
            this.Name = "frmDonorReport";
            this.Text = "Donor Report";
            this.Load += new System.EventHandler(this.frmDonorReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtaDonationReport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox cmbDonor;
        private Label lblDonor;
        private Button btnGenerateReport;
        private ListBox lstDonationReport;
        private DataGridView dtaDonationReport;
    }
}