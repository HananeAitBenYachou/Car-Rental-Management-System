using CarRental_BusinessLayer;
using CarRentalManagementSystem.Transactions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRentalManagementSystem.Transactions
{
    public partial class frmListTransactions : Form
    {
        private enum _FilterOptions
        {
            TransactionDate,
            UpdatedTransactionDate
        }

        private DataView _TransactionsDataView;

        public frmListTransactions()
        {
            InitializeComponent();
        }

        private void _RefreshTransactionsList()
        {
            _TransactionsDataView = clsRentalTransaction.GetAllRentalTransactions().DefaultView;
            dgvTransactionsList.DataSource = _TransactionsDataView;
            cbFilterByOptions.SelectedIndex = 0;
        }

        private void _FilterTransactionsList()
        {
            if (string.IsNullOrEmpty(txtFilterValue.Text))
            {
                _TransactionsDataView.RowFilter = null;
                return;
            }

            if (cbFilterByOptions.Text.Trim().EndsWith("ID"))
                _TransactionsDataView.RowFilter = string.Format("[{0}] = {1}", cbFilterByOptions.Text, txtFilterValue.Text);
            else
                _TransactionsDataView.RowFilter = string.Format("[{0}] LIKE '%{1}%'", cbFilterByOptions.Text, txtFilterValue.Text);
        }

        private void frmListTransactions_Load(object sender, EventArgs e)
        {
            _RefreshTransactionsList();
        }

        private void cbFilterByOptions_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Enum.TryParse(cbFilterByOptions.Text.Replace(" ", ""), true , out _FilterOptions result))
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
                txtFilterValue_TextChanged(null, null);
            }
        }

        private void txtFilterValue_TextChanged(object sender, EventArgs e)
        {
            _FilterTransactionsList();
        }

        private void txtFilterValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbFilterByOptions.Text.EndsWith("ID"))
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void showTransactionInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmShowTransactionDetails form = new frmShowTransactionDetails((int)dgvTransactionsList.CurrentRow.Cells[0].Value);
            form.ShowDialog();
        }

        private void dgvTransactionsList_SelectionChanged(object sender, EventArgs e)
        {
            cbRentalTransactions.Enabled = dgvTransactionsList.SelectedRows.Count > 0 ? true : false;
        }

        private void dgvTransactionsList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            showTransactionInformationToolStripMenuItem.PerformClick();
        }

        private void dtpTemp_ValueChanged(object sender, EventArgs e)
        {

            _TransactionsDataView.RowFilter = string.Format("[{0}] = '{1}'", cbFilterByOptions.Text, dtpTemp.Value.Date.ToString("dd-MM-yyyy"));
        }
    }
}
