using CarRentalManagementSystem.Bookings;
using CarRentalManagementSystem.Customers;
using CarRentalManagementSystem.Transactions;
using CarRentalManagementSystem.Users;
using CarRentalManagementSystem.Vehicles;
using System;
using System.Windows.Forms;

namespace CarRentalManagementSystem
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            if (Environment.OSVersion.Version.Major >= 6)
                SetProcessDPIAware();


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmShowBookingDetails(10));
        }

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern bool SetProcessDPIAware();
    }
}
