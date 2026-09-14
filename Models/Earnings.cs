using System.Collections.Generic;

namespace CarRentalManagementSystem.Models
{
    public class Earnings
    {
        public decimal TotalEarnings { get; set; }

        public decimal ThisMonthEarnings { get; set; }

        public decimal PendingPayments { get; set; }

        public int CompletedBookings { get; set; }

        public Dictionary<string, decimal> MonthlyEarnings { get; set; }
            = new Dictionary<string, decimal>();
    }
}