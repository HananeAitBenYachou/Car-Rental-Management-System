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
using static System.Net.Mime.MediaTypeNames;

namespace CarRentalManagementSystem.Reports
{
    public partial class Form1 : Form
    {
        private string text;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DateTime startDate = new DateTime(2024, 3, 20);
            DateTime endDate = new DateTime(2024, 3, 23);

            foreach (DataColumn column in RentalBooking.GetAllRentalBookingsByDateRange(startDate,endDate).Columns)
            {
                listBox1.Items.Add(column.ColumnName.Replace(" ", "_"));

                text += column.ColumnName.Replace(" ", "_") + "\n";
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {              
            Clipboard.SetText(text);
        }
    }
}
