using CarRentalManagementSystem.Users;
using Guna.UI2.WinForms;
using System.Drawing;
using System.Windows.Forms;

namespace CarRentalManagementSystem
{
    public partial class frmHome : Form
    {
        private Guna2Button _CurrentActiveButton = new Guna2Button();

        public frmHome()
        {
            InitializeComponent();
        }

        private void _ShowForm(Guna2Button activeBtn, Form frm)
        {
            if (_CurrentActiveButton != null)
                _CurrentActiveButton.Checked = false;

            _CurrentActiveButton = activeBtn;
            _CurrentActiveButton.Checked = true;

            frm.BackColor = pnlContainer.BackColor;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;

            pnlContainer.Controls.Clear();
            pnlContainer.Controls.Add(frm);

            frm.Show();
        }

        private void btnExit_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void btnCollapse_Click(object sender, System.EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button_MouseEnter(object sender, System.EventArgs e)
        {
           ((Guna2ImageButton)sender).BackColor = ColorTranslator.FromHtml("#372E18");
        }

        private void button_MouseLeave(object sender, System.EventArgs e)
        {
            ((Guna2ImageButton)sender).BackColor = ColorTranslator.FromHtml("#FBCD08");
        }

        private void btnManageUsers_Click(object sender, System.EventArgs e)
        {
            _ShowForm((Guna2Button)sender,new frmListUsers());
        }

        private void frmHome_Load(object sender, System.EventArgs e)
        {
            btnManageUsers.PerformClick();
        }
    }
}
