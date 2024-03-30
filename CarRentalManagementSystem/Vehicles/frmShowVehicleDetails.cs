using System;
using System.Windows.Forms;

namespace CarRentalManagementSystem.Vehicles
{
    public partial class FrmShowVehicleDetails : Form
    {
        private readonly int? _vehicleID = null;

        public FrmShowVehicleDetails(int? vehicleID)
        {
            InitializeComponent();
            _vehicleID = vehicleID;
        }

        private void FrmShowVehicleDetails_Load(object sender, EventArgs e)
        {
            if (!ucVehicleDetails1.LoadVehicleData(_vehicleID))
                btnClose.PerformClick();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
