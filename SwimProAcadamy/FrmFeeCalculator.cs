using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SwimProAcadamy
{
    public partial class FrmFeeCalculator : Form
    {
        private int selectedSwimmerId;
        private bool feeCalculated;
        private readonly Button btnSaveFee = new()
        {
            Text = "Save Fee",
            Width = 150,
            Height = 45,
            Left = 345,
            Top = 360,
            BackColor = Color.MidnightBlue,
            ForeColor = Color.White,
            FlatStyle = FlatStyle.Flat
        };
        private readonly Button btnClear = new()
        {
            Text = "Clear",
            Width = 150,
            Height = 45,
            Left = 30,
            Top = 420,
            BackColor = Color.Gray,
            ForeColor = Color.White,
            FlatStyle = FlatStyle.Flat
        };
        public FrmFeeCalculator()
        {
            InitializeComponent();
            Load += FrmFeeCalculator_Load;
            cmbSwimmer.SelectedIndexChanged += cmbSwimmer_SelectedIndexChanged;
            btnCalculate.Click += btnCalculate_Click;
            pnlCostBreakdown.Controls.Add(btnSaveFee);
            pnlCostBreakdown.Controls.Add(btnClear);
            btnSaveFee.Click += btnSaveFee_Click;
            btnClear.Click += (s, e) => ClearCalculator();
        }

        private void FrmFeeCalculator_Load(object? sender, EventArgs e)
        {
            try
            {
                using MySqlConnection connection = new Database().GetConnection();
                using MySqlDataAdapter adapter = new("SELECT id, name FROM swimmers ORDER BY name", connection);
                DataTable table = new();
                adapter.Fill(table);
                cmbSwimmer.DataSource = table;
                cmbSwimmer.DisplayMember = "name";
                cmbSwimmer.ValueMember = "id";
                cmbSwimmer.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to load swimmers. " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbSwimmer_SelectedIndexChanged(object? sender, EventArgs e)
        {
            if (cmbSwimmer.SelectedValue == null || cmbSwimmer.SelectedValue is DataRowView) return;
            int id = Convert.ToInt32(cmbSwimmer.SelectedValue);
            try
            {
                using MySqlConnection connection = new Database().GetConnection();
                connection.Open();
                using MySqlCommand command = new("SELECT id, training_plan, age, competition_category, competitions," +
                    " coaching_hours FROM swimmers WHERE id=@id", connection);

                command.Parameters.AddWithValue("@id", id);
                using MySqlDataReader reader = command.ExecuteReader();
                if (!reader.Read()) return;
                selectedSwimmerId = reader.GetInt32("id");
                txtSelectedPlan.Text = reader.GetString("training_plan");
                txtSelectedAge.Text = reader.GetInt32("age").ToString();
                txtSelectedCategory.Text = reader.GetString("competition_category");
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
                MessageBox.Show("Competition count and coaching hours must be valid positive numbers.",
                    "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (hours > SwimProRules.MaximumMonthlyCoachingHours)
            {
                MessageBox.Show("Private coaching cannot exceed 24 hours per month.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (competitions > 0 && !SwimProRules.IsCompetitionAllowed(txtSelectedPlan.Text))
            {
                MessageBox.Show("Beginner swimmers cannot enter competitions.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            decimal training = SwimProRules.GetTrainingFee(txtSelectedPlan.Text);
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
            bool valid = int.TryParse
                (txtSelectedAge.Text, out int age) && SwimProRules.AgeMatchesCategory(age, txtSelectedCategory.Text);
            lblValidationResult.Text = valid ? "Age matches the selected competition category."
                : "Age does NOT match the selected competition category.";
            lblValidationResult.ForeColor = valid ? Color.ForestGreen : Color.Firebrick;
        }
        private void btnSaveFee_Click(object? sender, EventArgs e)
        {
            if (selectedSwimmerId == 0 || !feeCalculated)
            {
                MessageBox.Show("Calculate the fee before saving it.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                decimal training = SwimProRules.GetTrainingFee(txtSelectedPlan.Text);
                int competitions = int.Parse(txtCompetitionCount.Text);
                decimal hours = decimal.Parse(txtCoachingHours.Text);
                decimal competition = competitions * SwimProRules.CompetitionFee;
                decimal coaching = hours * SwimProRules.CoachingFee;


                using MySqlConnection c = new Database().GetConnection();
                c.Open();
                using MySqlCommand cmd = new("INSERT INTO fees(swimmer_id,training_fee,competition_fee,coaching_fee,total_fee)" +
                    " VALUES(@id,@training,@competition,@coaching,@total)", c);
                cmd.Parameters.AddWithValue("@id", selectedSwimmerId);

                cmd.Parameters.AddWithValue("@training", training);
                cmd.Parameters.AddWithValue("@competition", competition);
                cmd.Parameters.AddWithValue("@coaching", coaching);
                cmd.Parameters.AddWithValue("@total", training + competition + coaching);
                cmd.ExecuteNonQuery();
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
