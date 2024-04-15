using CarRental_BusinessLayer;
using CarRentalManagementSystem.Returns;
using System;
using System.Data;
using System.Windows.Forms;

namespace CarRentalManagementSystem.Bookings
{
    public partial class FrmListBookings : Form
    {
        private DataView _bookingsDataView;

        public FrmListBookings()
        {
            InitializeComponent();
        }

        private void RefreshBookingsList()
        {
            _bookingsDataView = RentalBooking.GetAllRentalBookings().DefaultView;
            dgvBookingsList.DataSource = _bookingsDataView;
            cbFilterByOptions.SelectedIndex = 0;
        }

        private void FilterBookingsList()
        {
            if (string.IsNullOrEmpty(txtFilterValue.Text))
            {
                _bookingsDataView.RowFilter = null;
                return;
            }

            if (cbFilterByOptions.Text != "Pickup Location" && cbFilterByOptions.Text != "Drop Off Location")
                _bookingsDataView.RowFilter = string.Format("[{0}] = {1}", cbFilterByOptions.Text, txtFilterValue.Text);
            else
                _bookingsDataView.RowFilter = string.Format("[{0}] LIKE '%{1}%'", cbFilterByOptions.Text, txtFilterValue.Text);
        }

        private void FrmListBookings_Load(object sender, EventArgs e)
        {
            RefreshBookingsList();
        }

        private void CbFilterByOptions_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFilterValue.Visible = (cbFilterByOptions.Text != "None");
            txtFilterValue.ResetText();
            txtFilterValue.Focus();
            TxtFilterValue_TextChanged(null, null);
        }

        private void TxtFilterValue_TextChanged(object sender, EventArgs e)
        {
            FilterBookingsList();
        }

        private void TxtFilterValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbFilterByOptions.Text == "Vehicle ID" || cbFilterByOptions.Text == "Booking ID" || cbFilterByOptions.Text == "Customer ID")
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void BtnAddNewBooking_Click(object sender, EventArgs e)
        {
            FrmAddRentalBooking form = new FrmAddRentalBooking();
            form.ShowDialog();

            RefreshBookingsList();
        }

        private void AddNewBookingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnAddNewBooking.PerformClick();
        }

        private void ShowBookingInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmShowBookingDetails form = new FrmShowBookingDetails((int)dgvBookingsList.CurrentRow.Cells[0].Value);
            form.ShowDialog();
        }

        private void DgvBookingsList_SelectionChanged(object sender, EventArgs e)
        {
            cbRentalBookings.Enabled = dgvBookingsList.SelectedRows.Count > 0;
        }

        private void DgvBookingsList_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            showBookingInformationToolStripMenuItem.PerformClick();
        }

        private void ReturnVehicleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmReturnRentedVehicle form = new FrmReturnRentedVehicle((int)dgvBookingsList.CurrentRow.Cells[0].Value);
            form.ShowDialog();

            RefreshBookingsList();
        }

        private void CbRentalBookings_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            RentalBooking rentalBooking = RentalBooking.Find((int)dgvBookingsList.CurrentRow.Cells[0].Value, RentalBooking.EnFindBookingBy.BookingID);
            returnVehicleToolStripMenuItem.Enabled = rentalBooking.IsBookingActive;
        }

    }
}
