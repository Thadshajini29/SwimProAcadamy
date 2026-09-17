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
            lblAcademy = new Label();
            lblAdmin = new Label();
            btnSwimmers = new Button();
            btnFeeCalculator = new Button();
            btnPayments = new Button();
            btnReports = new Button();
            pnlHeader.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.MidnightBlue;
            pnlHeader.Controls.Add(lblAdmin);
            pnlHeader.Controls.Add(lblAcademy);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(878, 70);
            pnlHeader.TabIndex = 0;
            // 
            // lblAcademy
            // 
            lblAcademy.AutoSize = true;
            lblAcademy.BackColor = Color.Transparent;
            lblAcademy.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAcademy.ForeColor = Color.White;
            lblAcademy.Location = new Point(259, 9);
            lblAcademy.Name = "lblAcademy";
            lblAcademy.Size = new Size(377, 48);
            lblAcademy.TabIndex = 0;
            lblAcademy.Text = "SWIMPRO ACADEMY";
            lblAcademy.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblAdmin
            // 
            lblAdmin.AutoSize = true;
            lblAdmin.BackColor = Color.Transparent;
            lblAdmin.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAdmin.ForeColor = Color.White;
            lblAdmin.Location = new Point(733, 25);
            lblAdmin.Name = "lblAdmin";
            lblAdmin.Size = new Size(74, 28);
            lblAdmin.TabIndex = 1;
            lblAdmin.Text = "Admin";
            // 
            // btnSwimmers
            // 
            btnSwimmers.BackColor = Color.White;
            btnSwimmers.Cursor = Cursors.Hand;
            btnSwimmers.FlatStyle = FlatStyle.Flat;
            btnSwimmers.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSwimmers.ForeColor = Color.MidnightBlue;
            btnSwimmers.Location = new Point(135, 136);
            btnSwimmers.Name = "btnSwimmers";
            btnSwimmers.Size = new Size(250, 130);
            btnSwimmers.TabIndex = 1;
            btnSwimmers.Text = "SWIMMERS";
            btnSwimmers.UseVisualStyleBackColor = false;
            // 
            // btnFeeCalculator
            // 
            btnFeeCalculator.BackColor = Color.White;
            btnFeeCalculator.Cursor = Cursors.Hand;
            btnFeeCalculator.FlatStyle = FlatStyle.Flat;
            btnFeeCalculator.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFeeCalculator.ForeColor = Color.MidnightBlue;
            btnFeeCalculator.Location = new Point(445, 136);
            btnFeeCalculator.Name = "btnFeeCalculator";
            btnFeeCalculator.Size = new Size(250, 130);
            btnFeeCalculator.TabIndex = 1;
            btnFeeCalculator.Text = "FEE CALCULATOR";
            btnFeeCalculator.UseVisualStyleBackColor = false;
            // 
            // btnPayments
            // 
            btnPayments.BackColor = Color.White;
            btnPayments.Cursor = Cursors.Hand;
            btnPayments.FlatStyle = FlatStyle.Flat;
            btnPayments.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPayments.ForeColor = Color.MidnightBlue;
            btnPayments.Location = new Point(123, 320);
            btnPayments.Name = "btnPayments";
            btnPayments.Size = new Size(250, 130);
            btnPayments.TabIndex = 1;
            btnPayments.Text = "PAYMENTS";
            btnPayments.UseVisualStyleBackColor = false;
            // 
            // btnReports
            // 
            btnReports.BackColor = Color.White;
            btnReports.Cursor = Cursors.Hand;
            btnReports.FlatStyle = FlatStyle.Flat;
            btnReports.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReports.ForeColor = Color.MidnightBlue;
            btnReports.Location = new Point(445, 320);
            btnReports.Name = "btnReports";
            btnReports.Size = new Size(250, 130);
            btnReports.TabIndex = 1;
            btnReports.Text = "REPORTS";
            btnReports.UseVisualStyleBackColor = false;
            // 
            // FrmDashboard
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(878, 544);
            Controls.Add(btnFeeCalculator);
            Controls.Add(btnReports);
            Controls.Add(btnPayments);
            Controls.Add(btnSwimmers);
            Controls.Add(pnlHeader);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FrmDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SwimPro Academy - Dashboard";
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlHeader;
        private Label lblAdmin;
        private Label lblAcademy;
        private Button btnSwimmers;
        private Button btnFeeCalculator;
        private Button btnPayments;
        private Button btnReports;
    }
}