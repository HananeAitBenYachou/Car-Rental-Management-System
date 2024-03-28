using CarRental_BusinessLayer;
using CarRentalManagementSystem.Properties;
using Guna.UI2.WinForms;

//using Guna.UI2.WinForms;
using System;
using System.Linq;
using System.Windows.Forms;

namespace CarRentalManagementSystem.People.UserControls
{
    public partial class UcPersonCard : UserControl
    {
        public int? PersonID { get; private set; } = null;
        public Person Person { get; private set; } = null;

        public UcPersonCard()
        {
            InitializeComponent();
        }

        public void Reset()
        {
            PersonID = null;
            Person = null;

            foreach (Guna2TextBox textBox in this.groupBox.Controls.OfType<Guna2TextBox>())
            {
                textBox.ResetText();
            }

            rbMale.Checked = true;

            txtPersonID.Text = "N/A";

            dtpBirthDate.Value = DateTime.Now;

            pbPersonalImage.Image = Resources.man;
        }

        private void LoadPersonData()
        {
            PersonID = Person.PersonID;

            txtPersonID.Text = PersonID.ToString();
            txtNationalNo.Text = Person.NationalNo;
            txtFirstName.Text = Person.FirstName;
            txtLastName.Text = Person.LastName;
            txtPhone.Text = Person.Phone;
            txtEmail.Text = Person.Email ?? string.Empty;
            txtAddress.Text = Person.Address ?? string.Empty;
            txtCountry.Text = Person.CountryInfo.Name;

            dtpBirthDate.Value = Person.BirthDate;

            rbMale.Checked = (Person.Gender == Person.EnGender.Male);
            rbFemale.Checked = !rbMale.Checked;

            pbPersonalImage.Image = rbMale.Checked ? Resources.man : Resources.woman;

            if (Person.ImagePath != null)
                pbPersonalImage.ImageLocation = Person.ImagePath;
        }

        public bool LoadPersonData(int? personID)
        {
            Person = Person.Find(personID);

            if (Person == null)
            {
                Reset();
                MessageBox.Show($"No person with ID = {personID} was found in the system !", "Not Found !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            LoadPersonData();
            return true;
        }

        public bool LoadPersonData(string nationalNo)
        {
            Person = Person.Find(nationalNo);

            if (Person == null)
            {
                Reset();
                MessageBox.Show($"No person with NationalNo = {nationalNo} was found in the system !", "Not Found !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            LoadPersonData();
            return true;
        }
    }
}
