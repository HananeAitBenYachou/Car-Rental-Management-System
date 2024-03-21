using CarRentalManagementSystem.Bookings;
using CarRentalManagementSystem.Customers;
using CarRentalManagementSystem.Returns;
using CarRentalManagementSystem.Transactions;
using CarRentalManagementSystem.Users;
using CarRentalManagementSystem.Vehicles;
using Guna.UI2.WinForms;
using System.Drawing;
using System.Windows.Forms;

namespace CarRentalManagementSystem
{
    public partial class frmHome : Form
    {
        private Guna2Button _CurrentActiveButton = new Guna2Button();
        public frmHome()
        {
            InitializeComponent();
        }

        private void _ShowForm(Guna2Button activeBtn, Form frm)
        {
            if (_CurrentActiveButton != null)
                _CurrentActiveButton.Checked = false;

            _CurrentActiveButton = activeBtn;
            _CurrentActiveButton.Checked = true;

            frm.BackColor = pnlContainer.BackColor;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;

            pnlContainer.Controls.Clear();
            pnlContainer.Controls.Add(frm);

            frm.Show();
        }

        private void btnExit_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void btnCollapse_Click(object sender, System.EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button_MouseEnter(object sender, System.EventArgs e)
        {
            ((Guna2ImageButton)sender).BackColor = ColorTranslator.FromHtml("#372E18");
        }

        private void button_MouseLeave(object sender, System.EventArgs e)
        {
            ((Guna2ImageButton)sender).BackColor = ColorTranslator.FromHtml("#FBCD08");
        }

        private void frmHome_Load(object sender, System.EventArgs e)
        {

        }

        private void btnManageUsers_Click(object sender, System.EventArgs e)
        {
            _ShowForm((Guna2Button)sender, new frmListUsers());
        }

        private void btnManageCustomers_Click(object sender, System.EventArgs e)
        {
            _ShowForm((Guna2Button)sender, new frmListCustomers());
        }

        private void btnManageBookings_Click(object sender, System.EventArgs e)
        {
            _ShowForm((Guna2Button)sender, new frmListBookings());

        }

        private void btnManageVehicles_Click(object sender, System.EventArgs e)
        {
            _ShowForm((Guna2Button)sender, new frmListVehicles());
        }

        private void btnManageTransactions_Click(object sender, System.EventArgs e)
        {
            _ShowForm((Guna2Button)sender, new frmListTransactions());
        }

        private void btnManageReturns_Click(object sender, System.EventArgs e)
        {
            _ShowForm((Guna2Button)sender, new frmListVehicleReturns());
        }

        private void btnDashboard_Click(object sender, System.EventArgs e)
        {
            //Not implemented yet !
        }

        private void btnLogout_Click(object sender, System.EventArgs e)
        {
            btnExit.PerformClick();
        }
    }
}
