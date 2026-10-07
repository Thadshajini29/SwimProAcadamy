using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using SwimProAcadamy.DAL;
using SwimProAcadamy.Models;

namespace SwimProAcadamy
{
    public partial class FrmFeeCalculator : Form
    {
        private int selectedSwimmerId;
        private bool feeCalculated;
        private decimal selectedTrainingFee;
        private int? selectedMinimumAge;
        private int? selectedMaximumAge;
        private bool selectedCompetitionAllowed;
        public FrmFeeCalculator()
        {
            InitializeComponent();
            Load += FrmFeeCalculator_Load;
            cmbSwimmer.SelectedIndexChanged += cmbSwimmer_SelectedIndexChanged;
            btnCalculate.Click += btnCalculate_Click;
            btnSaveFee.Click += btnSaveFee_Click;
            btnClear.Click += (s, e) => ClearCalculator();
        }

        private void FrmFeeCalculator_Load(object? sender, EventArgs e)
        {
            if (!UserSession.IsAdmin() && !UserSession.IsManager() && !UserSession.IsStaff() && !UserSession.IsStudent())
            {
                MessageBox.Show("You do not have permission to access this feature.", "Access Denied", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Close();
                return;
            }
            try
            {
                using MySqlConnection connection = DatabaseHelper.GetConnection();
                string swimmersSql = UserSession.IsStudent()
                    ? "SELECT id, name FROM swimmers WHERE is_active = 1 AND user_id = @userId ORDER BY name"
                    : "SELECT id, name FROM swimmers WHERE is_active = 1 ORDER BY name";
                using MySqlDataAdapter adapter = new(swimmersSql, connection);
                if (UserSession.IsStudent()) adapter.SelectCommand.Parameters.AddWithValue("@userId", UserSession.UserId);
                DataTable table = new();
                adapter.Fill(table);
                cmbSwimmer.DataSource = table;
                cmbSwimmer.DisplayMember = "name";
                cmbSwimmer.ValueMember = "id";
                cmbSwimmer.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to load swimmers. " + ex.Message, "Database Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbSwimmer_SelectedIndexChanged(object? sender, EventArgs e)
        {
            if (cmbSwimmer.SelectedValue == null || cmbSwimmer.SelectedValue is DataRowView) return;
            int swimmerId = Convert.ToInt32(cmbSwimmer.SelectedValue);
            try
            {
                using MySqlConnection connection = DatabaseHelper.GetConnection();
                connection.Open();
                using MySqlCommand command = new(@"SELECT s.id, s.age, s.competitions, s.coaching_hours,
                    tp.plan_name, tp.weekly_fee, tp.competition_allowed, cc.category_name, cc.min_age, cc.max_age
                    FROM swimmers s
                    INNER JOIN training_plans tp ON s.training_plan_id = tp.id
                    LEFT JOIN competition_categories cc ON s.competition_category_id = cc.id
                    WHERE s.id = @id", connection);

                command.Parameters.AddWithValue("@id", swimmerId);
                using MySqlDataReader reader = command.ExecuteReader();
                if (!reader.Read()) return;
                selectedSwimmerId = reader.GetInt32("id");
                txtSelectedPlan.Text = reader.GetString("plan_name");
                selectedTrainingFee = reader.GetDecimal("weekly_fee") * 4m;
                selectedCompetitionAllowed = reader.GetBoolean("competition_allowed");
                txtSelectedAge.Text = reader.GetInt32("age").ToString();
                txtSelectedCategory.Text = reader.IsDBNull(reader.GetOrdinal("category_name")) ? 
                    "Not selected" : reader.GetString("category_name");
                selectedMinimumAge = reader.IsDBNull(reader.GetOrdinal("min_age")) ? null : reader.GetInt32("min_age");
                selectedMaximumAge = reader.IsDBNull(reader.GetOrdinal("max_age")) ? null : reader.GetInt32("max_age");
                txtCompetitionCount.Text = reader.GetInt32("competitions").ToString();
                txtCoachingHours.Text = reader.GetDecimal("coaching_hours").ToString("0.##");
                feeCalculated = false;
                ResetCostLabels();
                ShowAgeCategoryStatus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to load swimmer details. " + ex.Message, "Database Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCalculate_Click(object? sender, EventArgs e)
        {
            if (selectedSwimmerId == 0)
            {
                MessageBox.Show("Please select a swimmer.",
                    "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!int.TryParse(txtCompetitionCount.Text, out int competitions) || competitions < 0 ||
                !decimal.TryParse(txtCoachingHours.Text, out decimal hours) || hours < 0)
            {
                MessageBox.Show("Competition count and coaching hours must be valid non-negative numbers.",
                    "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (hours > SwimProRules.MaximumMonthlyCoachingHours)
            {
                MessageBox.Show("Private coaching cannot exceed 24 hours per month.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (competitions > 0 && !selectedCompetitionAllowed)
            {
                MessageBox.Show("Beginner swimmers cannot enter competitions.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // An age/category mismatch is displayed as a status message. It does
            // not prevent calculation of the compulsory monthly training fee.

            decimal training = selectedTrainingFee;
            decimal competition = competitions * SwimProRules.CompetitionFee;
            decimal coaching = hours * SwimProRules.CoachingFee;
            decimal total = training + competition + coaching;
            lblTrainingCost.Text = $"Training Fee: Rs. {training:N2}";
            lblCompetitionCost.Text = $"Competition Fee: Rs. {competition:N2}";
            lblCoachingCost.Text = $"Private Coaching: Rs. {coaching:N2}";
            lblTotalCost.Text = $"Total Monthly Cost: Rs. {total:N2}";
            feeCalculated = true;
        }

        private void ShowAgeCategoryStatus()
        {
            if (!selectedMinimumAge.HasValue || !selectedMaximumAge.HasValue)
            {
                lblValidationResult.Text = "No competition category has been selected.";
                lblValidationResult.ForeColor = Color.Firebrick;
                return;
            }

            bool valid = IsAgeCategoryValid();
            lblValidationResult.Text = valid ? "Age matches the selected competition category."
                : "Age does NOT match the selected competition category.";
            lblValidationResult.ForeColor = valid ? Color.ForestGreen : Color.Firebrick;
        }

        private bool IsAgeCategoryValid() =>
            selectedMinimumAge.HasValue && selectedMaximumAge.HasValue &&
            int.TryParse(txtSelectedAge.Text, out int age) &&
            age >= selectedMinimumAge.Value && age <= selectedMaximumAge.Value;
        private void btnSaveFee_Click(object? sender, EventArgs e)
        {
            if (selectedSwimmerId == 0 || !feeCalculated)
            {
                MessageBox.Show("Calculate the fee before saving it.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (UserSession.IsStudent())
            {
                MessageBox.Show("Students can view their fees but cannot save fee calculations.", "Permission Denied", 
                    MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            try
            {
                decimal training = selectedTrainingFee;
                int competitions = int.Parse(txtCompetitionCount.Text);
                decimal hours = decimal.Parse(txtCoachingHours.Text);
                decimal competition = competitions * SwimProRules.CompetitionFee;
                decimal coaching = hours * SwimProRules.CoachingFee;
                Fee fee = new Fee
                {
                    SwimmerId = selectedSwimmerId,
                    TrainingFee = training,
                    CompetitionFee = competition,
                    CoachingFee = coaching,
                    TotalFee = training + competition + coaching,
                    FeeMonth = DateTime.Today,
                    CreatedBy = UserSession.UserId
                };

                new FeeDAL().SaveFee(fee);
                AuditLogDAL.Log("CALCULATE", "Fee Calculator", $"Calculated monthly fee for swimmer ID {selectedSwimmerId}.");
                MessageBox.Show("Fee saved successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fee could not be saved. " + ex.Message, "Database Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void ClearCalculator()
        {
            selectedSwimmerId = 0;
            feeCalculated = false;
            selectedTrainingFee = 0;
            selectedMinimumAge = null;
            selectedMaximumAge = null;
            selectedCompetitionAllowed = false;
            cmbSwimmer.SelectedIndex = -1;
            txtSelectedPlan.Clear();
            txtSelectedAge.Clear();
            txtSelectedCategory.Clear();
            txtCompetitionCount.Clear();
            txtCoachingHours.Clear();
            lblValidationResult.Text = "Select a swimmer to check category";
            lblValidationResult.ForeColor = Color.DimGray;
            ResetCostLabels();
        }

        private void ResetCostLabels()
        {
            lblTrainingCost.Text = "Training Fee: Rs. 0.00";
            lblCompetitionCost.Text = "Competition Fee: Rs. 0.00";
            lblCoachingCost.Text = "Private Coaching: Rs. 0.00";
            lblTotalCost.Text = "Total Monthly Cost: Rs. 0.00";
        }

        private void pnlSwimmerDetails_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlCostBreakdown_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblAgeValidation_Click(object sender, EventArgs e)
        {

        }
    }
}
