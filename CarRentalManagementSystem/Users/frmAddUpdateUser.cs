using CarRental_BusinessLayer;
using CarRental_UtilityLayer;
using CarRentalManagementSystem.Properties;
using Guna.UI2.WinForms;
using System;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Windows.Forms;
using static CarRental_BusinessLayer.User;

namespace CarRentalManagementSystem.Users
{
    public partial class FrmAddUpdateUser : Form
    {
        private enum EnMode : byte { AddNew = 0, Update = 1 };
        private EnMode _mode = EnMode.AddNew;

        private int? _userID = null;

        private User _user = null;

        private bool _passwordEditEnabled
        {
            set
            {
                lblPassword.Visible = value;
                txtPassword.Visible = value;
            }

            get
            {
                return txtPassword.Visible;
            }
        }

        public FrmAddUpdateUser(int? userID)
        {
            InitializeComponent();
            _mode = EnMode.Update;
            _userID = userID;
        }
        public FrmAddUpdateUser()
        {
            InitializeComponent();
            _mode = EnMode.AddNew;
        }

        private void Reset()
        {
            FillCountriesInComboBox();

            if (_mode == EnMode.AddNew)
            {
                _user = new User();
                lblTitle.Text = "Add New User";
                _passwordEditEnabled = true;
            }

            else
            {
                lblTitle.Text = "Update User";
                _passwordEditEnabled = false;
            }

            dtpBirthDate.MinDate = DateTime.Now.AddYears(-100);
            dtpBirthDate.MaxDate = DateTime.Now.AddYears(-18);
            dtpBirthDate.Value = dtpBirthDate.MaxDate;

            rbMale.Checked = true;
            ckbIsActive.Checked = true;
            llbRemoveImage.Visible = false;
        }

        private void FillCountriesInComboBox()
        {
            foreach (DataRow row in Country.GetAllCountries().Rows)
            {
                cbCountries.Items.Add((string)row["CountryName"]);
            }

            cbCountries.SelectedIndex = 0;
        }

