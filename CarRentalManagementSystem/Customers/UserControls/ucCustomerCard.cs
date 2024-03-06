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
using static CarRental_BusinessLayer.clsCustomer;
using static CarRental_BusinessLayer.clsUser;

namespace CarRentalManagementSystem.Customers.UserControls
{
    public partial class ucCustomerCard : UserControl
    {
        public int? PersonID => ucPersonCard1.PersonID;
        public clsPerson Person => ucPersonCard1.Person;

        public int? CustomerID { get; private set; } = null;
        public clsCustomer Customer { get; private set; } = null;

        public ucCustomerCard()
        {
            InitializeComponent();
        }

        public void Reset()
        {
            txtCustomerID.Text = "N/A";
            txtLicenseNo.ResetText();
            ucPersonCard1.Reset();

            CustomerID = null;
            Customer = null;
        }

        private void _LoadCustomerData()
        {
            CustomerID = Customer.CustomerID;

            txtCustomerID.Text = CustomerID.ToString();
            txtLicenseNo.Text = Customer.DriverLicenseNumber;

            ucPersonCard1.LoadPersonData(Customer.PersonID);
        }

        public void LoadCustomerData(int? customerID)
        {
            Customer = clsCustomer.Find<int?>(customerID, enFindCustomerBy.CustomerID);

            if (Customer == null)
            {
                MessageBox.Show($"No customer with ID = {customerID} was found in the system !", "Not Found !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Reset();
                return;
            }

            _LoadCustomerData();
        }

        public void LoadCustomerData(string driverLicenseNumber)
        {
            Customer = clsCustomer.Find<string>(driverLicenseNumber, enFindCustomerBy.LicenseNumber);

            if (Customer == null)
            {
                MessageBox.Show($"No customer with License Number = {driverLicenseNumber} was found in the system !", "Not Found !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Reset();
                return;
            }

            _LoadCustomerData();
        }
    }
}