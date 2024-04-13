using CarRental_BusinessLayer;
using CarRentalManagementSystem.Bookings;
using CarRentalManagementSystem.Transactions;
using System;
using System.Data;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRentalManagementSystem.Customers
{
    public partial class FrmListCustomers : Form
    {
        private enum FilterOptions
        {
            Gender,
            Country,
        }

        private FilterOptions _selectedOption;

        private DataView _customersDataView;

        public FrmListCustomers()
        {
            InitializeComponent();
        }

        private async void FillCountriesInComboBoxAsync()
        {
            await Task.Run(() =>
            {
                cbTemp.Invoke(new Action(() =>
                {
                    foreach (DataRow row in Country.GetAllCountries().Rows)
                    {
                        cbTemp.Items.Add((string)row["CountryName"]);
                    }

                    cbTemp.SelectedIndex = 0;

                }));
            });
        }

        private void FillFilterOptionsInComboBox(FilterOptions option)
        {
            cbTemp.Items.Clear();

            switch (option)
            {
                case FilterOptions.Gender:
                    cbTemp.Items.AddRange(new object[] { "All", "Female", "Male" });
                    cbTemp.SelectedIndex = 0;
                    break;

                case FilterOptions.Country:
                    FillCountriesInComboBoxAsync();
                    break;
            }
        }

        private void RefreshCustomersList()
        {
            _customersDataView = Customer.GetAllCustomers().DefaultView;
            dgvCustomersList.DataSource = _customersDataView;
            cbFilterByOptions.SelectedIndex = 0;
        }

        private void FilterCustomersList()
        {
            if (string.IsNullOrEmpty(txtFilterValue.Text))
            {
                _customersDataView.RowFilter = null;
                return;
            }

            if (cbFilterByOptions.Text == "Customer ID")
                _customersDataView.RowFilter = string.Format("[{0}] = {1}", cbFilterByOptions.Text, txtFilterValue.Text);
            else
                _customersDataView.RowFilter = string.Format("[{0}] LIKE '%{1}%'", cbFilterByOptions.Text, txtFilterValue.Text);
        }

        private void FrmListCustomers_Load(object sender, EventArgs e)
        {
            RefreshCustomersList();
        }

        private void CbFilterByOptions_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Enum.TryParse(cbFilterByOptions.Text, out _selectedOption))
            {
                txtFilterValue.Visible = false;
                cbTemp.Visible = true;
                FillFilterOptionsInComboBox(_selectedOption);
            }

            else
            {
                cbTemp.Visible = false;
                txtFilterValue.Visible = (cbFilterByOptions.Text != "None");
                txtFilterValue.ResetText();
                txtFilterValue.Focus();
                TxtFilterValue_TextChanged(null, null);
            }

        }

        private void CbTemp_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbTemp.Text == "All")
            {
                _customersDataView.RowFilter = null;
                return;
            }

            _customersDataView.RowFilter = string.Format("[{0}] = '{1}'", cbFilterByOptions.Text, cbTemp.Text);
        }

        private void TxtFilterValue_TextChanged(object sender, EventArgs e)
        {
            FilterCustomersList();
        }

        private void TxtFilterValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbFilterByOptions.Text == "Customer ID")
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void BtnAddNewCustomer_Click(object sender, EventArgs e)
        {
            FrmAddUpdateCustomer form = new FrmAddUpdateCustomer();
            form.ShowDialog();

            RefreshCustomersList();
        }

        private void AddNewCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnAddNewCustomer.PerformClick();
        }

        private void EditCustomerInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAddUpdateCustomer form = new FrmAddUpdateCustomer((int)dgvCustomersList.CurrentRow.Cells[0].Value);
            form.ShowDialog();

            RefreshCustomersList();
        }

        private void ShowCustomerInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmShowCustomerDetails form = new FrmShowCustomerDetails((int)dgvCustomersList.CurrentRow.Cells[0].Value);
            form.ShowDialog();
        }

        private void DeleteCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete the selected customer ?", "Verification",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.Cancel)
                return;

            if (!Customer.DeleteCustomer((int)dgvCustomersList.CurrentRow.Cells[0].Value))
                MessageBox.Show("Failed to delete The selected customer , due to the data connected to it !", "Deletion Failed",
                 MessageBoxButtons.OK, MessageBoxIcon.Information);

            else
            {
                MessageBox.Show("The selected customer has been deleted successfully .", "Deletion Completed",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

                RefreshCustomersList();
            }

        }

        private void DgvCustomersList_SelectionChanged(object sender, EventArgs e)
        {
            cbCustomers.Enabled = dgvCustomersList.SelectedRows.Count > 0;
        }

        private void DgvCustomersList_CellDoubleContentClick(object sender, DataGridViewCellEventArgs e)
        {
            showCustomerInformationToolStripMenuItem.PerformClick();
        }

        private void ShowCustomerBookingHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmShowCustomerBookingHistory form = new FrmShowCustomerBookingHistory((int)dgvCustomersList.CurrentRow.Cells[0].Value);
            form.ShowDialog();
        }

        private void ShowCustomerTransactionHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmShowCustomerTransactionHistory form = new FrmShowCustomerTransactionHistory((int)dgvCustomersList.CurrentRow.Cells[0].Value);
            form.ShowDialog();
        }

    }
}
