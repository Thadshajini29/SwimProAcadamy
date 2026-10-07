using System;
using System.Data;
using MySql.Data.MySqlClient;
using SwimProAcadamy.Models;

namespace SwimProAcadamy.DAL
{
    public class TrainingPlanDAL
    {
        public DataTable GetAllPlans()
        {
            DataTable table = new DataTable();
            using (MySqlConnection connection = DatabaseHelper.GetConnection())
            using (MySqlCommand command = new MySqlCommand(
                @"SELECT id AS ID,
                         plan_name AS `Plan Name`,
                         sessions_per_week AS `Sessions Per Week`,
                         weekly_fee AS `Weekly Fee`,
                         IF(competition_allowed = 1, 'Yes', 'No') AS `Competition Allowed`,
                         IF(is_active = 1, 'Active', 'Inactive') AS Status
                  FROM training_plans
                  ORDER BY id", connection))
            using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
            {
                adapter.Fill(table);
            }
            return table;
        }

        public bool AddPlan(TrainingPlan plan)
        {
            using (MySqlConnection connection = DatabaseHelper.GetConnection())
            using (MySqlCommand command = new MySqlCommand(
                @"INSERT INTO training_plans (plan_name, sessions_per_week, weekly_fee, competition_allowed, is_active)
                  VALUES (@name, @sessions, @fee, @compAllowed, @isActive)", connection))
            {
                command.Parameters.AddWithValue("@name", plan.PlanName.Trim());
                command.Parameters.AddWithValue("@sessions", plan.SessionsPerWeek);
                command.Parameters.AddWithValue("@fee", plan.WeeklyFee);
                command.Parameters.AddWithValue("@compAllowed", plan.CompetitionAllowed ? 1 : 0);
                command.Parameters.AddWithValue("@isActive", plan.IsActive ? 1 : 0);
                connection.Open();
                return command.ExecuteNonQuery() == 1;
            }
        }

        public bool UpdatePlan(TrainingPlan plan)
        {
            using (MySqlConnection connection = DatabaseHelper.GetConnection())
            using (MySqlCommand command = new MySqlCommand(
                @"UPDATE training_plans 
                  SET plan_name = @name, sessions_per_week = @sessions, weekly_fee = @fee, competition_allowed = @compAllowed, is_active = @isActive
                  WHERE id = @id", connection))
            {
                command.Parameters.AddWithValue("@name", plan.PlanName.Trim());
                command.Parameters.AddWithValue("@sessions", plan.SessionsPerWeek);
                command.Parameters.AddWithValue("@fee", plan.WeeklyFee);
                command.Parameters.AddWithValue("@compAllowed", plan.CompetitionAllowed ? 1 : 0);
                command.Parameters.AddWithValue("@isActive", plan.IsActive ? 1 : 0);
                command.Parameters.AddWithValue("@id", plan.TrainingPlanId);
                connection.Open();
                return command.ExecuteNonQuery() == 1;
            }
        }

        public bool DeletePlan(int planId)
        {
            using (MySqlConnection connection = DatabaseHelper.GetConnection())
            using (MySqlCommand command = new MySqlCommand("DELETE FROM training_plans WHERE id = @id", connection))
            {
                command.Parameters.AddWithValue("@id", planId);
                connection.Open();
                return command.ExecuteNonQuery() == 1;
            }
        }
    }
}
