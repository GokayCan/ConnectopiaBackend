using Microsoft.AspNetCore.Identity;
using System.Diagnostics.CodeAnalysis;

namespace Connectopia.Domain.Entities
{
    public sealed class AppUser : IdentityUser<int>
    {
        [NotNull]
        public required string NameSurname { get; set; }

        [AllowNull]
        public string? RefreshToken { get; set; }

        [AllowNull]
        public DateTime? RefreshTokenEndDate { get; set; }

        [NotNull]
        public DateTime CreatedDate { get; set; } = DateTime.UtcNow;

        [AllowNull]
        public DateTime? ModifiedDate { get; set; }

        [AllowNull]
        public DateTime? DeletedDate { get; set; }
    }
}
