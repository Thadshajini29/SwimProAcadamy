namespace SwimProAcadamy
{
    partial class FrmLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            picBackground = new PictureBox();
            loginCard = new Panel();
            btnRegister = new Button();
            btnLogin = new Button();
            chkShowPassword = new CheckBox();
            txtPassword = new TextBox();
            txtUsername = new TextBox();
            lblPassword = new Label();
            lblUsername = new Label();
            lblSubtitle = new Label();
            lblTitle = new Label();
            picLogo = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)picBackground).BeginInit();
            loginCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            SuspendLayout();
            // 
            // picBackground
            // 
            picBackground.BackgroundImage = (Image)resources.GetObject("picBackground.BackgroundImage");
            picBackground.Dock = DockStyle.Fill;
            picBackground.Location = new Point(0, 0);
            picBackground.Name = "picBackground";
            picBackground.Size = new Size(880, 633);
            picBackground.TabIndex = 0;
            picBackground.TabStop = false;
            // 
            // loginCard
            // 
            loginCard.Anchor = AnchorStyles.None;
            loginCard.Controls.Add(btnRegister);
            loginCard.Controls.Add(btnLogin);
            loginCard.Controls.Add(chkShowPassword);
            loginCard.Controls.Add(txtPassword);
            loginCard.Controls.Add(txtUsername);
            loginCard.Controls.Add(lblPassword);
            loginCard.Controls.Add(lblUsername);
            loginCard.Controls.Add(lblSubtitle);
            loginCard.Controls.Add(lblTitle);
            loginCard.Controls.Add(picLogo);
            loginCard.Location = new Point(268, 25);
            loginCard.MaximumSize = new Size(420, 520);
            loginCard.MinimumSize = new Size(420, 520);
            loginCard.Name = "loginCard";
            loginCard.Size = new Size(420, 520);
            loginCard.TabIndex = 1;
            // 
            // btnRegister
            // 
            btnRegister.Cursor = Cursors.Hand;
            btnRegister.FlatStyle = FlatStyle.Flat;
            btnRegister.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegister.ForeColor = Color.MidnightBlue;
            btnRegister.Location = new Point(40, 462);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(350, 40);
            btnRegister.TabIndex = 6;
            btnRegister.Text = "CREATE ACCOUNT";
            btnRegister.UseVisualStyleBackColor = true;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.MidnightBlue;
            btnLogin.Cursor = Cursors.Hand;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(40, 398);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(350, 46);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "LOGIN";
            btnLogin.UseVisualStyleBackColor = false;
            // 
            // chkShowPassword
            // 
            chkShowPassword.AutoSize = true;
            chkShowPassword.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chkShowPassword.ForeColor = Color.DimGray;
            chkShowPassword.Location = new Point(54, 363);
            chkShowPassword.Name = "chkShowPassword";
            chkShowPassword.Size = new Size(164, 29);
            chkShowPassword.TabIndex = 4;
            chkShowPassword.Text = "Show password";
            chkShowPassword.UseVisualStyleBackColor = true;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(54, 311);
            txtPassword.Name = "txtPassword";
            txtPassword.PlaceholderText = "Enter your password";
            txtPassword.Size = new Size(350, 34);
            txtPassword.TabIndex = 3;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // txtUsername
            // 
            txtUsername.BackColor = Color.White;
            txtUsername.ForeColor = Color.Black;
            txtUsername.Location = new Point(53, 226);
            txtUsername.Name = "txtUsername";
            txtUsername.PlaceholderText = "Enter Your Username";
            txtUsername.Size = new Size(350, 34);
            txtUsername.TabIndex = 2;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPassword.ForeColor = Color.DimGray;
            lblPassword.Location = new Point(54, 280);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(93, 28);
            lblPassword.TabIndex = 1;
            lblPassword.Text = "Password";
            lblPassword.TextAlign = ContentAlignment.MiddleCenter;
            lblPassword.Click += lblPassword_Click;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUsername.ForeColor = Color.DimGray;
            lblUsername.Location = new Point(54, 195);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(175, 28);
            lblUsername.TabIndex = 1;
            lblUsername.Text = "Username or Email";
            lblUsername.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblSubtitle
            // 
            lblSubtitle.AutoSize = true;
            lblSubtitle.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSubtitle.ForeColor = Color.DimGray;
            lblSubtitle.Location = new Point(72, 141);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(292, 28);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "Swimming Management System";
            lblSubtitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.MidnightBlue;
            lblTitle.Location = new Point(27, 87);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(376, 54);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "SwimPro Academy";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // picLogo
            // 
            picLogo.BackColor = Color.Transparent;
            picLogo.BackgroundImage = (Image)resources.GetObject("picLogo.BackgroundImage");
            picLogo.Location = new Point(137, 3);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(152, 81);
            picLogo.SizeMode = PictureBoxSizeMode.Zoom;
            picLogo.TabIndex = 0;
            picLogo.TabStop = false;
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(880, 633);
            Controls.Add(loginCard);
            Controls.Add(picBackground);
            Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MinimumSize = new Size(900, 600);
            Name = "FrmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SwimPro Academy - Login";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)picBackground).EndInit();
            loginCard.ResumeLayout(false);
            loginCard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox picBackground;
        private Panel loginCard;
        private PictureBox picLogo;
        private Label lblTitle;
        private TextBox txtUsername;
        private Label lblUsername;
        private Label lblSubtitle;
        private TextBox txtPassword;
        private Label lblPassword;
        private Button btnLogin;
        private CheckBox chkShowPassword;
        private Button btnRegister;
    }
}