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
            cmbRolePreview = new ComboBox();
            lblRole = new Label();
            lblWelcome = new Label();
            lblDashboardSubtitle = new Label();
            lblDashboardTitle = new Label();
            pnlSwimmersSummary = new Panel();
            lblSwimmerCount = new Label();
            lblSwimmersTitle = new Label();
            pnlPlansSummary = new Panel();
            lblPlanCount = new Label();
            lblPlansTitle = new Label();
            pnlFeesSummary = new Panel();
            lblMonthlyFees = new Label();
            lblMonthlyFeesTitle = new Label();
            pnlCompetitionsSummary = new Panel();
            lblCompetitionCount = new Label();
            lblCompetitionsTitle = new Label();
            pnlSwimmers = new Panel();
            btnSwimmers = new Button();
            lblSwimmersCardTitle = new Label();
            pnlTrainingPlans = new Panel();
            btnTrainingPlans = new Button();
            lblTrainingPlansTitle = new Label();
            pnlCompetitionCategories = new Panel();
            btnCompetitionCategories = new Button();
            lblCompetitionCategoriesTitle = new Label();
            pnlFeeCalculator = new Panel();
            btnFeeCalculator = new Button();
            lblFeeCalculatorTitle = new Label();
            pnlFeeHistory = new Panel();
            btnFeeHistory = new Button();
            lblFeeHistoryTitle = new Label();
            pnlReports = new Panel();
            btnReports = new Button();
            lblReportsTitle = new Label();
            pnlUserManagement = new Panel();
            btnUserManagement = new Button();
            lblUserManagementTitle = new Label();
            pnlAudit = new Panel();
            btnAuditLog = new Button();
            lblAuditTitle = new Label();
            lnkGoToRegister = new LinkLabel();
            pnlHeader.SuspendLayout();
            pnlSwimmersSummary.SuspendLayout();
            pnlPlansSummary.SuspendLayout();
            pnlFeesSummary.SuspendLayout();
            pnlCompetitionsSummary.SuspendLayout();
            pnlSwimmers.SuspendLayout();
            pnlTrainingPlans.SuspendLayout();
            pnlCompetitionCategories.SuspendLayout();
            pnlFeeCalculator.SuspendLayout();
            pnlFeeHistory.SuspendLayout();
            pnlReports.SuspendLayout();
            pnlUserManagement.SuspendLayout();
            pnlAudit.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.MidnightBlue;
            pnlHeader.Controls.Add(btnLogout);
            pnlHeader.Controls.Add(cmbRolePreview);
            pnlHeader.Controls.Add(lblRole);
            pnlHeader.Controls.Add(lblWelcome);
            pnlHeader.Controls.Add(lblDashboardSubtitle);
            pnlHeader.Controls.Add(lblDashboardTitle);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(1178, 85);
            pnlHeader.TabIndex = 0;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.White;
            btnLogout.Cursor = Cursors.Hand;
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogout.ForeColor = Color.MidnightBlue;
            btnLogout.Location = new Point(1080, 25);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(95, 35);
            btnLogout.TabIndex = 1;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = false;
            // 
            // cmbRolePreview
            // 
            cmbRolePreview.BackColor = Color.White;
            cmbRolePreview.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRolePreview.ForeColor = Color.MidnightBlue;
            cmbRolePreview.FormattingEnabled = true;
            cmbRolePreview.Location = new Point(785, 25);
            cmbRolePreview.Name = "cmbRolePreview";
            cmbRolePreview.Size = new Size(160, 36);
            cmbRolePreview.TabIndex = 0;
            // 
            // lblRole
            // 
            lblRole.AutoSize = true;
            lblRole.BackColor = Color.Transparent;
            lblRole.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRole.ForeColor = Color.White;
            lblRole.Location = new Point(735, 29);
            lblRole.Name = "lblRole";
            lblRole.Size = new Size(59, 28);
            lblRole.TabIndex = 3;
            lblRole.Text = "Role:";
            lblRole.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblWelcome
            // 
            lblWelcome.BackColor = Color.Transparent;
            lblWelcome.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblWelcome.ForeColor = Color.White;
            lblWelcome.Location = new Point(440, 28);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(270, 30);
            lblWelcome.TabIndex = 2;
            lblWelcome.Text = "Welcome to SwimPro Academy";
            lblWelcome.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblDashboardSubtitle
            // 
            lblDashboardSubtitle.BackColor = Color.Transparent;
            lblDashboardSubtitle.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDashboardSubtitle.ForeColor = Color.LightBlue;
            lblDashboardSubtitle.Location = new Point(30, 47);
            lblDashboardSubtitle.Name = "lblDashboardSubtitle";
            lblDashboardSubtitle.Size = new Size(300, 22);
            lblDashboardSubtitle.TabIndex = 1;
            lblDashboardSubtitle.Text = "Swimming Management System";
            // 
            // lblDashboardTitle
            // 
            lblDashboardTitle.BackColor = Color.Transparent;
            lblDashboardTitle.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDashboardTitle.ForeColor = Color.White;
            lblDashboardTitle.Location = new Point(25, 0);
            lblDashboardTitle.Name = "lblDashboardTitle";
            lblDashboardTitle.Size = new Size(409, 57);
            lblDashboardTitle.TabIndex = 0;
            lblDashboardTitle.Text = "SwimPro Academy";
            lblDashboardTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pnlSwimmersSummary
            // 
            pnlSwimmersSummary.BackColor = Color.White;
            pnlSwimmersSummary.BorderStyle = BorderStyle.FixedSingle;
            pnlSwimmersSummary.Controls.Add(lblSwimmerCount);
            pnlSwimmersSummary.Controls.Add(lblSwimmersTitle);
            pnlSwimmersSummary.Location = new Point(30, 110);
            pnlSwimmersSummary.Name = "pnlSwimmersSummary";
            pnlSwimmersSummary.Size = new Size(270, 125);
            pnlSwimmersSummary.TabIndex = 1;
            // 
            // lblSwimmerCount
            // 
            lblSwimmerCount.Font = new Font("Segoe UI", 26F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSwimmerCount.ForeColor = Color.MidnightBlue;
            lblSwimmerCount.Location = new Point(18, 48);
            lblSwimmerCount.Name = "lblSwimmerCount";
            lblSwimmerCount.Size = new Size(230, 61);
            lblSwimmerCount.TabIndex = 0;
            lblSwimmerCount.Text = "0";
            // 
            // lblSwimmersTitle
            // 
            lblSwimmersTitle.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSwimmersTitle.ForeColor = Color.DimGray;
            lblSwimmersTitle.Location = new Point(18, 15);
            lblSwimmersTitle.Name = "lblSwimmersTitle";
            lblSwimmersTitle.Size = new Size(230, 33);
            lblSwimmersTitle.TabIndex = 0;
            lblSwimmersTitle.Text = "Total Swimmers";
            // 
            // pnlPlansSummary
            // 
            pnlPlansSummary.BackColor = Color.White;
            pnlPlansSummary.BorderStyle = BorderStyle.FixedSingle;
            pnlPlansSummary.Controls.Add(lblPlanCount);
            pnlPlansSummary.Controls.Add(lblPlansTitle);
            pnlPlansSummary.Location = new Point(325, 110);
            pnlPlansSummary.Name = "pnlPlansSummary";
            pnlPlansSummary.Size = new Size(270, 125);
            pnlPlansSummary.TabIndex = 1;
            // 
            // lblPlanCount
            // 
            lblPlanCount.Font = new Font("Segoe UI", 26F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPlanCount.ForeColor = Color.MidnightBlue;
            lblPlanCount.Location = new Point(18, 48);
            lblPlanCount.Name = "lblPlanCount";
            lblPlanCount.Size = new Size(230, 61);
            lblPlanCount.TabIndex = 0;
            lblPlanCount.Text = "0";
            // 
            // lblPlansTitle
            // 
            lblPlansTitle.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPlansTitle.ForeColor = Color.DimGray;
            lblPlansTitle.Location = new Point(18, 15);
            lblPlansTitle.Name = "lblPlansTitle";
            lblPlansTitle.Size = new Size(230, 33);
            lblPlansTitle.TabIndex = 0;
            lblPlansTitle.Text = "Training Plans";
            // 
            // pnlFeesSummary
            // 
            pnlFeesSummary.BackColor = Color.White;
            pnlFeesSummary.BorderStyle = BorderStyle.FixedSingle;
            pnlFeesSummary.Controls.Add(lblMonthlyFees);
            pnlFeesSummary.Controls.Add(lblMonthlyFeesTitle);
            pnlFeesSummary.Location = new Point(620, 110);
            pnlFeesSummary.Name = "pnlFeesSummary";
            pnlFeesSummary.Size = new Size(270, 125);
            pnlFeesSummary.TabIndex = 1;
            // 
            // lblMonthlyFees
            // 
            lblMonthlyFees.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMonthlyFees.ForeColor = Color.MidnightBlue;
            lblMonthlyFees.Location = new Point(18, 48);
            lblMonthlyFees.Name = "lblMonthlyFees";
            lblMonthlyFees.Size = new Size(230, 50);
            lblMonthlyFees.TabIndex = 0;
            lblMonthlyFees.Text = "Rs. 0.00";
            // 
            // lblMonthlyFeesTitle
            // 
            lblMonthlyFeesTitle.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMonthlyFeesTitle.ForeColor = Color.DimGray;
            lblMonthlyFeesTitle.Location = new Point(18, 15);
            lblMonthlyFeesTitle.Name = "lblMonthlyFeesTitle";
            lblMonthlyFeesTitle.Size = new Size(230, 33);
            lblMonthlyFeesTitle.TabIndex = 0;
            lblMonthlyFeesTitle.Text = "Monthly Fees";
            // 
            // pnlCompetitionsSummary
            // 
            pnlCompetitionsSummary.BackColor = Color.White;
            pnlCompetitionsSummary.BorderStyle = BorderStyle.FixedSingle;
            pnlCompetitionsSummary.Controls.Add(lblCompetitionCount);
            pnlCompetitionsSummary.Controls.Add(lblCompetitionsTitle);
            pnlCompetitionsSummary.Location = new Point(915, 110);
            pnlCompetitionsSummary.Name = "pnlCompetitionsSummary";
            pnlCompetitionsSummary.Size = new Size(255, 125);
            pnlCompetitionsSummary.TabIndex = 1;
            // 
            // lblCompetitionCount
            // 
            lblCompetitionCount.Font = new Font("Segoe UI", 26F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCompetitionCount.ForeColor = Color.MidnightBlue;
            lblCompetitionCount.Location = new Point(18, 48);
            lblCompetitionCount.Name = "lblCompetitionCount";
            lblCompetitionCount.Size = new Size(230, 61);
            lblCompetitionCount.TabIndex = 0;
            lblCompetitionCount.Text = "0";
            // 
            // lblCompetitionsTitle
            // 
            lblCompetitionsTitle.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCompetitionsTitle.ForeColor = Color.DimGray;
            lblCompetitionsTitle.Location = new Point(18, 15);
            lblCompetitionsTitle.Name = "lblCompetitionsTitle";
            lblCompetitionsTitle.Size = new Size(230, 33);
            lblCompetitionsTitle.TabIndex = 0;
            lblCompetitionsTitle.Text = "Competitions";
            // 
            // pnlSwimmers
            // 
            pnlSwimmers.BackColor = Color.White;
            pnlSwimmers.BorderStyle = BorderStyle.FixedSingle;
            pnlSwimmers.Controls.Add(btnSwimmers);
            pnlSwimmers.Controls.Add(lblSwimmersCardTitle);
            pnlSwimmers.Location = new Point(30, 260);
            pnlSwimmers.Name = "pnlSwimmers";
            pnlSwimmers.Size = new Size(270, 145);
            pnlSwimmers.TabIndex = 2;
            // 
            // btnSwimmers
            // 
            btnSwimmers.BackColor = Color.MidnightBlue;
            btnSwimmers.Cursor = Cursors.Hand;
            btnSwimmers.FlatAppearance.BorderSize = 0;
            btnSwimmers.FlatStyle = FlatStyle.Flat;
            btnSwimmers.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSwimmers.ForeColor = Color.White;
            btnSwimmers.Location = new Point(15, 85);
            btnSwimmers.Name = "btnSwimmers";
            btnSwimmers.Size = new Size(230, 35);
            btnSwimmers.TabIndex = 1;
            btnSwimmers.Text = "Open Swimmers";
            btnSwimmers.UseVisualStyleBackColor = false;
            // 
            // lblSwimmersCardTitle
            // 
            lblSwimmersCardTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSwimmersCardTitle.ForeColor = Color.DimGray;
            lblSwimmersCardTitle.Location = new Point(15, 10);
            lblSwimmersCardTitle.Name = "lblSwimmersCardTitle";
            lblSwimmersCardTitle.Size = new Size(250, 30);
            lblSwimmersCardTitle.TabIndex = 0;
            lblSwimmersCardTitle.Text = "Swimmer Management";
            // 
            // pnlTrainingPlans
            // 
            pnlTrainingPlans.BackColor = Color.White;
            pnlTrainingPlans.BorderStyle = BorderStyle.FixedSingle;
            pnlTrainingPlans.Controls.Add(btnTrainingPlans);
            pnlTrainingPlans.Controls.Add(lblTrainingPlansTitle);
            pnlTrainingPlans.Location = new Point(325, 260);
            pnlTrainingPlans.Name = "pnlTrainingPlans";
            pnlTrainingPlans.Size = new Size(270, 145);
            pnlTrainingPlans.TabIndex = 2;
            // 
            // btnTrainingPlans
            // 
            btnTrainingPlans.BackColor = Color.MidnightBlue;
            btnTrainingPlans.Cursor = Cursors.Hand;
            btnTrainingPlans.FlatAppearance.BorderSize = 0;
            btnTrainingPlans.FlatStyle = FlatStyle.Flat;
            btnTrainingPlans.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTrainingPlans.ForeColor = Color.White;
            btnTrainingPlans.Location = new Point(15, 85);
            btnTrainingPlans.Name = "btnTrainingPlans";
            btnTrainingPlans.Size = new Size(230, 35);
            btnTrainingPlans.TabIndex = 1;
            btnTrainingPlans.Text = "Open Training Plans";
            btnTrainingPlans.UseVisualStyleBackColor = false;
            // 
            // lblTrainingPlansTitle
            // 
            lblTrainingPlansTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTrainingPlansTitle.ForeColor = Color.DimGray;
            lblTrainingPlansTitle.Location = new Point(15, 10);
            lblTrainingPlansTitle.Name = "lblTrainingPlansTitle";
            lblTrainingPlansTitle.Size = new Size(240, 42);
            lblTrainingPlansTitle.TabIndex = 0;
            lblTrainingPlansTitle.Text = "Training Plans";
            // 
            // pnlCompetitionCategories
            // 
            pnlCompetitionCategories.BackColor = Color.White;
            pnlCompetitionCategories.BorderStyle = BorderStyle.FixedSingle;
            pnlCompetitionCategories.Controls.Add(btnCompetitionCategories);
            pnlCompetitionCategories.Controls.Add(lblCompetitionCategoriesTitle);
            pnlCompetitionCategories.Location = new Point(620, 260);
            pnlCompetitionCategories.Name = "pnlCompetitionCategories";
            pnlCompetitionCategories.Size = new Size(270, 145);
            pnlCompetitionCategories.TabIndex = 2;
            // 
            // btnCompetitionCategories
            // 
            btnCompetitionCategories.BackColor = Color.MidnightBlue;
            btnCompetitionCategories.Cursor = Cursors.Hand;
            btnCompetitionCategories.FlatAppearance.BorderSize = 0;
            btnCompetitionCategories.FlatStyle = FlatStyle.Flat;
            btnCompetitionCategories.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCompetitionCategories.ForeColor = Color.White;
            btnCompetitionCategories.Location = new Point(15, 85);
            btnCompetitionCategories.Name = "btnCompetitionCategories";
            btnCompetitionCategories.Size = new Size(230, 35);
            btnCompetitionCategories.TabIndex = 1;
            btnCompetitionCategories.Text = "Open Categories";
            btnCompetitionCategories.UseVisualStyleBackColor = false;
            // 
            // lblCompetitionCategoriesTitle
            // 
            lblCompetitionCategoriesTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCompetitionCategoriesTitle.ForeColor = Color.DimGray;
            lblCompetitionCategoriesTitle.Location = new Point(15, 10);
            lblCompetitionCategoriesTitle.Name = "lblCompetitionCategoriesTitle";
            lblCompetitionCategoriesTitle.Size = new Size(240, 42);
            lblCompetitionCategoriesTitle.TabIndex = 0;
            lblCompetitionCategoriesTitle.Text = "Competition Categories";
            // 
            // pnlFeeCalculator
            // 
            pnlFeeCalculator.BackColor = Color.White;
            pnlFeeCalculator.BorderStyle = BorderStyle.FixedSingle;
            pnlFeeCalculator.Controls.Add(btnFeeCalculator);
            pnlFeeCalculator.Controls.Add(lblFeeCalculatorTitle);
            pnlFeeCalculator.Location = new Point(915, 260);
            pnlFeeCalculator.Name = "pnlFeeCalculator";
            pnlFeeCalculator.Size = new Size(255, 145);
            pnlFeeCalculator.TabIndex = 2;
            // 
            // btnFeeCalculator
            // 
            btnFeeCalculator.BackColor = Color.MidnightBlue;
            btnFeeCalculator.Cursor = Cursors.Hand;
            btnFeeCalculator.FlatAppearance.BorderSize = 0;
            btnFeeCalculator.FlatStyle = FlatStyle.Flat;
            btnFeeCalculator.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFeeCalculator.ForeColor = Color.White;
            btnFeeCalculator.Location = new Point(12, 85);
            btnFeeCalculator.Name = "btnFeeCalculator";
            btnFeeCalculator.Size = new Size(225, 35);
            btnFeeCalculator.TabIndex = 1;
            btnFeeCalculator.Text = "Calculate Fees";
            btnFeeCalculator.UseVisualStyleBackColor = false;
            // 
            // lblFeeCalculatorTitle
            // 
            lblFeeCalculatorTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFeeCalculatorTitle.ForeColor = Color.DimGray;
            lblFeeCalculatorTitle.Location = new Point(15, 10);
            lblFeeCalculatorTitle.Name = "lblFeeCalculatorTitle";
            lblFeeCalculatorTitle.Size = new Size(225, 42);
            lblFeeCalculatorTitle.TabIndex = 0;
            lblFeeCalculatorTitle.Text = "Fee Calculator";
            // 
            // pnlFeeHistory
            // 
            pnlFeeHistory.BackColor = Color.White;
            pnlFeeHistory.BorderStyle = BorderStyle.FixedSingle;
            pnlFeeHistory.Controls.Add(btnFeeHistory);
            pnlFeeHistory.Controls.Add(lblFeeHistoryTitle);
            pnlFeeHistory.Location = new Point(30, 425);
            pnlFeeHistory.Name = "pnlFeeHistory";
            pnlFeeHistory.Size = new Size(270, 145);
            pnlFeeHistory.TabIndex = 2;
            // 
            // btnFeeHistory
            // 
            btnFeeHistory.BackColor = Color.MidnightBlue;
            btnFeeHistory.Cursor = Cursors.Hand;
            btnFeeHistory.FlatAppearance.BorderSize = 0;
            btnFeeHistory.FlatStyle = FlatStyle.Flat;
            btnFeeHistory.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFeeHistory.ForeColor = Color.White;
            btnFeeHistory.Location = new Point(15, 85);
            btnFeeHistory.Name = "btnFeeHistory";
            btnFeeHistory.Size = new Size(230, 35);
            btnFeeHistory.TabIndex = 1;
            btnFeeHistory.Text = "View Fee History";
            btnFeeHistory.UseVisualStyleBackColor = false;
            // 
            // lblFeeHistoryTitle
            // 
            lblFeeHistoryTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFeeHistoryTitle.ForeColor = Color.DimGray;
            lblFeeHistoryTitle.Location = new Point(15, 10);
            lblFeeHistoryTitle.Name = "lblFeeHistoryTitle";
            lblFeeHistoryTitle.Size = new Size(240, 40);
            lblFeeHistoryTitle.TabIndex = 0;
            lblFeeHistoryTitle.Text = "Fee History";
            // 
            // pnlReports
            // 
            pnlReports.BackColor = Color.White;
            pnlReports.BorderStyle = BorderStyle.FixedSingle;
            pnlReports.Controls.Add(btnReports);
            pnlReports.Controls.Add(lblReportsTitle);
            pnlReports.Location = new Point(325, 425);
            pnlReports.Name = "pnlReports";
            pnlReports.Size = new Size(270, 145);
            pnlReports.TabIndex = 2;
            // 
            // btnReports
            // 
            btnReports.BackColor = Color.MidnightBlue;
            btnReports.Cursor = Cursors.Hand;
            btnReports.FlatAppearance.BorderSize = 0;
            btnReports.FlatStyle = FlatStyle.Flat;
            btnReports.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReports.ForeColor = Color.White;
            btnReports.Location = new Point(15, 85);
            btnReports.Name = "btnReports";
            btnReports.Size = new Size(230, 35);
            btnReports.TabIndex = 1;
            btnReports.Text = "Open Reports";
            btnReports.UseVisualStyleBackColor = false;
            // 
            // lblReportsTitle
            // 
            lblReportsTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblReportsTitle.ForeColor = Color.DimGray;
            lblReportsTitle.Location = new Point(15, 10);
            lblReportsTitle.Name = "lblReportsTitle";
            lblReportsTitle.Size = new Size(240, 40);
            lblReportsTitle.TabIndex = 0;
            lblReportsTitle.Text = "Reports";
            // 
            // pnlUserManagement
            // 
            pnlUserManagement.BackColor = Color.White;
            pnlUserManagement.BorderStyle = BorderStyle.FixedSingle;
            pnlUserManagement.Controls.Add(btnUserManagement);
            pnlUserManagement.Controls.Add(lblUserManagementTitle);
            pnlUserManagement.Location = new Point(620, 425);
            pnlUserManagement.Name = "pnlUserManagement";
            pnlUserManagement.Size = new Size(270, 145);
            pnlUserManagement.TabIndex = 2;
            // 
            // btnUserManagement
            // 
            btnUserManagement.BackColor = Color.MidnightBlue;
            btnUserManagement.Cursor = Cursors.Hand;
            btnUserManagement.FlatAppearance.BorderSize = 0;
            btnUserManagement.FlatStyle = FlatStyle.Flat;
            btnUserManagement.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUserManagement.ForeColor = Color.White;
            btnUserManagement.Location = new Point(15, 85);
            btnUserManagement.Name = "btnUserManagement";
            btnUserManagement.Size = new Size(230, 35);
            btnUserManagement.TabIndex = 1;
            btnUserManagement.Text = "Manage Users";
            btnUserManagement.UseVisualStyleBackColor = false;
            // 
            // lblUserManagementTitle
            // 
            lblUserManagementTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUserManagementTitle.ForeColor = Color.DimGray;
            lblUserManagementTitle.Location = new Point(15, 10);
            lblUserManagementTitle.Name = "lblUserManagementTitle";
            lblUserManagementTitle.Size = new Size(240, 40);
            lblUserManagementTitle.TabIndex = 0;
            lblUserManagementTitle.Text = "User Management";
            // 
            // pnlAudit
            // 
            pnlAudit.BackColor = Color.White;
            pnlAudit.BorderStyle = BorderStyle.FixedSingle;
            pnlAudit.Controls.Add(btnAuditLog);
            pnlAudit.Controls.Add(lblAuditTitle);
            pnlAudit.Location = new Point(915, 425);
            pnlAudit.Name = "pnlAudit";
            pnlAudit.Size = new Size(255, 145);
            pnlAudit.TabIndex = 2;
            // 
            // btnAuditLog
            // 
            btnAuditLog.BackColor = Color.MidnightBlue;
            btnAuditLog.Cursor = Cursors.Hand;
            btnAuditLog.FlatAppearance.BorderSize = 0;
            btnAuditLog.FlatStyle = FlatStyle.Flat;
            btnAuditLog.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAuditLog.ForeColor = Color.White;
            btnAuditLog.Location = new Point(12, 85);
            btnAuditLog.Name = "btnAuditLog";
            btnAuditLog.Size = new Size(225, 35);
            btnAuditLog.TabIndex = 1;
            btnAuditLog.Text = "Open Audit Log";
            btnAuditLog.UseVisualStyleBackColor = false;
            // 
            // lblAuditTitle
            // 
            lblAuditTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAuditTitle.ForeColor = Color.DimGray;
            lblAuditTitle.Location = new Point(15, 10);
            lblAuditTitle.Name = "lblAuditTitle";
            lblAuditTitle.Size = new Size(225, 40);
            lblAuditTitle.TabIndex = 0;
            lblAuditTitle.Text = "Audit Log";
            // 
            // lnkGoToRegister
            // 
            lnkGoToRegister.ActiveLinkColor = Color.MidnightBlue;
            lnkGoToRegister.BackColor = Color.Transparent;
            lnkGoToRegister.Cursor = Cursors.Hand;
            lnkGoToRegister.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lnkGoToRegister.LinkColor = Color.RoyalBlue;
            lnkGoToRegister.Location = new Point(450, 600);
            lnkGoToRegister.Name = "lnkGoToRegister";
            lnkGoToRegister.Size = new Size(300, 30);
            lnkGoToRegister.TabIndex = 9;
            lnkGoToRegister.TabStop = true;
            lnkGoToRegister.Text = "+ Create New Account";
            lnkGoToRegister.TextAlign = ContentAlignment.MiddleCenter;
            lnkGoToRegister.VisitedLinkColor = Color.RoyalBlue;
            // 
            // FrmDashboard
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(1178, 704);
            Controls.Add(lnkGoToRegister);
            Controls.Add(pnlAudit);
            Controls.Add(pnlFeeCalculator);
            Controls.Add(pnlUserManagement);
            Controls.Add(pnlCompetitionCategories);
            Controls.Add(pnlTrainingPlans);
            Controls.Add(pnlReports);
            Controls.Add(pnlFeeHistory);
            Controls.Add(pnlSwimmers);
            Controls.Add(pnlFeesSummary);
            Controls.Add(pnlPlansSummary);
            Controls.Add(pnlCompetitionsSummary);
            Controls.Add(pnlSwimmersSummary);
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
            pnlSwimmersSummary.ResumeLayout(false);
            pnlPlansSummary.ResumeLayout(false);
            pnlFeesSummary.ResumeLayout(false);
            pnlCompetitionsSummary.ResumeLayout(false);
            pnlSwimmers.ResumeLayout(false);
            pnlTrainingPlans.ResumeLayout(false);
            pnlCompetitionCategories.ResumeLayout(false);
            pnlFeeCalculator.ResumeLayout(false);
            pnlFeeHistory.ResumeLayout(false);
            pnlReports.ResumeLayout(false);
            pnlUserManagement.ResumeLayout(false);
            pnlAudit.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlHeader;
        private Label lblDashboardTitle;
        private Label lblDashboardSubtitle;
        private Label lblRole;
        private Label lblWelcome;
        private Button btnLogout;
        private ComboBox cmbRolePreview;
        private Panel pnlSwimmersSummary;
        private Label lblSwimmerCount;
        private Label lblSwimmersTitle;
        private Panel pnlPlansSummary;
        private Label lblPlanCount;
        private Label lblPlansTitle;
        private Panel pnlFeesSummary;
        private Label lblMonthlyFees;
        private Label lblMonthlyFeesTitle;
        private Panel pnlCompetitionsSummary;
        private Label lblCompetitionCount;
        private Label lblCompetitionsTitle;
        private Panel pnlSwimmers;
        private Label lblSwimmersCardTitle;
        private Button btnSwimmers;
        private Panel pnlTrainingPlans;
        private Button btnTrainingPlans;
        private Label lblTrainingPlansTitle;
        private Panel pnlCompetitionCategories;
        private Button btnCompetitionCategories;
        private Label lblCompetitionCategoriesTitle;
        private Panel pnlFeeCalculator;
        private Button btnFeeCalculator;
        private Label lblFeeCalculatorTitle;
        private Panel pnlFeeHistory;
        private Button btnFeeHistory;
        private Label lblFeeHistoryTitle;
        private Panel pnlReports;
        private Button btnReports;
        private Label lblReportsTitle;
        private Panel pnlUserManagement;
        private Button btnUserManagement;
        private Label lblUserManagementTitle;
        private Panel pnlAudit;
        private Button btnAuditLog;
        private Label lblAuditTitle;
        private LinkLabel lnkGoToRegister;
    }
}
