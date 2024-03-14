﻿using CarRental_BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRentalManagementSystem.Bookings
{
    public partial class frmShowBookingDetails : Form
    {
        private int? _BookingID  = null;
        private clsRentalBooking _Booking = null;

        public frmShowBookingDetails(int? bookingID)
        {
            InitializeComponent();
            _BookingID = bookingID;
        }

        private void _LoadRentalBookingData()
        {
            _Booking = clsRentalBooking.Find(_BookingID);

            if (_Booking == null)
            {
                MessageBox.Show($"No booking with bookingID = {_BookingID} was found in the system !", "Not Found !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnClose.PerformClick();
                return;

            }

            ucCustomerCard1.LoadCustomerData(_Booking.CustomerID);
            ucVehicleCard1.LoadVehicleData(_Booking.VehicleID);

            txtBookingID.Text = _BookingID.ToString();
            txtCustomerID.Text = _Booking.CustomerID.ToString();
            txtVehicleID.Text = _Booking.VehicleID.ToString();
            txtRentalPricePerDay.Text = _Booking.VehicleInfo.RentalPricePerDay.ToString();
            txtInitialTotalDueAmount.Text = _Booking.InitialTotalDueAmount.ToString();
            txtPickUpLocation.Text = _Booking.PickupLocation;
            txtDropOffLocation.Text = _Booking.DropoffLocation;
            txtRentalPricePerDay.Text = _Booking.RentalPricePerDay.ToString();
            txtInitialCheckNotes.Text = _Booking.InitialCheckNotes ?? string.Empty;
            dtpStartDate.Value = _Booking.RentalStartDate;
            dtpEndDate.Value = _Booking.RentalEndDate;
            nudInitialRentalDays.Value = _Booking.InitialRentalDays;
        }

        private void frmShowBookingDetails_Load(object sender, EventArgs e)
        {
            _LoadRentalBookingData();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
