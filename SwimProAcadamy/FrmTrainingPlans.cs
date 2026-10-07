using System;
using System.Data;
using System.Windows.Forms;
using SwimProAcadamy.DAL;
using SwimProAcadamy.Models;

namespace SwimProAcadamy
{
    public partial class FrmTrainingPlans : Form
    {
        private readonly TrainingPlanDAL planDal = new TrainingPlanDAL();
        private int selectedPlanId = 0;

        public FrmTrainingPlans()
        {
            InitializeComponent();
            Load += FrmTrainingPlans_Load;
            dgvTrainingPlans.CellClick += DgvTrainingPlans_CellClick;
        }

        private void FrmTrainingPlans_Load(object? sender, EventArgs e)
        {
            if (!UserSession.IsAdmin() && !UserSession.IsManager())
            {
                MessageBox.Show("You do not have permission to access this feature.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Close();
                return;
            }

            LoadPlans();
            ClearForm();
        }

        private void LoadPlans()
        {
            try
            {
                dgvTrainingPlans.DataSource = planDal.GetAllPlans();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to load training plans: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearForm()
        {
            selectedPlanId = 0;
            txtPlanName.Clear();
            nudMonthlyFee.Value = 0;
            nudSessionsPerWeek.Value = 1;
            chkCompetitionAllowed.Checked = false;
            chkPlanActive.Checked = true;
            dgvTrainingPlans.ClearSelection();
        }

        private bool ValidateInputs()
        {
            if (string.IsNullOrWhiteSpace(txtPlanName.Text))
            {
                MessageBox.Show("Please enter Plan Name.", "Validation Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (nudMonthlyFee.Value < 0)
            {
                MessageBox.Show("Weekly fee cannot be negative.", "Validation Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (nudSessionsPerWeek.Value < 1)
            {
                MessageBox.Show("Sessions per week must be at least 1.", "Validation Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void btnAddPlan_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs()) return;

            try
            {
                TrainingPlan plan = new TrainingPlan
                {
                    PlanName = txtPlanName.Text.Trim(),
                    WeeklyFee = nudMonthlyFee.Value,
                    SessionsPerWeek = (int)nudSessionsPerWeek.Value,
                    CompetitionAllowed = chkCompetitionAllowed.Checked,
                    IsActive = chkPlanActive.Checked
                };

                if (planDal.AddPlan(plan))
                {
                    AuditLogDAL.Log("ADD", "Training Plans", $"Admin added training plan '{plan.PlanName}'.");
                    MessageBox.Show("Training plan added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadPlans();
                    ClearForm();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to add training plan: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdatePlan_Click(object sender, EventArgs e)
        {
            if (selectedPlanId == 0)
            {
                MessageBox.Show("Please select a training plan to update.", "Validation Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!ValidateInputs()) return;

            try
            {
                TrainingPlan plan = new TrainingPlan
                {
                    TrainingPlanId = selectedPlanId,
                    PlanName = txtPlanName.Text.Trim(),
                    WeeklyFee = nudMonthlyFee.Value,
                    SessionsPerWeek = (int)nudSessionsPerWeek.Value,
                    CompetitionAllowed = chkCompetitionAllowed.Checked,
                    IsActive = chkPlanActive.Checked
                };

                if (planDal.UpdatePlan(plan))
                {
                    AuditLogDAL.Log("UPDATE", "Training Plans", $"Admin updated training plan ID {selectedPlanId} ('{plan.PlanName}').");
                    MessageBox.Show("Training plan updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadPlans();
                    ClearForm();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to update training plan: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDeletePlan_Click(object sender, EventArgs e)
        {
            if (selectedPlanId == 0)
            {
                MessageBox.Show("Please select a training plan to delete.", "Validation Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("Are you sure you want to delete the selected training plan?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes)
            {
                return;
            }

            try
            {
                if (planDal.DeletePlan(selectedPlanId))
                {
                    AuditLogDAL.Log("DELETE", "Training Plans", $"Admin deleted training plan ID {selectedPlanId}.");
                    MessageBox.Show("Training plan deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadPlans();
                    ClearForm();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to delete training plan: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClearPlan_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void DgvTrainingPlans_CellClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow row = dgvTrainingPlans.Rows[e.RowIndex];
            selectedPlanId = Convert.ToInt32(row.Cells["ID"].Value);
            txtPlanName.Text = Convert.ToString(row.Cells["Plan Name"].Value) ?? "";
            nudMonthlyFee.Value = Convert.ToDecimal(row.Cells["Weekly Fee"].Value);
            nudSessionsPerWeek.Value = Convert.ToDecimal(row.Cells["Sessions Per Week"].Value);
            chkCompetitionAllowed.Checked = (Convert.ToString(row.Cells["Competition Allowed"].Value) == "Yes");
            chkPlanActive.Checked = (Convert.ToString(row.Cells["Status"].Value) == "Active");
        }

        private void txtPlanName_TextChanged(object sender, EventArgs e)
        {
        }

        private void dgvTrainingPlans_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
    }
}
