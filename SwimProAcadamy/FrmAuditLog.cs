using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SwimProAcadamy.DAL;

namespace SwimProAcadamy
{
    public partial class FrmAuditLog : Form
    {
        public FrmAuditLog()
        {
            InitializeComponent();
        }

        private void btnAuditSearch_Click(object sender, EventArgs e)
        {
            LoadLogs(cmbAuditUsername.Text, cmbAuditAction.Text, dtpAuditFromDate.Value, dtpAuditToDate.Value);
        }

        private void btnAuditShowAll_Click(object sender, EventArgs e)
        {
            cmbAuditUsername.SelectedIndex = -1;
            cmbAuditAction.SelectedIndex = 0;
            LoadLogs();
        }

        private void dgvAuditLog_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (!UserSession.IsAdmin())
            {
                MessageBox.Show("You do not have permission to access this feature.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Close();
                return;
            }
            cmbAuditAction.SelectedIndex = 0;
            LoadLogs();
        }

        private void LoadLogs(string username = "", string action = "", DateTime? from = null, DateTime? to = null)
        {
            try { dgvAuditLog.DataSource = AuditLogDAL.GetAuditLogs(username, action, from, to); }
            catch (Exception ex) { MessageBox.Show("Unable to load audit logs: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
    }
}
