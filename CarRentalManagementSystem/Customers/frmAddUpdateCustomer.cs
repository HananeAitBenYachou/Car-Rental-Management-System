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
    public partial class FrmAddUpdateCustomer : Form
    {
        private enum EnMode : byte { AddNew = 0, Update = 1 };
        private EnMode _mode = EnMode.AddNew;

        public event EventHandler<int?> NewCustomerAdded;
        protected virtual void OnNewCustomerAdded()
        {
            NewCustomerAdded?.Invoke(this, _customerID);
        }


        private int? _customerID = null;

        private Customer _customer = null;

        public FrmAddUpdateCustomer(int? customerID)
        {
            InitializeComponent();
            _mode = EnMode.Update;
            _customerID = customerID;
        }
        public FrmAddUpdateCustomer()
        {
            InitializeComponent();
            _mode = EnMode.AddNew;
        }

        private void Reset()
        {
            FillCountriesInComboBox();

            if (_mode == EnMode.AddNew)
            {
                _customer = new Customer();
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

        private void FillCountriesInComboBox()
        {
            foreach (DataRow row in Country.GetAllCountries().Rows)
            {
                cbCountries.Items.Add((string)row["CountryName"]);
            }

            cbCountries.SelectedIndex = 0;
        }

        private void LoadCustomerData()
        {
            _customer = Customer.Find<int?>(_customerID, EnFindCustomerBy.CustomerID);

            if (_customer == null)
            {
                MessageBox.Show($"No customer with CustomerID = {_customerID} was found in the system !", "Not Found !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            txtCustomerID.Text = _customerID.ToString();
            txtNationalNo.Text = _customer.NationalNo;
            txtFirstName.Text = _customer.FirstName;
            txtLastName.Text = _customer.LastName;
            txtPhone.Text = _customer.Phone;
            txtLicenseNo.Text = _customer.DriverLicenseNumber;
            txtAddress.Text = _customer.Address ?? string.Empty;
            txtEmail.Text = _customer.Email ?? string.Empty;

            dtpBirthDate.Value = _customer.BirthDate;
            cbCountries.SelectedIndex = cbCountries.FindString(_customer.CountryInfo.Name);

            rbMale.Checked = (_customer.Gender == Person.EnGender.Male);
            rbFemale.Checked = !rbMale.Checked;

            if (_customer.ImagePath != null)
                pbPersonalImage.ImageLocation = _customer.ImagePath;

            llbRemoveImage.Visible = pbPersonalImage.ImageLocation != null;
        }

        private bool IsPersonImageHandledSuccessfully()
        {
            if (_customer.ImagePath != pbPersonalImage.ImageLocation)
            {
                if (_customer.ImagePath != null)
                {
                    try
                    {
                        File.Delete(_customer.ImagePath);
                    }
                    catch (Exception ex)
                    {
                        ErrorLogger.LogError(ex);
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

                        Utility.CopyImageToProjectImagesFolder(ref sourceFilePath, FolderPath);

                        pbPersonalImage.ImageLocation = sourceFilePath;

                        return true;
                    }
                    catch (Exception ex)
                    {
                        ErrorLogger.LogError(ex);
                        MessageBox.Show("An error occured while saving the customer's new personal image", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
            }

            return true;
        }

        private bool SaveCustomerData()
        {
            if (!IsPersonImageHandledSuccessfully())
                return false;

            _customer.NationalNo = txtNationalNo.Text.Trim();
            _customer.FirstName = txtFirstName.Text.Trim();
            _customer.LastName = txtLastName.Text.Trim();
            _customer.Phone = txtPhone.Text.Trim();
            _customer.Email = string.IsNullOrEmpty(txtEmail.Text) ? null : txtEmail.Text.Trim();
            _customer.Address = string.IsNullOrEmpty(txtAddress.Text) ? null : txtAddress.Text.Trim();
            _customer.DriverLicenseNumber = txtLicenseNo.Text.Trim();
            _customer.BirthDate = dtpBirthDate.Value;
            _customer.NationalityCountryID = Country.Find(cbCountries.Text).CountryID.Value;
            _customer.Gender = rbMale.Checked == true ? Person.EnGender.Male : Person.EnGender.Female;
            _customer.ImagePath = pbPersonalImage.ImageLocation ?? null;

            if (!_customer.Save())
            {
                MessageBox.Show("Failed to save the customer data !", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            else
            {
                MessageBox.Show("Customer data was saved successfully !", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                _mode = EnMode.Update;
                lblTitle.Text = "Update Customer";

                _customerID = _customer.CustomerID;
                txtCustomerID.Text = _customerID.ToString();
            }

            return true;
        }

        private void FrmAddUpdateCustomer_Load(object sender, EventArgs e)
        {
            Reset();

            if (_mode == EnMode.Update)
                LoadCustomerData();
        }

        private void TxtNationalNo_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtNationalNo.Text.Trim()))
            {
                e.Cancel = true;
                txtNationalNo.Focus();
                errorProvider1.SetError(txtNationalNo, "This field is required !");
            }

            else if (_customer.NationalNo != txtNationalNo.Text.Trim() && User.DoesPersonExist(txtNationalNo.Text.Trim()))
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

        private void TxtLicenseNo_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtLicenseNo.Text.Trim()))
            {
                e.Cancel = true;
                txtLicenseNo.Focus();
                errorProvider1.SetError(txtLicenseNo, "This field is required !");
            }

            else if (_customer.DriverLicenseNumber != txtLicenseNo.Text.Trim() && Customer.DoesCustomerExist(txtLicenseNo.Text.Trim()))
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
            Guna2TextBox temp = (Guna2TextBox)sender;

            if (string.IsNullOrEmpty(temp.Text.Trim()))
            {
                e.Cancel = true;
                temp.Focus();
                errorProvider1.SetError(temp, "This field is required !");
            }

            else
            {
                e.Cancel = false;
                errorProvider1.SetError(temp, null);
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

            if (SaveCustomerData())
                OnNewCustomerAdded();
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
