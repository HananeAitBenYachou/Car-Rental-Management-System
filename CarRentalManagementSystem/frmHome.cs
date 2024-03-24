﻿using CarRentalManagementSystem.Bookings;
using CarRentalManagementSystem.Customers;
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
        private Guna2Button _CurrentActiveButton = new Guna2Button();

        private FrmLogin _loginForm;

        public FrmHome(FrmLogin loginForm)
        {
            InitializeComponent();
            _loginForm = loginForm;
        }

        private void ShowForm(Guna2Button activeBtn, Form frm)
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

        }

        private void BtnManageUsers_Click(object sender, System.EventArgs e)
        {
            ShowForm((Guna2Button)sender, new frmListUsers());
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
            ShowForm((Guna2Button)sender, new frmListVehicles());
        }

        private void BtnManageTransactions_Click(object sender, System.EventArgs e)
        {
            ShowForm((Guna2Button)sender, new frmListTransactions());
        }

        private void BtnManageReturns_Click(object sender, System.EventArgs e)
        {
            ShowForm((Guna2Button)sender, new frmListVehicleReturns());
        }

        private void BtnDashboard_Click(object sender, System.EventArgs e)
        {
            //Not implemented yet !
        }

        private void BtnLogout_Click(object sender, System.EventArgs e)
        {
            btnExit.PerformClick();
        }
    }
}
