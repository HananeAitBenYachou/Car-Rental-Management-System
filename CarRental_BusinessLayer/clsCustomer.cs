using CarRental_DataAccessLayer;
using System.Data;

namespace CarRental_BusinessLayer
{
    public class clsCustomer
    {
        private enum enMode { AddNew = 0, Update = 1 };
        private enMode _Mode;
        public int? CustomerID { get; private set; }
        public string DriverLicenseNumber { get; set; }
        public int PersonID { get; set; }

        public clsCustomer()
        {
            _Mode = enMode.AddNew;
            CustomerID = null;
            DriverLicenseNumber = default;
            PersonID = default;
        }
        private clsCustomer(int? CustomerID, string DriverLicenseNumber, int PersonID)
        {
            _Mode = enMode.Update;
            this.CustomerID = CustomerID;
            this.DriverLicenseNumber = DriverLicenseNumber;
            this.PersonID = PersonID;
        }

        public static clsCustomer Find(int? CustomerID)
        {
            string DriverLicenseNumber = default;
            int PersonID = default;

            bool isFound = clsCustomerData.GetCustomerInfoByID(CustomerID, ref DriverLicenseNumber, ref PersonID);

            if (isFound)
                return new clsCustomer(CustomerID, DriverLicenseNumber, PersonID);
            else
                return null;
        }

        public static bool DoesCustomerExist(int? CustomerID)
        {
            return clsCustomerData.DoesCustomerExist(CustomerID);
        }

        private bool _AddNewCustomer()
        {
            CustomerID = clsCustomerData.AddNewCustomer(DriverLicenseNumber, PersonID);
            return CustomerID.HasValue;
        }

        private bool _UpdateCustomer()
        {
            return clsCustomerData.UpdateCustomerInfo(CustomerID, DriverLicenseNumber, PersonID);
        }

        public bool Save()
        {
            switch (_Mode)
            {
                case enMode.AddNew:
                    if (_AddNewCustomer())
                    {
                        _Mode = enMode.Update;
                        return true;
                    }
                    return false;

                case enMode.Update:
                    return _UpdateCustomer();

            }
            return false;
        }

        public static bool DeleteCustomer(int? CustomerID)
        {
            return clsCustomerData.DeleteCustomer(CustomerID);
        }

        public static DataTable GetAllCustomers()
        {
            return clsCustomerData.GetAllCustomers();
        }

    }
}