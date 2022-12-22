using System.ComponentModel.DataAnnotations;

namespace CustomerData.Domain.Common
{
    public abstract class BaseEntity<TKey> : IHasKey<TKey>
    {
        [Key]
        public TKey Id { get; set; }

    }
}
