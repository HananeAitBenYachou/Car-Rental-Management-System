using CarRental_BusinessLayer;
using CarRental_UtilityLayer;
using System;
using System.ComponentModel;
using System.Data;
using System.Globalization;
using System.Windows.Forms;

namespace CarRentalManagementSystem.Vehicles
{
    public partial class FrmAddUpdateVehicle : Form
    {
        private enum EnMode : byte { AddNew = 0, Update = 1 };
        private EnMode _mode = EnMode.AddNew;


        public event EventHandler<int?> NewVehicleAdded;
        protected virtual void OnNewVehicleAdded()
        {
            NewVehicleAdded?.Invoke(this, _vehicleID);
        }


        private int? _vehicleID = null;
        private Vehicle _vehicle = null;

        public FrmAddUpdateVehicle(int? vehicleID)
        {
            InitializeComponent();
            _mode = EnMode.Update;
            _vehicleID = vehicleID;
        }
        public FrmAddUpdateVehicle()
        {
            InitializeComponent();
            _mode = EnMode.AddNew;
        }

        private void Reset()
        {
            FillMakesInComboBox();
            FillDriveTypesInComboBox();
            FillFuelTypesInComboBox();

            if (_mode == EnMode.AddNew)
            {
                _vehicle = new Vehicle();
                lblTitle.Text = "Add New Vehicle";
            }

            else
            {
                lblTitle.Text = "Update Vehicle";
            }

            ckbIsAvailableForRent.Checked = true;
        }

        private void FillMakesInComboBox()
        {
            foreach (DataRow row in Make.GetAllMakes().Rows)
            {
                cbMakes.Items.Add((string)row["Make"]);
            }

            cbMakes.SelectedIndex = 0;
        }

        private void FillMakeModelsInComboBox(int MakeID)
        {
            cbModels.Items.Clear();

            foreach (DataRow row in Model.GetAllModelsPerMake(MakeID).Rows)
            {
                cbModels.Items.Add((string)row["ModelName"]);
            }

            cbModels.SelectedIndex = 0;
        }

        private void FillSubModelsInComboBox(int ModelID)
        {
            cbSubModels.Items.Clear();

            foreach (DataRow row in SubModel.GetAllSubModelsPerModel(ModelID).Rows)
            {
                cbSubModels.Items.Add((string)row["SubModelName"]);
            }

            cbSubModels.SelectedIndex = 0;
        }

        private void FillDriveTypesInComboBox()
        {
            foreach (DataRow row in DriveType.GetAllDriveTypes().Rows)
            {
                cbDriveTypes.Items.Add((string)row["DriveTypeName"]);
            }

            cbDriveTypes.SelectedIndex = 0;
        }

        private void FillFuelTypesInComboBox()
        {
            foreach (DataRow row in FuelType.GetAllFuelTypes().Rows)
            {
                cbFuelTypes.Items.Add((string)row["FuelTypeName"]);
            }

            cbFuelTypes.SelectedIndex = 0;
        }

