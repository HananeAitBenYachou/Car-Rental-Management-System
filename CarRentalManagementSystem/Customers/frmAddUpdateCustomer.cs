using CarRental_BusinessLayer;
using CarRental_UtilityLayer;
using CarRentalManagementSystem.Properties;
using Guna.UI2.WinForms;
using System;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Windows.Forms;
using static CarRental_BusinessLayer.Customer;

namespace CarRentalManagementSystem.Customers
{
    public partial class frmAddUpdateCustomer : Form
    {
        private enum _enMode : byte { AddNew = 0, Update = 1 };
        private _enMode _Mode = _enMode.AddNew;

        public event EventHandler<int?> NewCustomerAdded;
        protected virtual void OnNewCustomerAdded()
        {
            NewCustomerAdded?.Invoke(this, _CustomerID);
        }


        private int? _CustomerID = null;

        private Customer _Customer = null;

        public frmAddUpdateCustomer(int? customerID)
        {
            InitializeComponent();
            _Mode = _enMode.Update;
            _CustomerID = customerID;
        }
        public frmAddUpdateCustomer()
        {
            InitializeComponent();
            _Mode = _enMode.AddNew;
        }

        private void _Reset()
        {
            _FillCountriesInComboBox();

            if (_Mode == _enMode.AddNew)
            {
                _Customer = new Customer();
                lblTitle.Text = "Add New Customer";
            }

            else
            {
                lblTitle.Text = "Update Customer";
            }

            dtpBirthDate.MinDate = DateTime.Now.AddYears(-100);
            dtpBirthDate.MaxDate = DateTime.Now.AddYears(-18);
            dtpBirthDate.Value = dtpBirthDate.MaxDate;

            rbMale.Checked = true;
            llbRemoveImage.Visible = false;
        }

        private void _FillCountriesInComboBox()
        {
            foreach (DataRow row in Country.GetAllCountries().Rows)
            {
                cbCountries.Items.Add((string)row["CountryName"]);
            }

            cbCountries.SelectedIndex = 0;
        }

        private void _LoadCustomerData()
        {
            _Customer = Customer.Find<int?>(_CustomerID, enFindCustomerBy.CustomerID);

            if (_Customer == null)
            {
                MessageBox.Show($"No customer with CustomerID = {_CustomerID} was found in the system !", "Not Found !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            txtCustomerID.Text = _CustomerID.ToString();
            txtNationalNo.Text = _Customer.NationalNo;
            txtFirstName.Text = _Customer.FirstName;
            txtLastName.Text = _Customer.LastName;
            txtPhone.Text = _Customer.Phone;
            txtLicenseNo.Text = _Customer.DriverLicenseNumber;
            txtAddress.Text = _Customer.Address ?? string.Empty;
            txtEmail.Text = _Customer.Email ?? string.Empty;

            dtpBirthDate.Value = _Customer.BirthDate;
            cbCountries.SelectedIndex = cbCountries.FindString(_Customer.CountryInfo.Name);

            rbMale.Checked = (_Customer.Gender == Person.enGender.Male);
            rbFemale.Checked = !rbMale.Checked;

            if (_Customer.ImagePath != null)
                pbPersonalImage.ImageLocation = _Customer.ImagePath;

            llbRemoveImage.Visible = pbPersonalImage.ImageLocation != null;
        }

        private bool _IsPersonImageHandledSuccessfully()
        {
            if (_Customer.ImagePath != pbPersonalImage.ImageLocation)
            {
                if (_Customer.ImagePath != null)
                {
                    try
                    {
                        File.Delete(_Customer.ImagePath);
                    }
                    catch (Exception ex)
                    {
                        clsErrorLogger.LogError(ex);
                        MessageBox.Show("An error occured while deleting the customer's old personal image", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }

                if (pbPersonalImage.ImageLocation != null)
                {
                    try
                    {
                        string FolderPath = @"C:\CarRentalApp-Customers-Images";
                        string sourceFilePath = pbPersonalImage.ImageLocation;

                        clsUtility.CopyImageToProjectImagesFolder(ref sourceFilePath, FolderPath);

                        pbPersonalImage.ImageLocation = sourceFilePath;

                        return true;
                    }
                    catch (Exception ex)
                    {
                        clsErrorLogger.LogError(ex);
                        MessageBox.Show("An error occured while saving the customer's new personal image", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
            }

            return true;
        }

        private bool _SaveCustomerData()
        {
            if (!_IsPersonImageHandledSuccessfully())
                return false;

            _Customer.NationalNo = txtNationalNo.Text.Trim();
            _Customer.FirstName = txtFirstName.Text.Trim();
            _Customer.LastName = txtLastName.Text.Trim();
            _Customer.Phone = txtPhone.Text.Trim();
            _Customer.Email = string.IsNullOrEmpty(txtEmail.Text) ? null : txtEmail.Text.Trim();
            _Customer.Address = string.IsNullOrEmpty(txtAddress.Text) ? null : txtAddress.Text.Trim();
            _Customer.DriverLicenseNumber = txtLicenseNo.Text.Trim();
            _Customer.BirthDate = dtpBirthDate.Value;
            _Customer.NationalityCountryID = Country.Find(cbCountries.Text).CountryID.Value;
            _Customer.Gender = rbMale.Checked == true ? Person.enGender.Male : Person.enGender.Female;
            _Customer.ImagePath = pbPersonalImage.ImageLocation ?? null;

            if (!_Customer.Save())
            {
                MessageBox.Show("Failed to save the customer data !", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            else
            {
                MessageBox.Show("Customer data was saved successfully !", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                _Mode = _enMode.Update;
                lblTitle.Text = "Update Customer";

                _CustomerID = _Customer.CustomerID;
                txtCustomerID.Text = _CustomerID.ToString();
            }

            return true;
        }

        private void frmAddUpdateCustomer_Load(object sender, EventArgs e)
        {
            _Reset();

            if (_Mode == _enMode.Update)
                _LoadCustomerData();
        }

        private void txtNationalNo_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtNationalNo.Text.Trim()))
            {
                e.Cancel = true;
                txtNationalNo.Focus();
                errorProvider1.SetError(txtNationalNo, "This field is required !");
            }

            else if (_Customer.NationalNo != txtNationalNo.Text.Trim() && User.DoesPersonExist(txtNationalNo.Text.Trim()))
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

        private void txtLicenseNo_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtLicenseNo.Text.Trim()))
            {
                e.Cancel = true;
                txtLicenseNo.Focus();
                errorProvider1.SetError(txtLicenseNo, "This field is required !");
            }

            else if (_Customer.DriverLicenseNumber != txtLicenseNo.Text.Trim() && Customer.DoesCustomerExist(txtLicenseNo.Text.Trim()))
            {
                e.Cancel = true;
                txtLicenseNo.Focus();
                errorProvider1.SetError(txtLicenseNo, "The driver license number you entered is already taken by another customer !");
            }

            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtLicenseNo, null);
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

            if (_SaveCustomerData())
                OnNewCustomerAdded();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar);
        }
    }
}
