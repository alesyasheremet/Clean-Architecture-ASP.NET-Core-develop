using CustomerData.Domain.Common;
using System;

namespace CustomerData.Domain.Entities
{
    public class Transaction : BaseEntity<Guid>
    {
        public decimal Amount { get; set; }
        public DateTime Date { get; set; }
        public Account Account { get; set; }

        public string AccountId { get; set; }
    }
}
