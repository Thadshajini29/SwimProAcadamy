namespace SwimProAcadamy
{
    partial class frmlogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmlogin));
            loginCard = new Panel();
            picShowPassword = new PictureBox();
            lnkRegister = new LinkLabel();
            lblNoAccount = new Label();
            btnLogin = new Button();
            lblError = new Label();
            lnkForgotPassword = new LinkLabel();
            chkRememberMe = new CheckBox();
            txtPassword = new TextBox();
            lblPassword = new Label();
            txtUsername = new TextBox();
            lblUsername = new Label();
            lblSubtitle = new Label();
            lblTitle = new Label();
            picLogo = new PictureBox();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            loginCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picShowPassword).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            SuspendLayout();
            // 
            // loginCard
            // 
            loginCard.Anchor = AnchorStyles.None;
            loginCard.BackColor = Color.White;
            loginCard.Controls.Add(picShowPassword);
            loginCard.Controls.Add(lnkRegister);
            loginCard.Controls.Add(lblNoAccount);
            loginCard.Controls.Add(btnLogin);
            loginCard.Controls.Add(lblError);
            loginCard.Controls.Add(lnkForgotPassword);
            loginCard.Controls.Add(chkRememberMe);
            loginCard.Controls.Add(txtPassword);
            loginCard.Controls.Add(lblPassword);
            loginCard.Controls.Add(txtUsername);
            loginCard.Controls.Add(lblUsername);
            loginCard.Controls.Add(lblSubtitle);
            loginCard.Controls.Add(lblTitle);
            loginCard.Controls.Add(picLogo);
            loginCard.Location = new Point(290, 55);
            loginCard.Name = "loginCard";
            loginCard.Size = new Size(430, 616);
            loginCard.TabIndex = 0;
            // 
            // picShowPassword
            // 
            picShowPassword.AccessibleName = "Show password";
            picShowPassword.Cursor = Cursors.Hand;
            picShowPassword.Image = (Image)resources.GetObject("picShowPassword.Image");
            picShowPassword.Location = new Point(359, 379);
            picShowPassword.Name = "picShowPassword";
            picShowPassword.Size = new Size(24, 24);
            picShowPassword.SizeMode = PictureBoxSizeMode.Zoom;
            picShowPassword.TabIndex = 9;
            picShowPassword.TabStop = false;
            picShowPassword.Click += picShowPassword_Click;
            // 
            // lnkRegister
            // 
            lnkRegister.ActiveLinkColor = Color.RoyalBlue;
            lnkRegister.AutoSize = true;
            lnkRegister.BackColor = Color.Transparent;
            lnkRegister.Cursor = Cursors.Hand;
            lnkRegister.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lnkRegister.LinkColor = Color.DodgerBlue;
            lnkRegister.Location = new Point(247, 572);
            lnkRegister.Name = "lnkRegister";
            lnkRegister.Size = new Size(82, 25);
            lnkRegister.TabIndex = 8;
            lnkRegister.TabStop = true;
            lnkRegister.Text = "Register";
            lnkRegister.VisitedLinkColor = Color.DodgerBlue;
            // 
            // lblNoAccount
            // 
            lblNoAccount.AutoSize = true;
            lblNoAccount.BackColor = Color.Transparent;
            lblNoAccount.ForeColor = Color.DimGray;
            lblNoAccount.Location = new Point(44, 572);
            lblNoAccount.Name = "lblNoAccount";
            lblNoAccount.Size = new Size(197, 25);
            lblNoAccount.TabIndex = 7;
            lblNoAccount.Text = "Don't have an account?";
            lblNoAccount.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.DodgerBlue;
            btnLogin.Cursor = Cursors.Hand;
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatAppearance.MouseDownBackColor = Color.RoyalBlue;
            btnLogin.FlatAppearance.MouseOverBackColor = Color.DeepSkyBlue;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(30, 486);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(360, 48);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // lblError
            // 
            lblError.ForeColor = Color.Firebrick;
            lblError.Location = new Point(30, 458);
            lblError.Name = "lblError";
            lblError.Size = new Size(360, 22);
            lblError.TabIndex = 10;
            lblError.TextAlign = ContentAlignment.MiddleCenter;
            lblError.Visible = false;
            // 
            // lnkForgotPassword
            // 
            lnkForgotPassword.ActiveLinkColor = Color.RoyalBlue;
            lnkForgotPassword.AutoSize = true;
            lnkForgotPassword.BackColor = Color.Transparent;
            lnkForgotPassword.Cursor = Cursors.Hand;
            lnkForgotPassword.LinkColor = Color.DodgerBlue;
            lnkForgotPassword.Location = new Point(209, 431);
            lnkForgotPassword.Name = "lnkForgotPassword";
            lnkForgotPassword.Size = new Size(154, 25);
            lnkForgotPassword.TabIndex = 6;
            lnkForgotPassword.TabStop = true;
            lnkForgotPassword.Text = "Forgot Password?";
            lnkForgotPassword.TextAlign = ContentAlignment.MiddleRight;
            lnkForgotPassword.VisitedLinkColor = Color.DodgerBlue;
            // 
            // chkRememberMe
            // 
            chkRememberMe.AutoSize = true;
            chkRememberMe.BackColor = Color.Transparent;
            chkRememberMe.Cursor = Cursors.Hand;
            chkRememberMe.ForeColor = Color.DimGray;
            chkRememberMe.Location = new Point(41, 428);
            chkRememberMe.Name = "chkRememberMe";
            chkRememberMe.Size = new Size(154, 29);
            chkRememberMe.TabIndex = 5;
            chkRememberMe.Text = "Remember me";
            chkRememberMe.UseVisualStyleBackColor = false;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.White;
            txtPassword.BorderStyle = BorderStyle.FixedSingle;
            txtPassword.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassword.ForeColor = Color.FromArgb(30, 30, 30);
            txtPassword.Location = new Point(30, 373);
            txtPassword.MaxLength = 50;
            txtPassword.Name = "txtPassword";
            txtPassword.PlaceholderText = "Enter your password";
            txtPassword.Size = new Size(360, 37);
            txtPassword.TabIndex = 1;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.BackColor = Color.Transparent;
            lblPassword.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPassword.ForeColor = Color.FromArgb(30, 30, 30);
            lblPassword.Location = new Point(30, 330);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(93, 28);
            lblPassword.TabIndex = 4;
            lblPassword.Text = "Password";
            lblPassword.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtUsername
            // 
            txtUsername.BackColor = Color.White;
            txtUsername.BorderStyle = BorderStyle.FixedSingle;
            txtUsername.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsername.ForeColor = Color.FromArgb(30, 30, 30);
            txtUsername.Location = new Point(30, 262);
            txtUsername.MaxLength = 100;
            txtUsername.Name = "txtUsername";
            txtUsername.PlaceholderText = "Enter your username or email";
            txtUsername.Size = new Size(360, 37);
            txtUsername.TabIndex = 0;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.BackColor = Color.Transparent;
            lblUsername.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUsername.ForeColor = Color.FromArgb(30, 30, 30);
            lblUsername.Location = new Point(30, 219);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(175, 28);
            lblUsername.TabIndex = 3;
            lblUsername.Text = "Username or Email";
            lblUsername.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblSubtitle
            // 
            lblSubtitle.AutoSize = true;
            lblSubtitle.BackColor = Color.Transparent;
            lblSubtitle.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSubtitle.ForeColor = Color.DimGray;
            lblSubtitle.Location = new Point(100, 163);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(177, 28);
            lblSubtitle.TabIndex = 2;
            lblSubtitle.Text = "Sign in to continue";
            lblSubtitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.BackColor = Color.Transparent;
            lblTitle.Font = new Font("Segoe UI", 22F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.MidnightBlue;
            lblTitle.Location = new Point(147, 101);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(142, 60);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "Login";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // picLogo
            // 
            picLogo.Image = (Image)resources.GetObject("picLogo.Image");
            picLogo.Location = new Point(141, 36);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(130, 62);
            picLogo.SizeMode = PictureBoxSizeMode.Zoom;
            picLogo.TabIndex = 0;
            picLogo.TabStop = false;
            // 
            // frmlogin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(939, 787);
            Controls.Add(loginCard);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "frmlogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SwimPro Academy - Login";
            Load += frmlogin_Load;
            loginCard.ResumeLayout(false);
            loginCard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picShowPassword).EndInit();
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel loginCard;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private PictureBox picLogo;
        private Label lblSubtitle;
        private Label lblTitle;
        private TextBox txtUsername;
        private Label lblUsername;
        private TextBox txtPassword;
        private Label lblPassword;
        private LinkLabel lnkForgotPassword;
        private CheckBox chkRememberMe;
        private Button btnLogin;
        private Label lblError;
        private LinkLabel lnkRegister;
        private Label lblNoAccount;
        private PictureBox picShowPassword;
    }
}
