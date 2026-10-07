namespace SwimProAcadamy
{
    partial class FrmDashboard
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
            pnlHeader = new Panel();
            btnLogout = new Button();
            lblWelcome = new Label();
            cmbRolePreview = new ComboBox();
            lblRole = new Label();
            lblDashboardTitle = new Label();
            pnlSwimmers = new Panel();
            btnSwimmers = new Button();
            lblSwimmerCount = new Label();
            lblTotalSwimmers = new Label();
            pnlTrainingPlans = new Panel();
            btnTrainingPlans = new Button();
            lblTrainingPlans = new Label();
            pnlFees = new Panel();
            btnFeeCalculator = new Button();
            lblFees = new Label();
            pnlReports = new Panel();
            btnReports = new Button();
            lblReports = new Label();
            pnlUsers = new Panel();
            btnUserManagement = new Button();
            lblUsers = new Label();
            pnlAudit = new Panel();
            btnAuditLog = new Button();
            lblAudit = new Label();
            pnlHeader.SuspendLayout();
            pnlSwimmers.SuspendLayout();
            pnlTrainingPlans.SuspendLayout();
            pnlFees.SuspendLayout();
            pnlReports.SuspendLayout();
            pnlUsers.SuspendLayout();
            pnlAudit.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.MidnightBlue;
            pnlHeader.Controls.Add(btnLogout);
            pnlHeader.Controls.Add(lblWelcome);
            pnlHeader.Controls.Add(cmbRolePreview);
            pnlHeader.Controls.Add(lblRole);
            pnlHeader.Controls.Add(lblDashboardTitle);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(1178, 80);
            pnlHeader.TabIndex = 0;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.White;
            btnLogout.Cursor = Cursors.Hand;
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogout.ForeColor = Color.MidnightBlue;
            btnLogout.Location = new Point(1080, 22);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(90, 35);
            btnLogout.TabIndex = 7;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.BackColor = Color.Transparent;
            lblWelcome.ForeColor = Color.White;
            lblWelcome.Location = new Point(446, 29);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(285, 28);
            lblWelcome.TabIndex = 3;
            lblWelcome.Text = "Welcome to SwimPro Academy";
            // 
            // cmbRolePreview
            // 
            cmbRolePreview.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRolePreview.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbRolePreview.FormattingEnabled = true;
            cmbRolePreview.Items.AddRange(new object[] { "Admin", "Manager", "Staff", "Student" });
            cmbRolePreview.Location = new Point(882, 22);
            cmbRolePreview.Name = "cmbRolePreview";
            cmbRolePreview.Size = new Size(180, 36);
            cmbRolePreview.TabIndex = 0;
            // 
            // lblRole
            // 
            lblRole.AutoSize = true;
            lblRole.BackColor = Color.Transparent;
            lblRole.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRole.ForeColor = Color.White;
            lblRole.Location = new Point(835, 22);
            lblRole.Name = "lblRole";
            lblRole.Size = new Size(55, 25);
            lblRole.TabIndex = 1;
            lblRole.Text = "Role:";
            // 
            // lblDashboardTitle
            // 
            lblDashboardTitle.AutoSize = true;
            lblDashboardTitle.BackColor = Color.Transparent;
            lblDashboardTitle.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDashboardTitle.ForeColor = Color.White;
            lblDashboardTitle.Location = new Point(30, 12);
            lblDashboardTitle.Name = "lblDashboardTitle";
            lblDashboardTitle.Size = new Size(376, 54);
            lblDashboardTitle.TabIndex = 0;
            lblDashboardTitle.Text = "SwimPro Academy";
            // 
            // pnlSwimmers
            // 
            pnlSwimmers.BackColor = Color.White;
            pnlSwimmers.Controls.Add(btnSwimmers);
            pnlSwimmers.Controls.Add(lblSwimmerCount);
            pnlSwimmers.Controls.Add(lblTotalSwimmers);
            pnlSwimmers.Location = new Point(50, 120);
            pnlSwimmers.Name = "pnlSwimmers";
            pnlSwimmers.Size = new Size(330, 220);
            pnlSwimmers.TabIndex = 1;
            // 
            // btnSwimmers
            // 
            btnSwimmers.BackColor = Color.DodgerBlue;
            btnSwimmers.Cursor = Cursors.Hand;
            btnSwimmers.FlatAppearance.BorderSize = 0;
            btnSwimmers.FlatStyle = FlatStyle.Flat;
            btnSwimmers.ForeColor = Color.White;
            btnSwimmers.Location = new Point(25, 145);
            btnSwimmers.Name = "btnSwimmers";
            btnSwimmers.Size = new Size(250, 40);
            btnSwimmers.TabIndex = 1;
            btnSwimmers.Text = "Manage Swimmers";
            btnSwimmers.UseVisualStyleBackColor = false;
            // 
            // lblSwimmerCount
            // 
            lblSwimmerCount.AutoSize = true;
            lblSwimmerCount.Font = new Font("Segoe UI", 28F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSwimmerCount.ForeColor = Color.DodgerBlue;
            lblSwimmerCount.Location = new Point(25, 60);
            lblSwimmerCount.Name = "lblSwimmerCount";
            lblSwimmerCount.Size = new Size(64, 74);
            lblSwimmerCount.TabIndex = 1;
            lblSwimmerCount.Text = "0";
            // 
            // lblTotalSwimmers
            // 
            lblTotalSwimmers.AutoSize = true;
            lblTotalSwimmers.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalSwimmers.ForeColor = Color.MidnightBlue;
            lblTotalSwimmers.Location = new Point(25, 25);
            lblTotalSwimmers.Name = "lblTotalSwimmers";
            lblTotalSwimmers.Size = new Size(194, 32);
            lblTotalSwimmers.TabIndex = 0;
            lblTotalSwimmers.Text = "Total Swimmers";
            // 
            // pnlTrainingPlans
            // 
            pnlTrainingPlans.BackColor = Color.White;
            pnlTrainingPlans.Controls.Add(btnTrainingPlans);
            pnlTrainingPlans.Controls.Add(lblTrainingPlans);
            pnlTrainingPlans.Location = new Point(435, 120);
            pnlTrainingPlans.Name = "pnlTrainingPlans";
            pnlTrainingPlans.Size = new Size(330, 220);
            pnlTrainingPlans.TabIndex = 1;
            // 
            // btnTrainingPlans
            // 
            btnTrainingPlans.BackColor = Color.DodgerBlue;
            btnTrainingPlans.Cursor = Cursors.Hand;
            btnTrainingPlans.FlatAppearance.BorderSize = 0;
            btnTrainingPlans.FlatStyle = FlatStyle.Flat;
            btnTrainingPlans.ForeColor = Color.White;
            btnTrainingPlans.Location = new Point(25, 145);
            btnTrainingPlans.Name = "btnTrainingPlans";
            btnTrainingPlans.Size = new Size(250, 40);
            btnTrainingPlans.TabIndex = 2;
            btnTrainingPlans.Text = "Manage Plans";
            btnTrainingPlans.UseVisualStyleBackColor = false;
            // 
            // lblTrainingPlans
            // 
            lblTrainingPlans.AutoSize = true;
            lblTrainingPlans.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTrainingPlans.ForeColor = Color.MidnightBlue;
            lblTrainingPlans.Location = new Point(25, 25);
            lblTrainingPlans.Name = "lblTrainingPlans";
            lblTrainingPlans.Size = new Size(176, 32);
            lblTrainingPlans.TabIndex = 0;
            lblTrainingPlans.Text = "Training Plans";
            // 
            // pnlFees
            // 
            pnlFees.BackColor = Color.White;
            pnlFees.Controls.Add(btnFeeCalculator);
            pnlFees.Controls.Add(lblFees);
            pnlFees.Location = new Point(820, 120);
            pnlFees.Name = "pnlFees";
            pnlFees.Size = new Size(330, 220);
            pnlFees.TabIndex = 1;
            // 
            // btnFeeCalculator
            // 
            btnFeeCalculator.BackColor = Color.DodgerBlue;
            btnFeeCalculator.Cursor = Cursors.Hand;
            btnFeeCalculator.FlatAppearance.BorderSize = 0;
            btnFeeCalculator.FlatStyle = FlatStyle.Flat;
            btnFeeCalculator.ForeColor = Color.White;
            btnFeeCalculator.Location = new Point(25, 145);
            btnFeeCalculator.Name = "btnFeeCalculator";
            btnFeeCalculator.Size = new Size(250, 40);
            btnFeeCalculator.TabIndex = 3;
            btnFeeCalculator.Text = "Calculate Fees";
            btnFeeCalculator.UseVisualStyleBackColor = false;
            // 
            // lblFees
            // 
            lblFees.AutoSize = true;
            lblFees.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFees.ForeColor = Color.MidnightBlue;
            lblFees.Location = new Point(25, 25);
            lblFees.Name = "lblFees";
            lblFees.Size = new Size(166, 32);
            lblFees.TabIndex = 0;
            lblFees.Text = "Monthly Fees";
            // 
            // pnlReports
            // 
            pnlReports.BackColor = Color.White;
            pnlReports.Controls.Add(btnReports);
            pnlReports.Controls.Add(lblReports);
            pnlReports.Location = new Point(50, 370);
            pnlReports.Name = "pnlReports";
            pnlReports.Size = new Size(330, 220);
            pnlReports.TabIndex = 1;
            // 
            // btnReports
            // 
            btnReports.BackColor = Color.DodgerBlue;
            btnReports.Cursor = Cursors.Hand;
            btnReports.FlatAppearance.BorderSize = 0;
            btnReports.FlatStyle = FlatStyle.Flat;
            btnReports.ForeColor = Color.White;
            btnReports.Location = new Point(25, 145);
            btnReports.Name = "btnReports";
            btnReports.Size = new Size(250, 40);
            btnReports.TabIndex = 4;
            btnReports.Text = "View Reports";
            btnReports.UseVisualStyleBackColor = false;
            // 
            // lblReports
            // 
            lblReports.AutoSize = true;
            lblReports.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblReports.ForeColor = Color.MidnightBlue;
            lblReports.Location = new Point(25, 25);
            lblReports.Name = "lblReports";
            lblReports.Size = new Size(103, 32);
            lblReports.TabIndex = 0;
            lblReports.Text = "Reports";
            // 
            // pnlUsers
            // 
            pnlUsers.BackColor = Color.White;
            pnlUsers.Controls.Add(btnUserManagement);
            pnlUsers.Controls.Add(lblUsers);
            pnlUsers.Location = new Point(435, 370);
            pnlUsers.Name = "pnlUsers";
            pnlUsers.Size = new Size(330, 220);
            pnlUsers.TabIndex = 1;
            // 
            // btnUserManagement
            // 
            btnUserManagement.BackColor = Color.DodgerBlue;
            btnUserManagement.Cursor = Cursors.Hand;
            btnUserManagement.FlatAppearance.BorderSize = 0;
            btnUserManagement.FlatStyle = FlatStyle.Flat;
            btnUserManagement.ForeColor = Color.White;
            btnUserManagement.Location = new Point(25, 145);
            btnUserManagement.Name = "btnUserManagement";
            btnUserManagement.Size = new Size(250, 40);
            btnUserManagement.TabIndex = 5;
            btnUserManagement.Text = "Manage Users";
            btnUserManagement.UseVisualStyleBackColor = false;
            // 
            // lblUsers
            // 
            lblUsers.AutoSize = true;
            lblUsers.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUsers.ForeColor = Color.MidnightBlue;
            lblUsers.Location = new Point(25, 25);
            lblUsers.Name = "lblUsers";
            lblUsers.Size = new Size(223, 32);
            lblUsers.TabIndex = 0;
            lblUsers.Text = "User Management";
            // 
            // pnlAudit
            // 
            pnlAudit.BackColor = Color.White;
            pnlAudit.Controls.Add(btnAuditLog);
            pnlAudit.Controls.Add(lblAudit);
            pnlAudit.Location = new Point(820, 370);
            pnlAudit.Name = "pnlAudit";
            pnlAudit.Size = new Size(330, 220);
            pnlAudit.TabIndex = 1;
            // 
            // btnAuditLog
            // 
            btnAuditLog.BackColor = Color.DodgerBlue;
            btnAuditLog.Cursor = Cursors.Hand;
            btnAuditLog.FlatAppearance.BorderSize = 0;
            btnAuditLog.FlatStyle = FlatStyle.Flat;
            btnAuditLog.ForeColor = Color.White;
            btnAuditLog.Location = new Point(25, 145);
            btnAuditLog.Name = "btnAuditLog";
            btnAuditLog.Size = new Size(250, 40);
            btnAuditLog.TabIndex = 6;
            btnAuditLog.Text = "View Activity";
            btnAuditLog.UseVisualStyleBackColor = false;
            // 
            // lblAudit
            // 
            lblAudit.AutoSize = true;
            lblAudit.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAudit.ForeColor = Color.MidnightBlue;
            lblAudit.Location = new Point(25, 25);
            lblAudit.Name = "lblAudit";
            lblAudit.Size = new Size(188, 32);
            lblAudit.TabIndex = 0;
            lblAudit.Text = "System Activity";
            // 
            // FrmDashboard
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(1178, 644);
            Controls.Add(pnlFees);
            Controls.Add(pnlTrainingPlans);
            Controls.Add(pnlAudit);
            Controls.Add(pnlUsers);
            Controls.Add(pnlReports);
            Controls.Add(pnlSwimmers);
            Controls.Add(pnlHeader);
            Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FrmDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SwimPro Academy - Dashboard";
            Load += FrmDashboard_Load;
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlSwimmers.ResumeLayout(false);
            pnlSwimmers.PerformLayout();
            pnlTrainingPlans.ResumeLayout(false);
            pnlTrainingPlans.PerformLayout();
            pnlFees.ResumeLayout(false);
            pnlFees.PerformLayout();
            pnlReports.ResumeLayout(false);
            pnlReports.PerformLayout();
            pnlUsers.ResumeLayout(false);
            pnlUsers.PerformLayout();
            pnlAudit.ResumeLayout(false);
            pnlAudit.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlHeader;
        private Label lblDashboardTitle;
        private Panel pnlSwimmers;
        private Label lblTotalSwimmers;
        private Button btnSwimmers;
        private Label lblSwimmerCount;
        private Panel pnlTrainingPlans;
        private Button btnTrainingPlans;
        private Label lblTrainingPlans;
        private Panel pnlFees;
        private Button btnFeeCalculator;
        private Label lblFees;
        private Panel pnlReports;
        private Button btnReports;
        private Label lblReports;
        private Panel pnlUsers;
        private Button btnUserManagement;
        private Label lblUsers;
        private Panel pnlAudit;
        private Button btnAuditLog;
        private Label lblAudit;
        private Label lblRole;
        private Button btnLogout;
        private Label lblWelcome;
        private ComboBox cmbRolePreview;
    }
}
