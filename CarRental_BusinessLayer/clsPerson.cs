using CarRental_DataAccessLayer;
using System;
using System.Data;

namespace CarRental_BusinessLayer
{
    public class clsPerson
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode;

        public enum enGender { Male = 0 , Female = 1 };
        public int? PersonID { get; private set; }
        public string NationalNo { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public enGender Gender { get; set; }
        public string GenderText => Gender.ToString();
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public int NationalityCountryID { get; set; }
        public string ImagePath { get; set; }
        public clsCountry CountryInfo { get; protected set; }

        public clsPerson()
        {
            Mode = enMode.AddNew;
            PersonID = null;
            NationalNo = default;
            FirstName = default;
            LastName = default;
            BirthDate = default;
            Gender = default;
            Address = null;
            Phone = default;
            Email = null;
            NationalityCountryID = default;
            ImagePath = null;
        }

        private clsPerson(int? PersonID, string NationalNo, string FirstName, string LastName, DateTime BirthDate, enGender Gender,
            string Address, string Phone, string Email, int NationalityCountryID, string ImagePath)
        {
            Mode = enMode.Update;
            this.PersonID = PersonID;
            this.NationalNo = NationalNo;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.BirthDate = BirthDate;
            this.Gender = Gender;
            this.Address = Address;
            this.Phone = Phone;
            this.Email = Email;
            this.NationalityCountryID = NationalityCountryID;
            this.ImagePath = ImagePath;

            this.CountryInfo = clsCountry.Find(NationalityCountryID);
        }

        public static clsPerson Find(int? PersonID)
        {
            string NationalNo = default;
            string FirstName = default;
            string LastName = default;
            DateTime BirthDate = default;
            byte Gender = default;
            string Address = default;
            string Phone = default;
            string Email = default;
            int NationalityCountryID = default;
            string ImagePath = default;

            bool isFound = clsPersonData.GetPersonInfoByID(PersonID, ref NationalNo, ref FirstName, ref LastName, ref BirthDate, ref Gender, ref Address, ref Phone, ref Email, ref NationalityCountryID, ref ImagePath);

            if (isFound)
                return new clsPerson(PersonID, NationalNo, FirstName, LastName, BirthDate, (enGender)Gender, Address, Phone, Email, NationalityCountryID, ImagePath);
            else
                return null;
        }

        public static clsPerson Find(string NationalNo)
        {
            int? PersonID = default;
            string FirstName = default;
            string LastName = default;
            DateTime BirthDate = default;
            byte Gender = default;
            string Address = default;
            string Phone = default;
            string Email = default;
            int NationalityCountryID = default;
            string ImagePath = default;

            bool isFound = clsPersonData.GetPersonInfoByNationalNo(NationalNo, ref PersonID, ref FirstName, ref LastName, ref BirthDate, ref Gender, ref Address, ref Phone, ref Email, ref NationalityCountryID, ref ImagePath);

            if (isFound)
                return new clsPerson(PersonID, NationalNo, FirstName, LastName, BirthDate, (enGender)Gender, Address, Phone, Email, NationalityCountryID, ImagePath);
            else
                return null;
        }

        public static bool DoesPersonExist(int? PersonID)
        {
            return clsPersonData.DoesPersonExist(PersonID);
        }

        public static bool DoesPersonExist(string NationalNo)
        {
            return clsPersonData.DoesPersonExist(NationalNo);
        }

        private bool _AddNewPerson()
        {
            PersonID = clsPersonData.AddNewPerson(NationalNo, FirstName, LastName, BirthDate, (byte)Gender, Address, Phone, Email, NationalityCountryID, ImagePath);
            return PersonID.HasValue;
        }

        private bool _UpdatePerson()
        {
            return clsPersonData.UpdatePersonInfo(PersonID, NationalNo, FirstName, LastName, BirthDate, (byte)Gender, Address, Phone, Email, NationalityCountryID, ImagePath);
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewPerson())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    return false;

                case enMode.Update:
                    return _UpdatePerson();

            }
            return false;
        }

        public static bool DeletePerson(int? PersonID)
        {
            return clsPersonData.DeletePerson(PersonID);
        }
    }
}