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

        private enum EnReportType
        {            
            RentalBookings,
            Transactions,
            VehicleReturns,
            Maintenances
        }

        private EnReportType _currentReportType;

        public FrmGenerateReports()
        {
            InitializeComponent();

            SetReportDefaultDates();
            pnlContainer.Visible = false;          
        }

        private void SetReportDefaultDates()
        {
            dtpStartDate.MinDate = DateTime.Now.AddYears(-5);
            dtpStartDate.Value = DateTime.Now;
            dtpStartDate.MaxDate = dtpStartDate.Value;

            dtpEndDate.MinDate = dtpStartDate.MinDate;
            dtpEndDate.Value = dtpStartDate.Value;
            dtpEndDate.MaxDate = dtpStartDate.MaxDate;
        }

        private void ShowReport()
        {
            FrmReport form = new FrmReport(_dataTable, _reportTitle, _reportPath);
            form.ShowDialog();
        }

        private void UpdateReportData()
        {
            switch(_currentReportType)
            {
                case EnReportType.RentalBookings:
                    _dataTable = RentalBooking.GetAllRentalBookingsByDateRange(dtpStartDate.Value, dtpEndDate.Value);
                    break;
                case EnReportType.Transactions:
                    _dataTable = RentalTransaction.GetAllRentalTransactionsByDateRange(dtpStartDate.Value, dtpEndDate.Value);
                    break;
                case EnReportType.VehicleReturns:
                    _dataTable = VehicleReturn.GetAllVehicleReturnsByDateRange(dtpStartDate.Value, dtpEndDate.Value);
                    break;
                case EnReportType.Maintenances:
                    _dataTable = Maintenance.GetAllMaintenancesByDateRange(dtpStartDate.Value, dtpEndDate.Value);
                    break;
            }

            _reportTitle = $"{_currentReportType} Report \nFrom {dtpStartDate.Value.ToShortDateString()}  To {dtpEndDate.Value.ToShortDateString()}";
        }

        private void BtnCustomersListReport_Click(object sender, EventArgs e)
        {
            pnlContainer.Visible = false;

            _dataTable = Customer.GetAllCustomers();
            _reportTitle = "Customers List";
            _reportPath = $@"C:\Users\hanan\source\repos\Car-Rental-Management-System\CarRentalManagementSystem\Reports\ReportViewers\customersReport.rdlc";

            ShowReport();
        }

        private void BtnVehiclesListReport_Click(object sender, EventArgs e)
        {
            pnlContainer.Visible = false;

            _dataTable = Vehicle.GetVehiclesPaginated(1,Vehicle.GetTotalVehiclesCount());
            _reportTitle = "Vehicles List";
            _reportPath = $@"C:\Users\hanan\source\repos\Car-Rental-Management-System\CarRentalManagementSystem\Reports\ReportViewers\vehiclesReport.rdlc";

            ShowReport();
        }

        private void BtnRentalBookingsReport_Click(object sender, EventArgs e)
        {
            pnlContainer.Visible = true;
            _currentReportType = EnReportType.RentalBookings;
            _reportPath = $@"C:\Users\hanan\source\repos\Car-Rental-Management-System\CarRentalManagementSystem\Reports\ReportViewers\rentalBookingsReport.rdlc";
        }

        private void BtnTransactionsReport_Click(object sender, EventArgs e)
        {
            pnlContainer.Visible = true;
            _currentReportType = EnReportType.Transactions;
            _reportPath = $@"C:\Users\hanan\source\repos\Car-Rental-Management-System\CarRentalManagementSystem\Reports\ReportViewers\rentalTransactiosReport.rdlc";
        }

        private void BtnVehicleReturnsReport_Click(object sender, EventArgs e)
        {   
            pnlContainer.Visible = true;
            _currentReportType = EnReportType.VehicleReturns;
            _reportPath = $@"C:\Users\hanan\source\repos\Car-Rental-Management-System\CarRentalManagementSystem\Reports\ReportViewers\vehicleReturnsReport.rdlc";
        }

        private void BtnMaintenancesReport_Click(object sender, EventArgs e)
        {
            pnlContainer.Visible = true;
            _currentReportType = EnReportType.Maintenances;
            _reportPath = $@"C:\Users\hanan\source\repos\Car-Rental-Management-System\CarRentalManagementSystem\Reports\ReportViewers\maintenancesReport.rdlc";
        }

        private void BtnGenerateReport_Click(object sender, EventArgs e)
        {
            UpdateReportData();
            ShowReport();
        }

    }
}
