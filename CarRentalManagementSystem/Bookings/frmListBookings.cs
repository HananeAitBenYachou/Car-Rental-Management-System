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

namespace CarRentalManagementSystem.Bookings
{
    public partial class frmListBookings : Form
    {
        private DataView _BookingsDataView;

        public frmListBookings()
        {
            InitializeComponent();
        }

        private void _RefreshBookingsList()
        {
            _BookingsDataView = clsRentalBooking.GetAllRentalBookings().DefaultView;
            dgvBookingsList.DataSource = _BookingsDataView;
            cbFilterByOptions.SelectedIndex = 0;
        }

        private void _FilterBookingsList()
        {
            if (string.IsNullOrEmpty(txtFilterValue.Text))
            {
                _BookingsDataView.RowFilter = null;
                return;
            }

            if (cbFilterByOptions.Text != "Pickup Location" && cbFilterByOptions.Text != "Drop Off Location")
                _BookingsDataView.RowFilter = string.Format("[{0}] = {1}", cbFilterByOptions.Text, txtFilterValue.Text);
            else
                _BookingsDataView.RowFilter = string.Format("[{0}] LIKE '%{1}%'", cbFilterByOptions.Text, txtFilterValue.Text);
        }

        private void frmListBookings_Load(object sender, EventArgs e)
        {
            _RefreshBookingsList();
        }

        private void cbFilterByOptions_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFilterValue.Visible = (cbFilterByOptions.Text != "None");
            txtFilterValue.ResetText();
            txtFilterValue.Focus();
            txtFilterValue_TextChanged(null, null);
        }

        private void txtFilterValue_TextChanged(object sender, EventArgs e)
        {
            _FilterBookingsList();
        }

        private void txtFilterValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbFilterByOptions.Text == "Vehicle ID" || cbFilterByOptions.Text == "Booking ID"  || cbFilterByOptions.Text == "Customer ID")
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void btnAddNewBooking_Click(object sender, EventArgs e)
        {
            frmAddRentalBooking form = new frmAddRentalBooking();
            form.ShowDialog();

            _RefreshBookingsList();
        }

        private void addNewBookingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnAddNewBooking.PerformClick();
        }

        private void showBookingInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmShowBookingDetails form = new frmShowBookingDetails((int)dgvBookingsList.CurrentRow.Cells[0].Value);
            form.ShowDialog();
        }

        private void dgvBookingsList_SelectionChanged(object sender, EventArgs e)
        {
            cbRentalBookings.Enabled = dgvBookingsList.SelectedRows.Count > 0 ? true : false;
        }

        private void dgvBookingsList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            showBookingInformationToolStripMenuItem.PerformClick();
        }

    }
}
