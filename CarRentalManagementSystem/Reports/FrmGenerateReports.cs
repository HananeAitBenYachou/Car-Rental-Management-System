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

namespace CarRentalManagementSystem.Reports
{
    public partial class FrmGenerateReports : Form
    {
        private DataTable _dataTable;
        private string _reportTitle;
        private string _reportPath;

        public FrmGenerateReports()
        {
            InitializeComponent();
        }

        private void ShowReport()
        {
            FrmReport form = new FrmReport(_dataTable, _reportTitle, _reportPath);
            form.ShowDialog();
        }

        private void BtnCustomersListReport_Click(object sender, EventArgs e)
        {
            _dataTable = Customer.GetAllCustomers();
            _reportTitle = "Customers List";
            _reportPath = $@"C:\Users\hanan\source\repos\Car-Rental-Management-System\CarRentalManagementSystem\Reports\ReportViewers\customersReport.rdlc";

            ShowReport();
        }

        private void BtnVehiclesListReport_Click(object sender, EventArgs e)
        {
            _dataTable = Vehicle.GetVehiclesPaginated(1,Vehicle.GetTotalVehiclesCount());
            _reportTitle = "Vehicles List";
            _reportPath = $@"C:\Users\hanan\source\repos\Car-Rental-Management-System\CarRentalManagementSystem\Reports\ReportViewers\vehiclesReport.rdlc";

            ShowReport();
        }
    }
}
