using System;
using System.Net.Mail;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SwimProAcadamy
{
    public partial class FrmRegister : Form
    {
        public FrmRegister()
        {
            InitializeComponent();
            picBackground.SendToBack();
            btnRegister.Click += btnRegister_Click;
            btnClear.Click += btnClear_Click;
            btnBackToLogin.Click += btnBackToLogin_Click;
            AcceptButton = btnRegister;
        }

        private void btnRegister_Click(object? sender, EventArgs e)
        {
            string fullName = txtFullName.Text.Trim();
            string username = txtUsername.Text.Trim();
            string email = txtEmail.Text.Trim();
            string password = txtPassword.Text;
            string confirmPassword = txtConfirmPassword.Text;

            if (string.IsNullOrWhiteSpace(fullName) || string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password) || string.IsNullOrWhiteSpace(confirmPassword))
            {
                MessageBox.Show("Please complete all fields.", "Missing Details", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!IsValidEmail(email))
            {
                MessageBox.Show("Please enter a valid email address.", "Invalid Email", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail.Focus();
                return;
            }

            if (password != confirmPassword)
            {
                MessageBox.Show("Password and Confirm Password must match.", "Password Mismatch", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtConfirmPassword.Clear();
                txtConfirmPassword.Focus();
                return;
            }

            try
            {
                using MySqlConnection connection = DatabaseConnection.GetConnection();
                connection.Open();

                const string checkSql = "SELECT COUNT(*) FROM Users WHERE Username = @username OR Email = @email";
                using MySqlCommand checkCommand = new MySqlCommand(checkSql, connection);
                checkCommand.Parameters.AddWithValue("@username", username);
                checkCommand.Parameters.AddWithValue("@email", email);
                if (Convert.ToInt32(checkCommand.ExecuteScalar()) > 0)
                {
                    MessageBox.Show("That username or email is already registered.", "Duplicate User", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                const string insertSql = @"INSERT INTO Users (FullName, Username, Email, Password)
                                           VALUES (@fullName, @username, @email, @password)";
                using MySqlCommand insertCommand = new MySqlCommand(insertSql, connection);
                insertCommand.Parameters.AddWithValue("@fullName", fullName);
                insertCommand.Parameters.AddWithValue("@username", username);
                insertCommand.Parameters.AddWithValue("@email", email);
                insertCommand.Parameters.AddWithValue("@password", PasswordHelper.HashPassword(password));
                insertCommand.ExecuteNonQuery();

                MessageBox.Show("Registration successful. You can now log in.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"The user could not be saved.\n\nMySQL message: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private static bool IsValidEmail(string email)
        {
            try
            {
                MailAddress address = new MailAddress(email);
                return address.Address == email;
            }
            catch (FormatException)
            {
                return false;
            }
        }

        private void btnClear_Click(object? sender, EventArgs e)
        {
            txtFullName.Clear();
            txtUsername.Clear();
            txtEmail.Clear();
            txtPassword.Clear();
            txtConfirmPassword.Clear();
            txtFullName.Focus();
        }

        private void btnBackToLogin_Click(object? sender, EventArgs e)
        {
            Close();
        }
    }
}
