using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

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
            try { using MySqlConnection c = new Database().GetConnection(); c.Open(); using MySqlCommand check = new("SELECT COUNT(*) FROM users WHERE username=@username", c); check.Parameters.AddWithValue("@username", txtRegUsername.Text.Trim()); if (Convert.ToInt32(check.ExecuteScalar()) > 0) { MessageBox.Show("This username already exists.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; } using MySqlCommand add = new("INSERT INTO users(full_name,username,email,password) VALUES(@name,@username,@email,@password)", c); add.Parameters.AddWithValue("@name", txtFullName.Text.Trim()); add.Parameters.AddWithValue("@username", txtRegUsername.Text.Trim()); add.Parameters.AddWithValue("@email", txtEmail.Text.Trim()); add.Parameters.AddWithValue("@password", PasswordHelper.HashPassword(txtRegPassword.Text)); add.ExecuteNonQuery(); MessageBox.Show("Account created successfully.", "Registration", MessageBoxButtons.OK, MessageBoxIcon.Information); Close(); }
            catch (Exception ex) { MessageBox.Show("Registration failed. " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void pnlRegister_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
