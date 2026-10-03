namespace SwimProAcadamy
{
    partial class FrmCompetitionCategories
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
            pnlCategoryHeader = new Panel();
            lblCategoryTitle = new Label();
            pnlCategoryInput = new Panel();
            lblCategoryName = new Label();
            txtCategoryName = new TextBox();
            lblMinAge = new Label();
            nudMinAge = new NumericUpDown();
            lblMaxAge = new Label();
            nudMaxAge = new NumericUpDown();
            chkCategoryActive = new CheckBox();
            btnAddCategory = new Button();
            btnUpdateCategory = new Button();
            btnDeleteCategory = new Button();
            btnClearCategory = new Button();
            dgvCategories = new DataGridView();
            pnlCategoryHeader.SuspendLayout();
            pnlCategoryInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudMinAge).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudMaxAge).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvCategories).BeginInit();
            SuspendLayout();
            // 
            // pnlCategoryHeader
            // 
            pnlCategoryHeader.BackColor = Color.MidnightBlue;
            pnlCategoryHeader.Controls.Add(lblCategoryTitle);
            pnlCategoryHeader.Dock = DockStyle.Top;
            pnlCategoryHeader.Location = new Point(0, 0);
            pnlCategoryHeader.Name = "pnlCategoryHeader";
            pnlCategoryHeader.Size = new Size(1178, 70);
            pnlCategoryHeader.TabIndex = 0;
            // 
            // lblCategoryTitle
            // 
            lblCategoryTitle.AutoSize = true;
            lblCategoryTitle.BackColor = Color.Transparent;
            lblCategoryTitle.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCategoryTitle.ForeColor = Color.White;
            lblCategoryTitle.Location = new Point(30, 20);
            lblCategoryTitle.Name = "lblCategoryTitle";
            lblCategoryTitle.Size = new Size(706, 54);
            lblCategoryTitle.TabIndex = 0;
            lblCategoryTitle.Text = "Competition Category Management";
            // 
            // pnlCategoryInput
            // 
            pnlCategoryInput.BackColor = Color.White;
            pnlCategoryInput.Controls.Add(btnClearCategory);
            pnlCategoryInput.Controls.Add(btnDeleteCategory);
            pnlCategoryInput.Controls.Add(btnUpdateCategory);
            pnlCategoryInput.Controls.Add(btnAddCategory);
            pnlCategoryInput.Controls.Add(chkCategoryActive);
            pnlCategoryInput.Controls.Add(nudMaxAge);
            pnlCategoryInput.Controls.Add(nudMinAge);
            pnlCategoryInput.Controls.Add(txtCategoryName);
            pnlCategoryInput.Controls.Add(lblMaxAge);
            pnlCategoryInput.Controls.Add(lblMinAge);
            pnlCategoryInput.Controls.Add(lblCategoryName);
            pnlCategoryInput.Location = new Point(30, 95);
            pnlCategoryInput.Name = "pnlCategoryInput";
            pnlCategoryInput.Size = new Size(1040, 230);
            pnlCategoryInput.TabIndex = 1;
            // 
            // lblCategoryName
            // 
            lblCategoryName.AutoSize = true;
            lblCategoryName.BackColor = Color.Transparent;
            lblCategoryName.ForeColor = Color.Black;
            lblCategoryName.Location = new Point(30, 20);
            lblCategoryName.Name = "lblCategoryName";
            lblCategoryName.Size = new Size(149, 28);
            lblCategoryName.TabIndex = 0;
            lblCategoryName.Text = "Category Name";
            // 
            // txtCategoryName
            // 
            txtCategoryName.BorderStyle = BorderStyle.FixedSingle;
            txtCategoryName.Location = new Point(30, 45);
            txtCategoryName.Name = "txtCategoryName";
            txtCategoryName.PlaceholderText = "Enter category name";
            txtCategoryName.Size = new Size(300, 34);
            txtCategoryName.TabIndex = 1;
            // 
            // lblMinAge
            // 
            lblMinAge.AutoSize = true;
            lblMinAge.BackColor = Color.Transparent;
            lblMinAge.ForeColor = Color.Black;
            lblMinAge.Location = new Point(360, 20);
            lblMinAge.Name = "lblMinAge";
            lblMinAge.Size = new Size(136, 28);
            lblMinAge.TabIndex = 0;
            lblMinAge.Text = "Minimum Age";
            // 
            // nudMinAge
            // 
            nudMinAge.Location = new Point(396, 50);
            nudMinAge.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudMinAge.Name = "nudMinAge";
            nudMinAge.Size = new Size(154, 34);
            nudMinAge.TabIndex = 2;
            nudMinAge.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // lblMaxAge
            // 
            lblMaxAge.AutoSize = true;
            lblMaxAge.BackColor = Color.Transparent;
            lblMaxAge.ForeColor = Color.Black;
            lblMaxAge.Location = new Point(530, 20);
            lblMaxAge.Name = "lblMaxAge";
            lblMaxAge.Size = new Size(139, 28);
            lblMaxAge.TabIndex = 0;
            lblMaxAge.Text = "Maximum Age";
            // 
            // nudMaxAge
            // 
            nudMaxAge.Location = new Point(583, 50);
            nudMaxAge.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudMaxAge.Name = "nudMaxAge";
            nudMaxAge.Size = new Size(154, 34);
            nudMaxAge.TabIndex = 2;
            nudMaxAge.Value = new decimal(new int[] { 100, 0, 0, 0 });
            // 
            // chkCategoryActive
            // 
            chkCategoryActive.AutoSize = true;
            chkCategoryActive.Checked = true;
            chkCategoryActive.CheckState = CheckState.Checked;
            chkCategoryActive.Cursor = Cursors.Hand;
            chkCategoryActive.Location = new Point(720, 52);
            chkCategoryActive.Name = "chkCategoryActive";
            chkCategoryActive.Size = new Size(92, 32);
            chkCategoryActive.TabIndex = 3;
            chkCategoryActive.Text = "Active";
            chkCategoryActive.UseVisualStyleBackColor = true;
            // 
            // btnAddCategory
            // 
            btnAddCategory.BackColor = Color.DodgerBlue;
            btnAddCategory.Cursor = Cursors.Hand;
            btnAddCategory.FlatAppearance.BorderSize = 0;
            btnAddCategory.FlatStyle = FlatStyle.Flat;
            btnAddCategory.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddCategory.ForeColor = Color.White;
            btnAddCategory.Location = new Point(30, 120);
            btnAddCategory.Name = "btnAddCategory";
            btnAddCategory.Size = new Size(180, 40);
            btnAddCategory.TabIndex = 4;
            btnAddCategory.Text = "Add Category";
            btnAddCategory.UseVisualStyleBackColor = false;
            // 
            // btnUpdateCategory
            // 
            btnUpdateCategory.BackColor = Color.SteelBlue;
            btnUpdateCategory.Cursor = Cursors.Hand;
            btnUpdateCategory.FlatAppearance.BorderSize = 0;
            btnUpdateCategory.FlatStyle = FlatStyle.Flat;
            btnUpdateCategory.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdateCategory.ForeColor = Color.White;
            btnUpdateCategory.Location = new Point(229, 120);
            btnUpdateCategory.Name = "btnUpdateCategory";
            btnUpdateCategory.Size = new Size(130, 40);
            btnUpdateCategory.TabIndex = 4;
            btnUpdateCategory.Text = "Update";
            btnUpdateCategory.UseVisualStyleBackColor = false;
            // 
            // btnDeleteCategory
            // 
            btnDeleteCategory.BackColor = Color.IndianRed;
            btnDeleteCategory.Cursor = Cursors.Hand;
            btnDeleteCategory.FlatAppearance.BorderSize = 0;
            btnDeleteCategory.FlatStyle = FlatStyle.Flat;
            btnDeleteCategory.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDeleteCategory.ForeColor = Color.White;
            btnDeleteCategory.Location = new Point(377, 120);
            btnDeleteCategory.Name = "btnDeleteCategory";
            btnDeleteCategory.Size = new Size(130, 40);
            btnDeleteCategory.TabIndex = 4;
            btnDeleteCategory.Text = "Delete";
            btnDeleteCategory.UseVisualStyleBackColor = false;
            // 
            // btnClearCategory
            // 
            btnClearCategory.BackColor = Color.Gray;
            btnClearCategory.Cursor = Cursors.Hand;
            btnClearCategory.FlatAppearance.BorderSize = 0;
            btnClearCategory.FlatStyle = FlatStyle.Flat;
            btnClearCategory.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClearCategory.ForeColor = Color.White;
            btnClearCategory.Location = new Point(530, 120);
            btnClearCategory.Name = "btnClearCategory";
            btnClearCategory.Size = new Size(130, 40);
            btnClearCategory.TabIndex = 4;
            btnClearCategory.Text = "Clear";
            btnClearCategory.UseVisualStyleBackColor = false;
            // 
            // dgvCategories
            // 
            dgvCategories.AllowUserToAddRows = false;
            dgvCategories.AllowUserToResizeRows = false;
            dgvCategories.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCategories.BackgroundColor = Color.White;
            dgvCategories.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCategories.Location = new Point(30, 345);
            dgvCategories.MultiSelect = false;
            dgvCategories.Name = "dgvCategories";
            dgvCategories.ReadOnly = true;
            dgvCategories.RowHeadersVisible = false;
            dgvCategories.RowHeadersWidth = 62;
            dgvCategories.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCategories.Size = new Size(1040, 270);
            dgvCategories.TabIndex = 2;
            // 
            // FrmCompetitionCategories
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(1178, 644);
            Controls.Add(dgvCategories);
            Controls.Add(pnlCategoryInput);
            Controls.Add(pnlCategoryHeader);
            Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FrmCompetitionCategories";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SwimPro Academy - Competition Categories";
            pnlCategoryHeader.ResumeLayout(false);
            pnlCategoryHeader.PerformLayout();
            pnlCategoryInput.ResumeLayout(false);
            pnlCategoryInput.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudMinAge).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudMaxAge).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvCategories).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlCategoryHeader;
        private Label lblCategoryTitle;
        private Panel pnlCategoryInput;
        private NumericUpDown nudMinAge;
        private TextBox txtCategoryName;
        private Label lblMinAge;
        private Label lblCategoryName;
        private Button btnAddCategory;
        private CheckBox chkCategoryActive;
        private NumericUpDown nudMaxAge;
        private Label lblMaxAge;
        private Button btnClearCategory;
        private Button btnDeleteCategory;
        private Button btnUpdateCategory;
        private DataGridView dgvCategories;
    }
}