using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SwimProAcadamy
{
    public partial class FrmSwimmer : Form
    {
        private int selectedId;
        public FrmSwimmer()
        {
            InitializeComponent();
            Load += FrmSwimmer_Load;
            btnAdd.Click += btnAdd_Click; 
            btnUpdate.Click += btnUpdate_Click;
            btnDelete.Click += btnDelete_Click; 
            btnClear.Click += (s, e) => ClearInputs();
            dgvSwimmers.CellClick += dgvSwimmers_CellClick;
        }
        private void FrmSwimmer_Load(object? sender, EventArgs e)
        {
            // Clear any design-time sample entries, then add the correct choices once.
            cmbTrainingPlan.Items.Clear();
            cmbCompetitionCategory.Items.Clear();
            cmbTrainingPlan.Items.AddRange(new[] { "Beginner", "Intermediate", "Advanced" });
            cmbCompetitionCategory.Items.AddRange(new[] { "Junior", "Youth", "Adult", "Senior" });

            dgvSwimmers.AutoGenerateColumns = false;
            colID.DataPropertyName = "id";
            colName.DataPropertyName = "name";
            colAge.DataPropertyName = "age";
            colTrainingPlan.DataPropertyName = "training_plan";
            colCompetitionCategory.DataPropertyName = "competition_category";
            colCompetitions.DataPropertyName = "competitions";
            colCoachingHours.DataPropertyName = "coaching_hours";
            LoadSwimmers();
            ClearInputs();
        }
        private bool InputsAreValid()
        {
            if (string.IsNullOrWhiteSpace(txtName.Text) 
                || cmbTrainingPlan.SelectedIndex < 0 || cmbCompetitionCategory.SelectedIndex < 0)
            { 
                MessageBox.Show("Enter name, training plan and competition category.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning); 
                return false;
            }
            if 
                (nudAge.Value < 1)
            { MessageBox.Show("Age must be greater than zero.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning); 
                return false;
            }
            if 
                (nudCoachingHours.Value > 24) 
            { MessageBox.Show("Private coaching cannot exceed 24 hours per month.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning); 
                return false; 
            }
            if 
                (nudCompetitions.Value > 0 && !SwimProRules.IsCompetitionAllowed(cmbTrainingPlan.Text)) 
            { MessageBox.Show("Beginner swimmers cannot enter competitions.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning); 
                return false; 
            }
            return true;
        }
        private MySqlCommand CreateCommand
            (string sql, MySqlConnection c) 
        { MySqlCommand cmd = new(sql, c); 
            cmd.Parameters.AddWithValue("@name", txtName.Text.Trim()); 
            cmd.Parameters.AddWithValue("@age", (int)nudAge.Value);
            cmd.Parameters.AddWithValue("@plan", cmbTrainingPlan.Text);
            cmd.Parameters.AddWithValue("@category", cmbCompetitionCategory.Text); 
            cmd.Parameters.AddWithValue("@competitions", (int)nudCompetitions.Value); 
            cmd.Parameters.AddWithValue("@hours", nudCoachingHours.Value); 
            return cmd; 
        }
        private void btnAdd_Click(object? sender, EventArgs e) 
        { 
            if (!InputsAreValid())
                return; 
            try 
            { 
                using MySqlConnection c = new Database().GetConnection(); 
                c.Open();
                using MySqlCommand cmd = CreateCommand("INSERT INTO swimmers(name,age,training_plan,competition_category,competitions,coaching_hours) VALUES(@name,@age,@plan,@category,@competitions,@hours)", c); if (cmd.ExecuteNonQuery() == 1) { LoadSwimmers(); ClearInputs(); MessageBox.Show("Swimmer added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                } 
                else 
                    MessageBox.Show("No swimmer was added.", "Add Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch 
            (Exception ex) 
            {
                MessageBox.Show("Unable to add swimmer. " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnUpdate_Click(object? sender, EventArgs e) { if (selectedId == 0) { MessageBox.Show("Select a swimmer row before clicking Update.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; } if (!InputsAreValid()) return; try { using MySqlConnection c = new Database().GetConnection(); c.Open(); using MySqlCommand cmd = CreateCommand("UPDATE swimmers SET name=@name,age=@age,training_plan=@plan,competition_category=@category,competitions=@competitions,coaching_hours=@hours WHERE id=@id", c); cmd.Parameters.AddWithValue("@id", selectedId); if (cmd.ExecuteNonQuery() == 1) { LoadSwimmers(); ClearInputs(); MessageBox.Show("Swimmer updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information); } else MessageBox.Show("The selected swimmer was not found.", "Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning); } catch (Exception ex) { MessageBox.Show("Unable to update swimmer. " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error); } }
        private void btnDelete_Click(object? sender, EventArgs e) { if (selectedId == 0) { MessageBox.Show("Select a swimmer row before clicking Delete.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; } if (MessageBox.Show("Delete the selected swimmer?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes) return; try { using MySqlConnection c = new Database().GetConnection(); c.Open(); using MySqlCommand cmd = new("DELETE FROM swimmers WHERE id=@id", c); cmd.Parameters.AddWithValue("@id", selectedId); if (cmd.ExecuteNonQuery() == 1) { LoadSwimmers(); ClearInputs(); MessageBox.Show("Swimmer deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information); } else MessageBox.Show("The selected swimmer was not found.", "Delete Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning); } catch (MySqlException ex) when (ex.Number == 1451) { MessageBox.Show("This swimmer has saved fee records and cannot be deleted. Delete their fee records first.", "Delete Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Warning); } catch (Exception ex) { MessageBox.Show("Unable to delete swimmer. " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error); } }
        private void LoadSwimmers() { try { using MySqlConnection c = new Database().GetConnection(); using MySqlDataAdapter a = new("SELECT id,name,age,training_plan,competition_category,competitions,coaching_hours FROM swimmers ORDER BY id DESC", c); DataTable t = new(); a.Fill(t); dgvSwimmers.DataSource = t; } catch (Exception ex) { MessageBox.Show("Unable to load swimmers. " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error); } }
        private void dgvSwimmers_CellClick(object? sender, DataGridViewCellEventArgs e) { if (e.RowIndex < 0) return; DataGridViewRow r = dgvSwimmers.Rows[e.RowIndex]; selectedId = Convert.ToInt32(r.Cells["colID"].Value); txtName.Text = Convert.ToString(r.Cells["colName"].Value) ?? ""; nudAge.Value = Convert.ToDecimal(r.Cells["colAge"].Value); cmbTrainingPlan.Text = Convert.ToString(r.Cells["colTrainingPlan"].Value) ?? ""; cmbCompetitionCategory.Text = Convert.ToString(r.Cells["colCompetitionCategory"].Value) ?? ""; nudCompetitions.Value = Convert.ToDecimal(r.Cells["colCompetitions"].Value); nudCoachingHours.Value = Convert.ToDecimal(r.Cells["colCoachingHours"].Value); }
        private void ClearInputs() { selectedId = 0; txtName.Clear(); nudAge.Value = nudAge.Minimum; nudCompetitions.Value = nudCompetitions.Minimum; nudCoachingHours.Value = nudCoachingHours.Minimum; cmbTrainingPlan.SelectedIndex = cmbCompetitionCategory.SelectedIndex = -1; dgvSwimmers.ClearSelection(); }

        private void pnlSwimmerInput_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
