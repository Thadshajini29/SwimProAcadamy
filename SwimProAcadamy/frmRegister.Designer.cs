namespace SwimProAcadamy
{
    partial class frmRegister
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
            pnlMainCard = new Panel();
            pnlBrand = new Panel();
            lblBrandName = new Label();
            lblBrandSubtitle = new Label();
            pnlMainCard.SuspendLayout();
            pnlBrand.SuspendLayout();
            SuspendLayout();
            // 
            // pnlMainCard
            // 
            pnlMainCard.BackColor = Color.White;
            pnlMainCard.Controls.Add(pnlBrand);
            pnlMainCard.Location = new Point(12, 12);
            pnlMainCard.Name = "pnlMainCard";
            pnlMainCard.Size = new Size(950, 600);
            pnlMainCard.TabIndex = 0;
            // 
            // pnlBrand
            // 
            pnlBrand.BackColor = Color.WhiteSmoke;
            pnlBrand.Controls.Add(lblBrandSubtitle);
            pnlBrand.Controls.Add(lblBrandName);
            pnlBrand.Dock = DockStyle.Left;
            pnlBrand.Location = new Point(0, 0);
            pnlBrand.Name = "pnlBrand";
            pnlBrand.Size = new Size(430, 600);
            pnlBrand.TabIndex = 0;
            // 
            // lblBrandName
            // 
            lblBrandName.AutoSize = true;
            lblBrandName.BackColor = Color.Transparent;
            lblBrandName.Font = new Font("Segoe UI", 22F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBrandName.ForeColor = Color.MidnightBlue;
            lblBrandName.Location = new Point(3, 15);
            lblBrandName.Name = "lblBrandName";
            lblBrandName.Size = new Size(413, 60);
            lblBrandName.TabIndex = 0;
            lblBrandName.Text = "SwimPro Academy";
            // 
            // lblBrandSubtitle
            // 
            lblBrandSubtitle.AutoSize = true;
            lblBrandSubtitle.BackColor = Color.Transparent;
            lblBrandSubtitle.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBrandSubtitle.ForeColor = Color.DimGray;
            lblBrandSubtitle.Location = new Point(130, 98);
            lblBrandSubtitle.Name = "lblBrandSubtitle";
            lblBrandSubtitle.Size = new Size(210, 30);
            lblBrandSubtitle.TabIndex = 1;
            lblBrandSubtitle.Text = "Create Your Account";
            // 
            // frmRegister
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(1078, 644);
            Controls.Add(pnlMainCard);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "frmRegister";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SwimPro Academy - Register";
            pnlMainCard.ResumeLayout(false);
            pnlBrand.ResumeLayout(false);
            pnlBrand.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlMainCard;
        private Panel pnlBrand;
        private Label lblBrandName;
        private Label lblBrandSubtitle;
    }
}