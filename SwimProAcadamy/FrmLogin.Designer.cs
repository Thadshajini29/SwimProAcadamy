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
            pnlLogin = new Panel();
            chkShowPassword = new CheckBox();
            lblNoAccount = new Label();
            btnLogin = new Button();
            lnkRegister = new LinkLabel();
            lnkForgotPassword = new LinkLabel();
            chkRemember = new CheckBox();
            txtPassword = new TextBox();
            txtUsername = new TextBox();
            lblPassword = new Label();
            lblUsername = new Label();
            lblSubtitle = new Label();
            lblTitle = new Label();
            picLogo = new PictureBox();
            pnlLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            SuspendLayout();
            // 
            // pnlLogin
            // 
            pnlLogin.BackColor = Color.White;
            pnlLogin.Controls.Add(chkShowPassword);
            pnlLogin.Controls.Add(lblNoAccount);
            pnlLogin.Controls.Add(btnLogin);
            pnlLogin.Controls.Add(lnkRegister);
            pnlLogin.Controls.Add(lnkForgotPassword);
            pnlLogin.Controls.Add(chkRemember);
            pnlLogin.Controls.Add(txtPassword);
            pnlLogin.Controls.Add(txtUsername);
            pnlLogin.Controls.Add(lblPassword);
            pnlLogin.Controls.Add(lblUsername);
            pnlLogin.Controls.Add(lblSubtitle);
            pnlLogin.Controls.Add(lblTitle);
            pnlLogin.Controls.Add(picLogo);
            pnlLogin.Location = new Point(307, 12);
            pnlLogin.Name = "pnlLogin";
            pnlLogin.Size = new Size(430, 550);
            pnlLogin.TabIndex = 0;
            // 
            // chkShowPassword
            // 
            chkShowPassword.AutoSize = true;
            chkShowPassword.BackColor = Color.Transparent;
            chkShowPassword.Cursor = Cursors.Hand;
            chkShowPassword.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chkShowPassword.ForeColor = Color.DimGray;
            chkShowPassword.Location = new Point(40, 335);
            chkShowPassword.Name = "chkShowPassword";
            chkShowPassword.Size = new Size(164, 29);
            chkShowPassword.TabIndex = 2;
            chkShowPassword.Text = "Show password";
            chkShowPassword.UseVisualStyleBackColor = false;
            chkShowPassword.CheckedChanged += chkShowPassword_CheckedChanged;
            // 
            // lblNoAccount
            // 
            lblNoAccount.AutoSize = true;
            lblNoAccount.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNoAccount.ForeColor = Color.DimGray;
            lblNoAccount.Location = new Point(95, 480);
            lblNoAccount.Name = "lblNoAccount";
            lblNoAccount.Size = new Size(197, 25);
            lblNoAccount.TabIndex = 7;
            lblNoAccount.Text = "Don't have an account?";
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.DodgerBlue;
            btnLogin.Cursor = Cursors.Hand;
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(40, 405);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(360, 48);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            // 
            // lnkRegister
            // 
            lnkRegister.AutoSize = true;
            lnkRegister.BackColor = Color.Transparent;
            lnkRegister.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lnkRegister.LinkColor = Color.DodgerBlue;
            lnkRegister.Location = new Point(285, 480);
            lnkRegister.Name = "lnkRegister";
            lnkRegister.Size = new Size(82, 25);
            lnkRegister.TabIndex = 6;
            lnkRegister.TabStop = true;
            lnkRegister.Text = "Register";
            // 
            // lnkForgotPassword
            // 
            lnkForgotPassword.AutoSize = true;
            lnkForgotPassword.BackColor = Color.Transparent;
            lnkForgotPassword.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lnkForgotPassword.LinkColor = Color.DodgerBlue;
            lnkForgotPassword.Location = new Point(265, 365);
            lnkForgotPassword.Name = "lnkForgotPassword";
            lnkForgotPassword.Size = new Size(154, 25);
            lnkForgotPassword.TabIndex = 4;
            lnkForgotPassword.TabStop = true;
            lnkForgotPassword.Text = "Forgot Password?";
            // 
            // chkRemember
            // 
            chkRemember.AutoSize = true;
            chkRemember.BackColor = Color.Transparent;
            chkRemember.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chkRemember.ForeColor = Color.DimGray;
            chkRemember.Location = new Point(40, 365);
            chkRemember.Name = "chkRemember";
            chkRemember.Size = new Size(154, 29);
            chkRemember.TabIndex = 3;
            chkRemember.Text = "Remember me";
            chkRemember.UseVisualStyleBackColor = false;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.White;
            txtPassword.BorderStyle = BorderStyle.FixedSingle;
            txtPassword.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassword.Location = new Point(40, 290);
            txtPassword.Name = "txtPassword";
            txtPassword.PlaceholderText = "Enter your password";
            txtPassword.Size = new Size(350, 37);
            txtPassword.TabIndex = 1;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // txtUsername
            // 
            txtUsername.BackColor = Color.White;
            txtUsername.BorderStyle = BorderStyle.FixedSingle;
            txtUsername.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsername.Location = new Point(40, 210);
            txtUsername.Name = "txtUsername";
            txtUsername.PlaceholderText = "Enter your username or email";
            txtUsername.Size = new Size(350, 37);
            txtUsername.TabIndex = 0;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.BackColor = Color.Transparent;
            lblPassword.ForeColor = Color.Black;
            lblPassword.Location = new Point(40, 265);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(93, 28);
            lblPassword.TabIndex = 3;
            lblPassword.Text = "Password";
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.BackColor = Color.Transparent;
            lblUsername.ForeColor = Color.Black;
            lblUsername.Location = new Point(40, 185);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(175, 28);
            lblUsername.TabIndex = 3;
            lblUsername.Text = "Username or Email";
            // 
            // lblSubtitle
            // 
            lblSubtitle.AutoSize = true;
            lblSubtitle.BackColor = Color.Transparent;
            lblSubtitle.ForeColor = Color.DimGray;
            lblSubtitle.Location = new Point(62, 157);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(292, 28);
            lblSubtitle.TabIndex = 2;
            lblSubtitle.Text = "Swimming Management System";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.BackColor = Color.Transparent;
            lblTitle.Font = new Font("Segoe UI", 22F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.MidnightBlue;
            lblTitle.Location = new Point(14, 107);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(413, 60);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "SwimPro Academy";
            // 
            // picLogo
            // 
            picLogo.BackColor = Color.Transparent;
            picLogo.Image = (Image)resources.GetObject("picLogo.Image");
            picLogo.Location = new Point(140, 15);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(150, 90);
            picLogo.SizeMode = PictureBoxSizeMode.Zoom;
            picLogo.TabIndex = 0;
            picLogo.TabStop = false;
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(978, 594);
            Controls.Add(pnlLogin);
            Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FrmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SwimPro Academy - Login";
            Load += FrmLogin_Load;
            pnlLogin.ResumeLayout(false);
            pnlLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlLogin;
        private PictureBox picLogo;
        private TextBox txtUsername;
        private Label lblUsername;
        private Label lblSubtitle;
        private Label lblTitle;
        private LinkLabel lnkForgotPassword;
        private CheckBox chkRemember;
        private TextBox txtPassword;
        private Label lblPassword;
        private Label lblNoAccount;
        private Button btnLogin;
        private LinkLabel lnkRegister;
        private CheckBox chkShowPassword;
    }
}