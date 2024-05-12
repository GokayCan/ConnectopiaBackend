using Connectopia.Application.Repositories.Endpoint;
using Connectopia.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Connectopia.Persistence.Repositories.Endpoint
{
    public class EndpointReadRepository : ReadRepository<Domain.Entities.Endpoint>, IEndpointReadRepository
    {
        public EndpointReadRepository(AppDbContext context) : base(context)
        {
        }
    }
}
