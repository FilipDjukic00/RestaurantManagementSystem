using RestaurantManagementSystem.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantManagementSystem.Models
{
    public class Invoice
    {
        public int InvoiceId { get; set; }

        public DateTime CreatedAt { get; set; }

        public int CreatedByUserId { get; set; }

        public decimal TotalPrice { get; set; }

        public InvoiceStatus Status { get; set; }
    }
}
