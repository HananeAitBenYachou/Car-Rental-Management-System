using System;
using System.Windows.Forms;

namespace CarRentalManagementSystem.Vehicles
{
    public partial class frmShowVehicleDetails : Form
    {
        private int? _VehicleID = null;

        public frmShowVehicleDetails(int? vehicleID)
        {
            InitializeComponent();
            _VehicleID = vehicleID;
        }

        private void frmShowVehicleDetails_Load(object sender, EventArgs e)
        {
            if (!ucVehicleDetails1.LoadVehicleData(_VehicleID))
                btnClose.PerformClick();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
