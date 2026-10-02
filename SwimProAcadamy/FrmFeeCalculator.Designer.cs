namespace SwimProAcadamy
{
    partial class FrmFeeCalculator
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
            pnlFeeHeader = new Panel();
            lblFeeTitle = new Label();
            pnlSwimmerDetails = new Panel();
            txtSelectedAge = new TextBox();
            txtCoachingHours = new TextBox();
            txtCompetitionCount = new TextBox();
            txtSelectedCategory = new TextBox();
            txtSelectedPlan = new TextBox();
            cmbSwimmer = new ComboBox();
            lblSelectedAge = new Label();
            lblCoachingHours = new Label();
            lblValidationResult = new Label();
            lblAgeValidation = new Label();
            lblCompetitionCount = new Label();
            lblSelectedCategory = new Label();
            lblSelectedPlan = new Label();
            lblSelectSwimmer = new Label();
            pnlCostBreakdown = new Panel();
            btnCalculate = new Button();
            lblTotalCost = new Label();
            lblCoachingCost = new Label();
            lblCompetitionCost = new Label();
            lblTrainingCost = new Label();
            lblCostTitle = new Label();
            pnlFeeHeader.SuspendLayout();
            pnlSwimmerDetails.SuspendLayout();
            pnlCostBreakdown.SuspendLayout();
            SuspendLayout();
            // 
            // pnlFeeHeader
            // 
            pnlFeeHeader.BackColor = Color.MidnightBlue;
            pnlFeeHeader.Controls.Add(lblFeeTitle);
            pnlFeeHeader.Dock = DockStyle.Top;
            pnlFeeHeader.Location = new Point(0, 0);
            pnlFeeHeader.Name = "pnlFeeHeader";
            pnlFeeHeader.Size = new Size(1296, 70);
            pnlFeeHeader.TabIndex = 0;
            // 
            // lblFeeTitle
            // 
            lblFeeTitle.AutoSize = true;
            lblFeeTitle.BackColor = Color.Transparent;
            lblFeeTitle.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFeeTitle.ForeColor = Color.White;
            lblFeeTitle.Location = new Point(30, 20);
            lblFeeTitle.Name = "lblFeeTitle";
            lblFeeTitle.Size = new Size(459, 54);
            lblFeeTitle.TabIndex = 0;
            lblFeeTitle.Text = "Monthly Fee Calculator";
            // 
            // pnlSwimmerDetails
            // 
            pnlSwimmerDetails.BackColor = Color.White;
            pnlSwimmerDetails.Controls.Add(txtSelectedAge);
            pnlSwimmerDetails.Controls.Add(txtCoachingHours);
            pnlSwimmerDetails.Controls.Add(txtCompetitionCount);
            pnlSwimmerDetails.Controls.Add(txtSelectedCategory);
            pnlSwimmerDetails.Controls.Add(txtSelectedPlan);
            pnlSwimmerDetails.Controls.Add(cmbSwimmer);
            pnlSwimmerDetails.Controls.Add(lblSelectedAge);
            pnlSwimmerDetails.Controls.Add(lblCoachingHours);
            pnlSwimmerDetails.Controls.Add(lblValidationResult);
            pnlSwimmerDetails.Controls.Add(lblAgeValidation);
            pnlSwimmerDetails.Controls.Add(lblCompetitionCount);
            pnlSwimmerDetails.Controls.Add(lblSelectedCategory);
            pnlSwimmerDetails.Controls.Add(lblSelectedPlan);
            pnlSwimmerDetails.Controls.Add(lblSelectSwimmer);
            pnlSwimmerDetails.Location = new Point(30, 100);
            pnlSwimmerDetails.Name = "pnlSwimmerDetails";
            pnlSwimmerDetails.Size = new Size(550, 500);
            pnlSwimmerDetails.TabIndex = 1;
            pnlSwimmerDetails.Paint += pnlSwimmerDetails_Paint;
            // 
            // txtSelectedAge
            // 
            txtSelectedAge.BackColor = Color.White;
            txtSelectedAge.Location = new Point(270, 130);
            txtSelectedAge.Name = "txtSelectedAge";
            txtSelectedAge.ReadOnly = true;
            txtSelectedAge.Size = new Size(210, 34);
            txtSelectedAge.TabIndex = 2;
            // 
            // txtCoachingHours
            // 
            txtCoachingHours.BackColor = Color.White;
            txtCoachingHours.Location = new Point(270, 290);
            txtCoachingHours.Name = "txtCoachingHours";
            txtCoachingHours.ReadOnly = true;
            txtCoachingHours.Size = new Size(210, 34);
            txtCoachingHours.TabIndex = 2;
            // 
            // txtCompetitionCount
            // 
            txtCompetitionCount.BackColor = Color.White;
            txtCompetitionCount.Location = new Point(30, 290);
            txtCompetitionCount.Name = "txtCompetitionCount";
            txtCompetitionCount.ReadOnly = true;
            txtCompetitionCount.Size = new Size(210, 34);
            txtCompetitionCount.TabIndex = 2;
            // 
            // txtSelectedCategory
            // 
            txtSelectedCategory.BackColor = Color.White;
            txtSelectedCategory.Location = new Point(30, 210);
            txtSelectedCategory.Name = "txtSelectedCategory";
            txtSelectedCategory.ReadOnly = true;
            txtSelectedCategory.Size = new Size(450, 34);
            txtSelectedCategory.TabIndex = 2;
            // 
            // txtSelectedPlan
            // 
            txtSelectedPlan.BackColor = Color.White;
            txtSelectedPlan.Location = new Point(30, 130);
            txtSelectedPlan.Name = "txtSelectedPlan";
            txtSelectedPlan.ReadOnly = true;
            txtSelectedPlan.Size = new Size(210, 34);
            txtSelectedPlan.TabIndex = 2;
            // 
            // cmbSwimmer
            // 
            cmbSwimmer.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSwimmer.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbSwimmer.FormattingEnabled = true;
            cmbSwimmer.Location = new Point(30, 50);
            cmbSwimmer.Name = "cmbSwimmer";
            cmbSwimmer.Size = new Size(450, 38);
            cmbSwimmer.TabIndex = 1;
            // 
            // lblSelectedAge
            // 
            lblSelectedAge.AutoSize = true;
            lblSelectedAge.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSelectedAge.Location = new Point(270, 105);
            lblSelectedAge.Name = "lblSelectedAge";
            lblSelectedAge.Size = new Size(126, 28);
            lblSelectedAge.TabIndex = 0;
            lblSelectedAge.Text = "Current Age";
            // 
            // lblCoachingHours
            // 
            lblCoachingHours.AutoSize = true;
            lblCoachingHours.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCoachingHours.Location = new Point(270, 265);
            lblCoachingHours.Name = "lblCoachingHours";
            lblCoachingHours.Size = new Size(161, 28);
            lblCoachingHours.TabIndex = 0;
            lblCoachingHours.Text = "Coaching Hours";
            // 
            // lblValidationResult
            // 
            lblValidationResult.AutoSize = true;
            lblValidationResult.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblValidationResult.ForeColor = Color.DimGray;
            lblValidationResult.Location = new Point(30, 380);
            lblValidationResult.Name = "lblValidationResult";
            lblValidationResult.Size = new Size(294, 25);
            lblValidationResult.TabIndex = 0;
            lblValidationResult.Text = "Select a swimmer to check category";
            // 
            // lblAgeValidation
            // 
            lblAgeValidation.AutoSize = true;
            lblAgeValidation.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAgeValidation.ForeColor = Color.MidnightBlue;
            lblAgeValidation.Location = new Point(30, 350);
            lblAgeValidation.Name = "lblAgeValidation";
            lblAgeValidation.Size = new Size(286, 28);
            lblAgeValidation.TabIndex = 0;
            lblAgeValidation.Text = "Competition Category Status";
            // 
            // lblCompetitionCount
            // 
            lblCompetitionCount.AutoSize = true;
            lblCompetitionCount.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCompetitionCount.Location = new Point(30, 265);
            lblCompetitionCount.Name = "lblCompetitionCount";
            lblCompetitionCount.Size = new Size(217, 28);
            lblCompetitionCount.TabIndex = 0;
            lblCompetitionCount.Text = "Competitions Entered";
            // 
            // lblSelectedCategory
            // 
            lblSelectedCategory.AutoSize = true;
            lblSelectedCategory.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSelectedCategory.Location = new Point(30, 185);
            lblSelectedCategory.Name = "lblSelectedCategory";
            lblSelectedCategory.Size = new Size(221, 28);
            lblSelectedCategory.TabIndex = 0;
            lblSelectedCategory.Text = "Competition Category";
            // 
            // lblSelectedPlan
            // 
            lblSelectedPlan.AutoSize = true;
            lblSelectedPlan.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSelectedPlan.Location = new Point(30, 105);
            lblSelectedPlan.Name = "lblSelectedPlan";
            lblSelectedPlan.Size = new Size(136, 28);
            lblSelectedPlan.TabIndex = 0;
            lblSelectedPlan.Text = "Training Plan";
            // 
            // lblSelectSwimmer
            // 
            lblSelectSwimmer.AutoSize = true;
            lblSelectSwimmer.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSelectSwimmer.Location = new Point(30, 25);
            lblSelectSwimmer.Name = "lblSelectSwimmer";
            lblSelectSwimmer.Size = new Size(163, 28);
            lblSelectSwimmer.TabIndex = 0;
            lblSelectSwimmer.Text = "Select Swimmer";
            // 
            // pnlCostBreakdown
            // 
            pnlCostBreakdown.BackColor = Color.White;
            pnlCostBreakdown.Controls.Add(btnCalculate);
            pnlCostBreakdown.Controls.Add(lblTotalCost);
            pnlCostBreakdown.Controls.Add(lblCoachingCost);
            pnlCostBreakdown.Controls.Add(lblCompetitionCost);
            pnlCostBreakdown.Controls.Add(lblTrainingCost);
            pnlCostBreakdown.Controls.Add(lblCostTitle);
            pnlCostBreakdown.Location = new Point(610, 100);
            pnlCostBreakdown.Name = "pnlCostBreakdown";
            pnlCostBreakdown.Size = new Size(550, 500);
            pnlCostBreakdown.TabIndex = 2;
            pnlCostBreakdown.Paint += pnlCostBreakdown_Paint;
            // 
            // btnCalculate
            // 
            btnCalculate.BackColor = Color.DodgerBlue;
            btnCalculate.Cursor = Cursors.Hand;
            btnCalculate.FlatAppearance.BorderSize = 0;
            btnCalculate.FlatStyle = FlatStyle.Flat;
            btnCalculate.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCalculate.ForeColor = Color.White;
            btnCalculate.Location = new Point(30, 360);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(300, 45);
            btnCalculate.TabIndex = 2;
            btnCalculate.Text = "Calculate Monthly Fee";
            btnCalculate.UseVisualStyleBackColor = false;
            // 
            // lblTotalCost
            // 
            lblTotalCost.AutoSize = true;
            lblTotalCost.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalCost.ForeColor = Color.MidnightBlue;
            lblTotalCost.Location = new Point(30, 290);
            lblTotalCost.Name = "lblTotalCost";
            lblTotalCost.Size = new Size(439, 45);
            lblTotalCost.TabIndex = 1;
            lblTotalCost.Text = "Total Monthly Cost: Rs. 0.00";
            // 
            // lblCoachingCost
            // 
            lblCoachingCost.AutoSize = true;
            lblCoachingCost.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCoachingCost.ForeColor = Color.Black;
            lblCoachingCost.Location = new Point(30, 210);
            lblCoachingCost.Name = "lblCoachingCost";
            lblCoachingCost.Size = new Size(260, 30);
            lblCoachingCost.TabIndex = 1;
            lblCoachingCost.Text = "Private Coaching: Rs. 0.00";
            // 
            // lblCompetitionCost
            // 
            lblCompetitionCost.AutoSize = true;
            lblCompetitionCost.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCompetitionCost.ForeColor = Color.Black;
            lblCompetitionCost.Location = new Point(30, 155);
            lblCompetitionCost.Name = "lblCompetitionCost";
            lblCompetitionCost.Size = new Size(259, 30);
            lblCompetitionCost.TabIndex = 1;
            lblCompetitionCost.Text = "Competition Fee: Rs. 0.00";
            // 
            // lblTrainingCost
            // 
            lblTrainingCost.AutoSize = true;
            lblTrainingCost.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTrainingCost.ForeColor = Color.Black;
            lblTrainingCost.Location = new Point(30, 100);
            lblTrainingCost.Name = "lblTrainingCost";
            lblTrainingCost.Size = new Size(215, 30);
            lblTrainingCost.TabIndex = 1;
            lblTrainingCost.Text = "Training Fee: Rs. 0.00";
            // 
            // lblCostTitle
            // 
            lblCostTitle.AutoSize = true;
            lblCostTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCostTitle.ForeColor = Color.MidnightBlue;
            lblCostTitle.Location = new Point(30, 25);
            lblCostTitle.Name = "lblCostTitle";
            lblCostTitle.Size = new Size(447, 48);
            lblCostTitle.TabIndex = 0;
            lblCostTitle.Text = "Monthly Cost Breakdown";
            // 
            // FrmFeeCalculator
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(1296, 777);
            Controls.Add(pnlCostBreakdown);
            Controls.Add(pnlSwimmerDetails);
            Controls.Add(pnlFeeHeader);
            Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FrmFeeCalculator";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SwimPro Academy - Monthly Fee Calculator";
            pnlFeeHeader.ResumeLayout(false);
            pnlFeeHeader.PerformLayout();
            pnlSwimmerDetails.ResumeLayout(false);
            pnlSwimmerDetails.PerformLayout();
            pnlCostBreakdown.ResumeLayout(false);
            pnlCostBreakdown.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlFeeHeader;
        private Label lblFeeTitle;
        private Panel pnlSwimmerDetails;
        private Label lblSelectSwimmer;
        private TextBox txtSelectedAge;
        private TextBox txtSelectedCategory;
        private TextBox txtSelectedPlan;
        private ComboBox cmbSwimmer;
        private Label lblSelectedAge;
        private Label lblSelectedCategory;
        private Label lblSelectedPlan;
        private TextBox txtCompetitionCount;
        private Label lblCompetitionCount;
        private TextBox txtCoachingHours;
        private Label lblCoachingHours;
        private Label lblValidationResult;
        private Label lblAgeValidation;
        private Panel pnlCostBreakdown;
        private Label lblCompetitionCost;
        private Label lblTrainingCost;
        private Label lblCostTitle;
        private Button btnCalculate;
        private Label lblTotalCost;
        private Label lblCoachingCost;
    }
}