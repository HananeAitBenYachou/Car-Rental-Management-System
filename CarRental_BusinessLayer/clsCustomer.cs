using CarRental_DataAccessLayer;
using System;
using System.Data;

namespace CarRental_BusinessLayer
{
    public class clsCustomer : clsPerson
    {
        private new enum enMode { AddNew = 0, Update = 1 };
        private enMode _Mode;

        public enum enFindCustomerBy { PersonID = 0, CustomerID = 1, LicenseNumber = 3 }

        public int? CustomerID { get; private set; }
        public new int? PersonID { get; private set; }
        public string DriverLicenseNumber { get; set; }

        public clsCustomer(): base()
        {
            _Mode = enMode.AddNew;
            CustomerID = null;
            DriverLicenseNumber = default;
            PersonID = default;
        }
        private clsCustomer(int? CustomerID, string DriverLicenseNumber, int? PersonID,
            string NationalNo, string FirstName, string LastName, DateTime BirthDate, enGender Gender,
            string Address, string Phone, string Email, int NationalityCountryID, string ImagePath):
            base(PersonID,NationalNo,FirstName,LastName,BirthDate,Gender,Address,Phone,Email,NationalityCountryID,ImagePath)
        {
            _Mode = enMode.Update;
            this.CustomerID = CustomerID;
            this.DriverLicenseNumber = DriverLicenseNumber;
            this.PersonID = PersonID;
        }

        private static clsCustomer _FindCustomerByCustomerID(int? CustomerID)
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

        private static clsCustomer _FindCustomerByPersonID(int? PersonID)
        {
            string DriverLicenseNumber = default;
            int? CustomerID = default;

            bool isFound = clsCustomerData.GetCustomerInfoByPersonID(PersonID, ref CustomerID, ref DriverLicenseNumber);

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

        private static clsCustomer _FindCustomerByLicenseNo(string DriverLicenseNumber)
        {
            int? CustomerID = default;
            int? PersonID = default;

            bool isFound = clsCustomerData.GetCustomerInfoByLicenseNo(DriverLicenseNumber , ref CustomerID, ref PersonID);

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

        public static clsCustomer Find<T>(T SearchValue , enFindCustomerBy FindCustomerBy)
        {
            switch(FindCustomerBy)
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
            return clsCustomerData.DoesCustomerExist(CustomerID);
        }

        public static bool DoesCustomerExist(string DriverLicenseNumber)
        {
            return clsCustomerData.DoesCustomerExist(DriverLicenseNumber);
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
            int? personID = clsCustomerData.GetCustomerPersonID(CustomerID);

            if (!personID.HasValue)
                return false;

            return clsPerson.DeletePerson(personID) ? clsCustomerData.DeleteCustomer(CustomerID) : false;
        }

        public static DataTable GetAllCustomers()
        {
            return clsCustomerData.GetAllCustomers();
        }

    }
}