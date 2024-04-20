using CarRental_BusinessLayer;
using System;
using System.Data;
using System.Threading.Tasks;
using System.Windows.Forms;
using static CarRentalManagementSystem.Global.Global;


namespace CarRentalManagementSystem.Users
{
    public partial class FrmListUsers : Form
    {
        private enum FilterOptions
        {
            Gender,
            Country,
            IsActive
        }

        private FilterOptions _selectedOption;

        private DataView _usersDataView;

        public FrmListUsers()
        {
            InitializeComponent();
        }

        private async void FillCountriesInComboBoxAsync()
        {
            await Task.Run(() =>
            {
                cbTemp.Invoke(new Action(() =>
                {
                    foreach (DataRow row in Country.GetAllCountries().Rows)
                    {
                        cbTemp.Items.Add((string)row["CountryName"]);
                    }

                    cbTemp.SelectedIndex = 0;

                }));
            });
        }

        private void FillFilterOptionsInComboBox(FilterOptions option)
        {
            cbTemp.Items.Clear();

            switch (option)
            {
                case FilterOptions.Gender:
                    cbTemp.Items.AddRange(new object[] { "All", "Female", "Male" });
                    cbTemp.SelectedIndex = 0;
                    break;

                case FilterOptions.IsActive:
                    cbTemp.Items.AddRange(new object[] { "All", "Yes", "No" });
                    cbTemp.SelectedIndex = 0;
                    break;

                case FilterOptions.Country:
                    FillCountriesInComboBoxAsync();
                    break;
            }
        }

        private void RefreshUsersList()
        {
            _usersDataView = User.GetAllUsers().DefaultView;
            dgvUsersList.DataSource = _usersDataView;
            cbFilterByOptions.SelectedIndex = 0;
        }

        private void FilterUsersList()
        {
            if (string.IsNullOrEmpty(txtFilterValue.Text))
            {
                _usersDataView.RowFilter = null;
                return;
            }

            if (cbFilterByOptions.Text == "User ID")
                _usersDataView.RowFilter = string.Format("[{0}] = {1}", cbFilterByOptions.Text, txtFilterValue.Text);
            else
                _usersDataView.RowFilter = string.Format("[{0}] LIKE '%{1}%'", cbFilterByOptions.Text, txtFilterValue.Text);
        }

        private void FrmListUsers_Load(object sender, EventArgs e)
        {
            RefreshUsersList();
        }

        private void CbFilterByOptions_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Enum.TryParse(cbFilterByOptions.Text, out _selectedOption))
            {
                txtFilterValue.Visible = false;
                cbTemp.Visible = true;
                FillFilterOptionsInComboBox(_selectedOption);
            }

            else
            {
                cbTemp.Visible = false;
                txtFilterValue.Visible = (cbFilterByOptions.Text != "None");
                txtFilterValue.ResetText();
                txtFilterValue.Focus();
                TxtFilterValue_TextChanged(null, null);
            }

        }

        private void CbTemp_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbTemp.Text == "All")
            {
                _usersDataView.RowFilter = null;
                return;
            }

            if (_selectedOption == FilterOptions.IsActive)
            {
                switch (cbTemp.Text)
                {
                    case "Yes":
                        _usersDataView.RowFilter = string.Format("[{0}] = 1", cbFilterByOptions.Text);
                        break;

                    case "No":
                        _usersDataView.RowFilter = string.Format("[{0}] = 0", cbFilterByOptions.Text);
                        break;
                }
            }

            else
            {
                _usersDataView.RowFilter = string.Format("[{0}] = '{1}'", cbFilterByOptions.Text, cbTemp.Text);
            }

        }

        private void TxtFilterValue_TextChanged(object sender, EventArgs e)
        {
            FilterUsersList();
        }

        private void TxtFilterValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbFilterByOptions.Text == "User ID")
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void BtnAddNewUser_Click(object sender, EventArgs e)
        {
            FrmAddUpdateUser form = new FrmAddUpdateUser();
            form.ShowDialog();

            RefreshUsersList();
        }

        private void AddNewUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnAddNewUser.PerformClick();
        }

        private void EditUserInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {

            FrmAddUpdateUser form = new FrmAddUpdateUser((int)dgvUsersList.CurrentRow.Cells[0].Value);
            form.ShowDialog();

            RefreshUsersList();
        }

        private void ShowUserInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmShowUserDetails form = new FrmShowUserDetails((int)dgvUsersList.CurrentRow.Cells[0].Value);
            form.ShowDialog();
        }

        private void DeleteUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete the selected user ?", "Verification",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.Cancel)
                return;

            if (!User.DeleteUser((int)dgvUsersList.CurrentRow.Cells[0].Value))
                MessageBox.Show("Failed to delete The selected user , due to the data connected to it !", "Deletion Failed",
                 MessageBoxButtons.OK, MessageBoxIcon.Information);

            else
            {
                MessageBox.Show("The selected user has been deleted successfully .", "Deletion Completed",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

                RefreshUsersList();
            }

        }

        private void ChangePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmChangeUserPassword form = new FrmChangeUserPassword((int)dgvUsersList.CurrentRow.Cells[0].Value);
            form.ShowDialog();
        }

        private void DgvUsersList_SelectionChanged(object sender, EventArgs e)
        {
            cbUsers.Enabled = dgvUsersList.SelectedRows.Count > 0;
        }

        private void DgvUsersList_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            showUserInformationToolStripMenuItem.PerformClick();
        }

        private void CbUsers_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            deleteUserToolStripMenuItem.Enabled = (int)dgvUsersList.CurrentRow.Cells[0].Value != CurrentUser.UserID;
        }
    }
}
