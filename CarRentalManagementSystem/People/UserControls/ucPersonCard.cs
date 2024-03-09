using CarRental_BusinessLayer;
using CarRentalManagementSystem.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRentalManagementSystem.People.UserControls
{
    public partial class ucPersonCard : UserControl
    {
        public int? PersonID { get; private set; } = null;
        public clsPerson Person { get; private set; } = null;

        public ucPersonCard()
        {
            InitializeComponent();
        }

        public void Reset()
        {
            PersonID = null; 
            Person = null;


            foreach (TextBox textBox in this.Controls.OfType<TextBox>())
            {
                textBox.ResetText();
            }

            rbMale.Checked = true;

            txtPersonID.Text = "N/A";

            dtpBirthDate.Value = DateTime.Now;

            pbPersonalImage.Image = Resources.man;
        }

        private void _LoadPersonData()
        {
            PersonID = Person.PersonID;
            
            txtPersonID.Text = PersonID.ToString();
            txtNationalNo.Text = Person.NationalNo;
            txtFirstName.Text = Person.FirstName;
            txtLastName.Text = Person.LastName;
            txtPhone.Text = Person.Phone;
            txtEmail.Text = Person.Email ?? string.Empty;
            txtAddress.Text = Person.Address ?? string.Empty;
            txtCountry.Text = Person.CountryInfo.CountryName;

            dtpBirthDate.Value = Person.BirthDate;

            rbMale.Checked = (Person.Gender == clsPerson.enGender.Male);
            rbFemale.Checked = !rbMale.Checked;

            pbPersonalImage.Image = rbMale.Checked ? Resources.man : Resources.woman;

            if (Person.ImagePath != null)
                pbPersonalImage.ImageLocation = Person.ImagePath;
        }

        public bool LoadPersonData(int? personID)
        {
            Person = clsPerson.Find(personID);

            if (Person == null)
            {
                Reset();
                MessageBox.Show($"No person with ID = {personID} was found in the system !", "Not Found !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            _LoadPersonData();
            return true;
        }

        public bool LoadPersonData(string nationalNo)
        {
            Person = clsPerson.Find(nationalNo);

            if (Person == null)
            {
                Reset();
                MessageBox.Show($"No person with NationalNo = {nationalNo} was found in the system !", "Not Found !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            _LoadPersonData();
            return true;
        }
    }
}
