using CustomerData.Domain.Common;
using System;

namespace CustomerData.Domain.Entities
{
    public class Transaction : BaseEntity<Guid>
    {
        public string Amount { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public Guid UserId { get; set; }
    }
}
