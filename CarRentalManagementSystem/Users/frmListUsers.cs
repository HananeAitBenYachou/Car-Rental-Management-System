using CarRental_BusinessLayer;
using System;
using System.Data;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRentalManagementSystem.Users
{
    public partial class frmListUsers : Form
    {
        private enum _FilterOptions
        {
            Gender,
            Country,
            IsActive
        }

        private _FilterOptions _SelectedOption;

        private DataView _UsersDataView;

        private int? _SelectedUserID = null;
        public frmListUsers()
        {
            InitializeComponent();
        }

        private async void _FillCountriesInComboBoxAsync()
        {
            await Task.Run(() =>
            {
                cbTemp.Invoke(new Action(() =>
                {
                    foreach (DataRow row in clsCountry.GetAllCountries().Rows)
                    {
                        cbTemp.Items.Add((string)row["CountryName"]);
                    }

                    cbTemp.SelectedIndex = 0;

                }));
            });
        }

        private void _FillFilterOptionsInComboBox(_FilterOptions option)
        {
            cbTemp.Items.Clear();

            switch (option)
            {
                case _FilterOptions.Gender:
                    cbTemp.Items.AddRange(new object[] { "Female", "Male" });
                    cbTemp.SelectedIndex = 0;
                    break;

                case _FilterOptions.IsActive:
                    cbTemp.Items.AddRange(new object[] { "Yes", "No" });
                    cbTemp.SelectedIndex = 0;
                    break;

                case _FilterOptions.Country:
                    _FillCountriesInComboBoxAsync();
                    break;
            }
        }

        private void _RefreshUsersList()
        {
            _UsersDataView = clsUser.GetAllUsers().DefaultView;
            dgvUsersList.DataSource = _UsersDataView;
            cbFilterByOptions.SelectedIndex = 0;
        }

        private void _FilterUsersList()
        {
            if (string.IsNullOrEmpty(txtFilterValue.Text))
            {
                _UsersDataView.RowFilter = null;
                return;
            }

            if (cbFilterByOptions.Text == "User ID")
                _UsersDataView.RowFilter = string.Format("[{0}] = {1}", cbFilterByOptions.Text, txtFilterValue.Text);
            else
                _UsersDataView.RowFilter = string.Format("[{0}] LIKE '%{1}%'", cbFilterByOptions.Text, txtFilterValue.Text);
        }

        private void frmListUsers_Load(object sender, EventArgs e)
        {
            _RefreshUsersList();
        }

        private void cbFilterByOptions_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Enum.TryParse(cbFilterByOptions.Text, out _SelectedOption))
            {
                txtFilterValue.Visible = false;
                cbTemp.Visible = true;
                _FillFilterOptionsInComboBox(_SelectedOption);
            }

            else
            {
                cbTemp.Visible = false;
                txtFilterValue.Visible = (cbFilterByOptions.Text != "None");
                txtFilterValue.ResetText();
                txtFilterValue.Focus();
                txtFilterValue_TextChanged(null, null);
            }

        }

        private void cbTemp_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_SelectedOption == _FilterOptions.IsActive)
            {
                switch (cbTemp.Text)
                {
                    case "Yes":
                        _UsersDataView.RowFilter = string.Format("[{0}] = 1", cbFilterByOptions.Text);
                        break;

                    case "No":
                        _UsersDataView.RowFilter = string.Format("[{0}] = 0", cbFilterByOptions.Text);
                        break;
                }
            }

            else
            {
                _UsersDataView.RowFilter = string.Format("[{0}] = '{1}'", cbFilterByOptions.Text, cbTemp.Text);
            }

        }

        private void txtFilterValue_TextChanged(object sender, EventArgs e)
        {
            _FilterUsersList();
        }

        private void txtFilterValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbFilterByOptions.Text == "User ID")
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void btnAddNewUser_Click(object sender, EventArgs e)
        {
            frmAddUpdateUser form = new frmAddUpdateUser();
            form.ShowDialog();

            _RefreshUsersList();
        }

        private void addNewUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnAddNewUser.PerformClick();
        }

        private void editUserInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddUpdateUser form = new frmAddUpdateUser(_SelectedUserID);
            form.ShowDialog();

            _RefreshUsersList();
        }

        private void showUserInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmShowUserDetails form = new frmShowUserDetails(_SelectedUserID);
            form.ShowDialog();
        }

        private void deleteUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete the selected user ?", "Verification",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.Cancel)
            return;

            if(!clsUser.DeleteUser(_SelectedUserID))                           
            MessageBox.Show("Failed to delete The selected user , due to the data connected to it !", "Deletion Failed",
             MessageBoxButtons.OK, MessageBoxIcon.Information);

            else
            {
                MessageBox.Show("The selected user has been deleted successfully .", "Deletion Completed",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

                _RefreshUsersList();
            }

        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmChangeUserPassword form = new frmChangeUserPassword(_SelectedUserID);    
            form.ShowDialog();
        }

        private void dgvUsersList_SelectionChanged(object sender, EventArgs e)
        {
            _SelectedUserID = (int)dgvUsersList.CurrentRow.Cells[0].Value;
        }

        private void dgvUsersList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            showUserInformationToolStripMenuItem.PerformClick();
        }
    }
}
