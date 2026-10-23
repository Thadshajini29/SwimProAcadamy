using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using SwimProAcadamy.DAL;

namespace SwimProAcadamy
{
    public partial class FrmDashboard : Form
    {
        private readonly List<Panel> cards;

        public FrmDashboard()
        {
            InitializeComponent();
            cards = new List<Panel> { pnlSwimmers, pnlTrainingPlans, pnlCompetitionCategories, pnlFeeCalculator, pnlFeeHistory, pnlReports, pnlUserManagement, pnlAudit };

            btnSwimmers.Click += (s, e) => OpenSwimmers();
            btnTrainingPlans.Click += (s, e) => OpenProtected("MANAGE_PLANS", () => new FrmTrainingPlans());
            btnCompetitionCategories.Click += (s, e) => OpenProtected("MANAGE_CATEGORIES", () => new FrmCompetitionCategories());
            btnFeeCalculator.Click += (s, e) => OpenProtected("CALCULATE_FEES", () => new FrmFeeCalculator());
            btnFeeHistory.Click += (s, e) => OpenProtected("VIEW_FEE_HISTORY", () => new FrmFeeHistory());
            btnReports.Click += (s, e) => OpenProtected("VIEW_REPORTS", () => new FrmReports());
            btnUserManagement.Click += (s, e) => OpenProtected("MANAGE_USERS", () => new FrmUserManagement());
            btnAuditLog.Click += (s, e) => OpenProtected("VIEW_AUDIT_LOG", () => new FrmAuditLog());
            btnLogout.Click += btnLogout_Click;
            lnkGoToRegister.LinkClicked += lnkGoToRegister_LinkClicked;
        }

        private void FrmDashboard_Load(object sender, EventArgs e)
        {
            if (UserSession.UserId <= 0) { Close(); return; }

            cmbRolePreview.Items.Clear();
            cmbRolePreview.Items.Add(UserSession.RoleName);
            cmbRolePreview.SelectedIndex = 0;
            cmbRolePreview.Enabled = false;
            lblRole.Text = "Role:";
            lblWelcome.Text = $"Welcome, {UserSession.FullName}";
            lnkGoToRegister.Text = "+ Create New Account";
            lnkGoToRegister.Visible = UserSession.HasPermission("MANAGE_USERS");
            ConfigureDashboard();
            LoadSummary();
        }

        private void ConfigureDashboard()
        {
            ResetCardText();
            SetCardVisibility(
                UserSession.HasPermission("VIEW_SWIMMERS") || UserSession.IsStudent(),
                UserSession.HasPermission("MANAGE_PLANS") || UserSession.IsStudent(),
                UserSession.HasPermission("MANAGE_CATEGORIES") || UserSession.IsStudent(),
                UserSession.HasPermission("CALCULATE_FEES") || UserSession.IsStudent(),
                UserSession.HasPermission("VIEW_FEE_HISTORY"),
                UserSession.HasPermission("VIEW_REPORTS") && !UserSession.IsStudent(),
                UserSession.HasPermission("MANAGE_USERS"),
                UserSession.HasPermission("VIEW_AUDIT_LOG"));

            if (UserSession.IsStudent())
            {
                lblSwimmersCardTitle.Text = "My Profile"; btnSwimmers.Text = "View My Profile";
                lblTrainingPlansTitle.Text = "My Training Plan"; btnTrainingPlans.Text = "View My Training Plan";
                lblCompetitionCategoriesTitle.Text = "My Competition Category"; btnCompetitionCategories.Text = "View My Category";
                lblFeeCalculatorTitle.Text = "My Monthly Fee"; btnFeeCalculator.Text = "View My Monthly Fee";
                lblFeeHistoryTitle.Text = "My Fee History"; btnFeeHistory.Text = "View My Fee History";
            }
            ArrangeVisibleCards();
        }

        private void ResetCardText()
        {
            lblSwimmersCardTitle.Text = "Swimmers"; btnSwimmers.Text = "Open Swimmers";
            lblTrainingPlansTitle.Text = "Training Plans"; btnTrainingPlans.Text = "Open Training Plans";
            lblCompetitionCategoriesTitle.Text = "Competition Categories"; btnCompetitionCategories.Text = "Open Categories";
            lblFeeCalculatorTitle.Text = "Monthly Fee Calculator"; btnFeeCalculator.Text = "Calculate Fees";
            lblFeeHistoryTitle.Text = "Fee History"; btnFeeHistory.Text = "View Fee History";
            lblReportsTitle.Text = "Reports"; btnReports.Text = "View Reports";
        }

