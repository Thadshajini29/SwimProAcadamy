using System;
using System.Data;
using MySql.Data.MySqlClient;
using SwimProAcadamy.Models;

namespace SwimProAcadamy.DAL
{
    public class FeeDAL
    {
        public bool SaveFee(Fee fee)
        {
            using (MySqlConnection connection = DatabaseHelper.GetConnection())
            using (MySqlCommand command = new MySqlCommand(
                @"INSERT INTO fees (swimmer_id, training_fee, competition_fee, coaching_fee, total_fee, fee_month, created_by)
                  VALUES (@swimmerId, @trainingFee, @competitionFee, @coachingFee, @totalFee, @feeMonth, @createdBy)
                  ON DUPLICATE KEY UPDATE 
                  training_fee = VALUES(training_fee),
                  competition_fee = VALUES(competition_fee),
                  coaching_fee = VALUES(coaching_fee),
                  total_fee = VALUES(total_fee),
                  created_by = VALUES(created_by),
                  created_at = CURRENT_TIMESTAMP", connection))
            {
                command.Parameters.AddWithValue("@swimmerId", fee.SwimmerId);
                command.Parameters.AddWithValue("@trainingFee", fee.TrainingFee);
                command.Parameters.AddWithValue("@competitionFee", fee.CompetitionFee);
                command.Parameters.AddWithValue("@coachingFee", fee.CoachingFee);
                command.Parameters.AddWithValue("@totalFee", fee.TotalFee);
                command.Parameters.AddWithValue("@feeMonth", fee.FeeMonth.ToString("yyyy-MM-01"));
                command.Parameters.AddWithValue("@createdBy", fee.CreatedBy > 0 ? fee.CreatedBy : (UserSession.UserId > 0 ? UserSession.UserId : 1));

                connection.Open();
                return command.ExecuteNonQuery() > 0;
            }
        }

        public DataTable GetFeeHistory(string searchSwimmer = "", int studentUserId = 0)
        {
            DataTable table = new DataTable();
            using (MySqlConnection connection = DatabaseHelper.GetConnection())
            {
                string sql = @"SELECT f.id AS ID,
                                      s.name AS `Swimmer Name`,
                                      f.training_fee AS `Training Fee`,
                                      f.competition_fee AS `Competition Fee`,
                                      f.coaching_fee AS `Coaching Fee`,
                                      f.total_fee AS `Total Fee`,
                                      DATE_FORMAT(f.fee_month, '%Y-%m') AS `Fee Month`,
                                      COALESCE(u.full_name, u.username, 'System') AS `Created By`,
                                      f.created_at AS `Date`
                               FROM fees f
                               INNER JOIN swimmers s ON f.swimmer_id = s.id
                               LEFT JOIN users u ON f.created_by = u.id
                               WHERE 1=1";

                if (!string.IsNullOrWhiteSpace(searchSwimmer))
                {
                    sql += " AND s.name LIKE @search";
                }
                if (studentUserId > 0)
                {
                    sql += " AND s.user_id = @studentUserId";
                }

                sql += " ORDER BY f.created_at DESC";

                using (MySqlCommand command = new MySqlCommand(sql, connection))
                {
                    if (!string.IsNullOrWhiteSpace(searchSwimmer))
                        command.Parameters.AddWithValue("@search", "%" + searchSwimmer.Trim() + "%");
                    if (studentUserId > 0)
                        command.Parameters.AddWithValue("@studentUserId", studentUserId);

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                    {
                        adapter.Fill(table);
                    }
                }
            }
            return table;
        }
    }
}
