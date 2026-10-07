using System;
using System.Windows.Forms;
using SwimProAcadamy.Models;

namespace SwimProAcadamy
{
    public partial class FrmRegister : Form
    {
        public FrmRegister()
        {
            InitializeComponent();
            btnRegister.Click += btnRegister_Click; lnkBackLogin.LinkClicked += (s, e) => Close();
            txtRegPassword.UseSystemPasswordChar = txtConfirmPassword.UseSystemPasswordChar = true;
        }

        private void btnRegister_Click(object? sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFullName.Text) || string.IsNullOrWhiteSpace(txtRegUsername.Text) || string.IsNullOrWhiteSpace(txtEmail.Text) || string.IsNullOrWhiteSpace(txtRegPassword.Text)) { MessageBox.Show("Please complete every field.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
            if (txtRegPassword.Text != txtConfirmPassword.Text) { MessageBox.Show("Passwords do not match.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
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

                userDal.RegisterPending(new User
                {
                    FullName = txtFullName.Text.Trim(),
                    Username = username,
                    Email = email,
                    IsActive = true
                }, txtRegPassword.Text);

                MessageBox.Show("Account created successfully. You can log in with your username and password; an Administrator will assign your system role.", "Registration", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            catch (Exception ex) { MessageBox.Show("Registration failed. " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void pnlRegister_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
