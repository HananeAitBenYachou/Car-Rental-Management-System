using CarRental_BusinessLayer;
using System;
using System.Data;
using System.Windows.Forms;

namespace CarRentalManagementSystem.Returns
{
    public partial class frmListVehicleReturns : Form
    {
        private DataView _VehicleReturnsDataView;

        public frmListVehicleReturns()
        {
            InitializeComponent();
        }

        private void _RefreshVehicleReturnsList()
        {
            _VehicleReturnsDataView = VehicleReturn.GetAllVehicleReturns().DefaultView;
            dgvReturnsList.DataSource = _VehicleReturnsDataView;
            cbFilterByOptions.SelectedIndex = 0;
        }

        private void _FilterVehicleReturnsList()
        {
            if (string.IsNullOrEmpty(txtFilterValue.Text))
            {
                _VehicleReturnsDataView.RowFilter = null;
                return;
            }

            if (cbFilterByOptions.Text != "Customer Name")
                _VehicleReturnsDataView.RowFilter = string.Format("[{0}] = {1}", cbFilterByOptions.Text, txtFilterValue.Text);
            else
                _VehicleReturnsDataView.RowFilter = string.Format("[{0}] LIKE '%{1}%'", cbFilterByOptions.Text, txtFilterValue.Text);
        }

        private void frmListVehicleReturns_Load(object sender, EventArgs e)
        {
            _RefreshVehicleReturnsList();
        }

        private void cbFilterByOptions_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFilterByOptions.Text == "Actual Rental Days")
            {
                txtFilterValue.Visible = false;
                dtpActualReturnDate.Visible = true;
                dtpActualReturnDate.Value = DateTime.Now;
            }

            else
            {
                dtpActualReturnDate.Visible = false;
                txtFilterValue.Visible = (cbFilterByOptions.Text != "None");
                txtFilterValue.ResetText();
                txtFilterValue.Focus();
                txtFilterValue_TextChanged(null, null);
            }
        }

        private void txtFilterValue_TextChanged(object sender, EventArgs e)
        {
            _FilterVehicleReturnsList();
        }

        private void txtFilterValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbFilterByOptions.Text != "Customer Name")
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void dgvVehicleReturnsList_SelectionChanged(object sender, EventArgs e)
        {
            cbVehicleReturns.Enabled = dgvReturnsList.SelectedRows.Count > 0 ? true : false;
        }

        private void dgvVehicleReturnsList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            showReturnInformationToolStripMenuItem.PerformClick();
        }

        private void dtpVehicleReturns_ValueChanged(object sender, EventArgs e)
        {
            _VehicleReturnsDataView.RowFilter = string.Format("[{0}] = '{1}'", cbFilterByOptions.Text, dtpActualReturnDate.Value.Date.ToString("dd-MM-yyyy"));
        }

        private void showReturnInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmShowVehicleReturnDetails form = new frmShowVehicleReturnDetails((int?)dgvReturnsList.CurrentRow.Cells[0].Value);
            form.ShowDialog();
        }

    }
}
