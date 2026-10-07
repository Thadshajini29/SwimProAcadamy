namespace SwimProAcadamy
{
    partial class FrmChangePassword
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
            pnlChangePassword = new Panel();
            btnCancel = new Button();
            btnChangePassword = new Button();
            txtConfirmPassword = new TextBox();
            txtNewPassword = new TextBox();
            txtCurrentPassword = new TextBox();
            lblConfirmPassword = new Label();
            lblNewPassword = new Label();
            lblCurrentPassword = new Label();
            lblChangePasswordTitle = new Label();
            pnlChangePassword.SuspendLayout();
            SuspendLayout();
            // 
            // pnlChangePassword
            // 
            pnlChangePassword.BackColor = Color.White;
            pnlChangePassword.Controls.Add(btnCancel);
            pnlChangePassword.Controls.Add(btnChangePassword);
            pnlChangePassword.Controls.Add(txtConfirmPassword);
            pnlChangePassword.Controls.Add(txtNewPassword);
            pnlChangePassword.Controls.Add(txtCurrentPassword);
            pnlChangePassword.Controls.Add(lblConfirmPassword);
            pnlChangePassword.Controls.Add(lblNewPassword);
            pnlChangePassword.Controls.Add(lblCurrentPassword);
            pnlChangePassword.Controls.Add(lblChangePasswordTitle);
            pnlChangePassword.Location = new Point(50, 40);
            pnlChangePassword.Name = "pnlChangePassword";
            pnlChangePassword.Size = new Size(500, 400);
            pnlChangePassword.TabIndex = 0;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.Gray;
            btnCancel.Cursor = Cursors.Hand;
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(260, 310);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(150, 42);
            btnCancel.TabIndex = 4;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnChangePassword
            // 
            btnChangePassword.BackColor = Color.DodgerBlue;
            btnChangePassword.Cursor = Cursors.Hand;
            btnChangePassword.FlatAppearance.BorderSize = 0;
            btnChangePassword.FlatStyle = FlatStyle.Flat;
            btnChangePassword.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnChangePassword.ForeColor = Color.White;
            btnChangePassword.Location = new Point(50, 310);
            btnChangePassword.Name = "btnChangePassword";
            btnChangePassword.Size = new Size(190, 42);
            btnChangePassword.TabIndex = 3;
            btnChangePassword.Text = "Change Password";
            btnChangePassword.UseVisualStyleBackColor = false;
            btnChangePassword.Click += btnChangePassword_Click;
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.BorderStyle = BorderStyle.FixedSingle;
            txtConfirmPassword.Location = new Point(50, 245);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.PlaceholderText = "Confirm new password";
            txtConfirmPassword.Size = new Size(400, 34);
            txtConfirmPassword.TabIndex = 2;
            txtConfirmPassword.UseSystemPasswordChar = true;
            // 
            // txtNewPassword
            // 
            txtNewPassword.BorderStyle = BorderStyle.FixedSingle;
            txtNewPassword.Location = new Point(50, 175);
            txtNewPassword.Name = "txtNewPassword";
            txtNewPassword.PlaceholderText = "Enter new password";
            txtNewPassword.Size = new Size(400, 34);
            txtNewPassword.TabIndex = 1;
            txtNewPassword.UseSystemPasswordChar = true;
            // 
            // txtCurrentPassword
            // 
            txtCurrentPassword.BorderStyle = BorderStyle.FixedSingle;
            txtCurrentPassword.Location = new Point(50, 105);
            txtCurrentPassword.Name = "txtCurrentPassword";
            txtCurrentPassword.PlaceholderText = "Enter current password";
            txtCurrentPassword.Size = new Size(400, 34);
            txtCurrentPassword.TabIndex = 0;
            txtCurrentPassword.UseSystemPasswordChar = true;
            // 
            // lblConfirmPassword
            // 
            lblConfirmPassword.AutoSize = true;
            lblConfirmPassword.BackColor = Color.Transparent;
            lblConfirmPassword.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblConfirmPassword.ForeColor = Color.Black;
            lblConfirmPassword.Location = new Point(50, 220);
            lblConfirmPassword.Name = "lblConfirmPassword";
            lblConfirmPassword.Size = new Size(212, 28);
            lblConfirmPassword.TabIndex = 0;
            lblConfirmPassword.Text = "Confirm New Password";
            // 
            // lblNewPassword
            // 
            lblNewPassword.AutoSize = true;
            lblNewPassword.BackColor = Color.Transparent;
            lblNewPassword.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNewPassword.ForeColor = Color.Black;
            lblNewPassword.Location = new Point(50, 150);
            lblNewPassword.Name = "lblNewPassword";
            lblNewPassword.Size = new Size(137, 28);
            lblNewPassword.TabIndex = 0;
            lblNewPassword.Text = "New Password";
            // 
            // lblCurrentPassword
            // 
            lblCurrentPassword.AutoSize = true;
            lblCurrentPassword.BackColor = Color.Transparent;
            lblCurrentPassword.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCurrentPassword.ForeColor = Color.Black;
            lblCurrentPassword.Location = new Point(50, 80);
            lblCurrentPassword.Name = "lblCurrentPassword";
            lblCurrentPassword.Size = new Size(163, 28);
            lblCurrentPassword.TabIndex = 0;
            lblCurrentPassword.Text = "Current Password";
            // 
            // lblChangePasswordTitle
            // 
            lblChangePasswordTitle.AutoSize = true;
            lblChangePasswordTitle.BackColor = Color.Transparent;
            lblChangePasswordTitle.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblChangePasswordTitle.ForeColor = Color.MidnightBlue;
            lblChangePasswordTitle.Location = new Point(71, 16);
            lblChangePasswordTitle.Name = "lblChangePasswordTitle";
            lblChangePasswordTitle.Size = new Size(355, 54);
            lblChangePasswordTitle.TabIndex = 0;
            lblChangePasswordTitle.Text = "Change Password";
            // 
            // FrmChangePassword
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(578, 444);
            Controls.Add(pnlChangePassword);
            Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FrmChangePassword";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SwimPro Academy - Change Password";
            pnlChangePassword.ResumeLayout(false);
            pnlChangePassword.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlChangePassword;
        private TextBox txtCurrentPassword;
        private Label lblNewPassword;
        private Label lblCurrentPassword;
        private Label lblChangePasswordTitle;
        private Button btnChangePassword;
        private TextBox txtConfirmPassword;
        private TextBox txtNewPassword;
        private Label lblConfirmPassword;
        private Button btnCancel;
    }
}