using CarRental_BusinessLayer;
using CarRentalManagementSystem.Vehicles.UserControls;
using System;
using System.Windows.Forms;

namespace CarRentalManagementSystem.Maintenances
{
    public partial class FrmMaintainVehicle : Form
    {
        private int? _vehicleID = null;
        private int? _maintenanceID = null;
        private Maintenance _maintenance = null;

        public FrmMaintainVehicle()
        {
            InitializeComponent();
        }
        public FrmMaintainVehicle(int? vehicleID)
        {
            InitializeComponent();

            _vehicleID = vehicleID;
        }

        private void LoadVehicleData()
        {
            ucVehicleCardWithFilter1.FilterEnabled = false;

            if (!ucVehicleCardWithFilter1.LoadVehicleData(_vehicleID))
                btnClose.PerformClick();
        }

        private void Reset()
        {
            ucVehicleCardWithFilter1.VehicleFound += UcBookingDetailsWithFilter1_BookingFound;
            ucVehicleCardWithFilter1.FilterEnabled = !_vehicleID.HasValue;

            dtpMaintenanceDate.Value = DateTime.Now;
            dtpMaintenanceDate.MinDate = dtpMaintenanceDate.Value;
            dtpMaintenanceDate.MaxDate = dtpMaintenanceDate.Value;

            btnNext.Enabled = false;
            btnSave.Enabled = false;
        }

        private void UcBookingDetailsWithFilter1_BookingFound(object sender, UcVehicleCardWithFilter.VehicleFoundEventArgs vehicleInfo)
        {
            if (!vehicleInfo.IsAvailableForRent)
            {
                MessageBox.Show($"You can't maintain this car , it is not available now !", "Not Valid !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnNext.Enabled = false;
                return;
            }

            _vehicleID = vehicleInfo.VehicleID;
            txtVehicleID.Text = _vehicleID.ToString();

            btnNext.Enabled = true;
            btnSave.Enabled = true;
        }

        private void FrmMaintainVehicle_Load(object sender, EventArgs e)
        {
            Reset();

            if (_vehicleID.HasValue)
                LoadVehicleData();
        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            tcMaintainVehicle.SelectedTab = tpMaintenanceInfo;
        }

        private void BtnNext_EnabledChanged(object sender, EventArgs e)
        {
            tpMaintenanceInfo.Enabled = btnNext.Enabled;
        }

        private void SaveMaintenanceInfo()
        {
            _maintenance = new Maintenance();

            _maintenance.VehicleID = _vehicleID.Value;
            _maintenance.MaintenanceDate = dtpMaintenanceDate.Value;
            _maintenance.Cost = Convert.ToSingle(txtCost.Text.Trim());
            _maintenance.Description = string.IsNullOrEmpty(txtDescription.Text) ? null : txtDescription.Text.Trim();

            if (!_maintenance.Save())
            {
                MessageBox.Show("Failed to save the data !", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                MessageBox.Show("Data was saved successfully !", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                _maintenanceID = _maintenance.MaintenanceID;
                txtMaintenanceID.Text = _maintenanceID.ToString();

                btnSave.Enabled = false;
                ucVehicleCardWithFilter1.FilterEnabled = false;
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren())
            {
                MessageBox.Show("Some fields are not valid , please put the mouse over the red icon(s) to see the error", "Validation Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SaveMaintenanceInfo();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TxtCost_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != '-';
        }
    }
}
