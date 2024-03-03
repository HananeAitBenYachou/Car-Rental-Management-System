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

            _FillCountriesInComboBox();

            cbCountries.SelectedIndex = 0;
        }

        private void _FillCountriesInComboBox()
        {
            foreach (DataRow row in clsCountry.GetAllCountries().Rows)
            {
                cbCountries.Items.Add((string)row["CountryName"]);
            }

            cbCountries.SelectedIndex = 0;
        }

        private void _LoadPersonData()
        {
            _FillCountriesInComboBox(); 

            PersonID = Person.PersonID;
            
            txtPersonID.Text = PersonID.ToString();
            txtNationalNo.Text = Person.NationalNo;
            txtFirstName.Text = Person.FirstName;
            txtLastName.Text = Person.LastName;
            txtPhone.Text = Person.Phone;
            txtEmail.Text = Person.Email ?? string.Empty;
            txtAddress.Text = Person.Address ?? string.Empty;

            dtpBirthDate.Value = Person.BirthDate;
            cbCountries.SelectedIndex = cbCountries.FindString(Person.CountryInfo.CountryName);

            rbMale.Checked = (Person.Gender == clsPerson.enGender.Male);
            rbFemale.Checked = !rbMale.Checked;

            pbPersonalImage.Image = rbMale.Checked ? Resources.man : Resources.woman;

            if (Person.ImagePath != null)
                pbPersonalImage.ImageLocation = Person.ImagePath;
        }

        public void LoadPersonData(int? personID)
        {
            Person = clsPerson.Find(personID);

            if (Person == null)
            {
                MessageBox.Show($"No person with ID = {personID} was found in the system !", "Not Found !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Reset();
                return;
            }

            _LoadPersonData();
        }

        public void LoadPersonData(string nationalNo)
        {
            Person = clsPerson.Find(nationalNo);

            if (Person == null)
            {
                MessageBox.Show($"No person with NationalNo = {nationalNo} was found in the system !", "Not Found !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Reset();
                return;
            }

            _LoadPersonData();
        }
    }
}
