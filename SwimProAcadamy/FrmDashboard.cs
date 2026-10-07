using System;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using SwimProAcadamy.DAL;

namespace SwimProAcadamy
{
    public partial class FrmDashboard : Form
    {
        public FrmDashboard()
        {
            InitializeComponent();
            btnSwimmers.Click += (s, e) => new FrmSwimmer().ShowDialog();
            btnFeeCalculator.Click += (s, e) => new FrmFeeCalculator().ShowDialog();
            btnReports.Click += (s, e) => new FrmReports().ShowDialog();
            btnTrainingPlans.Click += (s, e) => new FrmTrainingPlans().ShowDialog();
            btnUserManagement.Click += (s, e) => new FrmUserManagement().ShowDialog();
            btnAuditLog.Click += (s, e) => new FrmAuditLog().ShowDialog();
            cmbRolePreview.SelectedIndexChanged += cmbRolePreview_SelectedIndexChanged;
        }

        private void FrmDashboard_Load(object sender, EventArgs e)
        {
            LoadSwimmerCount();

            string loginRole = UserSession.RoleName?.Trim() ?? string.Empty;
            int roleIndex = cmbRolePreview.FindStringExact(loginRole);
            cmbRolePreview.SelectedIndex = roleIndex >= 0 ? roleIndex : 0;
        }

        private void cmbRolePreview_SelectedIndexChanged(object? sender, EventArgs e)
        {
            if (cmbRolePreview.SelectedItem == null) return;

            string selectedRole = cmbRolePreview.SelectedItem.ToString() ?? string.Empty;
            UpdateWelcomeMessage(selectedRole);

            switch (selectedRole)
            {
                case "Admin": SetAdminDashboard(); break;
                case "Manager": SetManagerDashboard(); break;
                case "Staff": SetStaffDashboard(); break;
                case "Student": SetStudentDashboard(); break;
            }
        }

        private void SetAdminDashboard()
        {
            ResetCardText();
            SetCards(true, true, true, true, true, true);
            pnlSwimmers.Location = new Point(50, 120);
            pnlTrainingPlans.Location = new Point(435, 120);
            pnlFees.Location = new Point(820, 120);
            pnlReports.Location = new Point(50, 370);
            pnlUsers.Location = new Point(435, 370);
            pnlAudit.Location = new Point(820, 370);
            lblRole.Text = "Role:";
        }

        private void SetManagerDashboard()
        {
            ResetCardText();
            SetCards(true, true, true, true, false, false);
            pnlSwimmers.Location = new Point(170, 120);
            pnlTrainingPlans.Location = new Point(550, 120);
            pnlFees.Location = new Point(170, 370);
            pnlReports.Location = new Point(550, 370);
            lblRole.Text = "Role:";
        }

        private void SetStaffDashboard()
        {
            ResetCardText();
            SetCards(true, false, true, true, false, false);
            pnlSwimmers.Location = new Point(50, 200);
            pnlFees.Location = new Point(435, 200);
            pnlReports.Location = new Point(820, 200);
            lblRole.Text = "Role:";
        }

        private void SetStudentDashboard()
        {
            ResetCardText();
            SetCards(false, false, true, true, false, false);
            pnlFees.Location = new Point(245, 200);
            pnlReports.Location = new Point(625, 200);
            lblFees.Text = "Monthly Fees";
            btnFeeCalculator.Text = "View your monthly fee details";
            lblReports.Text = "My Reports";
            btnReports.Text = "View your swimming reports";
            lblRole.Text = "Role:";
        }

        private void SetCards(bool swimmers, bool plans, bool fees, bool reports, bool users, bool audit)
        {
            pnlSwimmers.Visible = swimmers;
            pnlTrainingPlans.Visible = plans;
            pnlFees.Visible = fees;
            pnlReports.Visible = reports;
            pnlUsers.Visible = users;
            pnlAudit.Visible = audit;
        }

        private void ResetCardText()
        {
            lblFees.Text = "Monthly Fees";
            btnFeeCalculator.Text = "Calculate Fees";
            lblReports.Text = "Reports";
            btnReports.Text = "View Reports";
        }

        private void LoadSwimmerCount()
        {
            try
            {
                using MySqlConnection connection = DatabaseHelper.GetConnection();
                using MySqlCommand command = new MySqlCommand("SELECT COUNT(*) FROM swimmers", connection);
                connection.Open();
                lblSwimmerCount.Text = Convert.ToString(command.ExecuteScalar()) ?? "0";
            }
            catch
            {
                lblSwimmerCount.Text = "0";
            }
        }

        private void UpdateWelcomeMessage(string selectedRole)
        {
            // Keep the real logged-in user's name when their own role is shown.
            // For dashboard layout testing, display an active sample user of the
            // selected role without changing UserSession or login permissions.
            if (string.Equals(UserSession.RoleName, selectedRole, StringComparison.OrdinalIgnoreCase) &&
                !string.IsNullOrWhiteSpace(UserSession.FullName))
            {
                lblWelcome.Text = $"Welcome, {UserSession.FullName}";
                return;
            }

            try
            {
                using MySqlConnection connection = DatabaseHelper.GetConnection();
                using MySqlCommand command = new MySqlCommand(@"SELECT u.full_name
                    FROM users u
                    INNER JOIN user_roles ur ON ur.user_id = u.id
                    INNER JOIN roles r ON r.id = ur.role_id
                    WHERE r.role_name = @role AND u.is_active = 1
                    ORDER BY u.id LIMIT 1", connection);
                command.Parameters.AddWithValue("@role", selectedRole);
                connection.Open();
                string name = Convert.ToString(command.ExecuteScalar()) ?? string.Empty;
                lblWelcome.Text = string.IsNullOrWhiteSpace(name)
                    ? $"Welcome to SwimPro Academy ({selectedRole})"
                    : $"Welcome, {name}";
            }
            catch
            {
                lblWelcome.Text = "Welcome to SwimPro Academy";
            }
        }

        // Kept for the Click event generated by the Windows Forms Designer.
        private void btnLogout_Click(object sender, EventArgs e)
        {
            UserSession.Clear();
            Close();
        }

        // Required by the ComboBox event assigned in FrmDashboard.Designer.cs.
    }
}
