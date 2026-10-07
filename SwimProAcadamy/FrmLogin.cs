using System;
using System.Windows.Forms;
using SwimProAcadamy.DAL;
using SwimProAcadamy.Models;

namespace SwimProAcadamy
{
    public partial class FrmLogin : Form
    {
        private readonly UserDAL userDal = new UserDAL();

        public FrmLogin()
        {
            InitializeComponent();
            btnLogin.Click += BtnLogin_Click;
            lnkRegister.LinkClicked += LnkRegister_LinkClicked;
            chkShowPassword.CheckedChanged += chkShowPassword_CheckedChanged;
            txtPassword.UseSystemPasswordChar = true;
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            txtUsername.Focus();
        }

        private void BtnLogin_Click(object? sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please enter both username/email and password.", "Login Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                User? user = userDal.Login(username, password);

                if (user != null)
                {
                    UserSession.UserId = user.UserId;
                    UserSession.Username = user.Username;
                    UserSession.FullName = user.FullName;
                    UserSession.RoleName = user.RoleName;
                    UserSession.Permissions.Clear();
                    foreach (System.Data.DataRow row in userDal.GetPermissions(user.UserId).Rows)
                        UserSession.Permissions.Add(row["permission_name"].ToString() ?? string.Empty);

                    AuditLogDAL.Log("LOGIN", "Authentication", $"{user.RoleName} | User '{user.Username}' logged in successfully.");

                    txtPassword.Clear();
                    Hide();
                    using (FrmDashboard dashboard = new FrmDashboard())
                    {
                        dashboard.ShowDialog();
                    }
                    Show();
                }
                else
                {
                    MessageBox.Show("Invalid username/email or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database connection error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LnkRegister_LinkClicked(object? sender, LinkLabelLinkClickedEventArgs e)
        {
            Hide();
            using (FrmRegister registerForm = new FrmRegister())
            {
                registerForm.ShowDialog();
            }
            Show();
        }

        private void chkShowPassword_CheckedChanged(object? sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = !chkShowPassword.Checked;
        }
    }
}
