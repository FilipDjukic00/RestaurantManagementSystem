using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantManagementSystem.Models
{
    public class InvoiceItem
    {
        public int InvoiceItemId { get; set; }

        public int InvoiceId { get; set; }

        public int FoodId { get; set; }

        public int? SideDishId { get; set; }

        public decimal FoodPrice { get; set; }

        public decimal SideDishPrice { get; set; }
    }
}
