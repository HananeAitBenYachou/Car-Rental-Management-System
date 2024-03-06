using CarRental_DataAccessLayer;
using System;
using System.Data;

namespace CarRental_BusinessLayer
{
    public class clsCustomer : clsPerson
    {
        private new enum enMode { AddNew = 0, Update = 1 };
        private enMode _Mode;
        public int? CustomerID { get; private set; }
        public new int? PersonID { get; private set; }
        public string DriverLicenseNumber { get; set; }

        public clsCustomer() : base()
        {
            _Mode = enMode.AddNew;
            CustomerID = null;
            DriverLicenseNumber = default;
            PersonID = default;
        }
        private clsCustomer(int? CustomerID, string DriverLicenseNumber, int? PersonID,
            string NationalNo, string FirstName, string LastName, DateTime BirthDate, enGender Gender,
            string Address, string Phone, string Email, int NationalityCountryID, string ImagePath)
        {
            _Mode = enMode.Update;
            this.CustomerID = CustomerID;
            this.DriverLicenseNumber = DriverLicenseNumber;
            this.PersonID = PersonID;

            base.NationalNo = NationalNo;
            base.FirstName = FirstName;
            base.LastName = LastName;
            base.BirthDate = BirthDate;
            base.Gender = Gender;
            base.Address = Address;
            base.Phone = Phone;
            base.Email = Email;
            base.NationalityCountryID = NationalityCountryID;
            base.ImagePath = ImagePath;
            base.CountryInfo = clsCountry.Find(NationalityCountryID);
        }

        public static new clsCustomer Find(int? CustomerID)
        {
            string DriverLicenseNumber = default;
            int? PersonID = default;

            bool isFound = clsCustomerData.GetCustomerInfoByID(CustomerID, ref DriverLicenseNumber, ref PersonID);

            if (isFound)
            {
                clsPerson person = clsPerson.Find(PersonID);

                if (person == null)
                    return null;

                return new clsCustomer(CustomerID, DriverLicenseNumber, PersonID,
                    person.NationalNo, person.FirstName, person.LastName, person.BirthDate, person.Gender, person.Address,
                    person.Phone, person.Email, person.NationalityCountryID, person.ImagePath);

            }

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

        public new bool Save()
        {
            base.Mode = this.Mode;

            if (!base.Save())
                return false;
            else
                this.PersonID = base.PersonID;

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