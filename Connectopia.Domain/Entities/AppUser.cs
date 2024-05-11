using Microsoft.AspNetCore.Identity;

namespace Connectopia.Domain.Entities
{
    public sealed class AppUser : IdentityUser<int>, IEntity
    {
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public DateTime CreatedDate { get; set; } = DateTime.UtcNow;
        public DateTime? ModifiedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
    }
}
