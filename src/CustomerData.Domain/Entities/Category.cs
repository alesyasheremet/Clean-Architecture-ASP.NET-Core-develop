using CustomerData.Domain.Common;
using System;
using System.Collections.Generic;

namespace CustomerData.Domain.Entities
{
    public class Category : BaseEntity<Guid>
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public ICollection<Event> Events { get; set; }
    }
}
