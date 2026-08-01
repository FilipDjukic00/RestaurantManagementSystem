using Microsoft.Data.SqlClient;
using RestaurantManagementSystem.Enum;
using RestaurantManagementSystem.Models;
using System.Data;

namespace RestaurantManagementSystem.Services
{
    public class UserService
    {
        private readonly DatabaseService databaseService;


        public UserService()
        {
            databaseService = new DatabaseService();
        }


        public User Login(string username, string password)
        {
            User user = null;

            string query =
                @"SELECT 
                    UserId,
                    Username,
                    Password,
                    FullName,
                    Role,
                    IsActive
                  FROM Users
                  WHERE Username = @username
                  AND Password = @password
                  AND IsActive = 1";


            using (SqlConnection connection = databaseService.GetConnection())
            {
                connection.Open();


                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@username", username);
                    command.Parameters.AddWithValue("@password", password);


                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            user = new User();

                            user.UserId = reader.GetInt32(0);

                            user.Username = reader.GetString(1);

                            user.Password = reader.GetString(2);

                            user.FullName = reader.GetString(3);

                            user.Role = (UserRole)reader.GetInt32(4);

                            user.IsActive = reader.GetBoolean(5);
                        }
                    }
                }
            }
            return user;
        }
        public List<User> GetAllUsers()
        {
            List<User> users = new List<User>();

            string query = @"SELECT
                UserId,
                Username,
                Password,
                FullName,
                Role,
                IsActive
              FROM Users
              ORDER BY FullName";

            using (SqlConnection connection = databaseService.GetConnection())
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            User user = new User();

                            user.UserId = reader.GetInt32(0);

                            user.Username = reader.GetString(1);

                            user.Password = reader.GetString(2);

                            user.FullName = reader.GetString(3);

                            user.Role = (UserRole)reader.GetInt32(4);

                            user.IsActive = reader.GetBoolean(5);

                            users.Add(user);
                        }
                    }
                }
            }
            return users;
        }
        public void AddUser(User user)
        {
            string query =
                @"INSERT INTO Users
                (
                    Username,
                    Password,
                    FullName,
                    Role,
                    IsActive
                )
                VALUES
                (
                    @Username,
                    @Password,
                    @FullName,
                    @Role,
                    @IsActive
                )";

            using (SqlConnection connection = databaseService.GetConnection())
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.Add(
                        "@Username",
                        SqlDbType.NVarChar
                    ).Value = user.Username;

                    command.Parameters.Add(
                        "@Password",
                        SqlDbType.NVarChar
                    ).Value = user.Password;

                    command.Parameters.Add(
                        "@FullName",
                        SqlDbType.NVarChar
                    ).Value = user.FullName;

                    command.Parameters.Add(
                        "@Role",
                        SqlDbType.Int
                    ).Value = (int)user.Role;

                    command.Parameters.Add(
                        "@IsActive",
                        SqlDbType.Bit
                    ).Value = user.IsActive;

                    command.ExecuteNonQuery();
                }
            }
        }
        public void UpdateUser(User user)
        {
            string query =
                @"UPDATE Users
                SET
                    Username = @Username,
                    Password = @Password,
                    FullName = @FullName,
                    Role = @Role,
                    IsActive = @IsActive
                WHERE UserId = @UserId";

            using (SqlConnection connection = databaseService.GetConnection())
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.Add(
                        "@UserId",
                        SqlDbType.Int
                    ).Value = user.UserId;

                    command.Parameters.Add(
                        "@Username",
                        SqlDbType.NVarChar
                    ).Value = user.Username;

                    command.Parameters.Add(
                        "@Password",
                        SqlDbType.NVarChar
                    ).Value = user.Password;

                    command.Parameters.Add(
                        "@FullName",
                        SqlDbType.NVarChar
                    ).Value = user.FullName;

                    command.Parameters.Add(
                        "@Role",
                        SqlDbType.Int
                    ).Value = (int)user.Role;

                    command.Parameters.Add(
                        "@IsActive",
                        SqlDbType.Bit
                    ).Value = user.IsActive;

                    command.ExecuteNonQuery();
                }
            }
        }
        public void DeleteUser(int userId)
        {
            string query =
                @"DELETE FROM Users
                WHERE UserId = @UserId";

            using (SqlConnection connection = databaseService.GetConnection())
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.Add(
                        "@UserId",
                        SqlDbType.Int
                    ).Value = userId;

                    command.ExecuteNonQuery();
                }
            }
        }
    }
}