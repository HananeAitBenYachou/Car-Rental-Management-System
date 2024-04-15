using CarRental_BusinessLayer;
using CarRentalManagementSystem.Returns;
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
    public partial class FrmShowVehicleBookingHistory : Form
    {
        private readonly int? _vehicleID = null;

        public FrmShowVehicleBookingHistory(int? vehicleID)
        {
            InitializeComponent();
            _vehicleID = vehicleID;
        }

        private void FrmShowVehicleBookingHistory_Load(object sender, EventArgs e)
        {
            if (!ucVehicleCard1.LoadVehicleData(_vehicleID))
                return;

            dgvBookingsList.DataSource = Vehicle.GetVehicleRentalBookings(_vehicleID);

        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RefreshVehicleBookingsList()
        {
            dgvBookingsList.DataSource = RentalBooking.GetAllRentalBookings();
        }

        private void CbRentalBookings_Opening(object sender, CancelEventArgs e)
        {
            RentalBooking rentalBooking = RentalBooking.Find((int)dgvBookingsList.CurrentRow.Cells[0].Value, RentalBooking.EnFindBookingBy.BookingID);
            returnVehicleToolStripMenuItem.Enabled = rentalBooking.IsBookingActive;
        }

        private void DgvBookingsList_SelectionChanged(object sender, EventArgs e)
        {
            cbRentalBookings.Enabled = dgvBookingsList.SelectedRows.Count > 0;
        }

        private void ShowBookingInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmShowBookingDetails form = new FrmShowBookingDetails((int)dgvBookingsList.CurrentRow.Cells[0].Value);
            form.ShowDialog();
        }

        private void DgvBookingsList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            showBookingInformationToolStripMenuItem.PerformClick();
        }

        private void ReturnVehicleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmReturnRentedVehicle form = new FrmReturnRentedVehicle((int)dgvBookingsList.CurrentRow.Cells[0].Value);
            form.ShowDialog();

            RefreshVehicleBookingsList();
        }

    }
}
