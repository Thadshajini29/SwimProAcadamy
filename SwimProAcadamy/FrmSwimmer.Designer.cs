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
            lblTitle = new Label();
            lblSwimmerName = new Label();
            txtSwimmerName = new TextBox();
            lblAge = new Label();
            txtAge = new TextBox();
            lblTrainingPlan = new Label();
            cmbTrainingPlan = new ComboBox();
            lblCategory = new Label();
            cmbCategory = new ComboBox();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnClear = new Button();
            lblList = new Label();
            dgvSwimmers = new DataGridView();
            colID = new DataGridViewTextBoxColumn();
            colName = new DataGridViewTextBoxColumn();
            colAge = new DataGridViewTextBoxColumn();
            colPlan = new DataGridViewTextBoxColumn();
            colCategory = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvSwimmers).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.BackColor = Color.Transparent;
            lblTitle.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.MidnightBlue;
            lblTitle.Location = new Point(185, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(521, 54);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "SWIMMER MANAGEMENT";
            lblTitle.TextAlign = ContentAlignment.TopCenter;
            lblTitle.Click += lblTitle_Click;
            // 
            // lblSwimmerName
            // 
            lblSwimmerName.AutoSize = true;
            lblSwimmerName.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSwimmerName.ForeColor = Color.Black;
            lblSwimmerName.Location = new Point(157, 140);
            lblSwimmerName.Name = "lblSwimmerName";
            lblSwimmerName.Size = new Size(162, 28);
            lblSwimmerName.TabIndex = 1;
            lblSwimmerName.Text = "Swimmer Name";
            // 
            // txtSwimmerName
            // 
            txtSwimmerName.BackColor = Color.White;
            txtSwimmerName.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSwimmerName.ForeColor = Color.Black;
            txtSwimmerName.Location = new Point(372, 139);
            txtSwimmerName.Name = "txtSwimmerName";
            txtSwimmerName.PlaceholderText = "Enter swimmer name";
            txtSwimmerName.Size = new Size(400, 34);
            txtSwimmerName.TabIndex = 2;
            // 
            // lblAge
            // 
            lblAge.AutoSize = true;
            lblAge.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAge.ForeColor = Color.Black;
            lblAge.Location = new Point(157, 196);
            lblAge.Name = "lblAge";
            lblAge.Size = new Size(126, 28);
            lblAge.TabIndex = 1;
            lblAge.Text = "Current Age";
            // 
            // txtAge
            // 
            txtAge.BackColor = Color.White;
            txtAge.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtAge.ForeColor = Color.Black;
            txtAge.Location = new Point(372, 193);
            txtAge.MaxLength = 2;
            txtAge.Name = "txtAge";
            txtAge.PlaceholderText = "Enter age";
            txtAge.Size = new Size(180, 34);
            txtAge.TabIndex = 2;
            // 
            // lblTrainingPlan
            // 
            lblTrainingPlan.AutoSize = true;
            lblTrainingPlan.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTrainingPlan.ForeColor = Color.Black;
            lblTrainingPlan.Location = new Point(157, 265);
            lblTrainingPlan.Name = "lblTrainingPlan";
            lblTrainingPlan.Size = new Size(136, 28);
            lblTrainingPlan.TabIndex = 1;
            lblTrainingPlan.Text = "Training Plan";
            // 
            // cmbTrainingPlan
            // 
            cmbTrainingPlan.BackColor = Color.White;
            cmbTrainingPlan.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTrainingPlan.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbTrainingPlan.ForeColor = Color.Black;
            cmbTrainingPlan.FormattingEnabled = true;
            cmbTrainingPlan.Items.AddRange(new object[] { "Beginner", "Intermediate", "Advanced" });
            cmbTrainingPlan.Location = new Point(377, 270);
            cmbTrainingPlan.Name = "cmbTrainingPlan";
            cmbTrainingPlan.Size = new Size(220, 36);
            cmbTrainingPlan.TabIndex = 3;
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCategory.ForeColor = Color.Black;
            lblCategory.Location = new Point(157, 342);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(221, 28);
            lblCategory.TabIndex = 1;
            lblCategory.Text = "Competition Category";
            // 
            // cmbCategory
            // 
            cmbCategory.BackColor = Color.White;
            cmbCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCategory.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbCategory.ForeColor = Color.Black;
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Items.AddRange(new object[] { "Junior", "Senior", "Open" });
            cmbCategory.Location = new Point(422, 346);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(400, 36);
            cmbCategory.TabIndex = 4;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.SeaGreen;
            btnAdd.Cursor = Cursors.Hand;
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(135, 428);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(100, 40);
            btnAdd.TabIndex = 5;
            btnAdd.Text = "ADD";
            btnAdd.UseVisualStyleBackColor = false;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.DodgerBlue;
            btnUpdate.Cursor = Cursors.Hand;
            btnUpdate.FlatAppearance.BorderSize = 0;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(278, 428);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(100, 40);
            btnUpdate.TabIndex = 5;
            btnUpdate.Text = "UPDATE";
            btnUpdate.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.IndianRed;
            btnDelete.Cursor = Cursors.Hand;
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(433, 428);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(100, 40);
            btnDelete.TabIndex = 5;
            btnDelete.Text = "DELETE";
            btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.DimGray;
            btnClear.Cursor = Cursors.Hand;
            btnClear.FlatAppearance.BorderSize = 0;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.ForeColor = Color.White;
            btnClear.Location = new Point(571, 428);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(100, 40);
            btnClear.TabIndex = 5;
            btnClear.Text = "CLEAR";
            btnClear.UseVisualStyleBackColor = false;
            // 
            // lblList
            // 
            lblList.AutoSize = true;
            lblList.BackColor = Color.Transparent;
            lblList.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblList.ForeColor = Color.MidnightBlue;
            lblList.Location = new Point(135, 499);
            lblList.Name = "lblList";
            lblList.Size = new Size(188, 32);
            lblList.TabIndex = 1;
            lblList.Text = "SWIMMER LIST";
            // 
            // dgvSwimmers
            // 
            dgvSwimmers.AllowUserToAddRows = false;
            dgvSwimmers.AllowUserToDeleteRows = false;
            dgvSwimmers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSwimmers.BackgroundColor = Color.White;
            dgvSwimmers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSwimmers.Columns.AddRange(new DataGridViewColumn[] { colID, colName, colAge, colPlan, colCategory });
            dgvSwimmers.Location = new Point(135, 550);
            dgvSwimmers.MultiSelect = false;
            dgvSwimmers.Name = "dgvSwimmers";
            dgvSwimmers.ReadOnly = true;
            dgvSwimmers.RowHeadersVisible = false;
            dgvSwimmers.RowHeadersWidth = 62;
            dgvSwimmers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSwimmers.Size = new Size(556, 267);
            dgvSwimmers.TabIndex = 6;
            // 
            // colID
            // 
            colID.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colID.HeaderText = "ID";
            colID.MinimumWidth = 8;
            colID.Name = "colID";
            colID.ReadOnly = true;
            // 
            // colName
            // 
            colName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colName.HeaderText = "Name";
            colName.MinimumWidth = 8;
            colName.Name = "colName";
            colName.ReadOnly = true;
            // 
            // colAge
            // 
            colAge.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colAge.HeaderText = "Age";
            colAge.MinimumWidth = 8;
            colAge.Name = "colAge";
            colAge.ReadOnly = true;
            // 
            // colPlan
            // 
            colPlan.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colPlan.HeaderText = "Training Plan";
            colPlan.MinimumWidth = 8;
            colPlan.Name = "colPlan";
            colPlan.ReadOnly = true;
            // 
            // colCategory
            // 
            colCategory.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colCategory.HeaderText = "Competition Category";
            colCategory.MinimumWidth = 8;
            colCategory.Name = "colCategory";
            colCategory.ReadOnly = true;
            // 
            // FrmSwimmer
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(878, 922);
            Controls.Add(dgvSwimmers);
            Controls.Add(btnClear);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(cmbCategory);
            Controls.Add(cmbTrainingPlan);
            Controls.Add(txtAge);
            Controls.Add(txtSwimmerName);
            Controls.Add(lblList);
            Controls.Add(lblCategory);
            Controls.Add(lblTrainingPlan);
            Controls.Add(lblAge);
            Controls.Add(lblSwimmerName);
            Controls.Add(lblTitle);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FrmSwimmer";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SwimPro Academy - Swimmer Management";
            ((System.ComponentModel.ISupportInitialize)dgvSwimmers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblSwimmerName;
        private TextBox txtSwimmerName;
        private Label lblAge;
        private TextBox txtAge;
        private Label lblTrainingPlan;
        private ComboBox cmbTrainingPlan;
        private Label lblCategory;
        private ComboBox cmbCategory;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnClear;
        private Label lblList;
        private DataGridView dgvSwimmers;
        private DataGridViewTextBoxColumn colID;
        private DataGridViewTextBoxColumn colName;
        private DataGridViewTextBoxColumn colAge;
        private DataGridViewTextBoxColumn colPlan;
        private DataGridViewTextBoxColumn colCategory;
    }
}