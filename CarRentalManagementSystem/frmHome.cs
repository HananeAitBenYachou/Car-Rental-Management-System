using CarRentalManagementSystem.Bookings;
using CarRentalManagementSystem.Customers;
using CarRentalManagementSystem.Reports;
using CarRentalManagementSystem.Returns;
using CarRentalManagementSystem.Transactions;
using CarRentalManagementSystem.Users;
using CarRentalManagementSystem.Vehicles;
using Guna.UI2.WinForms;
using System.Drawing;
using System.Windows.Forms;
using static CarRentalManagementSystem.Global.Global;


namespace CarRentalManagementSystem
{
    public partial class FrmHome : Form
    {
        private Guna2Button _currentActiveButton;
        private readonly FrmLogin _loginForm;

        public FrmHome(FrmLogin loginForm)
        {
            InitializeComponent();
            _loginForm = loginForm;
            _currentActiveButton = new Guna2Button();
        }

        private void ShowForm(Guna2Button activeBtn, Form frm)
        {
            if (_currentActiveButton != null)
                _currentActiveButton.Checked = false;

            _currentActiveButton = activeBtn;
            _currentActiveButton.Checked = true;

            frm.BackColor = pnlContainer.BackColor;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;

            pnlContainer.Controls.Clear();
            pnlContainer.Controls.Add(frm);

            frm.Show();
        }

        private void LoadLoggedInUserInfo()
        {
            if (CurrentUser.ImagePath != null)
                pbUserImage.ImageLocation = CurrentUser.ImagePath;
        }

        private void BtnShowUserProfile_Click(object sender, System.EventArgs e)
        {
            FrmShowUserDetails form = new FrmShowUserDetails(CurrentUser.UserID);
            form.Show();
        }

        private void BtnExit_Click(object sender, System.EventArgs e)
        {
            CurrentUser = null;
            this.Close();
            _loginForm.Show();
        }

        private void BtnCollapse_Click(object sender, System.EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Button_MouseEnter(object sender, System.EventArgs e)
        {
            ((Guna2ImageButton)sender).BackColor = ColorTranslator.FromHtml("#372E18");
        }

        private void Button_MouseLeave(object sender, System.EventArgs e)
        {
            ((Guna2ImageButton)sender).BackColor = ColorTranslator.FromHtml("#FBCD08");
        }

        private void FrmHome_Load(object sender, System.EventArgs e)
        {
            LoadLoggedInUserInfo();

            btnDashboard.PerformClick();
        }

        private void BtnManageUsers_Click(object sender, System.EventArgs e)
        {
            ShowForm((Guna2Button)sender, new FrmListUsers());
        }

        private void BtnManageCustomers_Click(object sender, System.EventArgs e)
        {
            ShowForm((Guna2Button)sender, new FrmListCustomers());
        }

        private void BtnManageBookings_Click(object sender, System.EventArgs e)
        {
            ShowForm((Guna2Button)sender, new FrmListBookings());

        }

        private void BtnManageVehicles_Click(object sender, System.EventArgs e)
        {
            ShowForm((Guna2Button)sender, new FrmListVehicles());
        }

        private void BtnManageTransactions_Click(object sender, System.EventArgs e)
        {
            ShowForm((Guna2Button)sender, new FrmListTransactions());
        }

        private void BtnManageReturns_Click(object sender, System.EventArgs e)
        {
            ShowForm((Guna2Button)sender, new FrmListVehicleReturns());
        }

        private void BtnDashboard_Click(object sender, System.EventArgs e)
        {
            ShowForm((Guna2Button)sender, new FrmDashboard());
        }

        private void BtnLogout_Click(object sender, System.EventArgs e)
        {
            btnExit.PerformClick();
        }

        private void BtnReports_Click(object sender, System.EventArgs e)
        {
            ShowForm((Guna2Button)sender, new FrmGenerateReport());
        }
    }
}
