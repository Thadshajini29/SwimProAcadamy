namespace SwimProAcadamy
{
    partial class FrmReports
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
            pnlReportsHeader = new Panel();
            lblReportsTitle = new Label();
            pnlReportFilters = new Panel();
            btnExport = new Button();
            btnGenerateReport = new Button();
            dtpToDate = new DateTimePicker();
            dtpFromDate = new DateTimePicker();
            cmbReportType = new ComboBox();
            lblToDate = new Label();
            lblFromDate = new Label();
            lblReportType = new Label();
            dgvReports = new DataGridView();
            colID = new DataGridViewTextBoxColumn();
            colSwimmerName = new DataGridViewTextBoxColumn();
            colAge = new DataGridViewTextBoxColumn();
            colTrainingPlan = new DataGridViewTextBoxColumn();
            colCategory = new DataGridViewTextBoxColumn();
            colStatus = new DataGridViewTextBoxColumn();
            lblTotalRecords = new Label();
            lblReportStatus = new Label();
            pnlReportsHeader.SuspendLayout();
            pnlReportFilters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvReports).BeginInit();
            SuspendLayout();
            // 
            // pnlReportsHeader
            // 
            pnlReportsHeader.BackColor = Color.MidnightBlue;
            pnlReportsHeader.Controls.Add(lblReportsTitle);
            pnlReportsHeader.Dock = DockStyle.Top;
            pnlReportsHeader.Location = new Point(0, 0);
            pnlReportsHeader.Name = "pnlReportsHeader";
            pnlReportsHeader.Size = new Size(1178, 70);
            pnlReportsHeader.TabIndex = 4;
            // 
            // lblReportsTitle
            // 
            lblReportsTitle.AutoSize = true;
            lblReportsTitle.BackColor = Color.Transparent;
            lblReportsTitle.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblReportsTitle.ForeColor = Color.White;
            lblReportsTitle.Location = new Point(30, 20);
            lblReportsTitle.Name = "lblReportsTitle";
            lblReportsTitle.Size = new Size(374, 54);
            lblReportsTitle.TabIndex = 0;
            lblReportsTitle.Text = "Reports   Analytics";
            // 
            // pnlReportFilters
            // 
            pnlReportFilters.BackColor = Color.White;
            pnlReportFilters.Controls.Add(btnExport);
            pnlReportFilters.Controls.Add(btnGenerateReport);
            pnlReportFilters.Controls.Add(dtpToDate);
            pnlReportFilters.Controls.Add(dtpFromDate);
            pnlReportFilters.Controls.Add(cmbReportType);
            pnlReportFilters.Controls.Add(lblToDate);
            pnlReportFilters.Controls.Add(lblFromDate);
            pnlReportFilters.Controls.Add(lblReportType);
            pnlReportFilters.Location = new Point(30, 95);
            pnlReportFilters.Name = "pnlReportFilters";
            pnlReportFilters.Size = new Size(1140, 150);
            pnlReportFilters.TabIndex = 5;
            // 
            // btnExport
            // 
            btnExport.BackColor = Color.SteelBlue;
            btnExport.Cursor = Cursors.Hand;
            btnExport.FlatAppearance.BorderSize = 0;
            btnExport.FlatStyle = FlatStyle.Flat;
            btnExport.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExport.ForeColor = Color.White;
            btnExport.Location = new Point(950, 43);
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(120, 40);
            btnExport.TabIndex = 4;
            btnExport.Text = "Export";
            btnExport.UseVisualStyleBackColor = false;
            btnExport.Click += btnExport_Click;
            // 
            // btnGenerateReport
            // 
            btnGenerateReport.BackColor = Color.DodgerBlue;
            btnGenerateReport.Cursor = Cursors.Hand;
            btnGenerateReport.FlatAppearance.BorderSize = 0;
            btnGenerateReport.FlatStyle = FlatStyle.Flat;
            btnGenerateReport.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGenerateReport.ForeColor = Color.White;
            btnGenerateReport.Location = new Point(750, 43);
            btnGenerateReport.Name = "btnGenerateReport";
            btnGenerateReport.Size = new Size(180, 40);
            btnGenerateReport.TabIndex = 3;
            btnGenerateReport.Text = "Generate Report";
            btnGenerateReport.UseVisualStyleBackColor = false;
            btnGenerateReport.Click += btnGenerateReport_Click;
            // 
            // dtpToDate
            // 
            dtpToDate.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpToDate.Format = DateTimePickerFormat.Short;
            dtpToDate.Location = new Point(540, 45);
            dtpToDate.Name = "dtpToDate";
            dtpToDate.Size = new Size(180, 34);
            dtpToDate.TabIndex = 2;
            // 
            // dtpFromDate
            // 
            dtpFromDate.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpFromDate.Format = DateTimePickerFormat.Short;
            dtpFromDate.Location = new Point(340, 45);
            dtpFromDate.Name = "dtpFromDate";
            dtpFromDate.Size = new Size(180, 34);
            dtpFromDate.TabIndex = 1;
            dtpFromDate.ValueChanged += dtpFromDate_ValueChanged;
            // 
            // cmbReportType
            // 
            cmbReportType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbReportType.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbReportType.FormattingEnabled = true;
            cmbReportType.Items.AddRange(new object[] { "All Swimmers", "Monthly Fees", "Competition Entries", "Private Coaching", "Training Plans" });
            cmbReportType.Location = new Point(30, 45);
            cmbReportType.Name = "cmbReportType";
            cmbReportType.Size = new Size(280, 36);
            cmbReportType.TabIndex = 0;
            // 
            // lblToDate
            // 
            lblToDate.AutoSize = true;
            lblToDate.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblToDate.ForeColor = Color.MidnightBlue;
            lblToDate.Location = new Point(540, 20);
            lblToDate.Name = "lblToDate";
            lblToDate.Size = new Size(85, 28);
            lblToDate.TabIndex = 0;
            lblToDate.Text = "To Date";
            // 
            // lblFromDate
            // 
            lblFromDate.AutoSize = true;
            lblFromDate.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFromDate.ForeColor = Color.MidnightBlue;
            lblFromDate.Location = new Point(340, 20);
            lblFromDate.Name = "lblFromDate";
            lblFromDate.Size = new Size(111, 28);
            lblFromDate.TabIndex = 0;
            lblFromDate.Text = "From Date";
            // 
            // lblReportType
            // 
            lblReportType.AutoSize = true;
            lblReportType.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblReportType.ForeColor = Color.MidnightBlue;
            lblReportType.Location = new Point(30, 20);
            lblReportType.Name = "lblReportType";
            lblReportType.Size = new Size(128, 28);
            lblReportType.TabIndex = 0;
            lblReportType.Text = "Report Type";
            // 
            // dgvReports
            // 
            dgvReports.AllowUserToAddRows = false;
            dgvReports.AllowUserToResizeRows = false;
            dgvReports.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvReports.BackgroundColor = Color.White;
            dgvReports.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReports.Columns.AddRange(new DataGridViewColumn[] { colID, colSwimmerName, colAge, colTrainingPlan, colCategory, colStatus });
            dgvReports.Location = new Point(30, 270);
            dgvReports.MultiSelect = false;
            dgvReports.Name = "dgvReports";
            dgvReports.ReadOnly = true;
            dgvReports.RowHeadersVisible = false;
            dgvReports.RowHeadersWidth = 62;
            dgvReports.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvReports.Size = new Size(1140, 350);
            dgvReports.TabIndex = 5;
            // 
            // colID
            // 
            colID.HeaderText = "ID";
            colID.MinimumWidth = 8;
            colID.Name = "colID";
            colID.ReadOnly = true;
            // 
            // colSwimmerName
            // 
            colSwimmerName.HeaderText = "SwimmerName";
            colSwimmerName.MinimumWidth = 8;
            colSwimmerName.Name = "colSwimmerName";
            colSwimmerName.ReadOnly = true;
            // 
            // colAge
            // 
            colAge.HeaderText = "Age";
            colAge.MinimumWidth = 8;
            colAge.Name = "colAge";
            colAge.ReadOnly = true;
            // 
            // colTrainingPlan
            // 
            colTrainingPlan.HeaderText = "TrainingPlan";
            colTrainingPlan.MinimumWidth = 8;
            colTrainingPlan.Name = "colTrainingPlan";
            colTrainingPlan.ReadOnly = true;
            // 
            // colCategory
            // 
            colCategory.HeaderText = "Category";
            colCategory.MinimumWidth = 8;
            colCategory.Name = "colCategory";
            colCategory.ReadOnly = true;
            // 
            // colStatus
            // 
            colStatus.HeaderText = "Status";
            colStatus.MinimumWidth = 8;
            colStatus.Name = "colStatus";
            colStatus.ReadOnly = true;
            // 
            // lblTotalRecords
            // 
            lblTotalRecords.AutoSize = true;
            lblTotalRecords.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalRecords.ForeColor = Color.MidnightBlue;
            lblTotalRecords.Location = new Point(30, 240);
            lblTotalRecords.Name = "lblTotalRecords";
            lblTotalRecords.Size = new Size(163, 28);
            lblTotalRecords.TabIndex = 7;
            lblTotalRecords.Text = "Total Records: 0";
            // 
            // lblReportStatus
            // 
            lblReportStatus.AutoSize = true;
            lblReportStatus.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblReportStatus.ForeColor = Color.DimGray;
            lblReportStatus.Location = new Point(838, 248);
            lblReportStatus.Name = "lblReportStatus";
            lblReportStatus.Size = new Size(332, 25);
            lblReportStatus.TabIndex = 7;
            lblReportStatus.Text = "Select a report and click Generate Report";
            // 
            // FrmReports
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(1178, 644);
            Controls.Add(lblReportStatus);
            Controls.Add(lblTotalRecords);
            Controls.Add(dgvReports);
            Controls.Add(pnlReportFilters);
            Controls.Add(pnlReportsHeader);
            Name = "FrmReports";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SwimPro Academy - Reports";
            pnlReportsHeader.ResumeLayout(false);
            pnlReportsHeader.PerformLayout();
            pnlReportFilters.ResumeLayout(false);
            pnlReportFilters.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvReports).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel pnlReportsHeader;
        private Label lblReportsTitle;
        private Panel pnlReportFilters;
        private ComboBox cmbReportType;
        private Label lblReportType;
        private Button btnGenerateReport;
        private DateTimePicker dtpToDate;
        private DateTimePicker dtpFromDate;
        private Label lblToDate;
        private Label lblFromDate;
        private Button btnExport;
        private DataGridView dgvReports;
        private DataGridViewTextBoxColumn colID;
        private DataGridViewTextBoxColumn colSwimmerName;
        private DataGridViewTextBoxColumn colAge;
        private DataGridViewTextBoxColumn colTrainingPlan;
        private DataGridViewTextBoxColumn colCategory;
        private DataGridViewTextBoxColumn colStatus;
        private Label lblTotalRecords;
        private Label lblReportStatus;
    }
}
