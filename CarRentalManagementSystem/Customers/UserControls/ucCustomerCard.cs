using CarRental_BusinessLayer;
using System.Windows.Forms;
using static CarRental_BusinessLayer.Customer;

namespace CarRentalManagementSystem.Customers.UserControls
{
    public partial class UcCustomerCard : UserControl
    {
        public int? PersonID => ucPersonCard1.PersonID;
        public Person Person => ucPersonCard1.Person;

        public int? CustomerID { get; private set; } = null;
        public Customer Customer { get; private set; } = null;

        public UcCustomerCard()
        {
            InitializeComponent();
        }

        private void LoadCustomerData()
        {
            CustomerID = Customer.CustomerID;

            txtCustomerID.Text = CustomerID.ToString();
            txtLicenseNo.Text = Customer.DriverLicenseNumber;

            ucPersonCard1.LoadPersonData(Customer.PersonID);
        }

        public bool LoadCustomerData(int? customerID)
        {
            Customer = Find(customerID, EnFindCustomerBy.CustomerID);

            if (Customer == null)
            {
                MessageBox.Show($"No customer with customerID = {customerID} was found in the system !", "Not Found !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            LoadCustomerData();
            return true;
        }

        public bool LoadCustomerData(string driverLicenseNumber)
        {
            Customer = Find(driverLicenseNumber, EnFindCustomerBy.LicenseNumber);

            if (Customer == null)
            {
                MessageBox.Show($"No customer with License Number = {driverLicenseNumber} was found in the system !", "Not Found !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            LoadCustomerData();
            return true;
        }
    }
}
