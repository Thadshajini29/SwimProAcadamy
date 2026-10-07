using System;
using System;
using System.Data;
using MySql.Data.MySqlClient;
using SwimProAcadamy.Models;

namespace SwimProAcadamy.DAL
{
    public class SwimmerDal
    {
        public DataTable GetAllSwimmers(string search = "")
        {
            DataTable table = new DataTable();
            using MySqlConnection connection = DatabaseHelper.GetConnection();
            using MySqlCommand command = new MySqlCommand(@"SELECT s.id AS ID, s.name AS `Swimmer Name`, s.age AS Age,
                tp.plan_name AS `Training Plan`, cc.category_name AS `Competition Category`, s.competitions AS Competitions,
                s.coaching_hours AS `Coaching Hours`, IF(s.is_active=1, 'Active', 'Inactive') AS Status,
                s.training_plan_id, s.competition_category_id FROM swimmers s
                INNER JOIN training_plans tp ON s.training_plan_id=tp.id
                LEFT JOIN competition_categories cc ON s.competition_category_id=cc.id
                WHERE s.name LIKE @search ORDER BY s.id", connection);
            command.Parameters.AddWithValue("@search", "%" + search.Trim() + "%");
            using MySqlDataAdapter adapter = new MySqlDataAdapter(command); adapter.Fill(table); return table;
        }

        public bool AddSwimmer(Swimmer swimmer) => Save("INSERT INTO swimmers (name,age,training_plan_id,competition_category_id,competitions,coaching_hours,is_active) VALUES (@name,@age,@planId,@categoryId,@competitions,@coachingHours,@isActive)", swimmer);
        public bool UpdateSwimmer(Swimmer swimmer) => Save("UPDATE swimmers SET name=@name, age=@age, training_plan_id=@planId, competition_category_id=@categoryId, competitions=@competitions, coaching_hours=@coachingHours, is_active=@isActive WHERE id=@id", swimmer);

        public bool DeleteSwimmer(int swimmerId)
        {
            using MySqlConnection connection = DatabaseHelper.GetConnection(); using MySqlCommand command = new MySqlCommand("DELETE FROM swimmers WHERE id=@id", connection);
            command.Parameters.AddWithValue("@id", swimmerId); connection.Open(); return command.ExecuteNonQuery() == 1;
        }

        private static bool Save(string sql, Swimmer swimmer)
        {
            using MySqlConnection connection = DatabaseHelper.GetConnection(); using MySqlCommand command = new MySqlCommand(sql, connection);
            command.Parameters.AddWithValue("@name", swimmer.Name.Trim()); command.Parameters.AddWithValue("@age", swimmer.Age); command.Parameters.AddWithValue("@planId", swimmer.TrainingPlanId);
            command.Parameters.AddWithValue("@categoryId", swimmer.CompetitionCategoryId.HasValue ? swimmer.CompetitionCategoryId.Value : DBNull.Value); command.Parameters.AddWithValue("@competitions", swimmer.Competitions);
            command.Parameters.AddWithValue("@coachingHours", swimmer.CoachingHours); command.Parameters.AddWithValue("@isActive", swimmer.IsActive ? 1 : 0);
            if (sql.StartsWith("UPDATE", StringComparison.OrdinalIgnoreCase)) command.Parameters.AddWithValue("@id", swimmer.SwimmerId);
            connection.Open(); return command.ExecuteNonQuery() == 1;
        }
    }
}
