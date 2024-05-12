using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Connectopia.Domain.Entities
{
    public class AppRole : IdentityRole<int>
    {
        [NotNull]
        public DateTime CreatedDate { get; set; } = DateTime.UtcNow;

        [AllowNull]
        public DateTime? ModifiedDate { get; set; }

        [AllowNull]
        public DateTime? DeletedDate { get; set; }

        public ICollection<Endpoint> Endpoints { get; set; }
    }
}
