using Microsoft.Data.SqlClient;
using RestaurantManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace RestaurantManagementSystem.Services
{
    public class SideDishService
    {
        private readonly DatabaseService databaseService;

        public SideDishService()
        {
            databaseService = new DatabaseService();
        }
        public List<SideDish> GetSideDishesForFood(int foodId)
        {
            List<SideDish> sideDishes = new List<SideDish>();

            string query =
                        @"SELECT
                    S.SideDishId,
                    S.Name,
                    S.Price,
                    S.IsAvailable
                FROM SideDishes S
                INNER JOIN FoodSideDishes FSD
                    ON S.SideDishId = FSD.SideDishId
                WHERE FSD.FoodId = @FoodId
                ORDER BY S.Name";

            using (SqlConnection connection = databaseService.GetConnection())
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@FoodId", foodId);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            SideDish sideDish = new SideDish();

                            sideDish.SideDishId = reader.GetInt32(0);
                            sideDish.Name = reader.GetString(1);
                            sideDish.Price = reader.GetDecimal(2);
                            sideDish.IsAvailable = reader.GetBoolean(3);

                            sideDishes.Add(sideDish);
                        }
                    }
                }
            }

            return sideDishes;
        }
        public List<SideDish> GetAllSideDishes()
        {
            List<SideDish> sideDishes = new List<SideDish>();

            string query =
                @"SELECT
                SideDishId,
                Name,
                Price,
                IsAvailable
            FROM SideDishes
            ORDER BY Name";

            using (SqlConnection connection = databaseService.GetConnection())
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            SideDish sideDish = new SideDish();

                            sideDish.SideDishId = reader.GetInt32(0);

                            sideDish.Name = reader.GetString(1);

                            sideDish.Price = reader.GetDecimal(2);

                            sideDish.IsAvailable = reader.GetBoolean(3);

                            sideDishes.Add(sideDish);
                        }
                    }
                }
            }

            return sideDishes;
        }
        public void AddSideDish(SideDish sideDish)
        {
            string query =
                @"INSERT INTO SideDishes
                (
                    Name,
                    Price,
                    IsAvailable
                )
                VALUES
                (
                    @Name,
                    @Price,
                    @IsAvailable
                )";

            using (SqlConnection connection = databaseService.GetConnection())
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.Add(
                        "@Name",
                        SqlDbType.NVarChar
                    ).Value = sideDish.Name;

                    command.Parameters.Add(
                        "@Price",
                        SqlDbType.Decimal
                    ).Value = sideDish.Price;

                    command.Parameters.Add(
                        "@IsAvailable",
                        SqlDbType.Bit
                    ).Value = sideDish.IsAvailable;

                    command.ExecuteNonQuery();
                }
            }
        }
        public void UpdateSideDish(SideDish sideDish)
        {
            string query =
                @"UPDATE SideDishes
                SET
                    Name = @Name,
                    Price = @Price,
                    IsAvailable = @IsAvailable
                WHERE SideDishId = @SideDishId";

            using (SqlConnection connection = databaseService.GetConnection())
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.Add(
                        "@SideDishId",
                        SqlDbType.Int
                    ).Value = sideDish.SideDishId;

                    command.Parameters.Add(
                        "@Name",
                        SqlDbType.NVarChar
                    ).Value = sideDish.Name;

                    command.Parameters.Add(
                        "@Price",
                        SqlDbType.Decimal
                    ).Value = sideDish.Price;

                    command.Parameters.Add(
                        "@IsAvailable",
                        SqlDbType.Bit
                    ).Value = sideDish.IsAvailable;

                    command.ExecuteNonQuery();
                }
            }
        }
        public void DeleteSideDish(int sideDishId)
        {
            string query =
                @"DELETE FROM SideDishes
                WHERE SideDishId = @SideDishId";

            using (SqlConnection connection = databaseService.GetConnection())
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.Add(
                        "@SideDishId",
                        SqlDbType.Int
                    ).Value = sideDishId;

                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
