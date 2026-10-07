namespace SwimProAcadamy
{
    partial class FrmAuditLog
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
            pnlAuditHeader = new Panel();
            lblAuditTitle = new Label();
            pnlAuditFilters = new Panel();
            btnAuditShowAll = new Button();
            btnAuditSearch = new Button();
            dtpAuditToDate = new DateTimePicker();
            dtpAuditFromDate = new DateTimePicker();
            cmbAuditAction = new ComboBox();
            cmbAuditUsername = new ComboBox();
            lblAuditFromDate = new Label();
            lblAuditToDate = new Label();
            lblAuditAction = new Label();
            lblAuditUsername = new Label();
            dgvAuditLog = new DataGridView();
            pnlAuditHeader.SuspendLayout();
            pnlAuditFilters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAuditLog).BeginInit();
            SuspendLayout();
            // 
            // pnlAuditHeader
            // 
            pnlAuditHeader.BackColor = Color.MidnightBlue;
            pnlAuditHeader.Controls.Add(lblAuditTitle);
            pnlAuditHeader.Dock = DockStyle.Top;
            pnlAuditHeader.Location = new Point(0, 0);
            pnlAuditHeader.Name = "pnlAuditHeader";
            pnlAuditHeader.Size = new Size(1178, 70);
            pnlAuditHeader.TabIndex = 0;
            // 
            // lblAuditTitle
            // 
            lblAuditTitle.AutoSize = true;
            lblAuditTitle.BackColor = Color.Transparent;
            lblAuditTitle.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAuditTitle.ForeColor = Color.White;
            lblAuditTitle.Location = new Point(30, 20);
            lblAuditTitle.Name = "lblAuditTitle";
            lblAuditTitle.Size = new Size(354, 54);
            lblAuditTitle.TabIndex = 0;
            lblAuditTitle.Text = "System Audit Log";
            // 
            // pnlAuditFilters
            // 
            pnlAuditFilters.BackColor = Color.White;
            pnlAuditFilters.Controls.Add(btnAuditShowAll);
            pnlAuditFilters.Controls.Add(btnAuditSearch);
            pnlAuditFilters.Controls.Add(dtpAuditToDate);
            pnlAuditFilters.Controls.Add(dtpAuditFromDate);
            pnlAuditFilters.Controls.Add(cmbAuditAction);
            pnlAuditFilters.Controls.Add(cmbAuditUsername);
            pnlAuditFilters.Controls.Add(lblAuditFromDate);
            pnlAuditFilters.Controls.Add(lblAuditToDate);
            pnlAuditFilters.Controls.Add(lblAuditAction);
            pnlAuditFilters.Controls.Add(lblAuditUsername);
            pnlAuditFilters.Location = new Point(30, 95);
            pnlAuditFilters.Name = "pnlAuditFilters";
            pnlAuditFilters.Size = new Size(1140, 120);
            pnlAuditFilters.TabIndex = 1;
            // 
            // btnAuditShowAll
            // 
            btnAuditShowAll.BackColor = Color.SteelBlue;
            btnAuditShowAll.Cursor = Cursors.Hand;
            btnAuditShowAll.FlatAppearance.BorderSize = 0;
            btnAuditShowAll.FlatStyle = FlatStyle.Flat;
            btnAuditShowAll.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAuditShowAll.ForeColor = Color.White;
            btnAuditShowAll.Location = new Point(965, 43);
            btnAuditShowAll.Name = "btnAuditShowAll";
            btnAuditShowAll.Size = new Size(120, 40);
            btnAuditShowAll.TabIndex = 5;
            btnAuditShowAll.Text = "Show All";
            btnAuditShowAll.UseVisualStyleBackColor = false;
            btnAuditShowAll.Click += btnAuditShowAll_Click;
            // 
            // btnAuditSearch
            // 
            btnAuditSearch.BackColor = Color.DodgerBlue;
            btnAuditSearch.Cursor = Cursors.Hand;
            btnAuditSearch.FlatAppearance.BorderSize = 0;
            btnAuditSearch.FlatStyle = FlatStyle.Flat;
            btnAuditSearch.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAuditSearch.ForeColor = Color.White;
            btnAuditSearch.Location = new Point(830, 43);
            btnAuditSearch.Name = "btnAuditSearch";
            btnAuditSearch.Size = new Size(120, 40);
            btnAuditSearch.TabIndex = 4;
            btnAuditSearch.Text = "Search";
            btnAuditSearch.UseVisualStyleBackColor = false;
            btnAuditSearch.Click += btnAuditSearch_Click;
            // 
            // dtpAuditToDate
            // 
            dtpAuditToDate.Format = DateTimePickerFormat.Short;
            dtpAuditToDate.Location = new Point(650, 45);
            dtpAuditToDate.Name = "dtpAuditToDate";
            dtpAuditToDate.Size = new Size(150, 34);
            dtpAuditToDate.TabIndex = 3;
            // 
            // dtpAuditFromDate
            // 
            dtpAuditFromDate.Format = DateTimePickerFormat.Short;
            dtpAuditFromDate.Location = new Point(480, 45);
            dtpAuditFromDate.Name = "dtpAuditFromDate";
            dtpAuditFromDate.Size = new Size(150, 34);
            dtpAuditFromDate.TabIndex = 2;
            // 
            // cmbAuditAction
            // 
            cmbAuditAction.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbAuditAction.FormattingEnabled = true;
            cmbAuditAction.Items.AddRange(new object[] { "All Actions", "", "LOGIN", "", "LOGOUT", "", "ADD", "", "UPDATE", "", "DELETE", "", "CALCULATE", "", "EXPORT" });
            cmbAuditAction.Location = new Point(280, 45);
            cmbAuditAction.Name = "cmbAuditAction";
            cmbAuditAction.Size = new Size(180, 36);
            cmbAuditAction.TabIndex = 1;
            // 
            // cmbAuditUsername
            // 
            cmbAuditUsername.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbAuditUsername.FormattingEnabled = true;
            cmbAuditUsername.Location = new Point(30, 45);
            cmbAuditUsername.Name = "cmbAuditUsername";
            cmbAuditUsername.Size = new Size(220, 36);
            cmbAuditUsername.TabIndex = 0;
            // 
            // lblAuditFromDate
            // 
            lblAuditFromDate.AutoSize = true;
            lblAuditFromDate.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAuditFromDate.ForeColor = Color.MidnightBlue;
            lblAuditFromDate.Location = new Point(480, 20);
            lblAuditFromDate.Name = "lblAuditFromDate";
            lblAuditFromDate.Size = new Size(111, 28);
            lblAuditFromDate.TabIndex = 0;
            lblAuditFromDate.Text = "From Date";
            // 
            // lblAuditToDate
            // 
            lblAuditToDate.AutoSize = true;
            lblAuditToDate.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAuditToDate.ForeColor = Color.MidnightBlue;
            lblAuditToDate.Location = new Point(650, 20);
            lblAuditToDate.Name = "lblAuditToDate";
            lblAuditToDate.Size = new Size(85, 28);
            lblAuditToDate.TabIndex = 0;
            lblAuditToDate.Text = "To Date";
            // 
            // lblAuditAction
            // 
            lblAuditAction.AutoSize = true;
            lblAuditAction.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAuditAction.ForeColor = Color.MidnightBlue;
            lblAuditAction.Location = new Point(280, 20);
            lblAuditAction.Name = "lblAuditAction";
            lblAuditAction.Size = new Size(74, 28);
            lblAuditAction.TabIndex = 0;
            lblAuditAction.Text = "Action";
            // 
            // lblAuditUsername
            // 
            lblAuditUsername.AutoSize = true;
            lblAuditUsername.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAuditUsername.ForeColor = Color.MidnightBlue;
            lblAuditUsername.Location = new Point(30, 20);
            lblAuditUsername.Name = "lblAuditUsername";
            lblAuditUsername.Size = new Size(106, 28);
            lblAuditUsername.TabIndex = 0;
            lblAuditUsername.Text = "Username";
            // 
            // dgvAuditLog
            // 
            dgvAuditLog.AllowUserToAddRows = false;
            dgvAuditLog.AllowUserToResizeRows = false;
            dgvAuditLog.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAuditLog.BackgroundColor = Color.White;
            dgvAuditLog.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAuditLog.Location = new Point(30, 245);
            dgvAuditLog.MultiSelect = false;
            dgvAuditLog.Name = "dgvAuditLog";
            dgvAuditLog.ReadOnly = true;
            dgvAuditLog.RowHeadersVisible = false;
            dgvAuditLog.RowHeadersWidth = 62;
            dgvAuditLog.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAuditLog.Size = new Size(1140, 380);
            dgvAuditLog.TabIndex = 6;
            dgvAuditLog.CellContentClick += dgvAuditLog_CellContentClick;
            // 
            // FrmAuditLog
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(1178, 644);
            Controls.Add(dgvAuditLog);
            Controls.Add(pnlAuditFilters);
            Controls.Add(pnlAuditHeader);
            Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MinimizeBox = false;
            Name = "FrmAuditLog";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SwimPro Academy - Audit Log";
            pnlAuditHeader.ResumeLayout(false);
            pnlAuditHeader.PerformLayout();
            pnlAuditFilters.ResumeLayout(false);
            pnlAuditFilters.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAuditLog).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlAuditHeader;
        private Label lblAuditTitle;
        private Panel pnlAuditFilters;
        private ComboBox cmbAuditUsername;
        private Label lblAuditUsername;
        private ComboBox cmbAuditAction;
        private Label lblAuditAction;
        private Button btnAuditSearch;
        private DateTimePicker dtpAuditToDate;
        private DateTimePicker dtpAuditFromDate;
        private Label lblAuditFromDate;
        private Label lblAuditToDate;
        private Button btnAuditShowAll;
        private DataGridView dgvAuditLog;
    }
}