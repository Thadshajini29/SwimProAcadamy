using System;
using System.Windows.Forms;
using SwimProAcadamy.DAL;
using SwimProAcadamy.Models;

namespace SwimProAcadamy
{
    public partial class FrmRegister : Form
    {
        private readonly bool bootstrapMode;

        // Bootstrap mode is used only when no account exists. All normal user
        // creation is restricted to an authenticated Administrator.
        public FrmRegister(bool bootstrapMode = false)
        {
            this.bootstrapMode = bootstrapMode;
            InitializeComponent();
            btnRegister.Click += btnRegister_Click; lnkBackLogin.LinkClicked += (s, e) => Close();
            txtRegPassword.UseSystemPasswordChar = txtConfirmPassword.UseSystemPasswordChar = true;
            Load += FrmRegister_Load;
        }

        private void FrmRegister_Load(object? sender, EventArgs e)
        {
            try
            {
                UserDAL userDal = new UserDAL();
                if (bootstrapMode)
                {
                    if (userDal.HasAnyUsers())
                    {
                        MessageBox.Show("The initial Administrator has already been created. New accounts must be created by an Administrator.", "Registration", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Close();
                        return;
                    }

                    cmbRole.Visible = lblRole.Visible = chkActive.Visible = false;
                    lblRegisterTitle.Text = "Create First Administrator";
                    btnRegister.Text = "Create Administrator";
                    return;
                }

                if (!UserSession.IsAdmin())
                {
                    MessageBox.Show("Only an Administrator can create user accounts.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Close();
                    return;
                }

                cmbRole.DataSource = userDal.GetRoles();
                cmbRole.DisplayMember = "role_name";
                cmbRole.ValueMember = "role_name";
                cmbRole.SelectedIndex = -1;
                lblRegisterTitle.Text = "Create User Account";
                lnkBackLogin.Text = "Close";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to prepare registration: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }
        }

        private void btnRegister_Click(object? sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFullName.Text) || string.IsNullOrWhiteSpace(txtRegUsername.Text) || string.IsNullOrWhiteSpace(txtEmail.Text) || string.IsNullOrWhiteSpace(txtRegPassword.Text))
            {
                MessageBox.Show("Please complete every field.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txtRegPassword.Text != txtConfirmPassword.Text)
            {
                MessageBox.Show("Passwords do not match.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!txtEmail.Text.Contains('@') || !txtEmail.Text.Contains('.'))
            {
                MessageBox.Show("Please enter a valid email address.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txtRegPassword.Text.Length < 8)
            {
                MessageBox.Show("Password must contain at least 8 characters.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!bootstrapMode && cmbRole.SelectedIndex < 0)
            {
                MessageBox.Show("Please select a role for the new account.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string username = txtRegUsername.Text.Trim();
                string email = txtEmail.Text.Trim();
                UserDAL userDal = new UserDAL();

                if (userDal.UsernameOrEmailExists(username, email))
                {
                    MessageBox.Show("This username or email address already exists.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                User newUser = new User
                {
                    FullName = txtFullName.Text.Trim(),
                    Username = username,
                    Email = email,
                    IsActive = bootstrapMode || chkActive.Checked
                };

                string message;
                if (bootstrapMode)
                {
                    bool isFirstAccount = userDal.RegisterPublicAccount(newUser, txtRegPassword.Text);
                    message = isFirstAccount
                        ? "The first account has been created as the system Administrator. You can now log in."
                        : "An Administrator already exists. New accounts must be created by an Administrator.";
                }
                else
                {
                    userDal.AddUser(newUser, txtRegPassword.Text, cmbRole.SelectedValue?.ToString() ?? string.Empty);
                    AuditLogDAL.Log("ADD", "User Management", $"Admin created user '{username}' with role '{cmbRole.Text}'.");
                    message = "User account created successfully.";
                }
                MessageBox.Show(message, "Registration", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            catch (Exception ex) { MessageBox.Show("Registration failed. " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void pnlRegister_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cmbRole_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void chkActive_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
