using CarRental_BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRentalManagementSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ucBookingDetailsWithFilter1.BookingFound += UcBookingDetailsWithFilter1_BookingFound;
        }

        private void UcBookingDetailsWithFilter1_BookingFound(object sender, int? e)
        {
            clsRentalBooking b = clsRentalBooking.Find(e);

            MessageBox.Show(b.IsBookingActive ? "Active" : "Not Active");
        }
    }
}
