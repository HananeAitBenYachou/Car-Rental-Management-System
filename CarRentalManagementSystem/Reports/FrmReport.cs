using CarRental_BusinessLayer;
using Microsoft.Reporting.WinForms;
using System;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace CarRentalManagementSystem
{
    public partial class FrmReport : Form
    {
        private readonly DataTable _dataTable;
        private readonly string _reportTitle;
        private readonly string _reportPath;

        public FrmReport(DataTable dataTable , string reportTitle , string reportPath)
        {
            InitializeComponent();
            _dataTable = dataTable; 
            _reportTitle = reportTitle;
            _reportPath = reportPath;

            _dataTable.Columns.Cast<DataColumn>().ToList().ForEach(c => c.ColumnName = c.ColumnName.Replace(" ", "_"));
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (!File.Exists(_reportPath)) 
            {
                MessageBox.Show("Failed to load specified report file", "Failed", 
                    MessageBoxButtons.OK,MessageBoxIcon.Error);
                this.Close();
            }

            this.Text = _reportTitle;

            ReportDataSource reportDataSource = new ReportDataSource("DataSet", _dataTable);
            reportViewer1.LocalReport.ReportPath = _reportPath;
            reportViewer1.ZoomMode = ZoomMode.PageWidth;
            reportViewer1.LocalReport.DataSources.Add(reportDataSource);
            reportViewer1.RefreshReport();
        }

    }
}
