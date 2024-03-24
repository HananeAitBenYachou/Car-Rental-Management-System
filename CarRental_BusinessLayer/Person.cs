using CarRental_DataAccessLayer;
using System;

namespace CarRental_BusinessLayer
{
    public class Person
    {
        public enum enMode : byte { AddNew = 0, Update = 1 };
        public enMode Mode;
        public enum enGender : byte { Male = 0, Female = 1 };

        public int? PersonID { get; private set; }
        public string NationalNo { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName => FirstName + LastName;
        public DateTime BirthDate { get; set; }
        public enGender Gender { get; set; }
        public string GenderText => Gender.ToString();
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public int NationalityCountryID { get; set; }
        public string ImagePath { get; set; }
        public Country CountryInfo { get; protected set; }

        public Person()
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

        protected Person(int? personID, string nationalNo, string firstName, string lastName, DateTime birthDate,
                         enGender gender, string address, string phone, string email, int nationalityCountryID,
                         string imagePath)
        {
            Mode = enMode.Update;

            PersonID = personID;
            NationalNo = nationalNo;
            FirstName = firstName;
            LastName = lastName;
            BirthDate = birthDate;
            Gender = gender;
            Address = address;
            Phone = phone;
            Email = email;
            NationalityCountryID = nationalityCountryID;
            ImagePath = imagePath;

            CountryInfo = Country.Find(nationalityCountryID);
        }

        public static Person Find(int? personID)
        {
            string nationalNo = default;
            string firstName = default;
            string lastName = default;
            DateTime birthDate = default;
            byte gender = default;
            string address = default;
            string phone = default;
            string email = default;
            int nationalityCountryID = default;
            string imagePath = default;

            bool isFound = PersonData.GetPersonInfoByID(personID, ref nationalNo, ref firstName, ref lastName,
                                                        ref birthDate, ref gender, ref address, ref phone, ref email,
                                                        ref nationalityCountryID, ref imagePath);

            if (isFound)
                return new Person(personID, nationalNo, firstName, lastName,
                    birthDate, (enGender)gender, address, phone, email,
                    nationalityCountryID, imagePath);
            else
                return null;
        }

        public static Person Find(string nationalNo)
        {
            int? personID = default;
            string firstName = default;
            string lastName = default;
            DateTime birthDate = default;
            byte gender = default;
            string address = default;
            string phone = default;
            string email = default;
            int nationalityCountryID = default;
            string imagePath = default;

            bool isFound = PersonData.GetPersonInfoByNationalNo(nationalNo, ref personID, ref firstName, ref lastName,
                                                                ref birthDate, ref gender, ref address, ref phone,
                                                                ref email, ref nationalityCountryID, ref imagePath);

            if (isFound)
                return new Person(personID, nationalNo, firstName, lastName, birthDate,
                    (enGender)gender, address, phone, email, nationalityCountryID, imagePath);
            else
                return null;
        }

        public static bool DoesPersonExist(int? personID)
        {
            return PersonData.DoesPersonExist(personID);
        }

        public static bool DoesPersonExist(string nationalNo)
        {
            return PersonData.DoesPersonExist(nationalNo);
        }

        private bool AddNewPerson()
        {
            PersonID = PersonData.AddNewPerson(NationalNo, FirstName, LastName, BirthDate, (byte)Gender,
                                               Address, Phone,Email, NationalityCountryID, ImagePath);
            return PersonID.HasValue;
        }

        private bool UpdatePerson()
        {
            return PersonData.UpdatePersonInfo(PersonID, NationalNo, FirstName, LastName, BirthDate, (byte)Gender,
                                               Address, Phone, Email, NationalityCountryID, ImagePath);
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (AddNewPerson())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    return false;

                case enMode.Update:
                    return UpdatePerson();

            }
            return false;
        }

        public static bool DeletePerson(int? personID)
        {
            return PersonData.DeletePerson(personID);
        }
    }
}