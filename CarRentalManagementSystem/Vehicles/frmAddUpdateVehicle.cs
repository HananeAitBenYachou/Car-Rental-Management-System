using CarRental_BusinessLayer;
using CarRental_UtilityLayer;
using System;
using System.ComponentModel;
using System.Data;
using System.Globalization;
using System.Windows.Forms;

namespace CarRentalManagementSystem.Vehicles
{
    public partial class frmAddUpdateVehicle : Form
    {
        private enum _enMode : byte { AddNew = 0, Update = 1 };
        private _enMode _Mode = _enMode.AddNew;


        public event EventHandler<int?> NewVehicleAdded;
        protected virtual void OnNewVehicleAdded()
        {
            NewVehicleAdded?.Invoke(this, _VehicleID);
        }


        private int? _VehicleID = null;
        private Vehicle _Vehicle = null;

        public frmAddUpdateVehicle(int? vehicleID)
        {
            InitializeComponent();
            _Mode = _enMode.Update;
            _VehicleID = vehicleID;
        }
        public frmAddUpdateVehicle()
        {
            InitializeComponent();
            _Mode = _enMode.AddNew;
        }

        private void _Reset()
        {
            _FillMakesInComboBox();
            _FillDriveTypesInComboBox();
            _FillFuelTypesInComboBox();

            if (_Mode == _enMode.AddNew)
            {
                _Vehicle = new Vehicle();
                lblTitle.Text = "Add New Vehicle";
            }

            else
            {
                lblTitle.Text = "Update Vehicle";
            }

            ckbIsAvailableForRent.Checked = true;
        }

        private void _FillMakesInComboBox()
        {
            foreach (DataRow row in Make.GetAllMakes().Rows)
            {
                cbMakes.Items.Add((string)row["Make"]);
            }

            cbMakes.SelectedIndex = 0;
        }

        private void _FillMakeModelsInComboBox(int MakeID)
        {
            cbModels.Items.Clear();

            foreach (DataRow row in Model.GetAllModelsPerMake(MakeID).Rows)
            {
                cbModels.Items.Add((string)row["ModelName"]);
            }

            cbModels.SelectedIndex = 0;
        }

        private void _FillSubModelsInComboBox(int ModelID)
        {
            cbSubModels.Items.Clear();

            foreach (DataRow row in SubModel.GetAllSubModelsPerModel(ModelID).Rows)
            {
                cbSubModels.Items.Add((string)row["SubModelName"]);
            }

            cbSubModels.SelectedIndex = 0;
        }

        private void _FillDriveTypesInComboBox()
        {
            foreach (DataRow row in DriveType.GetAllDriveTypes().Rows)
            {
                cbDriveTypes.Items.Add((string)row["DriveTypeName"]);
            }

            cbDriveTypes.SelectedIndex = 0;
        }

        private void _FillFuelTypesInComboBox()
        {
            foreach (DataRow row in FuelType.GetAllFuelTypes().Rows)
            {
                cbFuelTypes.Items.Add((string)row["FuelTypeName"]);
            }

            cbFuelTypes.SelectedIndex = 0;
        }

