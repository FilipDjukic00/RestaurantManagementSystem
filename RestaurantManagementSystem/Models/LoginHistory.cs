using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantManagementSystem.Models
{
    public class LoginHistory
    {
        public int LoginHistoryId { get; set; }

        public int? UserId { get; set; }

        public string Username { get; set; }

        public DateTime LoginTime { get; set; }

        public bool IsSuccessful { get; set; }
    }
}
