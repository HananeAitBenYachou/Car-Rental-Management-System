using CarRental_BusinessLayer;
using CarRentalManagementSystem.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRentalManagementSystem.Customers
{
    public partial class frmListCustomers : Form
    {
        private enum _FilterOptions
        {
            Gender,
            Country,
        }

        private _FilterOptions _SelectedOption;

        private DataView _CustomersDataView;

        public frmListCustomers()
        {
            InitializeComponent();
        }

        private async void _FillCountriesInComboBoxAsync()
        {
            await Task.Run(() =>
            {
                cbTemp.Invoke(new Action(() =>
                {
                    foreach (DataRow row in clsCountry.GetAllCountries().Rows)
                    {
                        cbTemp.Items.Add((string)row["CountryName"]);
                    }

                    cbTemp.SelectedIndex = 0;

                }));
            });
        }

        private void _FillFilterOptionsInComboBox(_FilterOptions option)
        {
            cbTemp.Items.Clear();

            switch (option)
            {
                case _FilterOptions.Gender:
                    cbTemp.Items.AddRange(new object[] { "All", "Female", "Male" });
                    cbTemp.SelectedIndex = 0;
                    break;

                case _FilterOptions.Country:
                    _FillCountriesInComboBoxAsync();
                    break;
            }
        }

        private void _RefreshCustomersList()
        {
            _CustomersDataView = clsCustomer.GetAllCustomers().DefaultView;
            dgvCustomersList.DataSource = _CustomersDataView;
            cbFilterByOptions.SelectedIndex = 0;
        }

        private void _FilterCustomersList()
        {
            if (string.IsNullOrEmpty(txtFilterValue.Text))
            {
                _CustomersDataView.RowFilter = null;
                return;
            }

            if (cbFilterByOptions.Text == "Customer ID")
                _CustomersDataView.RowFilter = string.Format("[{0}] = {1}", cbFilterByOptions.Text, txtFilterValue.Text);
            else
                _CustomersDataView.RowFilter = string.Format("[{0}] LIKE '%{1}%'", cbFilterByOptions.Text, txtFilterValue.Text);
        }

        private void frmListCustomers_Load(object sender, EventArgs e)
        {
            _RefreshCustomersList();
        }

        private void cbFilterByOptions_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Enum.TryParse(cbFilterByOptions.Text, out _SelectedOption))
            {
                txtFilterValue.Visible = false;
                cbTemp.Visible = true;
                _FillFilterOptionsInComboBox(_SelectedOption);
            }

            else
            {
                cbTemp.Visible = false;
                txtFilterValue.Visible = (cbFilterByOptions.Text != "None");
                txtFilterValue.ResetText();
                txtFilterValue.Focus();
                txtFilterValue_TextChanged(null, null);
            }

        }

        private void cbTemp_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbTemp.Text == "All")
            {
                _CustomersDataView.RowFilter = null;
                return;
            }

            _CustomersDataView.RowFilter = string.Format("[{0}] = '{1}'", cbFilterByOptions.Text, cbTemp.Text);
        }

        private void txtFilterValue_TextChanged(object sender, EventArgs e)
        {
            _FilterCustomersList();
        }

        private void txtFilterValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbFilterByOptions.Text == "Customer ID")
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void btnAddNewCustomer_Click(object sender, EventArgs e)
        {
            frmAddUpdateCustomer form = new frmAddUpdateCustomer();
            form.ShowDialog();

            _RefreshCustomersList();
        }

        private void addNewCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnAddNewCustomer.PerformClick();
        }

        private void editCustomerInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddUpdateCustomer form = new frmAddUpdateCustomer((int)dgvCustomersList.CurrentRow.Cells[0].Value);
            form.ShowDialog();

            _RefreshCustomersList();
        }

        private void showCustomerInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmShowCustomerDetails form = new frmShowCustomerDetails((int)dgvCustomersList.CurrentRow.Cells[0].Value);
            form.ShowDialog();
        }

        private void deleteCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete the selected customer ?", "Verification",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.Cancel)
                return;

            if (!clsCustomer.DeleteCustomer((int)dgvCustomersList.CurrentRow.Cells[0].Value))
                MessageBox.Show("Failed to delete The selected customer , due to the data connected to it !", "Deletion Failed",
                 MessageBoxButtons.OK, MessageBoxIcon.Information);

            else
            {
                MessageBox.Show("The selected customer has been deleted successfully .", "Deletion Completed",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

                _RefreshCustomersList();
            }

        }

        private void dgvCustomersList_SelectionChanged(object sender, EventArgs e)
        {
            cbCustomers.Enabled = dgvCustomersList.SelectedRows.Count > 0 ? true : false;
        }

        private void dgvCustomersList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            showCustomerInformationToolStripMenuItem.PerformClick();
        }
    }
}
