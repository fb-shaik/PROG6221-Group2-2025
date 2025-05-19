namespace DonationFormsApp
{
    public partial class frmWelcome : Form
    {
        public frmWelcome()
        {
            InitializeComponent();
            ListUtil.PopulateLists();
        }

        private void btnAddDonor_Click(object sender, EventArgs e)
        {
            frmAddDonor addDonor= new frmAddDonor();
            this.Hide();
            addDonor.ShowDialog();
            this.Show();            
        }

        private void btnCaptureDonation_Click(object sender, EventArgs e)
        {
            frmCaptureDonation captureDonation = new frmCaptureDonation();
            this.Hide();
            captureDonation.ShowDialog();
            this.Show();
        }

        private void btnDonorReport_Click(object sender, EventArgs e)
        {
            frmDonorReport donorReport = new frmDonorReport();
            this.Hide();
            donorReport.ShowDialog();
            this.Show();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }
    }
}