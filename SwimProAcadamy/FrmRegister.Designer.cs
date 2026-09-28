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
            btnBackToLogin = new Button();
            btnClear = new Button();
            btnRegister = new Button();
            txtConfirmPassword = new TextBox();
            lblConfirmPassword = new Label();
            txtPassword = new TextBox();
            lblPassword = new Label();
            txtEmail = new TextBox();
            lblEmail = new Label();
            txtUsername = new TextBox();
            lblUsername = new Label();
            txtFullName = new TextBox();
            lblFullName = new Label();
            lblSubtitle = new Label();
            lblTitle = new Label();
            ((System.ComponentModel.ISupportInitialize)picBackground).BeginInit();
            registerCard.SuspendLayout();
            SuspendLayout();
            // 
            // picBackground
            // 
            picBackground.Dock = DockStyle.Fill;
            picBackground.Image = (Image)resources.GetObject("picBackground.Image");
            picBackground.Location = new Point(0, 0);
            picBackground.Name = "picBackground";
            picBackground.Size = new Size(900, 720);
            picBackground.SizeMode = PictureBoxSizeMode.StretchImage;
            picBackground.TabIndex = 1;
            picBackground.TabStop = false;
            // 
            // registerCard
            // 
            registerCard.Anchor = AnchorStyles.None;
            registerCard.BackColor = Color.White;
            registerCard.Controls.Add(btnBackToLogin);
            registerCard.Controls.Add(btnClear);
            registerCard.Controls.Add(btnRegister);
            registerCard.Controls.Add(txtConfirmPassword);
            registerCard.Controls.Add(lblConfirmPassword);
            registerCard.Controls.Add(txtPassword);
            registerCard.Controls.Add(lblPassword);
            registerCard.Controls.Add(txtEmail);
            registerCard.Controls.Add(lblEmail);
            registerCard.Controls.Add(txtUsername);
            registerCard.Controls.Add(lblUsername);
            registerCard.Controls.Add(txtFullName);
            registerCard.Controls.Add(lblFullName);
            registerCard.Controls.Add(lblSubtitle);
            registerCard.Controls.Add(lblTitle);
            registerCard.Location = new Point(268, 12);
            registerCard.Name = "registerCard";
            registerCard.Size = new Size(420, 630);
            registerCard.TabIndex = 0;
            // 
            // btnBackToLogin
            // 
            btnBackToLogin.Cursor = Cursors.Hand;
            btnBackToLogin.FlatStyle = FlatStyle.Flat;
            btnBackToLogin.ForeColor = Color.MidnightBlue;
            btnBackToLogin.Location = new Point(215, 520);
            btnBackToLogin.Name = "btnBackToLogin";
            btnBackToLogin.Size = new Size(170, 38);
            btnBackToLogin.TabIndex = 0;
            btnBackToLogin.Text = "BACK TO LOGIN";
            // 
            // btnClear
            // 
            btnClear.Cursor = Cursors.Hand;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.ForeColor = Color.MidnightBlue;
            btnClear.Location = new Point(35, 520);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(170, 38);
            btnClear.TabIndex = 1;
            btnClear.Text = "CLEAR";
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.MidnightBlue;
            btnRegister.Cursor = Cursors.Hand;
            btnRegister.FlatStyle = FlatStyle.Flat;
            btnRegister.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnRegister.ForeColor = Color.White;
            btnRegister.Location = new Point(35, 465);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(350, 42);
            btnRegister.TabIndex = 2;
            btnRegister.Text = "REGISTER";
            btnRegister.UseVisualStyleBackColor = false;
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Location = new Point(35, 405);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.PlaceholderText = "Re-enter your password";
            txtConfirmPassword.Size = new Size(350, 34);
            txtConfirmPassword.TabIndex = 3;
            txtConfirmPassword.UseSystemPasswordChar = true;
            // 
            // lblConfirmPassword
            // 
            lblConfirmPassword.AutoSize = true;
            lblConfirmPassword.Location = new Point(35, 380);
            lblConfirmPassword.Name = "lblConfirmPassword";
            lblConfirmPassword.Size = new Size(168, 28);
            lblConfirmPassword.TabIndex = 4;
            lblConfirmPassword.Text = "Confirm Password";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(35, 340);
            txtPassword.Name = "txtPassword";
            txtPassword.PlaceholderText = "Create a password";
            txtPassword.Size = new Size(350, 34);
            txtPassword.TabIndex = 5;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(35, 315);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(93, 28);
            lblPassword.TabIndex = 6;
            lblPassword.Text = "Password";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(35, 275);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "Enter your email address";
            txtEmail.Size = new Size(350, 34);
            txtEmail.TabIndex = 7;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(35, 250);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(59, 28);
            lblEmail.TabIndex = 8;
            lblEmail.Text = "Email";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(35, 210);
            txtUsername.Name = "txtUsername";
            txtUsername.PlaceholderText = "Choose a username";
            txtUsername.Size = new Size(350, 34);
            txtUsername.TabIndex = 9;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Location = new Point(35, 185);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(99, 28);
            lblUsername.TabIndex = 10;
            lblUsername.Text = "Username";
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(35, 145);
            txtFullName.Name = "txtFullName";
            txtFullName.PlaceholderText = "Enter your full name";
            txtFullName.Size = new Size(350, 34);
            txtFullName.TabIndex = 11;
            // 
            // lblFullName
            // 
            lblFullName.AutoSize = true;
            lblFullName.Location = new Point(35, 120);
            lblFullName.Name = "lblFullName";
            lblFullName.Size = new Size(100, 28);
            lblFullName.TabIndex = 12;
            lblFullName.Text = "Full Name";
            // 
            // lblSubtitle
            // 
            lblSubtitle.AutoSize = true;
            lblSubtitle.Font = new Font("Segoe UI", 9F);
            lblSubtitle.ForeColor = Color.DimGray;
            lblSubtitle.Location = new Point(78, 75);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(257, 25);
            lblSubtitle.TabIndex = 13;
            lblSubtitle.Text = "Register for SwimPro Academy";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblTitle.ForeColor = Color.MidnightBlue;
            lblTitle.Location = new Point(80, 25);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(311, 54);
            lblTitle.TabIndex = 14;
            lblTitle.Text = "Create Account";
            // 
            // FrmRegister
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
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
