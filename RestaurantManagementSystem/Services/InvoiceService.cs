using System;
using System.Data;
using System.Collections.Generic;
using System.Text;
using Microsoft.Data.SqlClient;
using RestaurantManagementSystem.Models;

namespace RestaurantManagementSystem.Services
{
    public class InvoiceService
    {
        private readonly DatabaseService databaseService;

        public InvoiceService()
        {
            databaseService = new DatabaseService();
        }
        public int SaveInvoice(List<InvoiceItemView> invoiceItems, int userId)
        {
            if (invoiceItems == null || invoiceItems.Count == 0)
            {
                throw new Exception("Invoice is empty.");
            }
            int invoiceId = 0;
            using (SqlConnection connection = databaseService.GetConnection())
            {
                connection.Open();
                SqlTransaction transaction = connection.BeginTransaction();
                try
                {
                    string invoiceQuery =
                        @"INSERT INTO Invoices
                        (
                            CreatedAt,
                            TotalPrice,
                            CreatedByUserId
                        )
                        VALUES
                        (
                            @CreatedAt,
                            @TotalPrice,
                            @CreatedByUserId
                        );

                        SELECT SCOPE_IDENTITY();";
                    decimal total = CalculateTotal(invoiceItems);
                    using (SqlCommand command = new SqlCommand(invoiceQuery, connection, transaction))
                    {
                        command.Parameters.Add(
                            "@CreatedAt",
                            SqlDbType.DateTime
                        ).Value = DateTime.Now;

                        command.Parameters.Add(
                            "@TotalPrice",
                            SqlDbType.Decimal
                        ).Value = total;

                        command.Parameters.Add(
                            "@CreatedByUserId",
                            System.Data.SqlDbType.Int
                        ).Value = userId;

                        invoiceId = Convert.ToInt32(command.ExecuteScalar());
                    }
                    foreach (InvoiceItemView item in invoiceItems)
                    {
                        string itemQuery =
                            @"INSERT INTO InvoiceItems
                            (
                                InvoiceId,
                                FoodId,
                                SideDishId,
                                FoodPrice,
                                SideDishPrice
                            )
                            VALUES
                            (
                                @InvoiceId,
                                @FoodId,
                                @SideDishId,
                                @FoodPrice,
                                @SideDishPrice
                            )";
                        using (SqlCommand itemCommand = new SqlCommand(itemQuery, connection, transaction))
                        {
                            itemCommand.Parameters.Add(
                                "@InvoiceId",
                                SqlDbType.Int
                            ).Value = invoiceId;


                            itemCommand.Parameters.Add(
                                "@FoodId",
                                SqlDbType.Int
                            ).Value = item.FoodId;


                            itemCommand.Parameters.Add(
                                "@SideDishId",
                                SqlDbType.Int
                            ).Value =
                                item.SideDishId ?? (object)DBNull.Value;


                            itemCommand.Parameters.Add(
                                "@FoodPrice",
                                SqlDbType.Decimal
                            ).Value = item.FoodPrice;


                            itemCommand.Parameters.Add(
                                "@SideDishPrice",
                                SqlDbType.Decimal
                            ).Value = item.SideDishPrice;


                            itemCommand.ExecuteNonQuery();
                        }
                    }
                    transaction.Commit();
                }
                catch
                {
                    transaction.Rollback();
                    throw;
                }
            }
            return invoiceId;
        }
        private decimal CalculateTotal(List<InvoiceItemView> invoiceItems)
        {
            decimal total = 0;

            foreach (InvoiceItemView item in invoiceItems)
            {
                total += item.TotalPrice;
            }

            return total;
        }
        public List<InvoiceView> GetAllInvoices()
        {
            List<InvoiceView> invoices = new List<InvoiceView>();

            string query =
                    @"SELECT
                I.InvoiceId,
                I.CreatedAt,
                U.FullName,
                I.TotalPrice
            FROM Invoices I
            INNER JOIN Users U
                ON I.CreatedByUserId = U.UserId
            ORDER BY I.CreatedAt DESC";

            using (SqlConnection connection = databaseService.GetConnection())
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            InvoiceView invoice = new InvoiceView();

                            invoice.InvoiceId = reader.GetInt32(0);

                            invoice.CreatedAt = reader.GetDateTime(1);

                            invoice.CreatedBy = reader.GetString(2);

                            invoice.TotalPrice = reader.GetDecimal(3);

                            invoices.Add(invoice);
                        }
                    }
                }
            }

            return invoices;
        }
        public List<InvoiceItemDetailsView> GetInvoiceItems(int invoiceId)
        {
            List<InvoiceItemDetailsView> invoiceItems =
                new List<InvoiceItemDetailsView>();

            string query =
                    @"SELECT
                F.Name,
                S.Name,
                II.FoodPrice,
                II.SideDishPrice
              FROM InvoiceItems II
              INNER JOIN Foods F
                  ON II.FoodId = F.FoodId
              LEFT JOIN SideDishes S
                  ON II.SideDishId = S.SideDishId
              WHERE II.InvoiceId = @InvoiceId";

            using (SqlConnection connection = databaseService.GetConnection())
            {
                connection.Open();

                using (SqlCommand command =
                    new SqlCommand(query, connection))
                {
                    command.Parameters.Add(
                        "@InvoiceId", SqlDbType.Int).Value = invoiceId;

                    using (SqlDataReader reader =
                        command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            InvoiceItemDetailsView item =
                                new InvoiceItemDetailsView();

                            item.Food = reader.GetString(0);

                            if (reader.IsDBNull(1))
                            {
                                item.SideDish = "";
                            }
                            else
                            {
                                item.SideDish = reader.GetString(1);
                            }

                            item.FoodPrice = reader.GetDecimal(2);

                            item.SideDishPrice = reader.GetDecimal(3);

                            invoiceItems.Add(item);
                        }
                    }
                }
            }

            return invoiceItems;
        }
    }
}
