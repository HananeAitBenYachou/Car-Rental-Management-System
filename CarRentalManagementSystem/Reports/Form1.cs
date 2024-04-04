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
            foreach(DataColumn column in Vehicle.GetAllVehicles().Columns)
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
