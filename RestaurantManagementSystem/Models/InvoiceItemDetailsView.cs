using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantManagementSystem.Models
{
    public class InvoiceItemDetailsView
    {
        public string Food { get; set; }

        public string SideDish { get; set; }

        public decimal FoodPrice { get; set; }

        public decimal SideDishPrice { get; set; }

        public decimal Total
        {
            get
            {
                return FoodPrice + SideDishPrice;
            }
        }
    }
}
