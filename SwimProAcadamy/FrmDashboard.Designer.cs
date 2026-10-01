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
            lblDashboardTitle = new Label();
            lblWelcome = new Label();
            pnlSwimmers = new Panel();
            lblSwimmers = new Label();
            btnSwimmers = new Button();
            pnlFees = new Panel();
            btnFeeCalculator = new Button();
            lblFees = new Label();
            pnlReports = new Panel();
            btnReports = new Button();
            lblReports = new Label();
            pnlLogout = new Panel();
            btnLogout = new Button();
            lblAccount = new Label();
            pnlHeader.SuspendLayout();
            pnlSwimmers.SuspendLayout();
            pnlFees.SuspendLayout();
            pnlReports.SuspendLayout();
            pnlLogout.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.MidnightBlue;
            pnlHeader.Controls.Add(lblWelcome);
            pnlHeader.Controls.Add(lblDashboardTitle);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(1296, 98);
            pnlHeader.TabIndex = 0;
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
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.BackColor = Color.Transparent;
            lblWelcome.ForeColor = Color.White;
            lblWelcome.Location = new Point(856, 32);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(402, 28);
            lblWelcome.TabIndex = 1;
            lblWelcome.Text = "Welcome to Swimming Management System";
            // 
            // pnlSwimmers
            // 
            pnlSwimmers.BackColor = Color.White;
            pnlSwimmers.Controls.Add(btnSwimmers);
            pnlSwimmers.Controls.Add(lblSwimmers);
            pnlSwimmers.Location = new Point(70, 150);
            pnlSwimmers.Name = "pnlSwimmers";
            pnlSwimmers.Size = new Size(250, 220);
            pnlSwimmers.TabIndex = 1;
            // 
            // lblSwimmers
            // 
            lblSwimmers.AutoSize = true;
            lblSwimmers.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSwimmers.ForeColor = Color.MidnightBlue;
            lblSwimmers.Location = new Point(33, 42);
            lblSwimmers.Name = "lblSwimmers";
            lblSwimmers.Size = new Size(194, 48);
            lblSwimmers.TabIndex = 0;
            lblSwimmers.Text = "Swimmers";
            // 
            // btnSwimmers
            // 
            btnSwimmers.BackColor = Color.DodgerBlue;
            btnSwimmers.Cursor = Cursors.No;
            btnSwimmers.FlatAppearance.BorderSize = 0;
            btnSwimmers.FlatStyle = FlatStyle.Flat;
            btnSwimmers.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSwimmers.ForeColor = Color.White;
            btnSwimmers.Location = new Point(17, 125);
            btnSwimmers.Name = "btnSwimmers";
            btnSwimmers.Size = new Size(220, 45);
            btnSwimmers.TabIndex = 1;
            btnSwimmers.Text = "Manage Swimmers";
            btnSwimmers.UseVisualStyleBackColor = false;
            // 
            // pnlFees
            // 
            pnlFees.BackColor = Color.White;
            pnlFees.Controls.Add(btnFeeCalculator);
            pnlFees.Controls.Add(lblFees);
            pnlFees.Location = new Point(350, 150);
            pnlFees.Name = "pnlFees";
            pnlFees.Size = new Size(250, 220);
            pnlFees.TabIndex = 1;
            // 
            // btnFeeCalculator
            // 
            btnFeeCalculator.BackColor = Color.DodgerBlue;
            btnFeeCalculator.Cursor = Cursors.No;
            btnFeeCalculator.FlatAppearance.BorderSize = 0;
            btnFeeCalculator.FlatStyle = FlatStyle.Flat;
            btnFeeCalculator.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFeeCalculator.ForeColor = Color.White;
            btnFeeCalculator.Location = new Point(30, 125);
            btnFeeCalculator.Name = "btnFeeCalculator";
            btnFeeCalculator.Size = new Size(190, 45);
            btnFeeCalculator.TabIndex = 1;
            btnFeeCalculator.Text = "Calculate Fees";
            btnFeeCalculator.UseVisualStyleBackColor = false;
            // 
            // lblFees
            // 
            lblFees.AutoSize = true;
            lblFees.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFees.ForeColor = Color.MidnightBlue;
            lblFees.Location = new Point(0, 42);
            lblFees.Name = "lblFees";
            lblFees.Size = new Size(256, 48);
            lblFees.TabIndex = 0;
            lblFees.Text = "Fee Calculator";
            // 
            // pnlReports
            // 
            pnlReports.BackColor = Color.White;
            pnlReports.Controls.Add(btnReports);
            pnlReports.Controls.Add(lblReports);
            pnlReports.Location = new Point(630, 150);
            pnlReports.Name = "pnlReports";
            pnlReports.Size = new Size(250, 220);
            pnlReports.TabIndex = 1;
            // 
            // btnReports
            // 
            btnReports.BackColor = Color.DodgerBlue;
            btnReports.Cursor = Cursors.No;
            btnReports.FlatAppearance.BorderSize = 0;
            btnReports.FlatStyle = FlatStyle.Flat;
            btnReports.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReports.ForeColor = Color.White;
            btnReports.Location = new Point(30, 125);
            btnReports.Name = "btnReports";
            btnReports.Size = new Size(190, 45);
            btnReports.TabIndex = 1;
            btnReports.Text = "View Reports";
            btnReports.UseVisualStyleBackColor = false;
            // 
            // lblReports
            // 
            lblReports.AutoSize = true;
            lblReports.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblReports.ForeColor = Color.MidnightBlue;
            lblReports.Location = new Point(85, 45);
            lblReports.Name = "lblReports";
            lblReports.Size = new Size(151, 48);
            lblReports.TabIndex = 0;
            lblReports.Text = "Reports";
            // 
            // pnlLogout
            // 
            pnlLogout.BackColor = Color.White;
            pnlLogout.Controls.Add(btnLogout);
            pnlLogout.Controls.Add(lblAccount);
            pnlLogout.Location = new Point(910, 150);
            pnlLogout.Name = "pnlLogout";
            pnlLogout.Size = new Size(250, 220);
            pnlLogout.TabIndex = 1;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.DodgerBlue;
            btnLogout.Cursor = Cursors.No;
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogout.ForeColor = Color.White;
            btnLogout.Location = new Point(30, 125);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(190, 45);
            btnLogout.TabIndex = 1;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = false;
            // 
            // lblAccount
            // 
            lblAccount.AutoSize = true;
            lblAccount.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAccount.ForeColor = Color.MidnightBlue;
            lblAccount.Location = new Point(85, 45);
            lblAccount.Name = "lblAccount";
            lblAccount.Size = new Size(159, 48);
            lblAccount.TabIndex = 0;
            lblAccount.Text = "Account";
            // 
            // FrmDashboard
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(1296, 721);
            Controls.Add(pnlLogout);
            Controls.Add(pnlReports);
            Controls.Add(pnlFees);
            Controls.Add(pnlSwimmers);
            Controls.Add(pnlHeader);
            Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FrmDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SwimPro Academy - Dashboard";
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlSwimmers.ResumeLayout(false);
            pnlSwimmers.PerformLayout();
            pnlFees.ResumeLayout(false);
            pnlFees.PerformLayout();
            pnlReports.ResumeLayout(false);
            pnlReports.PerformLayout();
            pnlLogout.ResumeLayout(false);
            pnlLogout.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlHeader;
        private Label lblDashboardTitle;
        private Label lblWelcome;
        private Panel pnlSwimmers;
        private Label lblSwimmers;
        private Button btnSwimmers;
        private Panel pnlFees;
        private Button btnFeeCalculator;
        private Label lblFees;
        private Panel pnlReports;
        private Button btnReports;
        private Label lblReports;
        private Panel pnlLogout;
        private Button btnLogout;
        private Label lblAccount;
    }
}