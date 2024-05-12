using Connectopia.Application.Repositories.Endpoint;
using Connectopia.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Connectopia.Persistence.Repositories.Endpoint
{
    public class EndpointWriteRepository : WriteRepository<Domain.Entities.Endpoint>, IEndpointWriteRepository
    {
        public EndpointWriteRepository(AppDbContext context) : base(context)
        {
        }
    }
}
