using CarRental_BusinessLayer;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace CarRentalManagementSystem.Vehicles.UserControls
{
    public partial class UcVehicleCardWithFilter : UserControl
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

        private int? _vehicleID => ucVehicleCard1.VehicleID;
        private Vehicle _vehicle => ucVehicleCard1.Vehicle;

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
        private void RaiseOnVehicleFoundEvent()
        {
            OnVehicleFound(new VehicleFoundEventArgs(_vehicleID, _vehicle.IsAvailableForRent, _vehicle.RentalPricePerDay));
        }
        protected virtual void OnVehicleFound(VehicleFoundEventArgs vehicleInfo)
        {
            VehicleFound?.Invoke(this, vehicleInfo);
        }

        public UcVehicleCardWithFilter()
        {
            InitializeComponent();
        }

        public bool LoadVehicleData(int? vehicleID)
        {
            txtVehicleID.Text = vehicleID.ToString();

            if (!FindVehicle())
                return false;

            RaiseOnVehicleFoundEvent();
            return true;
        }
        private void ClearErrorProvider()
        {
            errorProvider1.SetError(txtVehicleID, null);
        }

        private bool FindVehicle()
        {
            return ucVehicleCard1.LoadVehicleData(Convert.ToInt16(txtVehicleID.Text.Trim()));
        }

        private void BtnSearchVehicle_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren())
            {
                MessageBox.Show("Please enter the vehicle'ID you want to search !", "Validation Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (FindVehicle())
                RaiseOnVehicleFoundEvent();
        }

        private void BtnAddVehicle_Click(object sender, EventArgs e)
        {
            FrmAddUpdateVehicle form = new FrmAddUpdateVehicle();
            form.NewVehicleAdded += FrmAddUpdateVehicle_NewVehicleAdded;
            form.ShowDialog();
        }

        private void FrmAddUpdateVehicle_NewVehicleAdded(object sender, int? vehicleID)
        {
            LoadVehicleData(vehicleID);
            ClearErrorProvider();
            FilterEnabled = false;

            RaiseOnVehicleFoundEvent();
        }

        private void TxtVehicleID_Validating(object sender, CancelEventArgs e)
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

        private void TxtVehicleID_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

    }
}
