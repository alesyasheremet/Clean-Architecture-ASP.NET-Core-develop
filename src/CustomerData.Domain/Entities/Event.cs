using CustomerData.Domain.Common;
using System;

namespace CustomerData.Domain.Entities
{
    public class Event : BaseEntity<Guid>
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public Guid CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
