using CarRental_BusinessLayer;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace CarRentalManagementSystem.Customers.UserControls
{
    public partial class ucCustomerCardWithFilter : UserControl
    {
        private int? _CustomerID => ucCustomerCard1.CustomerID;
        private Customer _Customer => ucCustomerCard1.Customer;

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

        private enum enFindBy { CustomerID, DriverLicenseNumber };

        private enFindBy _FindCustomerBy;


        public event EventHandler<int?> CustomerFound;
        protected virtual void OnCustomerFound()
        {
            CustomerFound?.Invoke(this, _CustomerID);
        }

        public ucCustomerCardWithFilter()
        {
            InitializeComponent();
        }

        public void LoadCustomerData(int? customerID)
        {
            cbFilterByOptions.SelectedIndex = 0;
            txtFilterValue.Text = customerID.ToString();
            _FindCustomer();
        }

        private void _ClearErrorProvider()
        {
            errorProvider1.SetError(txtFilterValue, null);
        }

        private bool _FindCustomer()
        {
            switch (_FindCustomerBy)
            {
                case enFindBy.CustomerID:
                    ucCustomerCard1.LoadCustomerData(Convert.ToInt16(txtFilterValue.Text.Trim()));
                    break;

                case enFindBy.DriverLicenseNumber:
                    ucCustomerCard1.LoadCustomerData(txtFilterValue.Text.Trim());
                    break;
            }

            return _CustomerID.HasValue;
        }

        private void btnSearchCustomer_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren())
            {
                MessageBox.Show("Please enter the customer's ID/License No you want to search !", "Validation Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (_FindCustomer())
                OnCustomerFound();
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            frmAddUpdateCustomer form = new frmAddUpdateCustomer();
            form.NewCustomerAdded += frmAddUpdateCustomer_NewCustomerAdded;
            form.ShowDialog();
        }

        private void frmAddUpdateCustomer_NewCustomerAdded(object sender, int? customerID)
        {
            LoadCustomerData(customerID);
            _ClearErrorProvider();
            FilterEnabled = false;

            OnCustomerFound();
        }

        private void cbFilterByOptions_SelectedIndexChanged(object sender, EventArgs e)
        {
            _FindCustomerBy = cbFilterByOptions.SelectedIndex == 0 ? enFindBy.CustomerID : enFindBy.DriverLicenseNumber;

            txtFilterValue.ResetText();
        }

        private void txtFilterValue_Validating(object sender, CancelEventArgs e)
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

        private void txtFilterValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (_FindCustomerBy == enFindBy.CustomerID)
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void ucCustomerCardWithFilter_Load(object sender, EventArgs e)
        {
            if (cbFilterByOptions.SelectedIndex < 0)
                cbFilterByOptions.SelectedIndex = 0;
        }
    }
}
