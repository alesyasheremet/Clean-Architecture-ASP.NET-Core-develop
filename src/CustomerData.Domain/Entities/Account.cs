using CustomerData.Domain.Common;
using System;

namespace CustomerData.Domain.Entities
{
    public class Account : BaseEntity<Guid>
    {
        public DateTime Date { get; set; }

        public string UserId { get; set; }
        public ApplicationUser User { get; set; }
    }
}
