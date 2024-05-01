using CarRental_BusinessLayer;
using System;
using System.Data;
using System.Windows.Forms;

namespace CarRentalManagementSystem.Returns
{
    public partial class FrmListVehicleReturns : Form
    {
        private DataView _vehicleReturnsDataView;

        public FrmListVehicleReturns()
        {
            InitializeComponent();
        }

        private void RefreshVehicleReturnsList()
        {
            _vehicleReturnsDataView = VehicleReturn.GetAllVehicleReturns().DefaultView;
            dgvReturnsList.DataSource = _vehicleReturnsDataView;
            cbFilterByOptions.SelectedIndex = 0;
        }

        private void FilterVehicleReturnsList()
        {
            if (string.IsNullOrEmpty(txtFilterValue.Text))
            {
                _vehicleReturnsDataView.RowFilter = null;
                return;
            }

            if (cbFilterByOptions.Text != "Customer Name")
                _vehicleReturnsDataView.RowFilter = string.Format("[{0}] = {1}", cbFilterByOptions.Text, txtFilterValue.Text);
            else
                _vehicleReturnsDataView.RowFilter = string.Format("[{0}] LIKE '%{1}%'", cbFilterByOptions.Text, txtFilterValue.Text);
        }

        private void FrmListVehicleReturns_Load(object sender, EventArgs e)
        {
            RefreshVehicleReturnsList();
        }

        private void CbFilterByOptions_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFilterByOptions.Text == "Actual Return Date")
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
                TxtFilterValue_TextChanged(null, null);
            }
        }

        private void TxtFilterValue_TextChanged(object sender, EventArgs e)
        {
            FilterVehicleReturnsList();
        }

        private void TxtFilterValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbFilterByOptions.Text != "Customer Name")
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void DgvVehicleReturnsList_SelectionChanged(object sender, EventArgs e)
        {
            cbVehicleReturns.Enabled = dgvReturnsList.SelectedRows.Count > 0;
        }

        private void DgvVehicleReturnsList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            showReturnInformationToolStripMenuItem.PerformClick();
        }

        private void DtpVehicleReturns_ValueChanged(object sender, EventArgs e)
        {
             _vehicleReturnsDataView.RowFilter = string.Format("[{0}] = '{1}'", cbFilterByOptions.Text, dtpActualReturnDate.Value.Date.ToString("yyyy/MM/dd"));
        }

        private void ShowReturnInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmShowVehicleReturnDetails form = new FrmShowVehicleReturnDetails((int?)dgvReturnsList.CurrentRow.Cells[0].Value);
            form.ShowDialog();
        }
    }
}
