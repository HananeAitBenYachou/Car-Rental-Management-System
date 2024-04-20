using CarRental_BusinessLayer;
using CarRentalManagementSystem.Bookings;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using static CarRentalManagementSystem.Global.Global;
namespace CarRentalManagementSystem
{
    public partial class FrmDashboard : Form
    {
        public FrmDashboard()
        {
            InitializeComponent();
            
        }

        private void FrmDashboard_Load(object sender, EventArgs e)
        {
            LoadChartData();
            LoadTopMostRentedVehicles();
            LoadDashboardData();
        }

        private void LoadChartData()
        {
            Series serie = chart1.Series["VehiclesStatus"];

            serie.Points[0].SetValueY(Vehicle.GetVehiclesCountPerStatus(Vehicle.EnVehicleStatus.Rented));
            serie.Points[1].SetValueY(Vehicle.GetVehiclesCountPerStatus(Vehicle.EnVehicleStatus.Available));
        }

        private void LoadTopMostRentedVehicles()
        {
            var vehiclesList = Vehicle.GetTopMostRentedVehicles();

            lblFirstVehicle.Text = vehiclesList[0].vehicleName;
            lblSecondVehicle.Text = vehiclesList[1].vehicleName;
            lblThirdVehicle.Text = vehiclesList[2].vehicleName;
        }

        private void LoadDashboardData()
        {
            lblGreeting.Text = $"Welcome Back {CurrentUser.FullName} !";

            lblUsersCount.Text = User.GetTotalUsersCount().ToString();
            lblCustomersCount.Text = Customer.GetTotalCustomersCount().ToString();
            lblVehiclesCount.Text = Vehicle.GetTotalVehiclesCount().ToString();
            lblBookingsCount.Text = RentalBooking.GetTotalRentalBookingsCount().ToString();
            lblReturnsCount.Text = VehicleReturn.GetTotalVehicleReturnsCount().ToString();
            lblTransactionsCount.Text = RentalTransaction.GetTotalRentalTransactionsCount().ToString();
        }

        private void BtnAddNewRental_Click(object sender, EventArgs e)
        {
            FrmAddRentalBooking form = new FrmAddRentalBooking();
            form.ShowDialog();
        }
    }
}
