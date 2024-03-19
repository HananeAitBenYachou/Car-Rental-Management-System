using CarRental_BusinessLayer;
using CarRental_UtilityLayer;
using CarRentalManagementSystem.Properties;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static CarRental_BusinessLayer.clsUser;

namespace CarRentalManagementSystem.Users
{
    public partial class frmAddUpdateUser : Form
    {
        private enum _enMode : byte { AddNew = 0 , Update = 1 };
        private _enMode _Mode = _enMode.AddNew; 

        private int? _UserID  = null;

        private clsUser _User = null;

        private bool _PasswordEditEnabled
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

        public frmAddUpdateUser(int? userID)
        {
            InitializeComponent();
            _Mode = _enMode.Update;
            _UserID = userID;
        }
        public frmAddUpdateUser()
        {
            InitializeComponent();
            _Mode = _enMode.AddNew;
        }

        private void _Reset()
        {
            _FillCountriesInComboBox();

            if (_Mode  == _enMode.AddNew)
            {
                _User = new clsUser();
                lblTitle.Text = "Add New User";
                _PasswordEditEnabled = true;
            }

            else
            {
                lblTitle.Text = "Update User";
                _PasswordEditEnabled = false;
            }

            dtpBirthDate.MinDate = DateTime.Now.AddYears(-100);
            dtpBirthDate.MaxDate = DateTime.Now.AddYears(-18);
            dtpBirthDate.Value = dtpBirthDate.MaxDate;

            rbMale.Checked = true;
            ckbIsActive.Checked = true;
            llbRemoveImage.Visible = false;
        }

        private void _FillCountriesInComboBox()
        {
            foreach (DataRow row in clsCountry.GetAllCountries().Rows)
            {
                cbCountries.Items.Add((string)row["CountryName"]);
            }

            cbCountries.SelectedIndex = 0;
        }

        private void _LoadUserData()
        {
            _User = clsUser.Find<int?>(_UserID, enFindUserBy.UserID);

            if(_User == null)
            {
                MessageBox.Show($"No user with UserID = {_UserID} was found in the system !", "Not Found !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            txtUserID.Text = _UserID.ToString();
            txtNationalNo.Text = _User.NationalNo;
            txtFirstName.Text = _User.FirstName;
            txtLastName.Text = _User.LastName;
            txtPhone.Text = _User.Phone;
            txtEmail.Text = _User.Email ?? string.Empty;
            txtAddress.Text = _User.Address ?? string.Empty;
            txtUserName.Text = _User.UserName;
            txtPassword.Text = _User.Password;

            dtpBirthDate.Value = _User.BirthDate;
            cbCountries.SelectedIndex = cbCountries.FindString(_User.CountryInfo.CountryName);

            if (_User.Gender == clsPerson.enGender.Male)
                rbMale.Checked = true;
            else
                rbFemale.Checked = true;

            ckbIsActive.Checked = _User.IsActive;

            if (_User.ImagePath != null)
                pbPersonalImage.ImageLocation = _User.ImagePath;

            llbRemoveImage.Visible = pbPersonalImage.ImageLocation != null;
        }

        private bool _IsPersonImageHandledSuccessfully()
        {
            if(_User.ImagePath != pbPersonalImage.ImageLocation)
            {
                if(_User.ImagePath != null)
                {
                    try
                    {
                        File.Delete(_User.ImagePath);
                    }
                    catch(Exception ex)
                    {
                        clsErrorLogger.LogError(ex);
                        MessageBox.Show("An error occured while deleting the user's old personal image", "Error",
                            MessageBoxButtons.OK,MessageBoxIcon.Error);
                        return false;
                    }
                }

                if(pbPersonalImage.ImageLocation != null)
                {
                    try
                    {       
                        string FolderPath = @"C:\CarRentalApp-Users-Images";
                        string sourceFilePath = pbPersonalImage.ImageLocation;

                        clsUtility.CopyImageToProjectImagesFolder(ref sourceFilePath, FolderPath);

                        pbPersonalImage.ImageLocation = sourceFilePath;

                        return true;
                    }
                    catch (Exception ex)
                    {
                        clsErrorLogger.LogError(ex);
                        MessageBox.Show("An error occured while saving the user's new personal image", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
            }

            return true;
        }

        private void _SaveUserData()
        {
            if (!_IsPersonImageHandledSuccessfully())
                return;

            _User.NationalNo = txtNationalNo.Text.Trim();
            _User.FirstName = txtFirstName.Text.Trim();
            _User.LastName = txtLastName.Text.Trim();
            _User.Phone = txtPhone.Text.Trim();
            _User.Email = txtEmail.Text.Trim() ?? null;
            _User.Address = txtAddress.Text.Trim() ?? null;
            _User.UserName = txtUserName.Text.Trim();
            _User.Password = _PasswordEditEnabled ? txtPassword.Text.Trim() : _User.Password;
            _User.BirthDate = dtpBirthDate.Value;
            _User.NationalityCountryID = clsCountry.Find(cbCountries.Text).CountryID.Value;
            _User.Gender = rbMale.Checked == true ? clsPerson.enGender.Male : clsPerson.enGender.Female;
            _User.IsActive = ckbIsActive.Checked == true;
            _User.ImagePath = pbPersonalImage.ImageLocation ?? null;

            if(!_User.Save())
            {
                MessageBox.Show("Failed to save the user data !","Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            else
            {
                MessageBox.Show("User data was saved successfully !", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                _Mode = _enMode.Update;
                _UserID = _User.UserID;

                lblTitle.Text = "Update User";
                txtUserID.Text = _UserID.ToString();
            }
        }

        private void frmAddUpdateUser_Load(object sender, EventArgs e)
        {
            _Reset();

            if (_Mode == _enMode.Update)
                _LoadUserData();
        }

        private void txtNationalNo_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtNationalNo.Text.Trim()))
            {
                e.Cancel = true;
                txtNationalNo.Focus();
                errorProvider1.SetError(txtNationalNo, "This field is required !");
            }

            else if (_User.NationalNo != txtNationalNo.Text.Trim() && clsUser.DoesPersonExist(txtNationalNo.Text.Trim()))
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

        private void txtUserName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtUserName.Text.Trim()))
            {
                e.Cancel = true;
                txtUserName.Focus();
                errorProvider1.SetError(txtUserName, "This field is required !");
            }

            else if (_User.UserName != txtUserName.Text.Trim() && clsUser.DoesUserExist(txtUserName.Text.Trim()))
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
                errorProvider1.SetError(txtTemp,"This field is required !");
            }

            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtTemp, null);
            }
        }

        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            if (!string.IsNullOrEmpty(txtEmail.Text.Trim()) && !clsValidation.IsValidEmailAddress(txtEmail.Text.Trim()))
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

        private void llbUploadImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
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

        private void llbRemoveImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            llbRemoveImage.Visible = false;
            pbPersonalImage.ImageLocation = null;

            pbPersonalImage.Image = rbMale.Checked ? Resources.man : Resources.woman;
        }

        private void rbFemale_Click(object sender, EventArgs e)
        {
            if (pbPersonalImage.ImageLocation == null)
                pbPersonalImage.Image = Resources.woman;
        }

        private void rbMale_Click(object sender, EventArgs e)
        {
            if (pbPersonalImage.ImageLocation == null)
                pbPersonalImage.Image = Resources.man;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren())
            {
                MessageBox.Show("Some fields are not valid , please put the mouse over the red icon(s) to see the error", "Validation Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _SaveUserData();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsControl(e.KeyChar)&& !char.IsDigit(e.KeyChar);
        }
    }
}
