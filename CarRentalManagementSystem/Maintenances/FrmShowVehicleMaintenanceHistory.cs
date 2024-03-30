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

namespace CarRentalManagementSystem.Maintenances
{
    public partial class FrmShowVehicleMaintenanceHistory : Form
    {
        private readonly int? _vehicleID = null;

        public FrmShowVehicleMaintenanceHistory(int? vehicleID)
        {
            InitializeComponent();
            _vehicleID = vehicleID;
        }

        private void FrmShowVehicleMaintenancesHistory_Load(object sender, EventArgs e)
        {
            if(!ucVehicleCard1.LoadVehicleData(_vehicleID))            
                return;

            dgvMaintenancesList.DataSource = Vehicle.GetVehicleMaintenances(_vehicleID);

        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