        private void SetCardVisibility(bool swimmers, bool plans, bool categories, bool calculator, bool history, bool reports, bool users, bool audit)
        {
            pnlSwimmers.Visible = swimmers; pnlTrainingPlans.Visible = plans;
            pnlCompetitionCategories.Visible = categories; pnlFeeCalculator.Visible = calculator;
            pnlFeeHistory.Visible = history; pnlReports.Visible = reports;
            pnlUserManagement.Visible = users; pnlAudit.Visible = audit;
        }

        private void ArrangeVisibleCards()
        {
            int index = 0;
            foreach (Panel card in cards)
            {
                if (!card.Visible) continue;
                card.Location = new Point(30 + ((index % 4) * 295), 260 + ((index / 4) * 165));
                index++;
            }
        }

        private void LoadSummary()
        {
            try
            {
                using MySqlConnection connection = DatabaseHelper.GetConnection();
                connection.Open();
                if (UserSession.IsStudent())
                {
                    lblSwimmerCount.Text = GetStudentCount(connection, "SELECT COUNT(*) FROM swimmers WHERE is_active = 1 AND user_id = @userId");
                    lblPlanCount.Text = GetStudentCount(connection, "SELECT COUNT(DISTINCT training_plan_id) FROM swimmers WHERE is_active = 1 AND user_id = @userId");
                    lblMonthlyFees.Text = GetStudentCount(connection, "SELECT COUNT(*) FROM fees f INNER JOIN swimmers s ON s.id = f.swimmer_id WHERE s.user_id = @userId AND DATE_FORMAT(f.fee_month, '%Y-%m') = DATE_FORMAT(CURDATE(), '%Y-%m')");
                    lblCompetitionCount.Text = GetStudentCount(connection, "SELECT COALESCE(SUM(competitions), 0) FROM swimmers WHERE is_active = 1 AND user_id = @userId");
                    return;
                }
                lblSwimmerCount.Text = GetCount(connection, "SELECT COUNT(*) FROM swimmers WHERE is_active = 1");
                lblPlanCount.Text = GetCount(connection, "SELECT COUNT(*) FROM training_plans WHERE is_active = 1");
                lblMonthlyFees.Text = GetCount(connection, "SELECT COUNT(*) FROM fees WHERE DATE_FORMAT(fee_month, '%Y-%m') = DATE_FORMAT(CURDATE(), '%Y-%m')");
                lblCompetitionCount.Text = GetCount(connection, "SELECT COALESCE(SUM(competitions), 0) FROM swimmers WHERE is_active = 1");
            }
            catch { lblSwimmerCount.Text = lblPlanCount.Text = lblMonthlyFees.Text = lblCompetitionCount.Text = "0"; }
        }

        private static string GetCount(MySqlConnection connection, string sql)
        {
            using MySqlCommand command = new MySqlCommand(sql, connection);
            return Convert.ToString(command.ExecuteScalar()) ?? "0";
        }

        private static string GetStudentCount(MySqlConnection connection, string sql)
        {
            using MySqlCommand command = new MySqlCommand(sql, connection);
            command.Parameters.AddWithValue("@userId", UserSession.UserId);
            return Convert.ToString(command.ExecuteScalar()) ?? "0";
        }

        private void OpenSwimmers()
        {
            if (!UserSession.HasPermission("VIEW_SWIMMERS") && !UserSession.IsStudent()) { Deny(); return; }
            using FrmSwimmer form = new FrmSwimmer();
            form.ShowDialog(this);
            LoadSummary();
        }

        private void OpenProtected(string permission, Func<Form> createForm)
        {
            if (UserSession.IsStudent() && (permission == "CALCULATE_FEES" || permission == "MANAGE_PLANS" || permission == "MANAGE_CATEGORIES"))
            {
                if (permission == "CALCULATE_FEES") { using FrmFeeHistory feeHistoryForm = new FrmFeeHistory(); feeHistoryForm.ShowDialog(this); }
                else OpenSwimmers();
                return;
            }
            if (!UserSession.HasPermission(permission)) { Deny(); return; }
            using Form form = createForm();
            form.ShowDialog(this);
            LoadSummary();
        }

        private static void Deny() => MessageBox.Show("You do not have permission to access this feature.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        private void lnkGoToRegister_LinkClicked(object? sender, LinkLabelLinkClickedEventArgs e)
        {
            if (!UserSession.HasPermission("MANAGE_USERS")) { Deny(); return; }
            using FrmRegister form = new FrmRegister();
            form.ShowDialog(this);
        }

        private void btnLogout_Click(object? sender, EventArgs e)
        {
            AuditLogDAL.Log("LOGOUT", "Authentication", $"User '{UserSession.Username}' logged out.");
            UserSession.Clear();
            Close();
        }
    }
}
