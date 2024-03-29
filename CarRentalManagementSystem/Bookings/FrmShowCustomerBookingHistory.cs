using CarRental_BusinessLayer;
using CarRentalManagementSystem.Vehicles.UserControls;
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
    public partial class FrmShowCustomerBookingHistory : Form
    {
        private int? _customerID = null;

        public FrmShowCustomerBookingHistory(int? customerID)
        {
            InitializeComponent();
            this.HScroll = false;
            _customerID = customerID;
        }

        private void FrmShowCustomerBookingHistory_Load(object sender, EventArgs e)
        {
            if (!ucCustomerCard1.LoadCustomerData(_customerID))
                return;

            dgvBookingsList.DataSource = Customer.GetCustomerRentalBookings(_customerID);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
