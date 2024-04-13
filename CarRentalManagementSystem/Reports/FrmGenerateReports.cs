using CarRental_BusinessLayer;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRentalManagementSystem.Reports
{
    public partial class FrmGenerateReport : Form
    {
        private DataTable _reportData;
        private string _reportHeader;
        private string _reportFilePath;

        private enum EnReportType
        {            
            RentalBookings,
            Transactions,
            VehicleReturns,
            Maintenances,
            Profit
        }

        private EnReportType _currentReportType;

        public FrmGenerateReport()
        {
            InitializeComponent();

            pnlContainer.Visible = false;

            SetReportDefaultDates();
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
            FrmReport form = new FrmReport(_reportData, _reportHeader, _reportFilePath);
            form.ShowDialog();
        }

        private void UpdateReportData()
        {
            switch(_currentReportType)
            {
                case EnReportType.RentalBookings:
                    _reportData = RentalBooking.GetAllRentalBookingsByDateRange(dtpStartDate.Value, dtpEndDate.Value);
                    break;
                case EnReportType.Transactions:
                    _reportData = RentalTransaction.GetAllRentalTransactionsByDateRange(dtpStartDate.Value, dtpEndDate.Value);
                    break;
                case EnReportType.VehicleReturns:
                    _reportData = VehicleReturn.GetAllVehicleReturnsByDateRange(dtpStartDate.Value, dtpEndDate.Value);
                    break;
                case EnReportType.Maintenances:
                    _reportData = Maintenance.GetAllMaintenancesByDateRange(dtpStartDate.Value, dtpEndDate.Value);
                    break;
                case EnReportType.Profit:
                    _reportData = RentalTransaction.GetTotalProfitByDateRange(dtpStartDate.Value, dtpEndDate.Value);
                    break;
            }

            _reportHeader = $"{_currentReportType} Report \nFrom {dtpStartDate.Value.ToShortDateString()}  To {dtpEndDate.Value.ToShortDateString()}";
        }

        private void GenerateReport(string reportFilePath, DataTable reportData = null, string reportHeader = null, bool clickGenerateButton = false , bool showPanel = true)
        {
            pnlContainer.Visible = showPanel;

            _reportData = reportData;
            _reportHeader = reportHeader;
            _reportFilePath = reportFilePath;

            if(clickGenerateButton)
                ShowReport();
        }
        
        private void BtnCustomersListReport_Click(object sender, EventArgs e)
        {
            _reportFilePath = $@"C:\Users\hanan\source\repos\Car-Rental-Management-System\CarRentalManagementSystem\Reports\ReportViewers\customersReport.rdlc";
           
            GenerateReport(_reportFilePath,Customer.GetAllCustomers(), "Customers List", true, false);
        }

        private void BtnVehiclesListReport_Click(object sender, EventArgs e)
        {
            _reportFilePath = $@"C:\Users\hanan\source\repos\Car-Rental-Management-System\CarRentalManagementSystem\Reports\ReportViewers\vehiclesReport.rdlc";

            GenerateReport(_reportFilePath, Vehicle.GetVehiclesPaginated(1, Vehicle.GetTotalVehiclesCount()), "Vehicles List", true, false);
        }

        private void BtnRentalBookingsReport_Click(object sender, EventArgs e)
        {
            _currentReportType = EnReportType.RentalBookings;
            _reportFilePath = $@"C:\Users\hanan\source\repos\Car-Rental-Management-System\CarRentalManagementSystem\Reports\ReportViewers\rentalBookingsReport.rdlc";
            
            GenerateReport(_reportFilePath);
        }

        private void BtnTransactionsReport_Click(object sender, EventArgs e)
        {
            _currentReportType = EnReportType.Transactions;
            _reportFilePath = $@"C:\Users\hanan\source\repos\Car-Rental-Management-System\CarRentalManagementSystem\Reports\ReportViewers\rentalTransactiosReport.rdlc";

            GenerateReport(_reportFilePath);
        }

        private void BtnVehicleReturnsReport_Click(object sender, EventArgs e)
        {   
            _currentReportType = EnReportType.VehicleReturns;
            _reportFilePath = $@"C:\Users\hanan\source\repos\Car-Rental-Management-System\CarRentalManagementSystem\Reports\ReportViewers\vehicleReturnsReport.rdlc";

            GenerateReport(_reportFilePath);
        }

        private void BtnMaintenancesReport_Click(object sender, EventArgs e)
        {
            _currentReportType = EnReportType.Maintenances;
            _reportFilePath = $@"C:\Users\hanan\source\repos\Car-Rental-Management-System\CarRentalManagementSystem\Reports\ReportViewers\maintenancesReport.rdlc";

            GenerateReport(_reportFilePath);
        }

        private void BtnProfitReport_Click(object sender, EventArgs e)
        {
            _currentReportType = EnReportType.Profit;
            _reportFilePath = $@"C:\Users\hanan\source\repos\Car-Rental-Management-System\CarRentalManagementSystem\Reports\ReportViewers\profitReport.rdlc";

            GenerateReport(_reportFilePath);
        }

        private void BtnGenerateReport_Click(object sender, EventArgs e)
        {
            UpdateReportData();
            ShowReport();
        }   
    }
}
