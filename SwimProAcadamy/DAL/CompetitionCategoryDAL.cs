using System;
using System.Data;
using MySql.Data.MySqlClient;
using SwimProAcadamy.Models;

namespace SwimProAcadamy.DAL
{
    public class CompetitionCategoryDAL
    {
        public DataTable GetAllCategories()
        {
            DataTable table = new DataTable();
            using (MySqlConnection connection = DatabaseHelper.GetConnection())
            using (MySqlCommand command = new MySqlCommand(
                @"SELECT id AS ID,
                         category_name AS `Category Name`,
                         min_age AS `Minimum Age`,
                         max_age AS `Maximum Age`,
                         IF(is_active = 1, 'Active', 'Inactive') AS Status
                  FROM competition_categories
                  ORDER BY id", connection))
            using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
            {
                adapter.Fill(table);
            }
            return table;
        }

        public bool AddCategory(CompetitionCategory category)
        {
            using (MySqlConnection connection = DatabaseHelper.GetConnection())
            using (MySqlCommand command = new MySqlCommand(
                @"INSERT INTO competition_categories (category_name, min_age, max_age, is_active)
                  VALUES (@name, @minAge, @maxAge, @isActive)", connection))
            {
                command.Parameters.AddWithValue("@name", category.CategoryName.Trim());
                command.Parameters.AddWithValue("@minAge", category.MinimumAge);
                command.Parameters.AddWithValue("@maxAge", category.MaximumAge);
                command.Parameters.AddWithValue("@isActive", category.IsActive ? 1 : 0);
                connection.Open();
                return command.ExecuteNonQuery() == 1;
            }
        }

        public bool UpdateCategory(CompetitionCategory category)
        {
            using (MySqlConnection connection = DatabaseHelper.GetConnection())
            using (MySqlCommand command = new MySqlCommand(
                @"UPDATE competition_categories 
                  SET category_name = @name, min_age = @minAge, max_age = @maxAge, is_active = @isActive
                  WHERE id = @id", connection))
            {
                command.Parameters.AddWithValue("@name", category.CategoryName.Trim());
                command.Parameters.AddWithValue("@minAge", category.MinimumAge);
                command.Parameters.AddWithValue("@maxAge", category.MaximumAge);
                command.Parameters.AddWithValue("@isActive", category.IsActive ? 1 : 0);
                command.Parameters.AddWithValue("@id", category.CompetitionCategoryId);
                connection.Open();
                return command.ExecuteNonQuery() == 1;
            }
        }

        public bool DeleteCategory(int categoryId)
        {
            using (MySqlConnection connection = DatabaseHelper.GetConnection())
            using (MySqlCommand command = new MySqlCommand("DELETE FROM competition_categories WHERE id = @id", connection))
            {
                command.Parameters.AddWithValue("@id", categoryId);
                connection.Open();
                return command.ExecuteNonQuery() == 1;
            }
        }
    }
}
