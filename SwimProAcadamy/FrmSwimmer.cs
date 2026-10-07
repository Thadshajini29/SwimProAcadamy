using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using SwimProAcadamy.DAL;
using SwimProAcadamy.Models;

namespace SwimProAcadamy
{
    public partial class FrmSwimmer : Form
    {
        private readonly SwimmerDal swimmerDal = new SwimmerDal();
        private int selectedSwimmerId = 0;

        public FrmSwimmer()
        {
            InitializeComponent();
            // The data source supplies the required columns. Remove the empty
            // designer columns so the grid does not show every column twice.
            dgvSwimmers.AutoGenerateColumns = true;
            dgvSwimmers.Columns.Clear();
            Load += FrmSwimmer_Load;
            btnAdd.Click += BtnAdd_Click;
            btnUpdate.Click += BtnUpdate_Click;
            btnSearch.Click += BtnSearch_Click;
            dgvSwimmers.CellClick += DgvSwimmers_CellClick;
        }

        private void FrmSwimmer_Load(object? sender, EventArgs e)
        {
            if (!UserSession.IsAdmin() && !UserSession.IsManager() && !UserSession.IsStaff())
            {
                MessageBox.Show("You do not have permission to access this feature.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Close();
                return;
            }
            PopulateDropdowns();
            LoadSwimmers();

            // Staff users cannot delete swimmers
            if (UserSession.IsStaff())
            {
                btnDelete.Enabled = false;
                btnDelete.Visible = false;
            }

            ClearInputs();
        }

        private void PopulateDropdowns()
        {
            try
            {
                using (MySqlConnection connection = DatabaseHelper.GetConnection())
                {
                    connection.Open();

                    // Training Plans
                    using (MySqlCommand cmdPlans = new MySqlCommand("SELECT id, plan_name FROM training_plans WHERE is_active = 1", connection))
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmdPlans))
                    {
                        DataTable plansTable = new DataTable();
                        adapter.Fill(plansTable);
                        cmbTrainingPlan.DataSource = plansTable;
                        cmbTrainingPlan.DisplayMember = "plan_name";
                        cmbTrainingPlan.ValueMember = "id";
                        cmbTrainingPlan.SelectedIndex = -1;
                    }

                    // Competition Categories
                    using (MySqlCommand cmdCategories = new MySqlCommand("SELECT id, category_name FROM competition_categories WHERE is_active = 1", connection))
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmdCategories))
                    {
                        DataTable categoriesTable = new DataTable();
                        adapter.Fill(categoriesTable);
                        cmbCompetitionCategory.DataSource = categoriesTable;
                        cmbCompetitionCategory.DisplayMember = "category_name";
                        cmbCompetitionCategory.ValueMember = "id";
                        cmbCompetitionCategory.SelectedIndex = -1;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to load training plans or competition categories: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadSwimmers(string search = "")
        {
            try
            {
                dgvSwimmers.DataSource = swimmerDal.GetAllSwimmers(search);

                var colPlan = dgvSwimmers.Columns["training_plan_id"];
                if (colPlan != null) colPlan.Visible = false;

                var colCat = dgvSwimmers.Columns["competition_category_id"];
                if (colCat != null) colCat.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to load swimmer records: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidateInputs()
        {
            if (string.IsNullOrWhiteSpace(txtName.Text) || cmbTrainingPlan.SelectedValue == null)
            {
                MessageBox.Show("Please enter Swimmer Name and select a Training Plan.", "Validation Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (nudAge.Value < 1)
            {
                MessageBox.Show("Age must be greater than zero.", "Validation Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (nudCoachingHours.Value > 24)
            {
                MessageBox.Show("Private coaching cannot exceed 24 hours per month.", "Validation Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            string selectedPlanName = cmbTrainingPlan.Text;
            if (nudCompetitions.Value > 0 && string.Equals(selectedPlanName, "Beginner", StringComparison.OrdinalIgnoreCase))
            {
                MessageBox.Show("Beginner swimmers cannot enter competitions.", "Validation Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void BtnAdd_Click(object? sender, EventArgs e)
        {
            if (!ValidateInputs()) return;

            try
            {
                Swimmer swimmer = new Swimmer
                {
                    Name = txtName.Text.Trim(),
                    Age = (int)nudAge.Value,
                    TrainingPlanId = Convert.ToInt32(cmbTrainingPlan.SelectedValue),
                    CompetitionCategoryId = cmbCompetitionCategory.SelectedValue != null ? Convert.ToInt32(cmbCompetitionCategory.SelectedValue) : null,
                    Competitions = (int)nudCompetitions.Value,
                    CoachingHours = nudCoachingHours.Value,
                    IsActive = true
                };

                if (swimmerDal.AddSwimmer(swimmer))
                {
                    AuditLogDAL.Log("ADD", "Swimmer Management", $"{UserSession.RoleName} added swimmer '{swimmer.Name}'.");
                    MessageBox.Show("Swimmer added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadSwimmers();
                    ClearInputs();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to add swimmer: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnUpdate_Click(object? sender, EventArgs e)
        {
            if (selectedSwimmerId == 0)
            {
                MessageBox.Show("Please select a swimmer from the table to update.", "Validation Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!ValidateInputs()) return;

            try
            {
                Swimmer swimmer = new Swimmer
                {
                    SwimmerId = selectedSwimmerId,
                    Name = txtName.Text.Trim(),
                    Age = (int)nudAge.Value,
                    TrainingPlanId = Convert.ToInt32(cmbTrainingPlan.SelectedValue),
                    CompetitionCategoryId = cmbCompetitionCategory.SelectedValue != null ? Convert.ToInt32(cmbCompetitionCategory.SelectedValue) : null,
                    Competitions = (int)nudCompetitions.Value,
                    CoachingHours = nudCoachingHours.Value,
                    IsActive = true
                };

                if (swimmerDal.UpdateSwimmer(swimmer))
                {
                    AuditLogDAL.Log("UPDATE", "Swimmer Management", $"{UserSession.RoleName} updated swimmer ID {selectedSwimmerId} ('{swimmer.Name}').");
                    MessageBox.Show("Swimmer updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadSwimmers();
                    ClearInputs();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to update swimmer: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnDelete_Click(object? sender, EventArgs e)
        {
            if (UserSession.IsStaff())
            {
                MessageBox.Show("Staff users are not allowed to delete swimmers.", "Permission Denied", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            if (selectedSwimmerId == 0)
            {
                MessageBox.Show("Please select a swimmer from the table to delete.", "Validation Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("Are you sure you want to delete the selected swimmer?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes)
            {
                return;
            }

            try
            {
                if (swimmerDal.DeleteSwimmer(selectedSwimmerId))
                {
                    AuditLogDAL.Log("DELETE", "Swimmer Management", $"{UserSession.RoleName} deleted swimmer ID {selectedSwimmerId}.");
                    MessageBox.Show("Swimmer deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadSwimmers();
                    ClearInputs();
                }
            }
            catch (MySqlException ex) when (ex.Number == 1451)
            {
                MessageBox.Show("This swimmer has associated fee records and cannot be deleted.", "Delete Blocked", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to delete swimmer: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnSearch_Click(object? sender, EventArgs e)
        {
            LoadSwimmers(txtSearch.Text.Trim());
        }

        private void DgvSwimmers_CellClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow row = dgvSwimmers.Rows[e.RowIndex];
            selectedSwimmerId = Convert.ToInt32(row.Cells["ID"].Value);
            txtName.Text = Convert.ToString(row.Cells["Swimmer Name"].Value) ?? "";
            nudAge.Value = Convert.ToDecimal(row.Cells["Age"].Value);

            if (row.Cells["training_plan_id"].Value != DBNull.Value)
                cmbTrainingPlan.SelectedValue = Convert.ToInt32(row.Cells["training_plan_id"].Value);

            if (row.Cells["competition_category_id"].Value != DBNull.Value)
                cmbCompetitionCategory.SelectedValue = Convert.ToInt32(row.Cells["competition_category_id"].Value);
            else
                cmbCompetitionCategory.SelectedIndex = -1;

            nudCompetitions.Value = Convert.ToDecimal(row.Cells["Competitions"].Value);
            nudCoachingHours.Value = Convert.ToDecimal(row.Cells["Coaching Hours"].Value);
        }

        private void ClearInputs()
        {
            selectedSwimmerId = 0;
            txtName.Clear();
            txtSearch.Clear();
            nudAge.Value = 10;
            nudCompetitions.Value = 0;
            nudCoachingHours.Value = 0;
            cmbTrainingPlan.SelectedIndex = -1;
            cmbCompetitionCategory.SelectedIndex = -1;
            dgvSwimmers.ClearSelection();
        }

        private void btnClear_Click(object sender, EventArgs e) => ClearInputs();
        private void btnDelete_Click_1(object sender, EventArgs e) => BtnDelete_Click(sender, e);

        private void pnlSwimmerInput_Paint(object sender, PaintEventArgs e)
        {
        }
    }
}
