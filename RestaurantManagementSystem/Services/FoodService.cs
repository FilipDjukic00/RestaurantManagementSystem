using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Data.SqlClient;
using RestaurantManagementSystem.Models;

namespace RestaurantManagementSystem.Services
{
    public class FoodService
    {
        private readonly DatabaseService databaseService;


        public FoodService()
        {
            databaseService = new DatabaseService();
        }


        public List<Food> GetAllFoods()
        {
            List<Food> foods = new List<Food>();

            string query =
                "SELECT FoodId, Name, Price, Description, IsAvailable FROM Foods ORDER BY Name";


            using (SqlConnection connection = databaseService.GetConnection())
            {
                connection.Open();


                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Food food = new Food();

                            food.FoodId = reader.GetInt32(0);
                            food.Name = reader.GetString(1);
                            food.Price = reader.GetDecimal(2);

                            if (!reader.IsDBNull(3))
                                food.Description = reader.GetString(3);

                            food.IsAvailable = reader.GetBoolean(4);


                            foods.Add(food);
                        }
                    }
                }
            }


            return foods;
        }
        public void AddFood(Food food)
        {
            string query =
                @"INSERT INTO Foods
                (
                    Name,
                    Price,
                    Description,
                    IsAvailable
                )
                VALUES
                (
                    @Name,
                    @Price,
                    @Description,
                    @IsAvailable
                )";

            using (SqlConnection connection = databaseService.GetConnection())
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Name", food.Name);
                    command.Parameters.AddWithValue("@Price", food.Price);
                    command.Parameters.AddWithValue("@Description", string.IsNullOrWhiteSpace(food.Description) ? DBNull.Value : food.Description);
                    command.Parameters.AddWithValue("@IsAvailable", food.IsAvailable);
                    command.ExecuteNonQuery();
                }
            }
        }
        public void UpdateFood(Food food)
        {
            string query =
                @"UPDATE Foods
                SET
                    Name = @Name,
                    Price = @Price,
                    Description = @Description,
                    IsAvailable = @IsAvailable
                WHERE FoodId = @FoodId";

            using (SqlConnection connection = databaseService.GetConnection())
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Name", food.Name);
                    command.Parameters.AddWithValue("@Price", food.Price);
                    command.Parameters.AddWithValue("@Description", string.IsNullOrWhiteSpace(food.Description) ? DBNull.Value : food.Description);
                    command.Parameters.AddWithValue("@IsAvailable", food.IsAvailable);
                    command.Parameters.AddWithValue("@FoodId", food.FoodId);
                    command.ExecuteNonQuery();
                }
            }
        }
        public void DeleteFood(int foodId)
        {
            string query = "DELETE FROM Foods WHERE FoodId = @FoodId";

            using (SqlConnection connection = databaseService.GetConnection())
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@FoodId", foodId);
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
