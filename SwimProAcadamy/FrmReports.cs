using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SwimProAcadamy
{
    public partial class FrmReports : Form
    {
        public FrmReports()
        {
            InitializeComponent();
            btnSearch.Click += (s, e) => LoadReports(txtSearch.Text.Trim()); btnShowAll.Click += (s, e) => { txtSearch.Clear(); LoadReports(); }; Load += (s, e) => LoadReports();
        }
        private void LoadReports(string search = "") { try { using MySqlConnection c = new Database().GetConnection(); using MySqlDataAdapter a = new("SELECT f.id AS ID,s.name AS 'Swimmer Name',f.training_fee AS 'Training Fee',f.competition_fee AS 'Competition Fee',f.coaching_fee AS 'Coaching Fee',f.total_fee AS 'Total Fee',f.created_date AS Date FROM fees f INNER JOIN swimmers s ON f.swimmer_id=s.id WHERE s.name LIKE @search ORDER BY f.created_date DESC", c); a.SelectCommand.Parameters.AddWithValue("@search", "%" + search + "%"); DataTable t = new(); a.Fill(t); dgvReports.DataSource = t; } catch (Exception ex) { MessageBox.Show("Unable to load reports. " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error); } }

        private void dgvReports_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
