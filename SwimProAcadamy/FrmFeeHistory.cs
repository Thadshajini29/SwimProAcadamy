using System;
using System.Data;
using System.Windows.Forms;
using SwimProAcadamy.DAL;

namespace SwimProAcadamy
{
    public partial class FrmFeeHistory : Form
    {
        private readonly FeeDAL feeDal = new FeeDAL();

        public FrmFeeHistory()
        {
            InitializeComponent();
            Load += FrmFeeHistory_Load;
        }

        private void FrmFeeHistory_Load(object? sender, EventArgs e)
        {
            LoadFeeHistory();
        }

        private void LoadFeeHistory(string searchSwimmer = "")
        {
            try
            {
                int studentUserId = UserSession.IsStudent() ? UserSession.UserId : 0;
                DataTable table = feeDal.GetFeeHistory(searchSwimmer, studentUserId);
                dgvFeeHistory.DataSource = table;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to load fee history: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnSearch_Click(object? sender, EventArgs e)
        {
            LoadFeeHistory(txtSearch.Text.Trim());
        }

        private void BtnShowAll_Click(object? sender, EventArgs e)
        {
            txtSearch.Clear();
            LoadFeeHistory();
        }

        private void BtnPrint_Click(object? sender, EventArgs e)
        {
            if (dgvFeeHistory.Rows.Count == 0)
            {
                MessageBox.Show("No fee history records available to print.", "Print Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            MessageBox.Show($"Found {dgvFeeHistory.Rows.Count} fee history records. Printing feature is ready for printer connection.", "Print Fee History", MessageBoxButtons.OK, MessageBoxIcon.Information);
            AuditLogDAL.Log("EXPORT", "Fee History", $"{UserSession.RoleName} printed fee history report.");
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadFeeHistory(txtSearch.Text.Trim());
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
            LoadFeeHistory();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            BtnPrint_Click(sender, e);
        }

        private void dgvFeeHistory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
    }
}