        private void _LoadVehicleData()
        {
            _Vehicle = Vehicle.Find(_VehicleID);

            if (_Vehicle == null)
            {
                MessageBox.Show($"No vehicle with VehicleID = {_VehicleID} was found in the system !", "Not Found !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            txtVehicleID.Text = _VehicleID.ToString();
            txtVehicleName.Text = _Vehicle.VehicleName;
            txtYear.Text = _Vehicle.Year.ToString();
            txtEngine.Text = _Vehicle.Engine ?? string.Empty;
            txtMileage.Text = _Vehicle.Mileage.ToString();
            txtRentalPricePerDay.Text = _Vehicle.RentalPricePerDay.ToString().Replace(',', '.');

            cbMakes.SelectedIndex = cbMakes.FindString(_Vehicle.SubModelInfo.ModelInfo.MakeInfo.Name);
            cbModels.SelectedIndex = cbModels.FindString(_Vehicle.SubModelInfo.ModelInfo.ModelName);
            cbSubModels.SelectedIndex = cbSubModels.FindString(_Vehicle.SubModelInfo.SubModelName);
            cbFuelTypes.SelectedIndex = cbFuelTypes.FindString(_Vehicle.FuelTypeInfo.FuelTypeName);
            cbDriveTypes.SelectedIndex = cbDriveTypes.FindString(_Vehicle.DriveTypeInfo.DriveTypeName);

            nudNumberOfDoors.Value = _Vehicle.NumDoors;
            ckbIsAvailableForRent.Checked = _Vehicle.IsAvailableForRent;
        }

        private bool _SaveVehicleData()
        {

            _Vehicle.VehicleName = txtVehicleName.Text.Trim();
            _Vehicle.Year = Convert.ToInt16(txtYear.Text.Trim());
            _Vehicle.Engine = string.IsNullOrEmpty(txtEngine.Text.Trim()) ? null : txtEngine.Text.Trim();
            _Vehicle.Mileage = Convert.ToInt16(txtMileage.Text.Trim());
            _Vehicle.RentalPricePerDay = float.Parse(txtRentalPricePerDay.Text.Trim(), NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture);
            _Vehicle.NumDoors = (byte)nudNumberOfDoors.Value;
            _Vehicle.IsAvailableForRent = ckbIsAvailableForRent.Checked;
            _Vehicle.DriveTypeID = DriveType.Find(cbDriveTypes.Text).DriveTypeID.Value;
            _Vehicle.FuelTypeID = FuelType.Find(cbFuelTypes.Text).FuelTypeID.Value;
            _Vehicle.MakeID = Make.Find(cbMakes.Text).MakeID.Value;
            _Vehicle.ModelID = Model.Find(cbModels.Text).ModelID.Value;
            _Vehicle.SubModelID = SubModel.Find(cbSubModels.Text).SubModelID.Value;

            if (!_Vehicle.Save())
            {
                MessageBox.Show("Failed to save the data !", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            else
            {
                MessageBox.Show("Data was saved successfully !", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                _Mode = _enMode.Update;
                _VehicleID = _Vehicle.VehicleID;

                lblTitle.Text = "Update Vehicle";
                txtVehicleID.Text = _VehicleID.ToString();
            }

            return true;
        }

        private void frmAddUpdateVehicle_Load(object sender, EventArgs e)
        {
            _Reset();

            if (_Mode == _enMode.Update)
                _LoadVehicleData();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren())
            {
                MessageBox.Show("Some fields are not valid , please put the mouse over the red icon(s) to see the error", "Validation Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (_SaveVehicleData())
                OnNewVehicleAdded();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbMakes_SelectedIndexChanged(object sender, EventArgs e)
        {
            _FillMakeModelsInComboBox(Make.Find(cbMakes.Text).MakeID.Value);
        }

        private void cbModels_SelectedIndexChanged(object sender, EventArgs e)
        {
            _FillSubModelsInComboBox(Model.Find(cbModels.Text).ModelID.Value);
        }

        private void txtYear_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtYear.Text.Trim()))
            {
                e.Cancel = true;
                txtYear.Focus();
                errorProvider1.SetError(txtYear, "This field is required !");
            }

            else if (!clsValidation.IsValidYear(txtYear.Text.Trim()))
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

        private void txtVehicleName_Validating(object sender, CancelEventArgs e)
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

        private void txtRentalPricePerDay_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtRentalPricePerDay.Text.Trim()))
            {
                e.Cancel = true;
                txtRentalPricePerDay.Focus();
                errorProvider1.SetError(txtRentalPricePerDay, "This field is required !");
            }

            else if (!clsValidation.IsValidNumber(txtRentalPricePerDay.Text.Trim()))
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

        private void txtRentalPricePerDay_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.';
        }

    }
}
