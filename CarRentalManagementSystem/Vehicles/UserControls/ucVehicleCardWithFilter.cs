using CarRental_BusinessLayer;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace CarRentalManagementSystem.Vehicles.UserControls
{
    public partial class ucVehicleCardWithFilter : UserControl
    {
        public class VehicleFoundEventArgs : EventArgs
        {
            public int? VehicleID { get; }
            public bool IsAvailableForRent { get; }
            public double RentalPricePerDay { get; }

            public VehicleFoundEventArgs(int? vehicleID, bool isAvailableForRent, double rentalPricePerDay)
            {
                VehicleID = vehicleID;
                IsAvailableForRent = isAvailableForRent;
                RentalPricePerDay = rentalPricePerDay;
            }
        }

        private int? _VehicleID => ucVehicleCard1.VehicleID;
        private Vehicle _Vehicle => ucVehicleCard1.Vehicle;

        public bool FilterEnabled
        {
            get
            {
                return gbFilter.Enabled;
            }

            set
            {
                gbFilter.Enabled = value;

                if (gbFilter.Enabled)
                    txtVehicleID.Focus();
            }
        }

        public event EventHandler<VehicleFoundEventArgs> VehicleFound;
        private void _RaiseOnVehicleFoundEvent()
        {
            OnVehicleFound(new VehicleFoundEventArgs(_VehicleID, _Vehicle.IsAvailableForRent, _Vehicle.RentalPricePerDay));
        }
        protected virtual void OnVehicleFound(VehicleFoundEventArgs vehicleInfo)
        {
            VehicleFound?.Invoke(this, vehicleInfo);
        }

        public ucVehicleCardWithFilter()
        {
            InitializeComponent();
        }

        public void LoadVehicleData(int? vehicleID)
        {
            txtVehicleID.Text = vehicleID.ToString();
            _FindVehicle();
        }

        private void _ClearErrorProvider()
        {
            errorProvider1.SetError(txtVehicleID, null);
        }

        private bool _FindVehicle()
        {
            return ucVehicleCard1.LoadVehicleData(Convert.ToInt16(txtVehicleID.Text.Trim()));
        }

        private void btnSearchVehicle_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren())
            {
                MessageBox.Show("Please enter the vehicle'ID you want to search !", "Validation Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (_FindVehicle())
                _RaiseOnVehicleFoundEvent();
        }

        private void btnAddVehicle_Click(object sender, EventArgs e)
        {
            frmAddUpdateVehicle form = new frmAddUpdateVehicle();
            form.NewVehicleAdded += frmAddUpdateVehicle_NewVehicleAdded;
            form.ShowDialog();
        }

        private void frmAddUpdateVehicle_NewVehicleAdded(object sender, int? vehicleID)
        {
            LoadVehicleData(vehicleID);
            _ClearErrorProvider();
            FilterEnabled = false;

            _RaiseOnVehicleFoundEvent();
        }

        private void txtVehicleID_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtVehicleID.Text))
            {
                e.Cancel = true;
                txtVehicleID.Focus();
                errorProvider1.SetError(txtVehicleID, "Please enter the vehicle'ID you want to search !");
            }

            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtVehicleID, null);
            }
        }

        private void txtVehicleID_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

    }
}
