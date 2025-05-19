using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DonationFormsApp
{
    public partial class frmAddDonor : Form
    {
        public frmAddDonor()
        {
            InitializeComponent();
        }

        private void btnAddDonor_Click(object sender, EventArgs e)
        {
            // for you to do: Add error checking (nulls, numeric value, valid email, etc.)

            int donorId = ListUtil.donorList.Count + 1;
            string name = txbName.Text;
            string surname = txbSurname.Text;
            string phone = txbPhone.Text;
            string email = txbEmail.Text;

            Donor donor = new Donor(donorId, name, surname, phone, email);

            ListUtil.donorList.Add(donor);

            MessageBox.Show("Donor Added");

            this.Close();
        }
    }
}
