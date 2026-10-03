namespace SwimProAcadamy
{
    partial class FrmUserManagement
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
            pnlUserHeader = new Panel();
            lblUserTitle = new Label();
            pnlUserInput = new Panel();
            lblUserFullName = new Label();
            txtUserFullName = new TextBox();
            lblUserName = new Label();
            txtUserName = new TextBox();
            lblUserEmail = new Label();
            txtUserEmail = new TextBox();
            lblUserPassword = new Label();
            txtUserPassword = new TextBox();
            lblUserRole = new Label();
            cmbUserRole = new ComboBox();
            chkUserActive = new CheckBox();
            btnAddUser = new Button();
            btnUpdateUser = new Button();
            btnDeleteUser = new Button();
            btnResetPassword = new Button();
            btnClearUser = new Button();
            dgvUsers = new DataGridView();
            pnlUserHeader.SuspendLayout();
            pnlUserInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsers).BeginInit();
            SuspendLayout();
            // 
            // pnlUserHeader
            // 
            pnlUserHeader.BackColor = Color.MidnightBlue;
            pnlUserHeader.Controls.Add(lblUserTitle);
            pnlUserHeader.Dock = DockStyle.Top;
            pnlUserHeader.Location = new Point(0, 0);
            pnlUserHeader.Name = "pnlUserHeader";
            pnlUserHeader.Size = new Size(1178, 70);
            pnlUserHeader.TabIndex = 0;
            // 
            // lblUserTitle
            // 
            lblUserTitle.AutoSize = true;
            lblUserTitle.BackColor = Color.Transparent;
            lblUserTitle.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUserTitle.ForeColor = Color.White;
            lblUserTitle.Location = new Point(30, 20);
            lblUserTitle.Name = "lblUserTitle";
            lblUserTitle.Size = new Size(371, 54);
            lblUserTitle.TabIndex = 0;
            lblUserTitle.Text = "User Management";
            // 
            // pnlUserInput
            // 
            pnlUserInput.BackColor = Color.White;
            pnlUserInput.Controls.Add(btnResetPassword);
            pnlUserInput.Controls.Add(btnClearUser);
            pnlUserInput.Controls.Add(btnDeleteUser);
            pnlUserInput.Controls.Add(btnUpdateUser);
            pnlUserInput.Controls.Add(btnAddUser);
            pnlUserInput.Controls.Add(chkUserActive);
            pnlUserInput.Controls.Add(cmbUserRole);
            pnlUserInput.Controls.Add(txtUserEmail);
            pnlUserInput.Controls.Add(txtUserName);
            pnlUserInput.Controls.Add(txtUserPassword);
            pnlUserInput.Controls.Add(txtUserFullName);
            pnlUserInput.Controls.Add(lblUserRole);
            pnlUserInput.Controls.Add(lblUserPassword);
            pnlUserInput.Controls.Add(lblUserEmail);
            pnlUserInput.Controls.Add(lblUserName);
            pnlUserInput.Controls.Add(lblUserFullName);
            pnlUserInput.Location = new Point(30, 95);
            pnlUserInput.Name = "pnlUserInput";
            pnlUserInput.Size = new Size(1140, 250);
            pnlUserInput.TabIndex = 1;
            // 
            // lblUserFullName
            // 
            lblUserFullName.AutoSize = true;
            lblUserFullName.Location = new Point(30, 20);
            lblUserFullName.Name = "lblUserFullName";
            lblUserFullName.Size = new Size(100, 28);
            lblUserFullName.TabIndex = 0;
            lblUserFullName.Text = "Full Name";
            // 
            // txtUserFullName
            // 
            txtUserFullName.BorderStyle = BorderStyle.FixedSingle;
            txtUserFullName.Location = new Point(30, 45);
            txtUserFullName.Name = "txtUserFullName";
            txtUserFullName.PlaceholderText = "Enter full name";
            txtUserFullName.Size = new Size(300, 34);
            txtUserFullName.TabIndex = 1;
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.Location = new Point(350, 20);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(99, 28);
            lblUserName.TabIndex = 0;
            lblUserName.Text = "Username";
            // 
            // txtUserName
            // 
            txtUserName.BorderStyle = BorderStyle.FixedSingle;
            txtUserName.Location = new Point(350, 45);
            txtUserName.Name = "txtUserName";
            txtUserName.PlaceholderText = "Enter username";
            txtUserName.Size = new Size(250, 34);
            txtUserName.TabIndex = 1;
            // 
            // lblUserEmail
            // 
            lblUserEmail.AutoSize = true;
            lblUserEmail.Location = new Point(620, 20);
            lblUserEmail.Name = "lblUserEmail";
            lblUserEmail.Size = new Size(134, 28);
            lblUserEmail.TabIndex = 0;
            lblUserEmail.Text = "Email Address";
            // 
            // txtUserEmail
            // 
            txtUserEmail.BorderStyle = BorderStyle.FixedSingle;
            txtUserEmail.Location = new Point(620, 45);
            txtUserEmail.Name = "txtUserEmail";
            txtUserEmail.PlaceholderText = "Enter email address";
            txtUserEmail.Size = new Size(350, 34);
            txtUserEmail.TabIndex = 1;
            // 
            // lblUserPassword
            // 
            lblUserPassword.AutoSize = true;
            lblUserPassword.Location = new Point(30, 100);
            lblUserPassword.Name = "lblUserPassword";
            lblUserPassword.Size = new Size(93, 28);
            lblUserPassword.TabIndex = 0;
            lblUserPassword.Text = "Password";
            // 
            // txtUserPassword
            // 
            txtUserPassword.BorderStyle = BorderStyle.FixedSingle;
            txtUserPassword.Location = new Point(30, 125);
            txtUserPassword.Name = "txtUserPassword";
            txtUserPassword.PlaceholderText = "Enter password";
            txtUserPassword.Size = new Size(300, 34);
            txtUserPassword.TabIndex = 1;
            txtUserPassword.UseSystemPasswordChar = true;
            // 
            // lblUserRole
            // 
            lblUserRole.AutoSize = true;
            lblUserRole.Location = new Point(350, 100);
            lblUserRole.Name = "lblUserRole";
            lblUserRole.Size = new Size(50, 28);
            lblUserRole.TabIndex = 0;
            lblUserRole.Text = "Role";
            // 
            // cmbUserRole
            // 
            cmbUserRole.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbUserRole.FormattingEnabled = true;
            cmbUserRole.Items.AddRange(new object[] { "Admin", "", "Manager", "", "Staff", "Student" });
            cmbUserRole.Location = new Point(350, 125);
            cmbUserRole.Name = "cmbUserRole";
            cmbUserRole.Size = new Size(250, 36);
            cmbUserRole.TabIndex = 2;
            // 
            // chkUserActive
            // 
            chkUserActive.AutoSize = true;
            chkUserActive.Checked = true;
            chkUserActive.CheckState = CheckState.Checked;
            chkUserActive.Cursor = Cursors.Hand;
            chkUserActive.Location = new Point(650, 132);
            chkUserActive.Name = "chkUserActive";
            chkUserActive.Size = new Size(92, 32);
            chkUserActive.TabIndex = 3;
            chkUserActive.Text = "Active";
            chkUserActive.UseVisualStyleBackColor = true;
            // 
            // btnAddUser
            // 
            btnAddUser.BackColor = Color.DodgerBlue;
            btnAddUser.Cursor = Cursors.Hand;
            btnAddUser.FlatAppearance.BorderSize = 0;
            btnAddUser.FlatStyle = FlatStyle.Flat;
            btnAddUser.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddUser.ForeColor = Color.White;
            btnAddUser.Location = new Point(30, 185);
            btnAddUser.Name = "btnAddUser";
            btnAddUser.Size = new Size(130, 40);
            btnAddUser.TabIndex = 4;
            btnAddUser.Text = "Add User";
            btnAddUser.UseVisualStyleBackColor = false;
            // 
            // btnUpdateUser
            // 
            btnUpdateUser.BackColor = Color.SteelBlue;
            btnUpdateUser.Cursor = Cursors.Hand;
            btnUpdateUser.FlatAppearance.BorderSize = 0;
            btnUpdateUser.FlatStyle = FlatStyle.Flat;
            btnUpdateUser.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdateUser.ForeColor = Color.White;
            btnUpdateUser.Location = new Point(175, 185);
            btnUpdateUser.Name = "btnUpdateUser";
            btnUpdateUser.Size = new Size(120, 40);
            btnUpdateUser.TabIndex = 4;
            btnUpdateUser.Text = "Update";
            btnUpdateUser.UseVisualStyleBackColor = false;
            // 
            // btnDeleteUser
            // 
            btnDeleteUser.BackColor = Color.IndianRed;
            btnDeleteUser.Cursor = Cursors.Hand;
            btnDeleteUser.FlatAppearance.BorderSize = 0;
            btnDeleteUser.FlatStyle = FlatStyle.Flat;
            btnDeleteUser.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDeleteUser.ForeColor = Color.White;
            btnDeleteUser.Location = new Point(310, 185);
            btnDeleteUser.Name = "btnDeleteUser";
            btnDeleteUser.Size = new Size(120, 40);
            btnDeleteUser.TabIndex = 4;
            btnDeleteUser.Text = "Delete";
            btnDeleteUser.UseVisualStyleBackColor = false;
            // 
            // btnResetPassword
            // 
            btnResetPassword.BackColor = Color.DarkOrange;
            btnResetPassword.Cursor = Cursors.Hand;
            btnResetPassword.FlatAppearance.BorderSize = 0;
            btnResetPassword.FlatStyle = FlatStyle.Flat;
            btnResetPassword.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnResetPassword.ForeColor = Color.White;
            btnResetPassword.Location = new Point(445, 185);
            btnResetPassword.Name = "btnResetPassword";
            btnResetPassword.Size = new Size(180, 40);
            btnResetPassword.TabIndex = 4;
            btnResetPassword.Text = "Reset Password";
            btnResetPassword.UseVisualStyleBackColor = false;
            // 
            // btnClearUser
            // 
            btnClearUser.BackColor = Color.Gray;
            btnClearUser.Cursor = Cursors.Hand;
            btnClearUser.FlatAppearance.BorderSize = 0;
            btnClearUser.FlatStyle = FlatStyle.Flat;
            btnClearUser.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClearUser.ForeColor = Color.White;
            btnClearUser.Location = new Point(646, 185);
            btnClearUser.Name = "btnClearUser";
            btnClearUser.Size = new Size(120, 40);
            btnClearUser.TabIndex = 4;
            btnClearUser.Text = "Clear";
            btnClearUser.UseVisualStyleBackColor = false;
            // 
            // dgvUsers
            // 
            dgvUsers.AllowUserToAddRows = false;
            dgvUsers.AllowUserToResizeRows = false;
            dgvUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvUsers.BackgroundColor = Color.White;
            dgvUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsers.Location = new Point(30, 365);
            dgvUsers.MultiSelect = false;
            dgvUsers.Name = "dgvUsers";
            dgvUsers.ReadOnly = true;
            dgvUsers.RowHeadersVisible = false;
            dgvUsers.RowHeadersWidth = 62;
            dgvUsers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUsers.Size = new Size(1140, 300);
            dgvUsers.TabIndex = 2;
            // 
            // FrmUserManagement
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(1178, 694);
            Controls.Add(dgvUsers);
            Controls.Add(pnlUserInput);
            Controls.Add(pnlUserHeader);
            Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FrmUserManagement";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SwimPro Academy - User Management";
            pnlUserHeader.ResumeLayout(false);
            pnlUserHeader.PerformLayout();
            pnlUserInput.ResumeLayout(false);
            pnlUserInput.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsers).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlUserHeader;
        private Label lblUserTitle;
        private Panel pnlUserInput;
        private TextBox txtUserName;
        private TextBox txtUserFullName;
        private Label lblUserName;
        private Label lblUserFullName;
        private TextBox txtUserEmail;
        private TextBox txtUserPassword;
        private Label lblUserPassword;
        private Label lblUserEmail;
        private CheckBox chkUserActive;
        private ComboBox cmbUserRole;
        private Label lblUserRole;
        private Button btnResetPassword;
        private Button btnDeleteUser;
        private Button btnUpdateUser;
        private Button btnAddUser;
        private Button btnClearUser;
        private DataGridView dgvUsers;
    }
}