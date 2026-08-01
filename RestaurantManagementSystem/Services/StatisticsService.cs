using Microsoft.Data.SqlClient;
using RestaurantManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantManagementSystem.Services
{
    public class StatisticsService
    {
        private readonly DatabaseService databaseService;

        public StatisticsService()
        {
            databaseService = new DatabaseService();
        }
        public StatisticsView GetStatistics()
        {
            StatisticsView statistics = new StatisticsView();

            statistics.TotalFoods = GetTotalFoods();

            statistics.AvailableFoods = GetAvailableFoods();

            statistics.TotalSideDishes = GetTotalSideDishes();

            statistics.AvailableSideDishes = GetAvailableSideDishes();

            statistics.TotalUsers = GetTotalUsers();

            statistics.ActiveUsers = GetActiveUsers();

            statistics.TotalInvoices = GetTotalInvoices();

            statistics.TotalRevenue = GetTotalRevenue();

            statistics.AverageInvoice = GetAverageInvoice();

            return statistics;
        }
        private int ExecuteIntScalar(string query)
        {
            using (SqlConnection connection = databaseService.GetConnection())
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    object result = command.ExecuteScalar();

                    if (result == DBNull.Value)
                    {
                        return 0;
                    }

                    return Convert.ToInt32(result);
                }
            }
        }
        private decimal ExecuteDecimalScalar(string query)
        {
            using (SqlConnection connection = databaseService.GetConnection())
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    object result = command.ExecuteScalar();

                    if (result == DBNull.Value)
                    {
                        return 0;
                    }

                    return Convert.ToDecimal(result);
                }
            }
        }
        private int GetTotalFoods()
        {
            string query =
                @"SELECT COUNT(*)
                FROM Foods";

            return ExecuteIntScalar(query);
        }
        private int GetAvailableFoods()
        {
            string query =
                @"SELECT COUNT(*)
                  FROM Foods
                  WHERE IsAvailable = 1";

            return ExecuteIntScalar(query);
        }
        private int GetTotalSideDishes()
        {
            string query =
                @"SELECT COUNT(*)
                FROM SideDishes";

            return ExecuteIntScalar(query);
        }
        private int GetAvailableSideDishes()
        {
            string query =
                @"SELECT COUNT(*)
                  FROM SideDishes
                  WHERE IsAvailable = 1";

            return ExecuteIntScalar(query);
        }
        private int GetTotalUsers()
        {
            string query =
                @"SELECT COUNT(*)
                FROM Users";

            return ExecuteIntScalar(query);
        }
        private int GetActiveUsers()
        {
            string query =
                @"SELECT COUNT(*)
                  FROM Users
                  WHERE IsActive = 1";

            return ExecuteIntScalar(query);
        }
        private int GetTotalInvoices()
        {
            string query =
                @"SELECT COUNT(*)
                FROM Invoices";

            return ExecuteIntScalar(query);
        }
        private decimal GetTotalRevenue()
        {
            string query =
                @"SELECT SUM(TotalPrice)
                FROM Invoices";

            return ExecuteDecimalScalar(query);
        }
        private decimal GetAverageInvoice()
        {
            string query =
                @"SELECT AVG(TotalPrice)
                FROM Invoices";

            return ExecuteDecimalScalar(query);
        }
        public List<FoodSalesStatistics> GetTopSellingFoods()
        {
            List<FoodSalesStatistics> foods = new List<FoodSalesStatistics>();

            string query =
                @"SELECT
                    F.Name,
                    COUNT(*) AS TimesOrdered
                  FROM InvoiceItems II
                  INNER JOIN Foods F
                      ON II.FoodId = F.FoodId
                  GROUP BY F.Name
                  ORDER BY TimesOrdered DESC";
            using (SqlConnection connection = databaseService.GetConnection())
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            FoodSalesStatistics food = new FoodSalesStatistics();

                            food.FoodName = reader.GetString(0);
                            food.TimesOrdered = reader.GetInt32(1);
                            foods.Add(food);
                        }
                    }
                }
            }
            return foods;
        }
    }
}
