namespace SwimProAcadamy
{
    partial class FrmRegister
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRegister));
            picBackground = new PictureBox();
            registerCard = new Panel();
            lblTitle = new Label(); lblSubtitle = new Label();
            lblFullName = new Label(); txtFullName = new TextBox();
            lblUsername = new Label(); txtUsername = new TextBox();
            lblEmail = new Label(); txtEmail = new TextBox();
            lblPassword = new Label(); txtPassword = new TextBox();
            lblConfirmPassword = new Label(); txtConfirmPassword = new TextBox();
            btnRegister = new Button(); btnClear = new Button(); btnBackToLogin = new Button();
            ((System.ComponentModel.ISupportInitialize)picBackground).BeginInit();
            registerCard.SuspendLayout();
            SuspendLayout();
            picBackground.Dock = DockStyle.Fill;
            picBackground.Image = (Image)resources.GetObject("picBackground.Image");
            picBackground.Location = new Point(0, 0);
            picBackground.Name = "picBackground";
            picBackground.Size = new Size(900, 720);
            picBackground.SizeMode = PictureBoxSizeMode.StretchImage;
            picBackground.TabStop = false;
            registerCard.Anchor = AnchorStyles.None;
            registerCard.BackColor = Color.White;
            registerCard.Controls.AddRange(new Control[] { btnBackToLogin, btnClear, btnRegister, txtConfirmPassword, lblConfirmPassword, txtPassword, lblPassword, txtEmail, lblEmail, txtUsername, lblUsername, txtFullName, lblFullName, lblSubtitle, lblTitle });
            registerCard.Location = new Point(240, 35);
            registerCard.Name = "registerCard";
            registerCard.Size = new Size(420, 630);
            lblTitle.AutoSize = true; lblTitle.Font = new Font("Segoe UI", 20F, FontStyle.Bold); lblTitle.ForeColor = Color.MidnightBlue; lblTitle.Location = new Point(80, 25); lblTitle.Text = "Create Account";
            lblSubtitle.AutoSize = true; lblSubtitle.Font = new Font("Segoe UI", 9F); lblSubtitle.ForeColor = Color.DimGray; lblSubtitle.Location = new Point(78, 75); lblSubtitle.Text = "Register for SwimPro Academy";
            lblFullName.AutoSize = true; lblFullName.Location = new Point(35, 120); lblFullName.Text = "Full Name";
            txtFullName.Location = new Point(35, 145); txtFullName.PlaceholderText = "Enter your full name"; txtFullName.Size = new Size(350, 30);
            lblUsername.AutoSize = true; lblUsername.Location = new Point(35, 185); lblUsername.Text = "Username";
            txtUsername.Location = new Point(35, 210); txtUsername.PlaceholderText = "Choose a username"; txtUsername.Size = new Size(350, 30);
            lblEmail.AutoSize = true; lblEmail.Location = new Point(35, 250); lblEmail.Text = "Email";
            txtEmail.Location = new Point(35, 275); txtEmail.PlaceholderText = "Enter your email address"; txtEmail.Size = new Size(350, 30);
            lblPassword.AutoSize = true; lblPassword.Location = new Point(35, 315); lblPassword.Text = "Password";
            txtPassword.Location = new Point(35, 340); txtPassword.PlaceholderText = "Create a password"; txtPassword.Size = new Size(350, 30); txtPassword.UseSystemPasswordChar = true;
            lblConfirmPassword.AutoSize = true; lblConfirmPassword.Location = new Point(35, 380); lblConfirmPassword.Text = "Confirm Password";
            txtConfirmPassword.Location = new Point(35, 405); txtConfirmPassword.PlaceholderText = "Re-enter your password"; txtConfirmPassword.Size = new Size(350, 30); txtConfirmPassword.UseSystemPasswordChar = true;
            btnRegister.BackColor = Color.MidnightBlue; btnRegister.Cursor = Cursors.Hand; btnRegister.FlatStyle = FlatStyle.Flat; btnRegister.Font = new Font("Segoe UI", 10F, FontStyle.Bold); btnRegister.ForeColor = Color.White; btnRegister.Location = new Point(35, 465); btnRegister.Size = new Size(350, 42); btnRegister.Text = "REGISTER"; btnRegister.UseVisualStyleBackColor = false;
            btnClear.Cursor = Cursors.Hand; btnClear.FlatStyle = FlatStyle.Flat; btnClear.ForeColor = Color.MidnightBlue; btnClear.Location = new Point(35, 520); btnClear.Size = new Size(170, 38); btnClear.Text = "CLEAR";
            btnBackToLogin.Cursor = Cursors.Hand; btnBackToLogin.FlatStyle = FlatStyle.Flat; btnBackToLogin.ForeColor = Color.MidnightBlue; btnBackToLogin.Location = new Point(215, 520); btnBackToLogin.Size = new Size(170, 38); btnBackToLogin.Text = "BACK TO LOGIN";
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(900, 720);
            Controls.Add(registerCard);
            Controls.Add(picBackground);
            Font = new Font("Segoe UI", 10F);
            MinimumSize = new Size(900, 700);
            Name = "FrmRegister";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SwimPro Academy - Register";
            ((System.ComponentModel.ISupportInitialize)picBackground).EndInit();
            registerCard.ResumeLayout(false);
            registerCard.PerformLayout();
            ResumeLayout(false);
        }

        private PictureBox picBackground;
        private Panel registerCard;
        private Label lblTitle, lblSubtitle, lblFullName, lblUsername, lblEmail, lblPassword, lblConfirmPassword;
        private TextBox txtFullName, txtUsername, txtEmail, txtPassword, txtConfirmPassword;
        private Button btnRegister, btnClear, btnBackToLogin;
    }
}
