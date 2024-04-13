using CarRental_DataAccessLayer;
using System;
using System.Data;

namespace CarRental_BusinessLayer
{
    public class Customer : Person
    {
        private new enum EnMode : byte { AddNew = 0, Update = 1 };
        private EnMode _mode;
        public enum EnFindCustomerBy : byte { PersonID = 0, CustomerID = 1, LicenseNumber = 3 }

        public int? CustomerID { get; private set; }
        public new int? PersonID { get; private set; }
        public string DriverLicenseNumber { get; set; }

        public Customer() : base()
        {
            _mode = EnMode.AddNew;

            CustomerID = null;
            DriverLicenseNumber = default;
            PersonID = null;
        }
        private Customer(int? customerID, string driverLicenseNumber, int? personID, string nationalNo, string firstName,
                         string lastName, DateTime birthDate, EnGender gender, string address, string phone,
                         string email, int nationalityCountryID, string imagePath)

                  : base(personID, nationalNo, firstName, lastName, birthDate, gender, address, phone, email,
                         nationalityCountryID, imagePath)
        {
            _mode = EnMode.Update;

            CustomerID = customerID;
            DriverLicenseNumber = driverLicenseNumber;
            PersonID = personID;
        }

        private static Customer FindCustomerByCustomerID(int? customerID)
        {
            string driverLicenseNumber = default;
            int? personID = default;

            bool isFound = CustomerData.GetCustomerInfoByID(customerID, ref driverLicenseNumber, ref personID);

            if (isFound)
            {
                Person person = Person.Find(personID);

                if (person == null)
                    return null;

                return new Customer(customerID, driverLicenseNumber, personID, person.NationalNo, person.FirstName,
                                    person.LastName, person.BirthDate, person.Gender, person.Address, person.Phone,
                                    person.Email, person.NationalityCountryID, person.ImagePath);
            }

            else
                return null;
        }

        private static Customer FindCustomerByPersonID(int? personID)
        {
            string driverLicenseNumber = default;
            int? customerID = default;

            bool isFound = CustomerData.GetCustomerInfoByPersonID(personID, ref customerID, ref driverLicenseNumber);

            if (isFound)
            {
                Person person = Person.Find(personID);

                if (person == null)
                    return null;

                return new Customer(customerID, driverLicenseNumber, personID, person.NationalNo, person.FirstName,
                                    person.LastName, person.BirthDate, person.Gender, person.Address, person.Phone,
                                    person.Email, person.NationalityCountryID, person.ImagePath);
            }

            else
                return null;
        }

        private static Customer FindCustomerByLicenseNo(string driverLicenseNumber)
        {
            int? customerID = default;
            int? personID = default;

            bool isFound = CustomerData.GetCustomerInfoByLicenseNo(driverLicenseNumber, ref customerID, ref personID);

            if (isFound)
            {
                Person person = Person.Find(personID);

                if (person == null)
                    return null;

                return new Customer(customerID, driverLicenseNumber, personID, person.NationalNo, person.FirstName,
                                    person.LastName, person.BirthDate, person.Gender, person.Address, person.Phone,
                                    person.Email, person.NationalityCountryID, person.ImagePath);
            }
            else
                return null;
        }

        public static Customer Find<T>(T searchValue, EnFindCustomerBy findCustomerBy)
        {
            switch (findCustomerBy)
            {
                case EnFindCustomerBy.PersonID:
                    return FindCustomerByPersonID(Convert.ToInt16(searchValue));

                case EnFindCustomerBy.CustomerID:
                    return FindCustomerByCustomerID(Convert.ToInt16(searchValue));

                case EnFindCustomerBy.LicenseNumber:
                    return FindCustomerByLicenseNo(Convert.ToString(searchValue));

                default:
                    return null;
            }
        }

        public static bool DoesCustomerExist(int? customerID)
        {
            return CustomerData.DoesCustomerExist(customerID);
        }

        public static bool DoesCustomerExist(string driverLicenseNumber)
        {
            return CustomerData.DoesCustomerExist(driverLicenseNumber);
        }

        private bool AddNewCustomer()
        {
            CustomerID = CustomerData.AddNewCustomer(DriverLicenseNumber, PersonID);
            return CustomerID.HasValue;
        }

        private bool UpdateCustomer()
        {
            return CustomerData.UpdateCustomerInfo(CustomerID, DriverLicenseNumber, PersonID);
        }

        public new bool Save()
        {
            if (!base.Save())
                return false;

            PersonID = base.PersonID;

            switch (_mode)
            {
                case EnMode.AddNew:
                    if (AddNewCustomer())
                    {
                        _mode = EnMode.Update;
                        return true;
                    }
                    return false;

                case EnMode.Update:
                    return UpdateCustomer();

            }
            return false;
        }

        public static bool DeleteCustomer(int? customerID)
        {
            int? personID = CustomerData.GetCustomerPersonID(customerID);

            if (!personID.HasValue)
                return false;

            return Person.DeletePerson(personID) ? CustomerData.DeleteCustomer(customerID) : false;
        }

        public static DataTable GetAllCustomers()
        {
            return CustomerData.GetAllCustomers();
        }

        public static int GetTotalCustomersCount()
        {
            return CustomerData.GetTotalCustomersCount();
        }

        public static DataTable GetCustomerRentalBookings(int? customerID)
        {
            return CustomerData.GetCustomerRentalBookings(customerID);
        }

        public static DataTable GetCustomerRentalTransactions(int? customerID)
        {
            return CustomerData.GetCustomerRentalTransactions(customerID);
        }

    }
}