        private void LoadUserData()
        {
            _user = User.Find<int?>(_userID, EnFindUserBy.UserID);

            if (_user == null)
            {
                MessageBox.Show($"No user with UserID = {_userID} was found in the system !", "Not Found !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            txtUserID.Text = _userID.ToString();
            txtNationalNo.Text = _user.NationalNo;
            txtFirstName.Text = _user.FirstName;
            txtLastName.Text = _user.LastName;
            txtPhone.Text = _user.Phone;
            txtEmail.Text = _user.Email ?? string.Empty;
            txtAddress.Text = _user.Address ?? string.Empty;
            txtUserName.Text = _user.UserName;
            txtPassword.Text = _user.Password;

            dtpBirthDate.Value = _user.BirthDate;
            cbCountries.SelectedIndex = cbCountries.FindString(_user.CountryInfo.Name);

            if (_user.Gender == Person.EnGender.Male)
                rbMale.Checked = true;
            else
                rbFemale.Checked = true;

            ckbIsActive.Checked = _user.IsActive;

            if (_user.ImagePath != null)
                pbPersonalImage.ImageLocation = _user.ImagePath;

            llbRemoveImage.Visible = pbPersonalImage.ImageLocation != null;
        }

        private bool IsPersonImageHandledSuccessfully()
        {
            if (_user.ImagePath != pbPersonalImage.ImageLocation)
            {
                if (_user.ImagePath != null)
                {
                    try
                    {
                        File.Delete(_user.ImagePath);
                    }
                    catch (Exception ex)
                    {
                        ErrorLogger.LogError(ex);
                        MessageBox.Show("An error occured while deleting the user's old personal image", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }

                if (pbPersonalImage.ImageLocation != null)
                {
                    try
                    {
                        string FolderPath = @"C:\CarRentalApp-Users-Images";
                        string sourceFilePath = pbPersonalImage.ImageLocation;

                        Utility.CopyImageToProjectImagesFolder(ref sourceFilePath, FolderPath);

                        pbPersonalImage.ImageLocation = sourceFilePath;

                        return true;
                    }
                    catch (Exception ex)
                    {
                        ErrorLogger.LogError(ex);
                        MessageBox.Show("An error occured while saving the user's new personal image", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
            }

            return true;
        }

        private void SaveUserData()
        {
            if (!IsPersonImageHandledSuccessfully())
                return;

            _user.NationalNo = txtNationalNo.Text.Trim();
            _user.FirstName = txtFirstName.Text.Trim();
            _user.LastName = txtLastName.Text.Trim();
            _user.Phone = txtPhone.Text.Trim();
            _user.Email = txtEmail.Text.Trim() ?? null;
            _user.Address = txtAddress.Text.Trim() ?? null;
            _user.UserName = txtUserName.Text.Trim();
            _user.Password = _passwordEditEnabled ? txtPassword.Text.Trim() : _user.Password;
            _user.BirthDate = dtpBirthDate.Value;
            _user.NationalityCountryID = Country.Find(cbCountries.Text).CountryID.Value;
            _user.Gender = rbMale.Checked == true ? Person.EnGender.Male : Person.EnGender.Female;
            _user.IsActive = ckbIsActive.Checked == true;
            _user.ImagePath = pbPersonalImage.ImageLocation ?? null;

            if (!_user.Save())
            {
                MessageBox.Show("Failed to save the user data !", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            else
            {
                MessageBox.Show("User data was saved successfully !", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                _mode = EnMode.Update;
                _userID = _user.UserID;

                lblTitle.Text = "Update User";
                txtUserID.Text = _userID.ToString();
            }
        }

        private void FrmAddUpdateUser_Load(object sender, EventArgs e)
        {
            Reset();

            if (_mode == EnMode.Update)
                LoadUserData();
        }

        private void TxtNationalNo_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtNationalNo.Text.Trim()))
            {
                e.Cancel = true;
                txtNationalNo.Focus();
                errorProvider1.SetError(txtNationalNo, "This field is required !");
            }

            else if (_user.NationalNo != txtNationalNo.Text.Trim() && User.DoesPersonExist(txtNationalNo.Text.Trim()))
            {
                e.Cancel = true;
                txtNationalNo.Focus();
                errorProvider1.SetError(txtNationalNo, "The national number you entered is already taken !");
            }

            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtNationalNo, null);
            }
        }

        private void TxtUserName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtUserName.Text.Trim()))
            {
                e.Cancel = true;
                txtUserName.Focus();
                errorProvider1.SetError(txtUserName, "This field is required !");
            }

            else if (_user.UserName != txtUserName.Text.Trim() && User.DoesUserExist(txtUserName.Text.Trim()))
            {
                e.Cancel = true;
                txtUserName.Focus();
                errorProvider1.SetError(txtUserName, "The username you entered is already taken !");
            }

            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtUserName, null);
            }
        }

        private void TextBox_Validating(object sender, CancelEventArgs e)
        {
            Guna2TextBox txtTemp = (Guna2TextBox)sender;

            if (string.IsNullOrEmpty(txtTemp.Text.Trim()))
            {
                e.Cancel = true;
                txtTemp.Focus();
                errorProvider1.SetError(txtTemp, "This field is required !");
            }

            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtTemp, null);
            }
        }

        private void TxtEmail_Validating(object sender, CancelEventArgs e)
        {
            if (!string.IsNullOrEmpty(txtEmail.Text.Trim()) && !Validation.IsValidEmailAddress(txtEmail.Text.Trim()))
            {
                e.Cancel = true;
                txtEmail.Focus();
                errorProvider1.SetError(txtEmail, "This email format is not valid !");
            }

            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtEmail, null);
            }
        }

        private void LlbUploadImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                llbRemoveImage.Visible = true;
                pbPersonalImage.ImageLocation = openFileDialog1.FileName;
            }
        }

        private void LlbRemoveImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            llbRemoveImage.Visible = false;
            pbPersonalImage.ImageLocation = null;

            pbPersonalImage.Image = rbMale.Checked ? Resources.man : Resources.woman;
        }

        private void RbFemale_Click(object sender, EventArgs e)
        {
            if (pbPersonalImage.ImageLocation == null)
                pbPersonalImage.Image = Resources.woman;
        }

        private void RbMale_Click(object sender, EventArgs e)
        {
            if (pbPersonalImage.ImageLocation == null)
                pbPersonalImage.Image = Resources.man;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren())
            {
                MessageBox.Show("Some fields are not valid , please put the mouse over the red icon(s) to see the error", "Validation Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SaveUserData();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TxtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar);
        }
    }
}
