namespace SwimProAcadamy
{
    partial class FrmRegister
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRegister));
            pnlRegister = new Panel();
            lnkBackLogin = new LinkLabel();
            btnRegister = new Button();
            txtConfirmPassword = new TextBox();
            txtRegPassword = new TextBox();
            txtEmail = new TextBox();
            txtRegUsername = new TextBox();
            txtFullName = new TextBox();
            lblConfirmPassword = new Label();
            lblRegPassword = new Label();
            lblEmail = new Label();
            lblRegUsername = new Label();
            lblFullName = new Label();
            lblRegisterTitle = new Label();
            picRegisterLogo = new PictureBox();
            pnlRegister.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picRegisterLogo).BeginInit();
            SuspendLayout();
            // 
            // pnlRegister
            // 
            pnlRegister.BackColor = Color.White;
            pnlRegister.Controls.Add(lnkBackLogin);
            pnlRegister.Controls.Add(btnRegister);
            pnlRegister.Controls.Add(txtConfirmPassword);
            pnlRegister.Controls.Add(txtRegPassword);
            pnlRegister.Controls.Add(txtEmail);
            pnlRegister.Controls.Add(txtRegUsername);
            pnlRegister.Controls.Add(txtFullName);
            pnlRegister.Controls.Add(lblConfirmPassword);
            pnlRegister.Controls.Add(lblRegPassword);
            pnlRegister.Controls.Add(lblEmail);
            pnlRegister.Controls.Add(lblRegUsername);
            pnlRegister.Controls.Add(lblFullName);
            pnlRegister.Controls.Add(lblRegisterTitle);
            pnlRegister.Controls.Add(picRegisterLogo);
            pnlRegister.Location = new Point(250, 40);
            pnlRegister.Name = "pnlRegister";
            pnlRegister.Size = new Size(500, 570);
            pnlRegister.TabIndex = 0;
            pnlRegister.Paint += pnlRegister_Paint;
            // 
            // lnkBackLogin
            // 
            lnkBackLogin.AutoSize = true;
            lnkBackLogin.BackColor = Color.Transparent;
            lnkBackLogin.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lnkBackLogin.LinkColor = Color.DodgerBlue;
            lnkBackLogin.Location = new Point(145, 540);
            lnkBackLogin.Name = "lnkBackLogin";
            lnkBackLogin.Size = new Size(262, 25);
            lnkBackLogin.TabIndex = 5;
            lnkBackLogin.TabStop = true;
            lnkBackLogin.Text = "Already have an account? Login";
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.DodgerBlue;
            btnRegister.Cursor = Cursors.Hand;
            btnRegister.FlatAppearance.BorderSize = 0;
            btnRegister.FlatStyle = FlatStyle.Flat;
            btnRegister.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegister.ForeColor = Color.White;
            btnRegister.Location = new Point(40, 490);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(420, 42);
            btnRegister.TabIndex = 4;
            btnRegister.Text = "Create Account";
            btnRegister.UseVisualStyleBackColor = false;
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.BackColor = Color.White;
            txtConfirmPassword.BorderStyle = BorderStyle.FixedSingle;
            txtConfirmPassword.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtConfirmPassword.Location = new Point(40, 440);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.PlaceholderText = "Confirm password";
            txtConfirmPassword.Size = new Size(420, 37);
            txtConfirmPassword.TabIndex = 3;
            txtConfirmPassword.UseSystemPasswordChar = true;
            // 
            // txtRegPassword
            // 
            txtRegPassword.BackColor = Color.White;
            txtRegPassword.BorderStyle = BorderStyle.FixedSingle;
            txtRegPassword.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtRegPassword.Location = new Point(40, 370);
            txtRegPassword.Name = "txtRegPassword";
            txtRegPassword.PlaceholderText = "Enter password";
            txtRegPassword.Size = new Size(420, 37);
            txtRegPassword.TabIndex = 3;
            txtRegPassword.UseSystemPasswordChar = true;
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.White;
            txtEmail.BorderStyle = BorderStyle.FixedSingle;
            txtEmail.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmail.Location = new Point(40, 300);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "Enter email";
            txtEmail.Size = new Size(420, 37);
            txtEmail.TabIndex = 3;
            // 
            // txtRegUsername
            // 
            txtRegUsername.BackColor = Color.White;
            txtRegUsername.BorderStyle = BorderStyle.FixedSingle;
            txtRegUsername.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtRegUsername.Location = new Point(40, 230);
            txtRegUsername.Name = "txtRegUsername";
            txtRegUsername.PlaceholderText = "Enter username";
            txtRegUsername.Size = new Size(420, 37);
            txtRegUsername.TabIndex = 3;
            // 
            // txtFullName
            // 
            txtFullName.BackColor = Color.White;
            txtFullName.BorderStyle = BorderStyle.FixedSingle;
            txtFullName.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFullName.Location = new Point(40, 160);
            txtFullName.Name = "txtFullName";
            txtFullName.PlaceholderText = "Enter your full name";
            txtFullName.Size = new Size(420, 37);
            txtFullName.TabIndex = 3;
            // 
            // lblConfirmPassword
            // 
            lblConfirmPassword.AutoSize = true;
            lblConfirmPassword.BackColor = Color.Transparent;
            lblConfirmPassword.ForeColor = Color.Black;
            lblConfirmPassword.Location = new Point(40, 415);
            lblConfirmPassword.Name = "lblConfirmPassword";
            lblConfirmPassword.Size = new Size(168, 28);
            lblConfirmPassword.TabIndex = 2;
            lblConfirmPassword.Text = "Confirm Password";
            // 
            // lblRegPassword
            // 
            lblRegPassword.AutoSize = true;
            lblRegPassword.BackColor = Color.Transparent;
            lblRegPassword.ForeColor = Color.Black;
            lblRegPassword.Location = new Point(40, 345);
            lblRegPassword.Name = "lblRegPassword";
            lblRegPassword.Size = new Size(93, 28);
            lblRegPassword.TabIndex = 2;
            lblRegPassword.Text = "Password";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.BackColor = Color.Transparent;
            lblEmail.ForeColor = Color.Black;
            lblEmail.Location = new Point(40, 275);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(59, 28);
            lblEmail.TabIndex = 2;
            lblEmail.Text = "Email";
            // 
            // lblRegUsername
            // 
            lblRegUsername.AutoSize = true;
            lblRegUsername.BackColor = Color.Transparent;
            lblRegUsername.ForeColor = Color.Black;
            lblRegUsername.Location = new Point(40, 205);
            lblRegUsername.Name = "lblRegUsername";
            lblRegUsername.Size = new Size(99, 28);
            lblRegUsername.TabIndex = 2;
            lblRegUsername.Text = "Username";
            // 
            // lblFullName
            // 
            lblFullName.AutoSize = true;
            lblFullName.BackColor = Color.Transparent;
            lblFullName.ForeColor = Color.Black;
            lblFullName.Location = new Point(40, 135);
            lblFullName.Name = "lblFullName";
            lblFullName.Size = new Size(100, 28);
            lblFullName.TabIndex = 2;
            lblFullName.Text = "Full Name";
            // 
            // lblRegisterTitle
            // 
            lblRegisterTitle.AutoSize = true;
            lblRegisterTitle.BackColor = Color.Transparent;
            lblRegisterTitle.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRegisterTitle.ForeColor = Color.MidnightBlue;
            lblRegisterTitle.Location = new Point(70, 88);
            lblRegisterTitle.Name = "lblRegisterTitle";
            lblRegisterTitle.Size = new Size(406, 54);
            lblRegisterTitle.TabIndex = 1;
            lblRegisterTitle.Text = "Create Your Account";
            // 
            // picRegisterLogo
            // 
            picRegisterLogo.BackColor = Color.Transparent;
            picRegisterLogo.Image = (Image)resources.GetObject("picRegisterLogo.Image");
            picRegisterLogo.Location = new Point(190, 15);
            picRegisterLogo.Name = "picRegisterLogo";
            picRegisterLogo.Size = new Size(120, 70);
            picRegisterLogo.SizeMode = PictureBoxSizeMode.Zoom;
            picRegisterLogo.TabIndex = 0;
            picRegisterLogo.TabStop = false;
            // 
            // FrmRegister
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1076, 665);
            Controls.Add(pnlRegister);
            Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FrmRegister";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SwimPro Academy - Register";
            pnlRegister.ResumeLayout(false);
            pnlRegister.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picRegisterLogo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlRegister;
        private Label lblRegisterTitle;
        private PictureBox picRegisterLogo;
        private TextBox txtRegUsername;
        private TextBox txtFullName;
        private Label lblRegUsername;
        private Label lblFullName;
        private TextBox txtRegPassword;
        private TextBox txtEmail;
        private Label lblRegPassword;
        private Label lblEmail;
        private Button btnRegister;
        private TextBox txtConfirmPassword;
        private Label lblConfirmPassword;
        private LinkLabel lnkBackLogin;
    }
}