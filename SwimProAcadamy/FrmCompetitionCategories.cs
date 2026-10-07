using System;
using System.Data;
using System.Windows.Forms;
using SwimProAcadamy.DAL;
using SwimProAcadamy.Models;

namespace SwimProAcadamy
{
    public partial class FrmCompetitionCategories : Form
    {
        private readonly CompetitionCategoryDAL categoryDal = new CompetitionCategoryDAL();
        private int selectedCategoryId;

        public FrmCompetitionCategories()
        {
            InitializeComponent();
            dgvCategories.CellClick += DgvCategories_CellClick;
        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            if (!ValidateCategory()) return;
            SaveCategory(false);
        }

        private void btnUpdateCategory_Click(object sender, EventArgs e)
        {
            if (selectedCategoryId == 0)
            {
                MessageBox.Show("Please select a category to update.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!ValidateCategory()) return;
            SaveCategory(true);
        }

        private void btnDeleteCategory_Click(object sender, EventArgs e)
        {
            if (selectedCategoryId == 0)
            {
                MessageBox.Show("Please select a category to delete.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (MessageBox.Show("Delete the selected category?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes) return;
            try
            {
                if (categoryDal.DeleteCategory(selectedCategoryId))
                {
                    AuditLogDAL.Log("DELETE", "Competition Categories", $"Deleted category ID {selectedCategoryId}.");
                    LoadCategories();
                    ClearCategory();
                }
            }
            catch (Exception ex) { MessageBox.Show("Unable to delete category: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void FrmCompetitionCategories_Load(object sender, EventArgs e)
        {
            if (!UserSession.IsAdmin() && !UserSession.IsManager())
            {
                MessageBox.Show("You do not have permission to access this feature.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Close();
                return;
            }
            LoadCategories();
            ClearCategory();
        }

        private void btnClearCategory_Click(object sender, EventArgs e)
        {
            ClearCategory();
        }

        private bool ValidateCategory()
        {
            if (string.IsNullOrWhiteSpace(txtCategoryName.Text))
            {
                MessageBox.Show("Please enter a category name.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (nudMinAge.Value > nudMaxAge.Value)
            {
                MessageBox.Show("Minimum age cannot be greater than maximum age.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void SaveCategory(bool updating)
        {
            try
            {
                CompetitionCategory category = new CompetitionCategory
                {
                    CompetitionCategoryId = selectedCategoryId,
                    CategoryName = txtCategoryName.Text.Trim(),
                    MinimumAge = (int)nudMinAge.Value,
                    MaximumAge = (int)nudMaxAge.Value,
                    IsActive = chkCategoryActive.Checked
                };
                bool saved = updating ? categoryDal.UpdateCategory(category) : categoryDal.AddCategory(category);
                if (!saved) return;
                AuditLogDAL.Log(updating ? "UPDATE" : "ADD", "Competition Categories", $"{(updating ? "Updated" : "Added")} category '{category.CategoryName}'.");
                MessageBox.Show($"Category {(updating ? "updated" : "added")} successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadCategories();
                ClearCategory();
            }
            catch (Exception ex) { MessageBox.Show("Unable to save category: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void LoadCategories()
        {
            try { dgvCategories.DataSource = categoryDal.GetAllCategories(); }
            catch (Exception ex) { MessageBox.Show("Unable to load categories: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void ClearCategory()
        {
            selectedCategoryId = 0;
            txtCategoryName.Clear();
            nudMinAge.Value = 1;
            nudMaxAge.Value = 120;
            chkCategoryActive.Checked = true;
            dgvCategories.ClearSelection();
        }

        private void DgvCategories_CellClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            DataGridViewRow row = dgvCategories.Rows[e.RowIndex];
            selectedCategoryId = Convert.ToInt32(row.Cells["ID"].Value);
            txtCategoryName.Text = Convert.ToString(row.Cells["Category Name"].Value) ?? string.Empty;
            nudMinAge.Value = Convert.ToDecimal(row.Cells["Minimum Age"].Value);
            nudMaxAge.Value = Convert.ToDecimal(row.Cells["Maximum Age"].Value);
            chkCategoryActive.Checked = string.Equals(Convert.ToString(row.Cells["Status"].Value), "Active", StringComparison.OrdinalIgnoreCase);
        }
    }
}