        private void LoadVehicleData()
        {
            _vehicle = Vehicle.Find(_vehicleID);

            if (_vehicle == null)
            {
                MessageBox.Show($"No vehicle with VehicleID = {_vehicleID} was found in the system !", "Not Found !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            txtVehicleID.Text = _vehicleID.ToString();
            txtVehicleName.Text = _vehicle.VehicleName;
            txtYear.Text = _vehicle.Year.ToString();
            txtEngine.Text = _vehicle.Engine ?? string.Empty;
            txtMileage.Text = _vehicle.Mileage.ToString();
            txtRentalPricePerDay.Text = _vehicle.RentalPricePerDay.ToString().Replace(',', '.');

            cbMakes.SelectedIndex = cbMakes.FindString(_vehicle.SubModelInfo.ModelInfo.MakeInfo.Name);
            cbModels.SelectedIndex = cbModels.FindString(_vehicle.SubModelInfo.ModelInfo.ModelName);
            cbSubModels.SelectedIndex = cbSubModels.FindString(_vehicle.SubModelInfo.SubModelName);
            cbFuelTypes.SelectedIndex = cbFuelTypes.FindString(_vehicle.FuelTypeInfo.FuelTypeName);
            cbDriveTypes.SelectedIndex = cbDriveTypes.FindString(_vehicle.DriveTypeInfo.DriveTypeName);

            nudNumberOfDoors.Value = _vehicle.NumDoors;
            ckbIsAvailableForRent.Checked = _vehicle.IsAvailableForRent;
        }

        private bool SaveVehicleData()
        {

            _vehicle.VehicleName = txtVehicleName.Text.Trim();
            _vehicle.Year = Convert.ToInt16(txtYear.Text.Trim());
            _vehicle.Engine = string.IsNullOrEmpty(txtEngine.Text.Trim()) ? null : txtEngine.Text.Trim();
            _vehicle.Mileage = Convert.ToInt16(txtMileage.Text.Trim());
            _vehicle.RentalPricePerDay = float.Parse(txtRentalPricePerDay.Text.Trim(), NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture);
            _vehicle.NumDoors = (byte)nudNumberOfDoors.Value;
            _vehicle.IsAvailableForRent = ckbIsAvailableForRent.Checked;
            _vehicle.DriveTypeID = DriveType.Find(cbDriveTypes.Text).DriveTypeID.Value;
            _vehicle.FuelTypeID = FuelType.Find(cbFuelTypes.Text).FuelTypeID.Value;
            _vehicle.MakeID = Make.Find(cbMakes.Text).MakeID.Value;
            _vehicle.ModelID = Model.Find(cbModels.Text).ModelID.Value;
            _vehicle.SubModelID = SubModel.Find(cbSubModels.Text).SubModelID.Value;

            if (!_vehicle.Save())
            {
                MessageBox.Show("Failed to save the data !", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            else
            {
                MessageBox.Show("Data was saved successfully !", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                _mode = EnMode.Update;
                _vehicleID = _vehicle.VehicleID;

                lblTitle.Text = "Update Vehicle";
                txtVehicleID.Text = _vehicleID.ToString();
            }

            return true;
        }

        private void FrmAddUpdateVehicle_Load(object sender, EventArgs e)
        {
            Reset();

            if (_mode == EnMode.Update)
                LoadVehicleData();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren())
            {
                MessageBox.Show("Some fields are not valid , please put the mouse over the red icon(s) to see the error", "Validation Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (SaveVehicleData())
                OnNewVehicleAdded();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CbMakes_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillMakeModelsInComboBox(Make.Find(cbMakes.Text).MakeID.Value);
        }

        private void CbModels_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillSubModelsInComboBox(Model.Find(cbModels.Text).ModelID.Value);
        }

        private void TxtYear_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtYear.Text.Trim()))
            {
                e.Cancel = true;
                txtYear.Focus();
                errorProvider1.SetError(txtYear, "This field is required !");
            }

            else if (!Validation.IsValidYear(txtYear.Text.Trim()))
            {
                e.Cancel = true;
                txtYear.Focus();
                errorProvider1.SetError(txtYear, "This number is not valid !");
            }

            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtYear, null);
            }
        }

        private void TxtVehicleName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtVehicleName.Text.Trim()))
            {
                e.Cancel = true;
                txtVehicleName.Focus();
                errorProvider1.SetError(txtVehicleName, "This field is required !");
            }

            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtVehicleName, null);
            }
        }

        private void TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar);
        }

        private void TxtRentalPricePerDay_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtRentalPricePerDay.Text.Trim()))
            {
                e.Cancel = true;
                txtRentalPricePerDay.Focus();
                errorProvider1.SetError(txtRentalPricePerDay, "This field is required !");
            }

            else if (!Validation.IsValidNumber(txtRentalPricePerDay.Text.Trim()))
            {
                e.Cancel = true;
                txtRentalPricePerDay.Focus();
                errorProvider1.SetError(txtRentalPricePerDay, "This number is not valid !");
            }

            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtRentalPricePerDay, null);
            }
        }

        private void TxtRentalPricePerDay_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.';
        }

    }
}
