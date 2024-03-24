using CarRental_BusinessLayer;
using CarRental_UtilityLayer;
using System;
using System.ComponentModel;
using System.Windows.Forms;
using static CarRental_BusinessLayer.User;

namespace CarRentalManagementSystem.Users
{
    public partial class frmChangeUserPassword : Form
    {
        private int? _UserID = null;

        private User _User = null;
        public frmChangeUserPassword(int? userID)
        {
            InitializeComponent();

            _UserID = userID;
        }

        private void txtCurrentPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtCurrentPassword.Text.Trim()))
            {
                e.Cancel = true;
                txtCurrentPassword.Focus();
                errorProvider1.SetError(txtCurrentPassword, "This field is required !");
            }

            else if (CryptoUtility.ComputeHash(txtCurrentPassword.Text.Trim()) != _User.Password)
            {
                e.Cancel = true;
                txtCurrentPassword.Focus();
                errorProvider1.SetError(txtCurrentPassword, "The password you entered is not correct , please try again !");
            }

            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtCurrentPassword, null);
            }
        }

        private void txtNewPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtNewPassword.Text.Trim()))
            {
                e.Cancel = true;
                txtNewPassword.Focus();
                errorProvider1.SetError(txtNewPassword, "This field is required !");
            }

            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtNewPassword, null);
            }
        }

        private void txtConfirmPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtConfirmPassword.Text.Trim()))
            {
                e.Cancel = true;
                txtConfirmPassword.Focus();
                errorProvider1.SetError(txtConfirmPassword, "This field is required !");
            }


            if (txtNewPassword.Text.Trim() != txtConfirmPassword.Text.Trim())
            {
                e.Cancel = true;
                txtConfirmPassword.Focus();
                errorProvider1.SetError(txtConfirmPassword, "The password confirmation does not match !");
            }

            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtConfirmPassword, null);
            }
        }

        private void _UpdateUserPassword()
        {
            if (_User.UpdateUserPassword(CryptoUtility.ComputeHash(txtNewPassword.Text.Trim())))
                MessageBox.Show("Your password has been changed successfully !", "Password changed", MessageBoxButtons.OK, MessageBoxIcon.Information);

            else
                MessageBox.Show("The change password operation failed .", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren())
            {
                MessageBox.Show("Some fields are not valid , please put the mouse over the red icon(s) to see the error", "Validation Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _UpdateUserPassword();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmChangeUserPassword_Load(object sender, EventArgs e)
        {
            _User = User.Find<int?>(_UserID, enFindUserBy.UserID);

            if (_User == null)
            {
                MessageBox.Show($"No user with UserID = {_UserID} was found in the system !", "Not Found !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }
        }

    }
}
