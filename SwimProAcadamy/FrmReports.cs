using System;
using System.Data;
using System.IO;
using System.Text;
using System.Windows.Forms;
using SwimProAcadamy.DAL;

namespace SwimProAcadamy
{
    public partial class FrmReports : Form
    {
        private readonly ReportDAL reportDal = new ReportDAL();

        public FrmReports()
        {
            InitializeComponent();
            // Reports have different result shapes. Remove the designer's fixed
            // columns so binding supplies exactly the columns returned by SQL.
            dgvReports.Columns.Clear();
            dgvReports.AutoGenerateColumns = true;
            Load += FrmReports_Load;
        }

        private void FrmReports_Load(object? sender, EventArgs e)
        {
            if (!UserSession.IsAdmin() && !UserSession.IsManager() && !UserSession.IsStaff() && !UserSession.IsStudent())
            {
                MessageBox.Show("You do not have permission to access this feature.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Close();
                return;
            }

            cmbReportType.Items.Clear();
            cmbReportType.Items.AddRange(new string[] {
                "All Swimmers",
                "Monthly Fees",
                "Competition Entries",
                "Private Coaching",
                "Training Plans"
            });

            cmbReportType.SelectedIndex = 0;
            dtpFromDate.Value = DateTime.Now.AddMonths(-1);
            dtpToDate.Value = DateTime.Now;

            GenerateReport();
        }

        private void BtnGenerateReport_Click(object? sender, EventArgs e)
        {
            GenerateReport();
        }

        private void GenerateReport()
        {
            if (cmbReportType.SelectedItem == null)
            {
                MessageBox.Show("Please select a report type.", "Validation Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string reportType = cmbReportType.SelectedItem.ToString() ?? "";
            DateTime fromDate = dtpFromDate.Value;
            DateTime toDate = dtpToDate.Value;

            if (fromDate > toDate)
            {
                MessageBox.Show("From Date cannot be later than To Date.", "Validation Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                DataTable reportData = reportDal.GenerateReport(reportType, fromDate, toDate);
                dgvReports.DataSource = reportData;

                lblTotalRecords.Text = $"Total Records: {reportData.Rows.Count}";
                lblReportStatus.Text = $"Generated '{reportType}' report on {DateTime.Now:yyyy-MM-dd HH:mm:ss}";

                AuditLogDAL.Log("VIEW", "Reports", $"{UserSession.RoleName} generated '{reportType}' report.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to generate report: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnExport_Click(object? sender, EventArgs e)
        {
            if (dgvReports.Rows.Count == 0)
            {
                MessageBox.Show("No data available in report to export.", "Export Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "CSV File (*.csv)|*.csv";
                saveFileDialog.FileName = $"SwimPro_Report_{cmbReportType.SelectedItem}_{DateTime.Now:yyyyMMdd}.csv";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        StringBuilder csv = new StringBuilder();

                        // Header
                        for (int i = 0; i < dgvReports.Columns.Count; i++)
                        {
                            csv.Append($"\"{dgvReports.Columns[i].HeaderText}\"");
                            if (i < dgvReports.Columns.Count - 1) csv.Append(",");
                        }
                        csv.AppendLine();

                        // Rows
                        foreach (DataGridViewRow row in dgvReports.Rows)
                        {
                            if (!row.IsNewRow)
                            {
                                for (int i = 0; i < dgvReports.Columns.Count; i++)
                                {
                                    string cellValue = row.Cells[i].Value?.ToString() ?? "";
                                    csv.Append($"\"{cellValue.Replace("\"", "\"\"")}\"");
                                    if (i < dgvReports.Columns.Count - 1) csv.Append(",");
                                }
                                csv.AppendLine();
                            }
                        }

                        File.WriteAllText(saveFileDialog.FileName, csv.ToString(), Encoding.UTF8);
                        AuditLogDAL.Log("EXPORT", "Reports", $"{UserSession.RoleName} exported report to '{saveFileDialog.FileName}'.");

                        MessageBox.Show("Report exported successfully!", "Export Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Unable to export file: " + ex.Message, "Export Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void dgvReports_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void btnGenerateReport_Click(object sender, EventArgs e)
        {
            GenerateReport();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            BtnExport_Click(sender, e);
        }

        private void dtpFromDate_ValueChanged(object sender, EventArgs e)
        {
        }
    }
}

