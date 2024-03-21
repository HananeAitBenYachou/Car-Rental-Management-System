using CarRental_BusinessLayer;
using System;
using System.Data;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRentalManagementSystem.Vehicles
{
    public partial class frmListVehicles : Form
    {
        private enum _FilterOptions
        {
            Make,
            Model,
            SubModel,
            DriveType,
            FuelType,
            Status,
        }

        private _FilterOptions _SelectedOption;

        private DataView _VehiclesDataView = new DataView();

        private int _PageNumber = 1;

        private int _PageSize = 10;

        private int _TotalPages = 0;

        public frmListVehicles()
        {
            InitializeComponent();
            btnPreviousPage.Enabled = false;
        }

        private async void _FillMakesInComboBoxAsync()
        {
            await Task.Run(() =>
            {
                cbTemp.Invoke(new Action(() =>
                {
                    foreach (DataRow row in Make.GetAllMakes().Rows)
                    {
                        cbTemp.Items.Add((string)row["Make"]);
                    }

                    cbTemp.SelectedIndex = 0;

                }));
            });
        }

        private async void _FillMakeModelsInComboBoxAsync()
        {
            await Task.Run(() =>
            {
                cbTemp.Invoke(new Action(() =>
                {
                    foreach (DataRow row in Model.GetAllModels().Rows)
                    {
                        cbTemp.Items.Add((string)row["ModelName"]);
                    }

                    cbTemp.SelectedIndex = 0;

                }));
            });
        }

        private async void _FillSubModelsInComboBoxAsync()
        {
            await Task.Run(() =>
            {
                cbTemp.Invoke(new Action(() =>
                {
                    foreach (DataRow row in SubModel.GetAllSubModels().Rows)
                    {
                        cbTemp.Items.Add((string)row["SubModelName"]);
                    }

                    cbTemp.SelectedIndex = 0;

                }));
            });
        }

        private async void _FillDriveTypesInComboBoxAsync()
        {
            await Task.Run(() =>
            {
                cbTemp.Invoke(new Action(() =>
                {
                    foreach (DataRow row in DriveType.GetAllDriveTypes().Rows)
                    {
                        cbTemp.Items.Add((string)row["DriveTypeName"]);
                    }

                    cbTemp.SelectedIndex = 0;

                }));
            });
        }

        private async void _FillFuelTypesInComboBoxAsync()
        {
            await Task.Run(() =>
            {
                cbTemp.Invoke(new Action(() =>
                {
                    foreach (DataRow row in FuelType.GetAllFuelTypes().Rows)
                    {
                        cbTemp.Items.Add((string)row["FuelTypeName"]);
                    }

                    cbTemp.SelectedIndex = 0;

                }));
            });
        }

        private void _FillFilterOptionsInComboBox(_FilterOptions option)
        {
            cbTemp.Items.Clear();

            switch (option)
            {
                case _FilterOptions.Status:
                    cbTemp.Items.AddRange(new object[] { "All", "Available", "Rented" });
                    cbTemp.SelectedIndex = 0;
                    break;

                case _FilterOptions.Make:
                    _FillMakesInComboBoxAsync();
                    break;

                case _FilterOptions.Model:
                    _FillMakeModelsInComboBoxAsync();
                    break;

                case _FilterOptions.SubModel:
                    _FillSubModelsInComboBoxAsync();
                    break;

                case _FilterOptions.DriveType:
                    _FillDriveTypesInComboBoxAsync();
                    break;

                case _FilterOptions.FuelType:
                    _FillFuelTypesInComboBoxAsync();
                    break;
            }
        }

        private void _RefreshVehiclesList()
        {
            _VehiclesDataView = Vehicle.GetAllVehicles(_PageNumber, _PageSize).DefaultView;
            dgvVehiclesList.DataSource = _VehiclesDataView;

            cbFilterByOptions.SelectedIndex = 0;
        }

        private void _FilterVehiclesList()
        {
            if (string.IsNullOrEmpty(txtFilterValue.Text))
            {
                _VehiclesDataView.RowFilter = null;
                return;
            }

            if (cbFilterByOptions.Text == "Vehicle ID" || cbFilterByOptions.Text == "Doors")
                _VehiclesDataView.RowFilter = string.Format("[{0}] = {1}", cbFilterByOptions.Text, txtFilterValue.Text);

            else if (cbFilterByOptions.Text == "Rental Price Per Day")
                _VehiclesDataView.RowFilter = string.Format("Convert([{0}], 'System.String') LIKE '%{1}%'", cbFilterByOptions.Text,
                                                            txtFilterValue.Text.Trim().Replace('.', ','));

            else
                _VehiclesDataView.RowFilter = string.Format("[{0}] LIKE '%{1}%'", cbFilterByOptions.Text, txtFilterValue.Text);
        }

        private void frmListVehicles_Load(object sender, EventArgs e)
        {
            _TotalPages = _GetTotalPages();
            _RefreshVehiclesList();
        }

        private void cbFilterByOptions_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Enum.TryParse(cbFilterByOptions.Text.Replace(" ", ""), true, out _SelectedOption))
            {
                txtFilterValue.Visible = false;
                cbTemp.Visible = true;
                _FillFilterOptionsInComboBox(_SelectedOption);
            }

            else
            {
                cbTemp.Visible = false;
                txtFilterValue.Visible = (cbFilterByOptions.Text != "None");
                txtFilterValue.ResetText();
                txtFilterValue.Focus();
                txtFilterValue_TextChanged(null, null);
            }

        }

        private void cbTemp_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbTemp.Text == "All")
            {
                _VehiclesDataView.RowFilter = null;
                return;
            }

            _VehiclesDataView.RowFilter = string.Format("[{0}] = '{1}'", cbFilterByOptions.Text, cbTemp.Text);
        }

        private void txtFilterValue_TextChanged(object sender, EventArgs e)
        {
            _FilterVehiclesList();
        }

        private void txtFilterValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbFilterByOptions.Text == "Vehicle ID" || cbFilterByOptions.Text == "Doors")
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

            else if (cbFilterByOptions.Text == "Rental Price Per Day")
                e.Handled = !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != ',';
        }

        private void btnAddNewVehicle_Click(object sender, EventArgs e)
        {
            addNewVehicleToolStripMenuItem.PerformClick();
        }

        private void addNewVehicleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddUpdateVehicle form = new frmAddUpdateVehicle();
            form.ShowDialog();

            _RefreshVehiclesList();
        }

        private void editVehiclesInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddUpdateVehicle form = new frmAddUpdateVehicle((int)dgvVehiclesList.CurrentRow.Cells[0].Value);
            form.ShowDialog();

            _RefreshVehiclesList();
        }

        private void showVehiclesInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmShowVehicleDetails form = new frmShowVehicleDetails((int)dgvVehiclesList.CurrentRow.Cells[0].Value);
            form.ShowDialog();
        }

        private void deleteVehiclesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete the selected vehicle ?", "Verification",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.Cancel)
                return;

            if (!Vehicle.DeleteVehicle((int)dgvVehiclesList.CurrentRow.Cells[0].Value))
                MessageBox.Show("Failed to delete The selected vehicle , due to the data connected to it !", "Deletion Failed",
                 MessageBoxButtons.OK, MessageBoxIcon.Information);

            else
            {
                MessageBox.Show("The selected vehicle has been deleted successfully .", "Deletion Completed",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

                _RefreshVehiclesList();
            }

        }

        private void dgvVehiclesList_SelectionChanged(object sender, EventArgs e)
        {
            cbVehicles.Enabled = dgvVehiclesList.SelectedRows.Count > 0 ? true : false;
        }

        private void dgvVehiclesList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            showVehicleInformationToolStripMenuItem.PerformClick();
        }

        private int _GetTotalPages()
        {
            return (int)Math.Ceiling((Convert.ToDouble(Vehicle.GetTotalVehiclesCount()) / _PageSize));
        }

        private void _UpdateButtonStates()
        {
            btnPreviousPage.Enabled = (_PageNumber != 1);
            btnNextPage.Enabled = (_PageNumber < _TotalPages);
        }

        private void cbPageSizes_SelectedIndexChanged(object sender, EventArgs e)
        {
            _PageSize = Convert.ToInt16(cbPageSizes.Text);
            _RefreshVehiclesList();
        }

        private void btnPreviousPage_Click(object sender, EventArgs e)
        {
            if (btnPreviousPage.Enabled)
            {
                btnCurrentPage.Text = (--_PageNumber).ToString();
                _RefreshVehiclesList();
            }

            _UpdateButtonStates();
        }

        private void btnNextPage_Click(object sender, EventArgs e)
        {
            if (btnNextPage.Enabled)
            {
                btnCurrentPage.Text = (++_PageNumber).ToString();
                _RefreshVehiclesList();
            }
            _UpdateButtonStates();
        }
    }
}
