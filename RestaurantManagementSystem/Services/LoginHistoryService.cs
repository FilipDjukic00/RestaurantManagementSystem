using Microsoft.Data.SqlClient;
using RestaurantManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace RestaurantManagementSystem.Services
{
    public class LoginHistoryService
    {
        private readonly DatabaseService databaseService;

        public LoginHistoryService()
        {
            databaseService = new DatabaseService();
        }
        public List<LoginHistory> GetLoginHistory()
        {
            List<LoginHistory> history = new List<LoginHistory>();

            string query =
                @"SELECT
                LoginHistoryId,
                UserId,
                Username,
                LoginTime,
                IsSuccessful
              FROM LoginHistory
              ORDER BY LoginTime DESC";

            using (SqlConnection connection = databaseService.GetConnection())
            {
                connection.Open();

                using (SqlCommand command =
                    new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader =
                        command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            LoginHistory login =
                                new LoginHistory();

                            login.LoginHistoryId =
                                reader.GetInt32(0);

                            if (reader.IsDBNull(1))
                            {
                                login.UserId = null;
                            }
                            else
                            {
                                login.UserId =
                                    reader.GetInt32(1);
                            }

                            login.Username =
                                reader.GetString(2);

                            login.LoginTime =
                                reader.GetDateTime(3);

                            login.IsSuccessful =
                                reader.GetBoolean(4);

                            history.Add(login);
                        }
                    }
                }
            }

            return history;
        }
        public void AddLoginHistory(int? userId, string username, bool isSuccessful)
        {
            string query =
                @"INSERT INTO LoginHistory
                (
                    UserId,
                    Username,
                    LoginTime,
                    IsSuccessful
                )
                VALUES
                (
                    @UserId,
                    @Username,
                    @LoginTime,
                    @IsSuccessful
                )";

            using (SqlConnection connection = databaseService.GetConnection())
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.Add(
                        "@UserId",
                        SqlDbType.Int).Value =
                        userId ?? (object)DBNull.Value;

                    command.Parameters.Add(
                        "@Username",
                        SqlDbType.NVarChar).Value = username;

                    command.Parameters.Add(
                        "@LoginTime",
                        SqlDbType.DateTime).Value = DateTime.Now;

                    command.Parameters.Add(
                        "@IsSuccessful",
                        SqlDbType.Bit).Value = isSuccessful;

                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
