using System;
using System.Data;
using MySql.Data.MySqlClient;

namespace SwimProAcadamy.DAL
{
    public class ReportDAL
    {
        public DataTable GenerateReport(string reportType, DateTime fromDate, DateTime toDate)
        {
            DataTable table = new DataTable();
            using (MySqlConnection connection = DatabaseHelper.GetConnection())
            {
                string sql = string.Empty;
                MySqlCommand command = new MySqlCommand();
                command.Connection = connection;

                switch (reportType)
                {
                    case "All Swimmers":
                        sql = @"SELECT s.id AS `ID`,
                                       s.name AS `Swimmer Name`,
                                       s.age AS `Age`,
                                       tp.plan_name AS `Training Plan`,
                                       COALESCE(cc.category_name, 'None') AS `Competition Category`,
                                       s.competitions AS `Competitions`,
                                       s.coaching_hours AS `Coaching Hours`,
                                       IF(s.is_active = 1, 'Active', 'Inactive') AS `Status`
                                FROM swimmers s
                                LEFT JOIN training_plans tp ON s.training_plan_id = tp.id
                                LEFT JOIN competition_categories cc ON s.competition_category_id = cc.id
                                ORDER BY s.id";
                        break;

                    case "Monthly Fees":
                        sql = @"SELECT f.id AS `ID`,
                                       s.name AS `Swimmer Name`,
                                       f.training_fee AS `Training Fee`,
                                       f.competition_fee AS `Competition Fee`,
                                       f.coaching_fee AS `Coaching Fee`,
                                       f.total_fee AS `Total Fee`,
                                       DATE_FORMAT(f.fee_month, '%Y-%m') AS `Fee Month`,
                                       COALESCE(u.username, 'System') AS `Created By`,
                                       f.created_at AS `Date`
                                FROM fees f
                                INNER JOIN swimmers s ON f.swimmer_id = s.id
                                LEFT JOIN users u ON f.created_by = u.id
                                WHERE f.created_at >= @fromDate AND f.created_at <= @toDate
                                ORDER BY f.created_at DESC";
                        command.Parameters.AddWithValue("@fromDate", fromDate.Date);
                        command.Parameters.AddWithValue("@toDate", toDate.Date.AddDays(1).AddSeconds(-1));
                        break;

                    case "Competition Entries":
                        sql = @"SELECT s.id AS `Swimmer ID`,
                                       s.name AS `Swimmer Name`,
                                       s.competitions AS `Number of Competitions`,
                                       tp.plan_name AS `Training Plan`,
                                       COALESCE(cc.category_name, 'None') AS `Competition Category`
                                FROM swimmers s
                                LEFT JOIN training_plans tp ON s.training_plan_id = tp.id
                                LEFT JOIN competition_categories cc ON s.competition_category_id = cc.id
                                WHERE s.competitions > 0
                                ORDER BY s.competitions DESC";
                        break;

                    case "Private Coaching":
                        sql = @"SELECT s.id AS `Swimmer ID`,
                                       s.name AS `Swimmer Name`,
                                       s.coaching_hours AS `Coaching Hours`,
                                       (s.coaching_hours * 120) AS `Estimated Coaching Fee (Rs.)`,
                                       tp.plan_name AS `Training Plan`
                                FROM swimmers s
                                LEFT JOIN training_plans tp ON s.training_plan_id = tp.id
                                WHERE s.coaching_hours > 0
                                ORDER BY s.coaching_hours DESC";
                        break;

                    case "Training Plans":
                        sql = @"SELECT tp.id AS `Plan ID`,
                                       tp.plan_name AS `Plan Name`,
                                       tp.sessions_per_week AS `Sessions Per Week`,
                                       tp.weekly_fee AS `Weekly Fee`,
                                       IF(tp.competition_allowed = 1, 'Yes', 'No') AS `Competition Allowed`,
                                       COUNT(s.id) AS `Total Enrolled Swimmers`
                                FROM training_plans tp
                                LEFT JOIN swimmers s ON tp.id = s.training_plan_id
                                GROUP BY tp.id, tp.plan_name, tp.sessions_per_week, tp.weekly_fee, tp.competition_allowed
                                ORDER BY tp.id";
                        break;

                    default:
                        sql = "SELECT 'Select a valid report type' AS Notice";
                        break;
                }

                command.CommandText = sql;
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                {
                    adapter.Fill(table);
                }
            }
            return table;
        }
    }
}
