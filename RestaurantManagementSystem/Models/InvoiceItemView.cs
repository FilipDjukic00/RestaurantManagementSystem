using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantManagementSystem.Models
{
    public class InvoiceItemView
    {
        public int FoodId { get; set; }

        public string FoodName { get; set; }

        public decimal FoodPrice { get; set; }

        public int? SideDishId { get; set; }

        public string SideDishName { get; set; }

        public decimal SideDishPrice { get; set; }

        public decimal TotalPrice
        {
            get
            {
                return FoodPrice + SideDishPrice;
            }
        }
    }
}
