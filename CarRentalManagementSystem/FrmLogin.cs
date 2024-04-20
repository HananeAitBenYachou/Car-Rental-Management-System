using CarRental_BusinessLayer;
using CarRental_UtilityLayer;
using System;
using System.ComponentModel;
using System.Windows.Forms;
using static CarRentalManagementSystem.Global.Global;

namespace CarRentalManagementSystem
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void Reset()
        {
            txtUsername.ResetText();
            txtPassword.ResetText();

            txtUsername.Select();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void TxtUsername_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtUsername.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtUsername, "Please enter your email address !");
            }

            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtUsername, null);
            }
        }

        private void TxtPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtPassword.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtPassword, "Please enter your password !");
            }

            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtPassword, null);
            }
        }

        private bool Login()
        {
            CurrentUser = User.Find(txtUsername.Text.Trim(), CryptoUtility.ComputeHash(txtPassword.Text.Trim()));

            if (CurrentUser == null)
            {
                MessageBox.Show($"Invalid Email or Password ! please try again.", "Wrong Credintials",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!CurrentUser.IsActive)
            {
                MessageBox.Show($"This account is not active ! please contact your admin.", "Invalid Account",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (ckbRememberMe.Checked)
                Utility.StoreUserCredintialsToRegistery(txtUsername.Text.Trim(), txtPassword.Text.Trim());

            else
            {
                Utility.StoreUserCredintialsToRegistery(string.Empty, string.Empty);

                txtUsername.ResetText();
                txtPassword.ResetText();
            }

            this.Hide();
            FrmHome Home = new FrmHome(this);
            Home.Show();

            return true;
        }

        private void BtnSignIn_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren())
            {
                MessageBox.Show("Please fill out all required fields !", "Validation Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!Login())
                Reset();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            string userName = string.Empty;
            string password = string.Empty;

            if (!Utility.GetUserCredintialsFromRegistery(ref userName, ref password))
            {
                ckbRememberMe.Checked = false;
                Reset();
                return;
            }

            txtUsername.Text = userName;
            txtPassword.Text = password;
            ckbRememberMe.Checked = true;
        }
    }
}
