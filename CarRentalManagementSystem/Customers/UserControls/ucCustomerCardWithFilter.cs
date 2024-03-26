using CarRental_BusinessLayer;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace CarRentalManagementSystem.Customers.UserControls
{
    public partial class UcCustomerCardWithFilter : UserControl
    {
        private int? _customerID => ucCustomerCard1.CustomerID;
        private Customer _customer => ucCustomerCard1.Customer;

        public bool FilterEnabled
        {
            get
            {
                return gbFilter.Enabled;
            }

            set
            {
                gbFilter.Enabled = value;

                if (gbFilter.Enabled)
                    txtFilterValue.Focus();
            }
        }

        private enum EnFindBy { CustomerID, DriverLicenseNumber };

        private EnFindBy _findCustomerBy;


        public event EventHandler<int?> CustomerFound;
        protected virtual void OnCustomerFound()
        {
            CustomerFound?.Invoke(this, _customerID);
        }

        public UcCustomerCardWithFilter()
        {
            InitializeComponent();
        }

        public void LoadCustomerData(int? customerID)
        {
            cbFilterByOptions.SelectedIndex = 0;
            txtFilterValue.Text = customerID.ToString();
            FindCustomer();
        }

        private void ClearErrorProvider()
        {
            errorProvider1.SetError(txtFilterValue, null);
        }

        private bool FindCustomer()
        {
            switch (_findCustomerBy)
            {
                case EnFindBy.CustomerID:
                    ucCustomerCard1.LoadCustomerData(Convert.ToInt16(txtFilterValue.Text.Trim()));
                    break;

                case EnFindBy.DriverLicenseNumber:
                    ucCustomerCard1.LoadCustomerData(txtFilterValue.Text.Trim());
                    break;
            }

            return _customerID.HasValue;
        }

        private void BtnSearchCustomer_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren())
            {
                MessageBox.Show("Please enter the customer's ID/License No you want to search !", "Validation Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (FindCustomer())
                OnCustomerFound();
        }

        private void BtnAddCustomer_Click(object sender, EventArgs e)
        {
            FrmAddUpdateCustomer form = new FrmAddUpdateCustomer();
            form.NewCustomerAdded += FrmAddUpdateCustomer_NewCustomerAdded;
            form.ShowDialog();
        }

        private void FrmAddUpdateCustomer_NewCustomerAdded(object sender, int? customerID)
        {
            LoadCustomerData(customerID);
            ClearErrorProvider();
            FilterEnabled = false;

            OnCustomerFound();
        }

        private void CbFilterByOptions_SelectedIndexChanged(object sender, EventArgs e)
        {
            _findCustomerBy = cbFilterByOptions.SelectedIndex == 0 ? EnFindBy.CustomerID : EnFindBy.DriverLicenseNumber;

            txtFilterValue.ResetText();
        }

        private void TxtFilterValue_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtFilterValue.Text))
            {
                e.Cancel = true;
                txtFilterValue.Focus();
                errorProvider1.SetError(txtFilterValue, "Please enter the customer's ID/License No you want to search !");
            }

            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtFilterValue, null);
            }
        }

        private void TxtFilterValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (_findCustomerBy == EnFindBy.CustomerID)
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void UcCustomerCardWithFilter_Load(object sender, EventArgs e)
        {
            if (cbFilterByOptions.SelectedIndex < 0)
                cbFilterByOptions.SelectedIndex = 0;
        }
    }
}
