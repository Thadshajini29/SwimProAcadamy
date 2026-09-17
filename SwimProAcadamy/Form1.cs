namespace SwimProAcadamy
{
    public partial class frmlogin : Form
    {
        public frmlogin()
        {
            InitializeComponent();
            AcceptButton = btnLogin;
        }

        private void lblcontinue_Click(object sender, EventArgs e)
        {

        }

        private void txtusername_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            lblError.Visible = false;

            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                ShowError("Please enter your email address or username.");
                txtUsername.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                ShowError("Please enter your password.");
                txtPassword.Focus();
                return;
            }

            // This is only a basic input check. Keep the actual account check here
            // when authentication or database code is added to the application.
            if (txtUsername.Text.Trim().Length < 3 || txtPassword.Text.Length < 4)
            {
                ShowError("The login details you entered are invalid.");
                return;
            }

            MessageBox.Show("Login details accepted.", "Login",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void frmlogin_Load(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true;
        }

        private void picShowPassword_Click(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = !txtPassword.UseSystemPasswordChar;
            picShowPassword.AccessibleName = txtPassword.UseSystemPasswordChar
                ? "Show password"
                : "Hide password";
        }

        private void ShowError(string message)
        {
            lblError.Text = message;
            lblError.Visible = true;
        }
    }
}
