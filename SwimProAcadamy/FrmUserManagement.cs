using System;
using System.Data;
using System.Windows.Forms;
using SwimProAcadamy.DAL;
using SwimProAcadamy.Models;

namespace SwimProAcadamy
{
    public partial class FrmUserManagement : Form
    {
        private readonly UserDAL userDal = new UserDAL();
        private int selectedUserId = 0;

        public FrmUserManagement()
        {
            InitializeComponent();
            Load += FrmUserManagement_Load;
            dgvUsers.CellClick += DgvUsers_CellClick;
        }

        private void FrmUserManagement_Load(object? sender, EventArgs e)
        {
            if (!UserSession.IsAdmin())
            {
                MessageBox.Show("You do not have permission to access this feature.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Close();
                return;
            }

            LoadRoles();

            LoadUsers();
            ClearForm();
        }

        private void LoadUsers()
        {
            try
            {
                dgvUsers.DataSource = userDal.GetAllUsers();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to load user records: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadRoles()
        {
            try
            {
                cmbUserRole.DataSource = userDal.GetRoles();
                cmbUserRole.DisplayMember = "role_name";
                cmbUserRole.ValueMember = "role_name";
                cmbUserRole.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to load available roles: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearForm()
        {
            selectedUserId = 0;
            txtUserFullName.Clear();
            txtUserName.Clear();
            txtUserEmail.Clear();
            txtUserPassword.Clear();
            txtUserPassword.Enabled = true;
            cmbUserRole.SelectedIndex = -1;
            chkUserActive.Checked = true;
            dgvUsers.ClearSelection();
        }

        private bool ValidateInputs(bool isNewUser = true)
        {
            if (string.IsNullOrWhiteSpace(txtUserFullName.Text) ||
                string.IsNullOrWhiteSpace(txtUserName.Text) ||
                string.IsNullOrWhiteSpace(txtUserEmail.Text) ||
                cmbUserRole.SelectedIndex < 0)
            {
                MessageBox.Show("Please fill in Full Name, Username, Email, and select a Role.", "Validation Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (isNewUser && string.IsNullOrWhiteSpace(txtUserPassword.Text))
            {
                MessageBox.Show("Password is required for new users.", "Validation Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!txtUserEmail.Text.Contains("@") || !txtUserEmail.Text.Contains("."))
            {
                MessageBox.Show("Please enter a valid email address.", "Validation Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs(isNewUser: true)) return;

            string fullName = txtUserFullName.Text.Trim();
            string username = txtUserName.Text.Trim();
            string email = txtUserEmail.Text.Trim();
            string password = txtUserPassword.Text;
            string role = cmbUserRole.Text;

            try
            {
                if (userDal.UsernameOrEmailExists(username, email))
                {
                    MessageBox.Show("Username or Email already exists. Please enter unique details.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                User newUser = new User
                {
                    FullName = fullName,
                    Username = username,
                    Email = email,
                    IsActive = chkUserActive.Checked
                };

                userDal.AddUser(newUser, password, role);
                AuditLogDAL.Log("ADD", "User Management", $"Admin created new user '{username}' with role '{role}'.");

                MessageBox.Show("User added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadUsers();
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to add user: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdateUser_Click(object sender, EventArgs e)
        {
            if (selectedUserId == 0)
            {
                MessageBox.Show("Please select a user to update.", "Validation Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!ValidateInputs(isNewUser: false)) return;

            string fullName = txtUserFullName.Text.Trim();
            string username = txtUserName.Text.Trim();
            string email = txtUserEmail.Text.Trim();
            string role = cmbUserRole.Text;

            try
            {
                if (userDal.UsernameOrEmailExists(username, email, selectedUserId))
                {
                    MessageBox.Show("Another user already exists with this username or email.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                User userToUpdate = new User
                {
                    UserId = selectedUserId,
                    FullName = fullName,
                    Username = username,
                    Email = email,
                    IsActive = chkUserActive.Checked
                };

                userDal.UpdateUser(userToUpdate, role);
                AuditLogDAL.Log("UPDATE", "User Management", $"Admin updated user ID {selectedUserId} ('{username}').");

                MessageBox.Show("User updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadUsers();
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to update user: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            if (selectedUserId == 0)
            {
                MessageBox.Show("Please select a user to delete.", "Validation Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (selectedUserId == UserSession.UserId)
            {
                MessageBox.Show("You cannot delete your own currently logged-in account.", "Action Prohibited", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("Are you sure you want to delete the selected user?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes)
            {
                return;
            }

            try
            {
                userDal.DeleteUser(selectedUserId);
                AuditLogDAL.Log("DELETE", "User Management", $"Admin deleted user ID {selectedUserId}.");

                MessageBox.Show("User deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadUsers();
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to delete user: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnResetPassword_Click(object sender, EventArgs e)
        {
            if (selectedUserId == 0)
            {
                MessageBox.Show("Please select a user to reset password.", "Validation Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string newPassword = txtUserPassword.Text.Trim();
            if (string.IsNullOrWhiteSpace(newPassword))
            {
                newPassword = "Password123";
            }

            try
            {
                userDal.ChangePassword(selectedUserId, newPassword);
                AuditLogDAL.Log("UPDATE", "User Management", $"Admin reset password for user ID {selectedUserId}.");

                MessageBox.Show($"Password for the user has been reset to: {newPassword}", "Password Reset Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to reset password: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClearUser_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void DgvUsers_CellClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow row = dgvUsers.Rows[e.RowIndex];
            selectedUserId = Convert.ToInt32(row.Cells["ID"].Value);
            txtUserFullName.Text = Convert.ToString(row.Cells["Full Name"].Value) ?? "";
            txtUserName.Text = Convert.ToString(row.Cells["Username"].Value) ?? "";
            txtUserEmail.Text = Convert.ToString(row.Cells["Email"].Value) ?? "";
            cmbUserRole.Text = Convert.ToString(row.Cells["Role"].Value) ?? "";
            chkUserActive.Checked = (Convert.ToString(row.Cells["Status"].Value) == "Active");

            txtUserPassword.Clear();
            txtUserPassword.PlaceholderText = "Leave empty to keep current, or type new to reset";
        }

        private void dgvUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
    }
}
