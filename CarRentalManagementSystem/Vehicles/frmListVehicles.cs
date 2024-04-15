using CarRental_BusinessLayer;
using CarRentalManagementSystem.Bookings;
using CarRentalManagementSystem.Maintenances;
using System;
using System.Data;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRentalManagementSystem.Vehicles
{
    public partial class FrmListVehicles : Form
    {
        private enum FilterOptions
        {
            Make,
            Model,
            SubModel,
            DriveType,
            FuelType,
            Status,
        }

        private FilterOptions _selectedOption;

        private DataView _vehiclesDataView = new DataView();

        private int _pageNumber = 1;

        private int _pageSize = 10;

        private int _totalPages = 0;

        public FrmListVehicles()
        {
            InitializeComponent();
            btnPreviousPage.Enabled = false;
        }

        private async void FillMakesInComboBoxAsync()
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

        private async void FillMakeModelsInComboBoxAsync()
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

        private async void FillSubModelsInComboBoxAsync()
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

        private async void FillDriveTypesInComboBoxAsync()
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

        private async void FillFuelTypesInComboBoxAsync()
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

        private void FillFilterOptionsInComboBox(FilterOptions option)
        {
            cbTemp.Items.Clear();

            switch (option)
            {
                case FilterOptions.Status:
                    cbTemp.Items.AddRange(new object[] { "All", "Available", "Rented" });
                    cbTemp.SelectedIndex = 0;
                    break;

                case FilterOptions.Make:
                    FillMakesInComboBoxAsync();
                    break;

                case FilterOptions.Model:
                    FillMakeModelsInComboBoxAsync();
                    break;

                case FilterOptions.SubModel:
                    FillSubModelsInComboBoxAsync();
                    break;

                case FilterOptions.DriveType:
                    FillDriveTypesInComboBoxAsync();
                    break;

                case FilterOptions.FuelType:
                    FillFuelTypesInComboBoxAsync();
                    break;
            }
        }

        private void RefreshVehiclesList()
        {
            _vehiclesDataView = Vehicle.GetVehiclesPaginated(_pageNumber, _pageSize).DefaultView;
            dgvVehiclesList.DataSource = _vehiclesDataView;

            cbFilterByOptions.SelectedIndex = 0;
        }

        private void FilterVehiclesList()
        {
            if (string.IsNullOrEmpty(txtFilterValue.Text))
            {
                _vehiclesDataView.RowFilter = null;
                return;
            }

            if (cbFilterByOptions.Text == "Vehicle ID" || cbFilterByOptions.Text == "Doors")
                _vehiclesDataView.RowFilter = string.Format("[{0}] = {1}", cbFilterByOptions.Text, txtFilterValue.Text);

            else if (cbFilterByOptions.Text == "Rental Price Per Day")
                _vehiclesDataView.RowFilter = string.Format("Convert([{0}], 'System.String') LIKE '%{1}%'", cbFilterByOptions.Text,
                                                            txtFilterValue.Text.Trim().Replace('.', ','));

            else
                _vehiclesDataView.RowFilter = string.Format("[{0}] LIKE '%{1}%'", cbFilterByOptions.Text, txtFilterValue.Text);
        }

        private void FrmListVehicles_Load(object sender, EventArgs e)
        {
            _totalPages = GetTotalPages();
            RefreshVehiclesList();
        }

        private void CbFilterByOptions_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Enum.TryParse(cbFilterByOptions.Text.Replace(" ", ""), true, out _selectedOption))
            {
                txtFilterValue.Visible = false;
                cbTemp.Visible = true;
                FillFilterOptionsInComboBox(_selectedOption);
            }

            else
            {
                cbTemp.Visible = false;
                txtFilterValue.Visible = (cbFilterByOptions.Text != "None");
                txtFilterValue.ResetText();
                txtFilterValue.Focus();
                TxtFilterValue_TextChanged(null, null);
            }

        }

        private void CbTemp_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbTemp.Text == "All")
            {
                _vehiclesDataView.RowFilter = null;
                return;
            }

            _vehiclesDataView.RowFilter = string.Format("[{0}] = '{1}'", cbFilterByOptions.Text, cbTemp.Text);
        }

        private void TxtFilterValue_TextChanged(object sender, EventArgs e)
        {
            FilterVehiclesList();
        }

        private void TxtFilterValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbFilterByOptions.Text == "Vehicle ID" || cbFilterByOptions.Text == "Doors")
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

            else if (cbFilterByOptions.Text == "Rental Price Per Day")
                e.Handled = !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != ',';
        }

        private void BtnAddNewVehicle_Click(object sender, EventArgs e)
        {
            addNewVehicleToolStripMenuItem.PerformClick();
        }

        private void AddNewVehicleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAddUpdateVehicle form = new FrmAddUpdateVehicle();
            form.ShowDialog();

            RefreshVehiclesList();
        }

        private void EditVehiclesInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAddUpdateVehicle form = new FrmAddUpdateVehicle((int)dgvVehiclesList.CurrentRow.Cells[0].Value);
            form.ShowDialog();

            RefreshVehiclesList();
        }

        private void ShowVehiclesInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmShowVehicleDetails form = new FrmShowVehicleDetails((int)dgvVehiclesList.CurrentRow.Cells[0].Value);
            form.ShowDialog();
        }

        private void DeleteVehiclesToolStripMenuItem_Click(object sender, EventArgs e)
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

                RefreshVehiclesList();
            }

        }

        private void DgvVehiclesList_SelectionChanged(object sender, EventArgs e)
        {
            cbVehicles.Enabled = dgvVehiclesList.SelectedRows.Count > 0;
        }

        private void DgvVehiclesList_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            showVehicleInformationToolStripMenuItem.PerformClick();
        }

        private int GetTotalPages()
        {
            return (int)Math.Ceiling((Convert.ToDouble(Vehicle.GetTotalVehiclesCount()) / _pageSize));
        }

        private void UpdateButtonStates()
        {
            btnPreviousPage.Enabled = (_pageNumber != 1);
            btnNextPage.Enabled = (_pageNumber < _totalPages);
        }

        private void CbPageSizes_SelectedIndexChanged(object sender, EventArgs e)
        {
            _pageSize = Convert.ToInt16(cbPageSizes.Text);
            RefreshVehiclesList();
        }

        private void BtnPreviousPage_Click(object sender, EventArgs e)
        {
            if (btnPreviousPage.Enabled)
            {
                btnCurrentPage.Text = (--_pageNumber).ToString();
                RefreshVehiclesList();
            }

            UpdateButtonStates();
        }

        private void BtnNextPage_Click(object sender, EventArgs e)
        {
            if (btnNextPage.Enabled)
            {
                btnCurrentPage.Text = (++_pageNumber).ToString();
                RefreshVehiclesList();
            }
            UpdateButtonStates();
        }

        private void MaintainVehicleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMaintainVehicle form = new FrmMaintainVehicle((int)dgvVehiclesList.CurrentRow.Cells[0].Value);
            form.ShowDialog();
        }

        private void CbVehicles_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Vehicle vehicle = Vehicle.Find((int)dgvVehiclesList.CurrentRow.Cells[0].Value);

            maintainVehicleToolStripMenuItem.Enabled = vehicle.IsAvailableForRent;
            deleteVehicleToolStripMenuItem.Enabled = vehicle.IsAvailableForRent;
        }

        private void ShowVehicleBookingHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmShowVehicleBookingHistory form = new FrmShowVehicleBookingHistory((int)dgvVehiclesList.CurrentRow.Cells[0].Value);
            form.ShowDialog();
        }

        private void ShowVehicleMaintenanceHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmShowVehicleMaintenanceHistory form = new FrmShowVehicleMaintenanceHistory((int)dgvVehiclesList.CurrentRow.Cells[0].Value);
            form.ShowDialog();
        }
    }
}
