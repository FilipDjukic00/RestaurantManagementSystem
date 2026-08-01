using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantManagementSystem.Models
{
    public class StatisticsView
    {
        public int TotalFoods { get; set; }

        public int AvailableFoods { get; set; }

        public int TotalSideDishes { get; set; }

        public int AvailableSideDishes { get; set; }

        public int TotalUsers { get; set; }

        public int ActiveUsers { get; set; }

        public int TotalInvoices { get; set; }

        public decimal TotalRevenue { get; set; }

        public decimal AverageInvoice { get; set; }
    }
}
