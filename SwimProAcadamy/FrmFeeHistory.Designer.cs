namespace SwimProAcadamy
{
    partial class FrmFeeHistory
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
            pnlHistoryHeader = new Panel();
            lblHistoryTitle = new Label();
            pnlHistorySearch = new Panel();
            lblSearch = new Label();
            txtSearch = new TextBox();
            btnSearch = new Button();
            btnShowAll = new Button();
            btnPrint = new Button();
            dgvFeeHistory = new DataGridView();
            pnlHistoryHeader.SuspendLayout();
            pnlHistorySearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvFeeHistory).BeginInit();
            SuspendLayout();
            // 
            // pnlHistoryHeader
            // 
            pnlHistoryHeader.BackColor = Color.MidnightBlue;
            pnlHistoryHeader.Controls.Add(lblHistoryTitle);
            pnlHistoryHeader.Dock = DockStyle.Top;
            pnlHistoryHeader.Location = new Point(0, 0);
            pnlHistoryHeader.Name = "pnlHistoryHeader";
            pnlHistoryHeader.Size = new Size(1178, 70);
            pnlHistoryHeader.TabIndex = 0;
            // 
            // lblHistoryTitle
            // 
            lblHistoryTitle.AutoSize = true;
            lblHistoryTitle.BackColor = Color.Transparent;
            lblHistoryTitle.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHistoryTitle.ForeColor = Color.White;
            lblHistoryTitle.Location = new Point(30, 20);
            lblHistoryTitle.Name = "lblHistoryTitle";
            lblHistoryTitle.Size = new Size(239, 54);
            lblHistoryTitle.TabIndex = 1;
            lblHistoryTitle.Text = "Fee History";
            // 
            // pnlHistorySearch
            // 
            pnlHistorySearch.BackColor = Color.White;
            pnlHistorySearch.Controls.Add(btnPrint);
            pnlHistorySearch.Controls.Add(btnShowAll);
            pnlHistorySearch.Controls.Add(btnSearch);
            pnlHistorySearch.Controls.Add(txtSearch);
            pnlHistorySearch.Controls.Add(lblSearch);
            pnlHistorySearch.Location = new Point(30, 100);
            pnlHistorySearch.Name = "pnlHistorySearch";
            pnlHistorySearch.Size = new Size(1140, 110);
            pnlHistorySearch.TabIndex = 1;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSearch.ForeColor = Color.MidnightBlue;
            lblSearch.Location = new Point(30, 20);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(169, 28);
            lblSearch.TabIndex = 0;
            lblSearch.Text = "Search Swimmer";
            // 
            // txtSearch
            // 
            txtSearch.BorderStyle = BorderStyle.FixedSingle;
            txtSearch.Location = new Point(30, 45);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Enter swimmer name";
            txtSearch.Size = new Size(350, 34);
            txtSearch.TabIndex = 1;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.DodgerBlue;
            btnSearch.Cursor = Cursors.Hand;
            btnSearch.FlatAppearance.BorderSize = 0;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(400, 45);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(120, 35);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            // 
            // btnShowAll
            // 
            btnShowAll.BackColor = Color.SteelBlue;
            btnShowAll.Cursor = Cursors.Hand;
            btnShowAll.FlatAppearance.BorderSize = 0;
            btnShowAll.FlatStyle = FlatStyle.Flat;
            btnShowAll.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnShowAll.ForeColor = Color.White;
            btnShowAll.Location = new Point(535, 45);
            btnShowAll.Name = "btnShowAll";
            btnShowAll.Size = new Size(120, 35);
            btnShowAll.TabIndex = 2;
            btnShowAll.Text = "Show All";
            btnShowAll.UseVisualStyleBackColor = false;
            // 
            // btnPrint
            // 
            btnPrint.BackColor = Color.DimGray;
            btnPrint.Cursor = Cursors.Hand;
            btnPrint.FlatAppearance.BorderSize = 0;
            btnPrint.FlatStyle = FlatStyle.Flat;
            btnPrint.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPrint.ForeColor = Color.White;
            btnPrint.Location = new Point(990, 45);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(120, 35);
            btnPrint.TabIndex = 2;
            btnPrint.Text = "Print";
            btnPrint.UseVisualStyleBackColor = false;
            // 
            // dgvFeeHistory
            // 
            dgvFeeHistory.AllowUserToAddRows = false;
            dgvFeeHistory.AllowUserToResizeRows = false;
            dgvFeeHistory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvFeeHistory.BackgroundColor = Color.White;
            dgvFeeHistory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFeeHistory.Location = new Point(30, 235);
            dgvFeeHistory.MultiSelect = false;
            dgvFeeHistory.Name = "dgvFeeHistory";
            dgvFeeHistory.ReadOnly = true;
            dgvFeeHistory.RowHeadersVisible = false;
            dgvFeeHistory.RowHeadersWidth = 62;
            dgvFeeHistory.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvFeeHistory.Size = new Size(1140, 390);
            dgvFeeHistory.TabIndex = 2;
            // 
            // FrmFeeHistory
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(1178, 644);
            Controls.Add(dgvFeeHistory);
            Controls.Add(pnlHistorySearch);
            Controls.Add(pnlHistoryHeader);
            Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FrmFeeHistory";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SwimPro Academy - Fee History";
            pnlHistoryHeader.ResumeLayout(false);
            pnlHistoryHeader.PerformLayout();
            pnlHistorySearch.ResumeLayout(false);
            pnlHistorySearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvFeeHistory).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlHistoryHeader;
        private Label lblHistoryTitle;
        private Panel pnlHistorySearch;
        private Button btnSearch;
        private TextBox txtSearch;
        private Label lblSearch;
        private Button btnPrint;
        private Button btnShowAll;
        private DataGridView dgvFeeHistory;
    }
}