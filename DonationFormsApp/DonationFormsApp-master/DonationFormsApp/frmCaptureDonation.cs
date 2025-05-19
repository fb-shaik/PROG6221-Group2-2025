using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace DonationFormsApp
{
    public partial class frmCaptureDonation : Form
    {
        public frmCaptureDonation()
        {
            InitializeComponent();
        }

        private void frmCaptureDonation_Load(object sender, EventArgs e)
        {
            List<string> donorNames = new List<string>();
            foreach (Donor donor in ListUtil.donorList)
            {
                donorNames.Add(donor.Name);
            }
            
            cmbDonor.DataSource = donorNames;
        }

        private void btnCaptueDonation_Click(object sender, EventArgs e)
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
            
            Donation donation = new(ListUtil.donations.Count, Convert.ToDouble(txbAmount.Text), 
                                    txbCause.Text, currentDonorId);

            ListUtil.donations.Add(donation);

            MessageBox.Show("Donation Added");

            this.Close();
        }


    }
}
