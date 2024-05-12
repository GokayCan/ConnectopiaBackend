using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace Connectopia.Domain.Entities
{
    public class BaseEntity
    {
        [Key]        
        public int Id { get; set; }

        [NotNull]
        public DateTime CreatedDate { get; set; } = DateTime.UtcNow;

        [AllowNull]
        public DateTime? ModifiedDate { get; set; }

        [AllowNull]
        public DateTime? DeletedDate { get; set; }

    }
}
