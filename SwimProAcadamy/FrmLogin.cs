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
            picBackground.SendToBack();
            btnLogin.Click += btnLogin_Click;
            btnRegister.Click += btnRegister_Click;
            btnClear.Click += btnClear_Click;
            chkShowPassword.CheckedChanged += chkShowPassword_CheckedChanged;
            AcceptButton = btnLogin;
        }

        private void btnRegister_Click(object? sender, EventArgs e)
        {
            Hide();
            using FrmRegister registerForm = new FrmRegister();
            registerForm.ShowDialog();
            Show();
            ClearFields();
        }

        private void btnLogin_Click(object? sender, EventArgs e)
        {
            string usernameOrEmail = txtUsername.Text.Trim();
            string password = txtPassword.Text;

            if (string.IsNullOrWhiteSpace(usernameOrEmail) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please enter your username/email and password.", "Missing Details",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using MySqlConnection connection = DatabaseConnection.GetConnection();
                connection.Open();

                const string sql = @"SELECT FullName FROM Users
                                     WHERE (Username = @login OR Email = @login)
                                     AND Password = @password";
                using MySqlCommand command = new MySqlCommand(sql, connection);
                command.Parameters.AddWithValue("@login", usernameOrEmail);
                command.Parameters.AddWithValue("@password", PasswordHelper.HashPassword(password));

                object? result = command.ExecuteScalar();
                if (result == null)
                {
                    MessageBox.Show("Incorrect username/email or password.", "Login Failed",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPassword.Clear();
                    txtPassword.Focus();
                    return;
                }

                Hide();
                using FrmDashboard dashboard = new FrmDashboard(result.ToString()!);
                dashboard.ShowDialog();
                Show();
                ClearFields();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"The database operation could not be completed.\n\nMySQL message: {ex.Message}",
                    "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void chkShowPassword_CheckedChanged(object? sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = !chkShowPassword.Checked;
        }

        private void btnClear_Click(object? sender, EventArgs e)
        {
            ClearFields();
        }

        // Keeps the form designer working if it still has the older Clear button event name.
        private void btnClear_Click_1(object? sender, EventArgs e)
        {
            ClearFields();
        }

        private void ClearFields()
        {
            txtUsername.Clear();
            txtPassword.Clear();
            chkShowPassword.Checked = false;
            txtUsername.Focus();
        }
    }
}
