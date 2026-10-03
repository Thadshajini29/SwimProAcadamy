namespace SwimProAcadamy
{
    partial class FrmTrainingPlans
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
            pnlTrainingHeader = new Panel();
            lblTrainingTitle = new Label();
            pnlTrainingInput = new Panel();
            lblPlanName = new Label();
            txtPlanName = new TextBox();
            lblMonthlyFee = new Label();
            nudMonthlyFee = new NumericUpDown();
            chkCompetitionAllowed = new CheckBox();
            chkPlanActive = new CheckBox();
            btnAddPlan = new Button();
            btnUpdatePlan = new Button();
            btnDeletePlan = new Button();
            btnClearPlan = new Button();
            dgvTrainingPlans = new DataGridView();
            pnlTrainingHeader.SuspendLayout();
            pnlTrainingInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudMonthlyFee).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvTrainingPlans).BeginInit();
            SuspendLayout();
            // 
            // pnlTrainingHeader
            // 
            pnlTrainingHeader.BackColor = Color.MidnightBlue;
            pnlTrainingHeader.Controls.Add(lblTrainingTitle);
            pnlTrainingHeader.Dock = DockStyle.Top;
            pnlTrainingHeader.Location = new Point(0, 0);
            pnlTrainingHeader.Name = "pnlTrainingHeader";
            pnlTrainingHeader.Size = new Size(1178, 70);
            pnlTrainingHeader.TabIndex = 0;
            // 
            // lblTrainingTitle
            // 
            lblTrainingTitle.AutoSize = true;
            lblTrainingTitle.BackColor = Color.Transparent;
            lblTrainingTitle.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTrainingTitle.ForeColor = Color.White;
            lblTrainingTitle.Location = new Point(30, 20);
            lblTrainingTitle.Name = "lblTrainingTitle";
            lblTrainingTitle.Size = new Size(532, 54);
            lblTrainingTitle.TabIndex = 0;
            lblTrainingTitle.Text = "Training Plan Management";
            // 
            // pnlTrainingInput
            // 
            pnlTrainingInput.BackColor = Color.White;
            pnlTrainingInput.Controls.Add(btnClearPlan);
            pnlTrainingInput.Controls.Add(btnDeletePlan);
            pnlTrainingInput.Controls.Add(btnUpdatePlan);
            pnlTrainingInput.Controls.Add(btnAddPlan);
            pnlTrainingInput.Controls.Add(chkPlanActive);
            pnlTrainingInput.Controls.Add(chkCompetitionAllowed);
            pnlTrainingInput.Controls.Add(nudMonthlyFee);
            pnlTrainingInput.Controls.Add(txtPlanName);
            pnlTrainingInput.Controls.Add(lblMonthlyFee);
            pnlTrainingInput.Controls.Add(lblPlanName);
            pnlTrainingInput.Location = new Point(30, 95);
            pnlTrainingInput.Name = "pnlTrainingInput";
            pnlTrainingInput.Size = new Size(1040, 230);
            pnlTrainingInput.TabIndex = 1;
            // 
            // lblPlanName
            // 
            lblPlanName.AutoSize = true;
            lblPlanName.BackColor = Color.Transparent;
            lblPlanName.ForeColor = Color.Black;
            lblPlanName.Location = new Point(30, 20);
            lblPlanName.Name = "lblPlanName";
            lblPlanName.Size = new Size(106, 28);
            lblPlanName.TabIndex = 0;
            lblPlanName.Text = "Plan Name";
            // 
            // txtPlanName
            // 
            txtPlanName.BorderStyle = BorderStyle.FixedSingle;
            txtPlanName.Location = new Point(30, 45);
            txtPlanName.Name = "txtPlanName";
            txtPlanName.PlaceholderText = "Enter training plan";
            txtPlanName.Size = new Size(280, 34);
            txtPlanName.TabIndex = 1;
            // 
            // lblMonthlyFee
            // 
            lblMonthlyFee.AutoSize = true;
            lblMonthlyFee.BackColor = Color.Transparent;
            lblMonthlyFee.ForeColor = Color.Black;
            lblMonthlyFee.Location = new Point(340, 20);
            lblMonthlyFee.Name = "lblMonthlyFee";
            lblMonthlyFee.Size = new Size(121, 28);
            lblMonthlyFee.TabIndex = 0;
            lblMonthlyFee.Text = "Monthly Fee";
            // 
            // nudMonthlyFee
            // 
            nudMonthlyFee.DecimalPlaces = 2;
            nudMonthlyFee.Increment = new decimal(new int[] { 100, 0, 0, 0 });
            nudMonthlyFee.Location = new Point(340, 45);
            nudMonthlyFee.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            nudMonthlyFee.Name = "nudMonthlyFee";
            nudMonthlyFee.Size = new Size(180, 34);
            nudMonthlyFee.TabIndex = 2;
            // 
            // chkCompetitionAllowed
            // 
            chkCompetitionAllowed.AutoSize = true;
            chkCompetitionAllowed.Cursor = Cursors.Hand;
            chkCompetitionAllowed.Location = new Point(550, 52);
            chkCompetitionAllowed.Name = "chkCompetitionAllowed";
            chkCompetitionAllowed.Size = new Size(224, 32);
            chkCompetitionAllowed.TabIndex = 3;
            chkCompetitionAllowed.Text = "Competition Allowed";
            chkCompetitionAllowed.UseVisualStyleBackColor = true;
            // 
            // chkPlanActive
            // 
            chkPlanActive.AutoSize = true;
            chkPlanActive.Checked = true;
            chkPlanActive.CheckState = CheckState.Checked;
            chkPlanActive.Cursor = Cursors.Hand;
            chkPlanActive.Location = new Point(770, 52);
            chkPlanActive.Name = "chkPlanActive";
            chkPlanActive.Size = new Size(92, 32);
            chkPlanActive.TabIndex = 3;
            chkPlanActive.Text = "Active";
            chkPlanActive.UseVisualStyleBackColor = true;
            // 
            // btnAddPlan
            // 
            btnAddPlan.BackColor = Color.DodgerBlue;
            btnAddPlan.Cursor = Cursors.Hand;
            btnAddPlan.FlatAppearance.BorderSize = 0;
            btnAddPlan.FlatStyle = FlatStyle.Flat;
            btnAddPlan.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddPlan.ForeColor = Color.White;
            btnAddPlan.Location = new Point(30, 120);
            btnAddPlan.Name = "btnAddPlan";
            btnAddPlan.Size = new Size(130, 40);
            btnAddPlan.TabIndex = 4;
            btnAddPlan.Text = "Add Plan";
            btnAddPlan.UseVisualStyleBackColor = false;
            // 
            // btnUpdatePlan
            // 
            btnUpdatePlan.BackColor = Color.SteelBlue;
            btnUpdatePlan.Cursor = Cursors.Hand;
            btnUpdatePlan.FlatAppearance.BorderSize = 0;
            btnUpdatePlan.FlatStyle = FlatStyle.Flat;
            btnUpdatePlan.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdatePlan.ForeColor = Color.White;
            btnUpdatePlan.Location = new Point(175, 120);
            btnUpdatePlan.Name = "btnUpdatePlan";
            btnUpdatePlan.Size = new Size(130, 40);
            btnUpdatePlan.TabIndex = 4;
            btnUpdatePlan.Text = "Update";
            btnUpdatePlan.UseVisualStyleBackColor = false;
            // 
            // btnDeletePlan
            // 
            btnDeletePlan.BackColor = Color.IndianRed;
            btnDeletePlan.Cursor = Cursors.Hand;
            btnDeletePlan.FlatAppearance.BorderSize = 0;
            btnDeletePlan.FlatStyle = FlatStyle.Flat;
            btnDeletePlan.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDeletePlan.ForeColor = Color.White;
            btnDeletePlan.Location = new Point(320, 120);
            btnDeletePlan.Name = "btnDeletePlan";
            btnDeletePlan.Size = new Size(130, 40);
            btnDeletePlan.TabIndex = 4;
            btnDeletePlan.Text = "Delete";
            btnDeletePlan.UseVisualStyleBackColor = false;
            // 
            // btnClearPlan
            // 
            btnClearPlan.BackColor = Color.Gray;
            btnClearPlan.Cursor = Cursors.Hand;
            btnClearPlan.FlatAppearance.BorderSize = 0;
            btnClearPlan.FlatStyle = FlatStyle.Flat;
            btnClearPlan.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClearPlan.ForeColor = Color.White;
            btnClearPlan.Location = new Point(465, 120);
            btnClearPlan.Name = "btnClearPlan";
            btnClearPlan.Size = new Size(130, 40);
            btnClearPlan.TabIndex = 4;
            btnClearPlan.Text = "Clear";
            btnClearPlan.UseVisualStyleBackColor = false;
            // 
            // dgvTrainingPlans
            // 
            dgvTrainingPlans.AllowUserToAddRows = false;
            dgvTrainingPlans.AllowUserToResizeRows = false;
            dgvTrainingPlans.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTrainingPlans.BackgroundColor = Color.White;
            dgvTrainingPlans.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTrainingPlans.Location = new Point(30, 345);
            dgvTrainingPlans.MultiSelect = false;
            dgvTrainingPlans.Name = "dgvTrainingPlans";
            dgvTrainingPlans.ReadOnly = true;
            dgvTrainingPlans.RowHeadersVisible = false;
            dgvTrainingPlans.RowHeadersWidth = 62;
            dgvTrainingPlans.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTrainingPlans.Size = new Size(1040, 270);
            dgvTrainingPlans.TabIndex = 2;
            // 
            // FrmTrainingPlans
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(1178, 644);
            Controls.Add(dgvTrainingPlans);
            Controls.Add(pnlTrainingInput);
            Controls.Add(pnlTrainingHeader);
            Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FrmTrainingPlans";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SwimPro Academy - Training Plans";
            pnlTrainingHeader.ResumeLayout(false);
            pnlTrainingHeader.PerformLayout();
            pnlTrainingInput.ResumeLayout(false);
            pnlTrainingInput.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudMonthlyFee).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvTrainingPlans).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlTrainingHeader;
        private Label lblTrainingTitle;
        private Panel pnlTrainingInput;
        private TextBox txtPlanName;
        private Label lblPlanName;
        private CheckBox chkPlanActive;
        private CheckBox chkCompetitionAllowed;
        private NumericUpDown nudMonthlyFee;
        private Label lblMonthlyFee;
        private Button btnClearPlan;
        private Button btnDeletePlan;
        private Button btnUpdatePlan;
        private Button btnAddPlan;
        private DataGridView dgvTrainingPlans;
    }
}