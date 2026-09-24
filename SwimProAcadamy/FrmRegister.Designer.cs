namespace SwimProAcadamy
{
    partial class FrmRegister
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRegister));
            picBackground = new PictureBox();
            registerCard = new Panel();
            ((System.ComponentModel.ISupportInitialize)picBackground).BeginInit();
            SuspendLayout();
            // 
            // picBackground
            // 
            picBackground.Dock = DockStyle.Fill;
            picBackground.Image = (Image)resources.GetObject("picBackground.Image");
            picBackground.Location = new Point(0, 0);
            picBackground.Name = "picBackground";
            picBackground.Size = new Size(878, 773);
            picBackground.SizeMode = PictureBoxSizeMode.StretchImage;
            picBackground.TabIndex = 0;
            picBackground.TabStop = false;
            picBackground.Click += picBackground_Click;
            // 
            // registerCard
            // 
            registerCard.Anchor = AnchorStyles.None;
            registerCard.Location = new Point(270, 12);
            registerCard.Name = "registerCard";
            registerCard.Size = new Size(450, 620);
            registerCard.TabIndex = 1;
            // 
            // FrmRegister
            // 
            AutoScaleDimensions = new SizeF(144F, 144F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.White;
            ClientSize = new Size(878, 773);
            Controls.Add(registerCard);
            Controls.Add(picBackground);
            MinimumSize = new Size(900, 650);
            Name = "FrmRegister";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SwimPro Academy - Register";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)picBackground).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox picBackground;
        private Panel registerCard;
    }
}