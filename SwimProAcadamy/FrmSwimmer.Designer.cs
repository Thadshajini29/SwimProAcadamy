namespace SwimProAcadamy
{
    partial class FrmSwimmer
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
            pnlSwimmerHeader = new Panel();
            lblSwimmerTitle = new Label();
            pnlSwimmerInput = new Panel();
            btnClear = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnAdd = new Button();
            cmbCompetitionCategory = new ComboBox();
            cmbTrainingPlan = new ComboBox();
            nudCoachingHours = new NumericUpDown();
            nudCompetitions = new NumericUpDown();
            nudAge = new NumericUpDown();
            txtName = new TextBox();
            lblAge = new Label();
            lblCompetitionCategory = new Label();
            lblTrainingPlan = new Label();
            lblCoachingHours = new Label();
            lblCompetitions = new Label();
            lblName = new Label();
            dgvSwimmers = new DataGridView();
            colID = new DataGridViewTextBoxColumn();
            colName = new DataGridViewTextBoxColumn();
            colAge = new DataGridViewTextBoxColumn();
            colTrainingPlan = new DataGridViewTextBoxColumn();
            colCompetitionCategory = new DataGridViewTextBoxColumn();
            colCompetitions = new DataGridViewTextBoxColumn();
            colCoachingHours = new DataGridViewTextBoxColumn();
            pnlSwimmerHeader.SuspendLayout();
            pnlSwimmerInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudCoachingHours).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudCompetitions).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudAge).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvSwimmers).BeginInit();
            SuspendLayout();
            // 
            // pnlSwimmerHeader
            // 
            pnlSwimmerHeader.BackColor = Color.MidnightBlue;
            pnlSwimmerHeader.Controls.Add(lblSwimmerTitle);
            pnlSwimmerHeader.Dock = DockStyle.Top;
            pnlSwimmerHeader.Location = new Point(0, 0);
            pnlSwimmerHeader.Name = "pnlSwimmerHeader";
            pnlSwimmerHeader.Size = new Size(1296, 70);
            pnlSwimmerHeader.TabIndex = 0;
            // 
            // lblSwimmerTitle
            // 
            lblSwimmerTitle.AutoSize = true;
            lblSwimmerTitle.BackColor = Color.Transparent;
            lblSwimmerTitle.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSwimmerTitle.ForeColor = Color.White;
            lblSwimmerTitle.Location = new Point(30, 20);
            lblSwimmerTitle.Name = "lblSwimmerTitle";
            lblSwimmerTitle.Size = new Size(463, 54);
            lblSwimmerTitle.TabIndex = 0;
            lblSwimmerTitle.Text = "Swimmer Management";
            // 
            // pnlSwimmerInput
            // 
            pnlSwimmerInput.BackColor = Color.White;
            pnlSwimmerInput.Controls.Add(btnClear);
            pnlSwimmerInput.Controls.Add(btnDelete);
            pnlSwimmerInput.Controls.Add(btnUpdate);
            pnlSwimmerInput.Controls.Add(btnAdd);
            pnlSwimmerInput.Controls.Add(cmbCompetitionCategory);
            pnlSwimmerInput.Controls.Add(cmbTrainingPlan);
            pnlSwimmerInput.Controls.Add(nudCoachingHours);
            pnlSwimmerInput.Controls.Add(nudCompetitions);
            pnlSwimmerInput.Controls.Add(nudAge);
            pnlSwimmerInput.Controls.Add(txtName);
            pnlSwimmerInput.Controls.Add(lblAge);
            pnlSwimmerInput.Controls.Add(lblCompetitionCategory);
            pnlSwimmerInput.Controls.Add(lblTrainingPlan);
            pnlSwimmerInput.Controls.Add(lblCoachingHours);
            pnlSwimmerInput.Controls.Add(lblCompetitions);
            pnlSwimmerInput.Controls.Add(lblName);
            pnlSwimmerInput.Location = new Point(30, 95);
            pnlSwimmerInput.Name = "pnlSwimmerInput";
            pnlSwimmerInput.Size = new Size(1140, 260);
            pnlSwimmerInput.TabIndex = 1;
            pnlSwimmerInput.Paint += pnlSwimmerInput_Paint;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.Gray;
            btnClear.Cursor = Cursors.Hand;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.ForeColor = Color.White;
            btnClear.Location = new Point(845, 125);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(130, 40);
            btnClear.TabIndex = 4;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.IndianRed;
            btnDelete.Cursor = Cursors.Hand;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(700, 125);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(130, 40);
            btnDelete.TabIndex = 4;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.SteelBlue;
            btnUpdate.Cursor = Cursors.Hand;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(555, 125);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(130, 40);
            btnUpdate.TabIndex = 4;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.DodgerBlue;
            btnAdd.Cursor = Cursors.Hand;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(405, 130);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(130, 40);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            // 
            // cmbCompetitionCategory
            // 
            cmbCompetitionCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCompetitionCategory.FormattingEnabled = true;
            cmbCompetitionCategory.Items.AddRange(new object[] { "Beginner", "", "Intermediate", "", "Advanced" });
            cmbCompetitionCategory.Location = new Point(810, 50);
            cmbCompetitionCategory.Name = "cmbCompetitionCategory";
            cmbCompetitionCategory.Size = new Size(280, 36);
            cmbCompetitionCategory.TabIndex = 3;
            // 
            // cmbTrainingPlan
            // 
            cmbTrainingPlan.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTrainingPlan.FormattingEnabled = true;
            cmbTrainingPlan.Items.AddRange(new object[] { "Beginner", "", "Intermediate", "", "Advanced" });
            cmbTrainingPlan.Location = new Point(550, 50);
            cmbTrainingPlan.Name = "cmbTrainingPlan";
            cmbTrainingPlan.Size = new Size(230, 36);
            cmbTrainingPlan.TabIndex = 3;
            // 
            // nudCoachingHours
            // 
            nudCoachingHours.DecimalPlaces = 1;
            nudCoachingHours.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nudCoachingHours.Location = new Point(220, 130);
            nudCoachingHours.Maximum = new decimal(new int[] { 24, 0, 0, 0 });
            nudCoachingHours.Name = "nudCoachingHours";
            nudCoachingHours.Size = new Size(150, 37);
            nudCoachingHours.TabIndex = 2;
            nudCoachingHours.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // nudCompetitions
            // 
            nudCompetitions.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nudCompetitions.Location = new Point(30, 130);
            nudCompetitions.Maximum = new decimal(new int[] { 20, 0, 0, 0 });
            nudCompetitions.Name = "nudCompetitions";
            nudCompetitions.Size = new Size(150, 37);
            nudCompetitions.TabIndex = 2;
            nudCompetitions.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // nudAge
            // 
            nudAge.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nudAge.Location = new Point(370, 50);
            nudAge.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudAge.Name = "nudAge";
            nudAge.Size = new Size(165, 37);
            nudAge.TabIndex = 2;
            nudAge.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // txtName
            // 
            txtName.BorderStyle = BorderStyle.FixedSingle;
            txtName.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtName.Location = new Point(30, 50);
            txtName.Name = "txtName";
            txtName.PlaceholderText = "Enter swimmer name";
            txtName.Size = new Size(300, 37);
            txtName.TabIndex = 1;
            // 
            // lblAge
            // 
            lblAge.AutoSize = true;
            lblAge.Location = new Point(370, 25);
            lblAge.Name = "lblAge";
            lblAge.Size = new Size(117, 28);
            lblAge.TabIndex = 0;
            lblAge.Text = "Current Age";
            // 
            // lblCompetitionCategory
            // 
            lblCompetitionCategory.AutoSize = true;
            lblCompetitionCategory.Location = new Point(810, 25);
            lblCompetitionCategory.Name = "lblCompetitionCategory";
            lblCompetitionCategory.Size = new Size(247, 28);
            lblCompetitionCategory.TabIndex = 0;
            lblCompetitionCategory.Text = "Competition Age Category";
            // 
            // lblTrainingPlan
            // 
            lblTrainingPlan.AutoSize = true;
            lblTrainingPlan.Location = new Point(550, 25);
            lblTrainingPlan.Name = "lblTrainingPlan";
            lblTrainingPlan.Size = new Size(123, 28);
            lblTrainingPlan.TabIndex = 0;
            lblTrainingPlan.Text = "Training Plan";
            // 
            // lblCoachingHours
            // 
            lblCoachingHours.AutoSize = true;
            lblCoachingHours.Location = new Point(220, 105);
            lblCoachingHours.Name = "lblCoachingHours";
            lblCoachingHours.Size = new Size(216, 28);
            lblCoachingHours.TabIndex = 0;
            lblCoachingHours.Text = "Private Coaching Hours";
            // 
            // lblCompetitions
            // 
            lblCompetitions.AutoSize = true;
            lblCompetitions.Location = new Point(30, 105);
            lblCompetitions.Name = "lblCompetitions";
            lblCompetitions.Size = new Size(202, 28);
            lblCompetitions.TabIndex = 0;
            lblCompetitions.Text = "Competitions Entered";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(30, 25);
            lblName.Name = "lblName";
            lblName.Size = new Size(150, 28);
            lblName.TabIndex = 0;
            lblName.Text = "Swimmer Name";
            // 
            // dgvSwimmers
            // 
            dgvSwimmers.AllowUserToAddRows = false;
            dgvSwimmers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSwimmers.BackgroundColor = Color.White;
            dgvSwimmers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSwimmers.Columns.AddRange(new DataGridViewColumn[] { colID, colName, colAge, colTrainingPlan, colCompetitionCategory, colCompetitions, colCoachingHours });
            dgvSwimmers.Location = new Point(30, 375);
            dgvSwimmers.MultiSelect = false;
            dgvSwimmers.Name = "dgvSwimmers";
            dgvSwimmers.RowHeadersVisible = false;
            dgvSwimmers.RowHeadersWidth = 62;
            dgvSwimmers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSwimmers.Size = new Size(1140, 300);
            dgvSwimmers.TabIndex = 5;
            // 
            // colID
            // 
            colID.HeaderText = "ID";
            colID.MinimumWidth = 8;
            colID.Name = "colID";
            // 
            // colName
            // 
            colName.HeaderText = "Name";
            colName.MinimumWidth = 8;
            colName.Name = "colName";
            // 
            // colAge
            // 
            colAge.HeaderText = "Age";
            colAge.MinimumWidth = 8;
            colAge.Name = "colAge";
            // 
            // colTrainingPlan
            // 
            colTrainingPlan.HeaderText = "TrainingPlan";
            colTrainingPlan.MinimumWidth = 8;
            colTrainingPlan.Name = "colTrainingPlan";
            // 
            // colCompetitionCategory
            // 
            colCompetitionCategory.HeaderText = "CompetitionCategory";
            colCompetitionCategory.MinimumWidth = 8;
            colCompetitionCategory.Name = "colCompetitionCategory";
            // 
            // colCompetitions
            // 
            colCompetitions.HeaderText = "Competitions";
            colCompetitions.MinimumWidth = 8;
            colCompetitions.Name = "colCompetitions";
            // 
            // colCoachingHours
            // 
            colCoachingHours.HeaderText = "CoachingHours";
            colCoachingHours.MinimumWidth = 8;
            colCoachingHours.Name = "colCoachingHours";
            // 
            // FrmSwimmer
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(1296, 777);
            Controls.Add(dgvSwimmers);
            Controls.Add(pnlSwimmerInput);
            Controls.Add(pnlSwimmerHeader);
            Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FrmSwimmer";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SwimPro Academy - Swimmer Management";
            pnlSwimmerHeader.ResumeLayout(false);
            pnlSwimmerHeader.PerformLayout();
            pnlSwimmerInput.ResumeLayout(false);
            pnlSwimmerInput.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudCoachingHours).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudCompetitions).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudAge).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvSwimmers).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlSwimmerHeader;
        private Label lblSwimmerTitle;
        private Panel pnlSwimmerInput;
        private TextBox txtName;
        private Label lblName;
        private NumericUpDown nudAge;
        private Label lblAge;
        private Label lblTrainingPlan;
        private ComboBox cmbCompetitionCategory;
        private ComboBox cmbTrainingPlan;
        private Label lblCompetitionCategory;
        private NumericUpDown nudCoachingHours;
        private NumericUpDown nudCompetitions;
        private Label lblCoachingHours;
        private Label lblCompetitions;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnAdd;
        private Button btnClear;
        private DataGridView dgvSwimmers;
        private DataGridViewTextBoxColumn colID;
        private DataGridViewTextBoxColumn colName;
        private DataGridViewTextBoxColumn colAge;
        private DataGridViewTextBoxColumn colTrainingPlan;
        private DataGridViewTextBoxColumn colCompetitionCategory;
        private DataGridViewTextBoxColumn colCompetitions;
        private DataGridViewTextBoxColumn colCoachingHours;
    }
}