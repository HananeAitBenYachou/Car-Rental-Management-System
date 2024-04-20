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
        private string _reportFile;
        private const string ReportsPath = @"C:\Users\hanan\source\repos\Car-Rental-Management-System\CarRentalManagementSystem\Reports\ReportViewers\";
        
        private enum EnReportType
        {    
            Customers,
            Vehicles,
            RentalBookings,
            Transactions,
            VehicleReturns,
            Maintenances,
            Profit
        }
        private EnReportType _currentReportType;

        private readonly Dictionary<EnReportType, string> _reportFiles;

        public FrmGenerateReport()
        {
            InitializeComponent();

            pnlContainer.Visible = false;

            SetReportDefaultDates();

            _reportFiles = new Dictionary<EnReportType, string>
            {
                { EnReportType.Customers, "customersReport.rdlc" },
                { EnReportType.Vehicles, "vehiclesReport.rdlc" },
                { EnReportType.RentalBookings, "rentalBookingsReport.rdlc" },
                { EnReportType.Transactions, "rentalTransactiosReport.rdlc" },
                { EnReportType.VehicleReturns, "vehicleReturnsReport.rdlc" },
                { EnReportType.Maintenances, "maintenancesReport.rdlc" },
                { EnReportType.Profit, "profitReport.rdlc" }
            };
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
            FrmReport form = new FrmReport(_reportData, _reportHeader, _reportFile);
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

        private void GenerateReport(DataTable reportData = null, string reportHeader = null, bool clickGenerateButton = false , bool showPanel = true)
        {
            pnlContainer.Visible = showPanel;

            _reportData = reportData;
            _reportHeader = reportHeader;
            _reportFile = Path.Combine(ReportsPath, _reportFiles[_currentReportType]);

            if (clickGenerateButton)
                ShowReport();
        }
        
        private void BtnCustomersListReport_Click(object sender, EventArgs e)
        {
            _currentReportType = EnReportType.Customers;
            GenerateReport(Customer.GetAllCustomers(), "Customers List", true, false);
        }

        private void BtnVehiclesListReport_Click(object sender, EventArgs e)
        {
            _currentReportType = EnReportType.Vehicles;
            GenerateReport(Vehicle.GetVehiclesPaginated(1, Vehicle.GetTotalVehiclesCount()), "Vehicles List", true, false);
        }

        private void BtnRentalBookingsReport_Click(object sender, EventArgs e)
        {
            _currentReportType = EnReportType.RentalBookings;
            GenerateReport();
        }

        private void BtnTransactionsReport_Click(object sender, EventArgs e)
        {
            _currentReportType = EnReportType.Transactions;
            GenerateReport();
        }

        private void BtnVehicleReturnsReport_Click(object sender, EventArgs e)
        {   
            _currentReportType = EnReportType.VehicleReturns;
            GenerateReport();
        }

        private void BtnMaintenancesReport_Click(object sender, EventArgs e)
        {
            _currentReportType = EnReportType.Maintenances;
            GenerateReport();
        }

        private void BtnProfitReport_Click(object sender, EventArgs e)
        {
            _currentReportType = EnReportType.Profit;
            GenerateReport();
        }

        private void BtnGenerateReport_Click(object sender, EventArgs e)
        {
            UpdateReportData();
            ShowReport();
        }

        private void PopulateMonthlyRevenueChart()
        {
            chart1.Series[0].Points.DataBind(RentalTransaction.GetMonthlyRevenue().AsEnumerable(), "Month", "Revenue", "");
        }

        private void FrmGenerateReport_Load(object sender, EventArgs e)
        {
            PopulateMonthlyRevenueChart();
        }

    }
}
