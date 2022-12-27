using CustomerData.Domain.Common;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace CustomerData.Domain.Entities
{
    public class Account : BaseEntity<Guid>
    {
        public DateTime Date { get; set; }

        public string UserId { get; set; }
        public ApplicationUser User { get; set; }

        [ForeignKey("AccountId")]
        public ICollection<Transaction> Transactions {get;set;}
    }
}
