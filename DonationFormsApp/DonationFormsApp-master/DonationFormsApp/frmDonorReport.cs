using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DonationFormsApp
{
    public partial class frmDonorReport : Form
    {
        public frmDonorReport()
        {
            InitializeComponent();
        }

        private void frmDonorReport_Load(object sender, EventArgs e)
        {
            // get list of emails of all donors and add to the combo box
            List<string> donorEmails = new List<string>();

            foreach (Donor don  in ListUtil.donorList)
            {
                donorEmails.Add(don.Email);
            }
            cmbDonor.DataSource = donorEmails;

            // set the listbox and datagridview source to all donations (we show all until user filters)
            lstDonationReport.DataSource = ListUtil.donations;
            dtaDonationReport.DataSource = ListUtil.donations;            
        }

        private void btnGenerateReport_Click(object sender, EventArgs e)
        {
            string selectedDonor = cmbDonor.Text;

            int currentDonorId = 0;
            foreach (Donor don in ListUtil.donorList)
            {
                if (don.Email == selectedDonor)
                {
                    currentDonorId = don.DonorId; 
                    break;
                }
            }
            
            List<Donation> filteredDonations = new List<Donation>();
            double total = 0;
            foreach (Donation donation in ListUtil.donations)
            {
                if (donation.DonorId == currentDonorId)
                {
                    filteredDonations.Add(donation);
                    total += donation.Amount;
                }                    
            }
            lstDonationReport.DataSource = filteredDonations;
            dtaDonationReport.DataSource = filteredDonations;

            MessageBox.Show("Total is R " + total);
        }
    }
}
