using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SwimProAcadamy
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
            btnLogin.Click += btnLogin_Click;
            lnkRegister.LinkClicked += (s, e) => { Hide(); new FrmRegister().ShowDialog(); Show(); };
            txtPassword.UseSystemPasswordChar = true;
        }

        private void btnLogin_Click(object? sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsername.Text) || string.IsNullOrWhiteSpace(txtPassword.Text)) { MessageBox.Show("Enter your username and password.", "Login", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
            try
            {
                using MySqlConnection connection = new Database().GetConnection(); connection.Open();
                using MySqlCommand command = new("SELECT COUNT(*) FROM users WHERE username=@username AND password=@password", connection);
                command.Parameters.AddWithValue("@username", txtUsername.Text.Trim()); command.Parameters.AddWithValue("@password", PasswordHelper.HashPassword(txtPassword.Text));
                if (Convert.ToInt32(command.ExecuteScalar()) == 1) { Hide(); new FrmDashboard().ShowDialog(); Show(); txtPassword.Clear(); }
                else MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex) { MessageBox.Show("Login could not connect to the database. " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chkShowPassword.Checked)
            {
                txtPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
            }
        }
    }
}
