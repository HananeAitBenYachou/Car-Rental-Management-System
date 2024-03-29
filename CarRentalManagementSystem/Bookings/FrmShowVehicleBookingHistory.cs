using CarRental_BusinessLayer;
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
        private int? _vehicleID = null;

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

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
