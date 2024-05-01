using CarRental_BusinessLayer;
using CarRentalManagementSystem.Bookings;
using CarRentalManagementSystem.Customers;
using CarRentalManagementSystem.Returns;
using CarRentalManagementSystem.Vehicles;
using System;
using System.Data;
using System.Windows.Forms;

namespace CarRentalManagementSystem.Transactions
{
    public partial class FrmListTransactions : Form
    {
        private enum FilterOptions
        {
            TransactionDate,
            UpdatedTransactionDate
        }

        private DataView _transactionsDataView;

        public FrmListTransactions()
        {
            InitializeComponent();
        }

        private void RefreshTransactionsList()
        {
            _transactionsDataView = RentalTransaction.GetAllRentalTransactions().DefaultView;
            dgvTransactionsList.DataSource = _transactionsDataView;
            cbFilterByOptions.SelectedIndex = 0;
        }

        private void FilterTransactionsList()
        {
            if (string.IsNullOrEmpty(txtFilterValue.Text))
            {
                _transactionsDataView.RowFilter = null;
                return;
            }

            if (cbFilterByOptions.Text.Trim().EndsWith("ID"))
                _transactionsDataView.RowFilter = string.Format("[{0}] = {1}", cbFilterByOptions.Text, txtFilterValue.Text);
            else
                _transactionsDataView.RowFilter = string.Format("[{0}] LIKE '%{1}%'", cbFilterByOptions.Text, txtFilterValue.Text);
        }

        private void FrmListTransactions_Load(object sender, EventArgs e)
        {
            RefreshTransactionsList();
        }

        private void CbFilterByOptions_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Enum.TryParse(cbFilterByOptions.Text.Replace(" ", ""), true, out FilterOptions _))
            {
                txtFilterValue.Visible = false;
                dtpTemp.Visible = true;
                dtpTemp.Value = DateTime.Now;
            }

            else
            {
                dtpTemp.Visible = false;
                txtFilterValue.Visible = (cbFilterByOptions.Text != "None");
                txtFilterValue.ResetText();
                txtFilterValue.Focus();
                TxtFilterValue_TextChanged(null, null);
            }
        }

        private void TxtFilterValue_TextChanged(object sender, EventArgs e)
        {
            FilterTransactionsList();
        }

        private void TxtFilterValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbFilterByOptions.Text.EndsWith("ID"))
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void DtpTemp_ValueChanged(object sender, EventArgs e)
        {
            _transactionsDataView.RowFilter = string.Format("[{0}] = '{1}'", cbFilterByOptions.Text, dtpTemp.Value.Date.ToString("yyyy/MM/dd"));
        }

        private void ShowTransactionInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmShowTransactionDetails form = new FrmShowTransactionDetails((int)dgvTransactionsList.CurrentRow.Cells[0].Value);
            form.ShowDialog();
        }

        private void DgvTransactionsList_SelectionChanged(object sender, EventArgs e)
        {
            cbRentalTransactions.Enabled = dgvTransactionsList.SelectedRows.Count > 0;
        }

        private void DgvTransactionsList_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            showTransactionInformationToolStripMenuItem.PerformClick();
        }

        private void ShowCustomerInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmShowCustomerDetails form = new FrmShowCustomerDetails((int)dgvTransactionsList.CurrentRow.Cells["Customer ID"].Value);
            form.ShowDialog();
        }

        private void ShowVehicleInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RentalTransaction transaction = RentalTransaction.Find((int)dgvTransactionsList.CurrentRow.Cells[0].Value
                , RentalTransaction.EnFindTransactionBy.TransactionID);

            FrmShowVehicleDetails form = new FrmShowVehicleDetails(transaction.RentalBookingInfo.VehicleID);
            form.ShowDialog();
        }

        private void ShowBookingInforamtionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmShowBookingDetails form = new FrmShowBookingDetails((int)dgvTransactionsList.CurrentRow.Cells["Booking ID"].Value);
            form.ShowDialog();
        }

        private void ShowReturnInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmShowVehicleReturnDetails form = new FrmShowVehicleReturnDetails((int)dgvTransactionsList.CurrentRow.Cells["Return ID"].Value);
            form.ShowDialog();
        }

        private void CbRentalTransactions_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            RentalTransaction transaction = RentalTransaction.Find((int)dgvTransactionsList.CurrentRow.Cells[0].Value
                , RentalTransaction.EnFindTransactionBy.TransactionID);

            showReturnInformationToolStripMenuItem.Enabled = !transaction.RentalBookingInfo.IsBookingActive;
        }

    }
}
