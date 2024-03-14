﻿using CarRental_BusinessLayer;
using CarRentalManagementSystem.Customers.UserControls;
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

namespace CarRentalManagementSystem.Vehicles.UserControls
{
    public partial class ucVehicleCardWithFilter : UserControl
    {
        public class VehicleFoundEventArgs : EventArgs
        {
            public int? VehicleID { get; }

            public bool IsAvailableForRent { get; }

            public double RentalPricePerDay { get; }

            public VehicleFoundEventArgs(int? vehicleID , bool isAvailableForRent , double rentalPricePerDay)
            {
                VehicleID = vehicleID;
                IsAvailableForRent = isAvailableForRent;
                RentalPricePerDay = rentalPricePerDay;
            }

        }

        private int? _VehicleID => ucVehicleCard1.VehicleID;
        private clsVehicle _Vehicle => ucVehicleCard1.Vehicle;

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
                    txtFilterValue.Focus();
            }
        }


        public event EventHandler<VehicleFoundEventArgs> VehicleFound;
        private void _RaiseOnVehicleFoundEvent()
        {
            OnVehicleFound(new VehicleFoundEventArgs(_VehicleID, _Vehicle.IsAvailableForRent, _Vehicle.RentalPricePerDay));
        }
        protected virtual void OnVehicleFound(VehicleFoundEventArgs vehicleInfo)
        {
            VehicleFound?.Invoke(this,vehicleInfo);
        }

        public ucVehicleCardWithFilter()
        {
            InitializeComponent();
        }

        public void Reset()
        {
            txtFilterValue.ResetText();
            ucVehicleCard1.Reset();
            FilterEnabled = true;
        }

        public void LoadVehicleData(int? vehicleID)
        {
            txtFilterValue.Text = vehicleID.ToString();
            _FindVehicle();
        }

        private void _ClearErrorProvider()
        {
            errorProvider1.SetError(txtFilterValue, null);
        }

        private bool _FindVehicle()
        {
            return ucVehicleCard1.LoadVehicleData(Convert.ToInt16(txtFilterValue.Text.Trim()));
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

        private void txtFilterValue_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtFilterValue.Text))
            {
                e.Cancel = true;
                txtFilterValue.Focus();
                errorProvider1.SetError(txtFilterValue,"Please enter the vehicle'ID you want to search !");
            }

            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtFilterValue, null);
            }
        }

        private void txtFilterValue_KeyPress(object sender, KeyPressEventArgs e)
        {
           e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

    }
}