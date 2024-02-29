using Guna.UI2.WinForms;
using System.Drawing;
using System.Windows.Forms;

namespace CarRentalManagementSystem
{
    public partial class frmHome : Form
    {
        public frmHome()
        {
            InitializeComponent();
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
    }
}
