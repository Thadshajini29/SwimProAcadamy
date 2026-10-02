using System;
using System.Windows.Forms;

namespace SwimProAcadamy
{
    public partial class FrmDashboard : Form
    {
        public FrmDashboard()
        {
            InitializeComponent();
            btnSwimmers.Click += (s, e) => new FrmSwimmer().ShowDialog();
            btnFeeCalculator.Click += (s, e) => new FrmFeeCalculator().ShowDialog();
            btnReports.Click += (s, e) => new FrmReports().ShowDialog();
            btnLogout.Click += (s, e) => Close();
        }

        private void FrmDashboard_Load(object sender, EventArgs e)
        {

        }
    }
}
