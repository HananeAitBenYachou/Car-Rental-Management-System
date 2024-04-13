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
        private readonly DataTable _reportData;
        private readonly string _reportHeader;
        private readonly string _reportFilePath;

        public FrmReport(DataTable reportData , string reportHeader , string reportfilePath)
        {
            InitializeComponent();
            _reportData = reportData; 
            _reportHeader = reportHeader;
            _reportFilePath = reportfilePath;

            _reportData.Columns.Cast<DataColumn>().ToList().ForEach(c => c.ColumnName = c.ColumnName.Replace(" ", "_"));
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (!File.Exists(_reportFilePath)) 
            {
                MessageBox.Show("Failed to load specified report file", "Failed", 
                    MessageBoxButtons.OK,MessageBoxIcon.Error);
                this.Close();
                return;
            }

            this.Text = _reportHeader;

            ReportDataSource reportDataSource = new ReportDataSource("DataSet", _reportData);
            ReportParameter reportParameter = new ReportParameter("Title", _reportHeader);

            reportViewer1.LocalReport.ReportPath = _reportFilePath;
            reportViewer1.ZoomMode = ZoomMode.PageWidth;
            reportViewer1.LocalReport.DataSources.Add(reportDataSource);
            reportViewer1.LocalReport.SetParameters(reportParameter);
            reportViewer1.RefreshReport();
        }

    }
}
