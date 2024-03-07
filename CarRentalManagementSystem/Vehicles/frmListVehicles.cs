﻿using CarRental_BusinessLayer;
using CarRentalManagementSystem.Customers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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

        private DataView _VehiclesDataView;

        public frmListVehicles()
        {
            InitializeComponent();
        }

        private async void _FillMakesInComboBoxAsync()
        {
            await Task.Run(() =>
            {
                cbTemp.Invoke(new Action(() =>
                {
                    foreach (DataRow row in clsMake.GetAllMakes().Rows)
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
                    foreach (DataRow row in clsModel.GetAllModels().Rows)
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
                    foreach (DataRow row in clsSubModel.GetAllSubModels().Rows)
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
                    foreach (DataRow row in clsDriveType.GetAllDriveTypes().Rows)
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
                    foreach (DataRow row in clsFuelType.GetAllFuelTypes().Rows)
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
            _VehiclesDataView = clsVehicle.GetAllVehicles().DefaultView;
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

            if (cbFilterByOptions.Text == "Vehicle ID" || cbFilterByOptions.Text == "Doors" || cbFilterByOptions.Text == "Rental Price Per Day")
                _VehiclesDataView.RowFilter = string.Format("[{0}] = {1}", cbFilterByOptions.Text, txtFilterValue.Text);
            else
                _VehiclesDataView.RowFilter = string.Format("[{0}] LIKE '%{1}%'", cbFilterByOptions.Text, txtFilterValue.Text);
        }

        private void frmListVehicles_Load(object sender, EventArgs e)
        {
            _RefreshVehiclesList();
        }

        private void cbFilterByOptions_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Enum.TryParse(cbFilterByOptions.Text.Replace(' ','\0'), out _SelectedOption))
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
            if (cbFilterByOptions.Text == "Vehicle ID" || cbFilterByOptions.Text == "Doors" || cbFilterByOptions.Text == "Rental Price Per Day")
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void btnAddNewVehicle_Click(object sender, EventArgs e)
        {
            //Not Implemented yet !
        }

        private void addNewVehiclesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Not Implemented yet !
        }

        private void editVehiclesInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Not Implemented yet !
        }

        private void showVehiclesInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Not Implemented yet !
        }

        private void deleteVehiclesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete the selected vehicle ?", "Verification",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.Cancel)
                return;

            if (!clsVehicle.DeleteVehicle((int)dgvVehiclesList.CurrentRow.Cells[0].Value))
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
    }
}
