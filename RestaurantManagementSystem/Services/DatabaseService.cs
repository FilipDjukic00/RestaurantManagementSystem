using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Data.SqlClient;

namespace RestaurantManagementSystem.Services
{
    public class DatabaseService
    {
        private readonly string connectionString =
        @"Server=(localdb)\MSSQLLocalDB;
          Database=RestaurantManagementDB;
          Trusted_Connection=True;";

        public SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }


        public bool TestConnection()
        {
            try
            {
                using (SqlConnection connection = GetConnection())
                {
                    connection.Open();
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
    }
}
