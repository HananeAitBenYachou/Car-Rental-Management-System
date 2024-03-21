using CarRental_DataAccessLayer;
using System;
using System.Data;

namespace CarRental_BusinessLayer
{
    public class Customer : Person
    {
        private new enum enMode : byte { AddNew = 0, Update = 1 };
        private enMode _Mode;
        public enum enFindCustomerBy : byte { PersonID = 0, CustomerID = 1, LicenseNumber = 3 }

        public int? CustomerID { get; private set; }
        public new int? PersonID { get; private set; }
        public string DriverLicenseNumber { get; set; }

        public Customer() : base()
        {
            _Mode = enMode.AddNew;
            CustomerID = null;
            DriverLicenseNumber = default;
            PersonID = null;
        }
        private Customer(int? CustomerID, string DriverLicenseNumber, int? PersonID,
            string NationalNo, string FirstName, string LastName, DateTime BirthDate, enGender Gender,
            string Address, string Phone, string Email, int NationalityCountryID, string ImagePath) :
            base(PersonID, NationalNo, FirstName, LastName, BirthDate, Gender, Address, Phone, Email, NationalityCountryID, ImagePath)
        {
            _Mode = enMode.Update;
            this.CustomerID = CustomerID;
            this.DriverLicenseNumber = DriverLicenseNumber;
            this.PersonID = PersonID;
        }

        private static Customer _FindCustomerByCustomerID(int? CustomerID)
        {
            string DriverLicenseNumber = default;
            int? PersonID = default;

            bool isFound = CustomerData.GetCustomerInfoByID(CustomerID, ref DriverLicenseNumber, ref PersonID);

            if (isFound)
            {
                Person person = Person.Find(PersonID);

                if (person == null)
                    return null;

                return new Customer(CustomerID, DriverLicenseNumber, PersonID,
                    person.NationalNo, person.FirstName, person.LastName, person.BirthDate, person.Gender, person.Address,
                    person.Phone, person.Email, person.NationalityCountryID, person.ImagePath);

            }

            else
                return null;
        }

        private static Customer _FindCustomerByPersonID(int? PersonID)
        {
            string DriverLicenseNumber = default;
            int? CustomerID = default;

            bool isFound = CustomerData.GetCustomerInfoByPersonID(PersonID, ref CustomerID, ref DriverLicenseNumber);

            if (isFound)
            {
                Person person = Person.Find(PersonID);

                if (person == null)
                    return null;

                return new Customer(CustomerID, DriverLicenseNumber, PersonID,
                    person.NationalNo, person.FirstName, person.LastName, person.BirthDate, person.Gender, person.Address,
                    person.Phone, person.Email, person.NationalityCountryID, person.ImagePath);

            }

            else
                return null;
        }

        private static Customer _FindCustomerByLicenseNo(string DriverLicenseNumber)
        {
            int? CustomerID = default;
            int? PersonID = default;

            bool isFound = CustomerData.GetCustomerInfoByLicenseNo(DriverLicenseNumber, ref CustomerID, ref PersonID);

            if (isFound)
            {
                Person person = Person.Find(PersonID);

                if (person == null)
                    return null;

                return new Customer(CustomerID, DriverLicenseNumber, PersonID,
                    person.NationalNo, person.FirstName, person.LastName, person.BirthDate, person.Gender, person.Address,
                    person.Phone, person.Email, person.NationalityCountryID, person.ImagePath);

            }
            else
                return null;
        }

        public static Customer Find<T>(T SearchValue, enFindCustomerBy FindCustomerBy)
        {
            switch (FindCustomerBy)
            {
                case enFindCustomerBy.PersonID:
                    return _FindCustomerByPersonID(Convert.ToInt16(SearchValue));

                case enFindCustomerBy.CustomerID:
                    return _FindCustomerByCustomerID(Convert.ToInt16(SearchValue));

                case enFindCustomerBy.LicenseNumber:
                    return _FindCustomerByLicenseNo(Convert.ToString(SearchValue));

                default:
                    return null;
            }
        }

        public static bool DoesCustomerExist(int? CustomerID)
        {
            return CustomerData.DoesCustomerExist(CustomerID);
        }

        public static bool DoesCustomerExist(string DriverLicenseNumber)
        {
            return CustomerData.DoesCustomerExist(DriverLicenseNumber);
        }

        private bool _AddNewCustomer()
        {
            CustomerID = CustomerData.AddNewCustomer(DriverLicenseNumber, PersonID);
            return CustomerID.HasValue;
        }

        private bool _UpdateCustomer()
        {
            return CustomerData.UpdateCustomerInfo(CustomerID, DriverLicenseNumber, PersonID);
        }

        public new bool Save()
        {
            if (!base.Save())
                return false;

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
            int? personID = CustomerData.GetCustomerPersonID(CustomerID);

            if (!personID.HasValue)
                return false;

            return Person.DeletePerson(personID) ? CustomerData.DeleteCustomer(CustomerID) : false;
        }

        public static DataTable GetAllCustomers()
        {
            return CustomerData.GetAllCustomers();
        }

    }
}