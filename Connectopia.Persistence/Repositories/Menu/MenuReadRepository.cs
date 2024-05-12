using Connectopia.Application.Repositories.Menu;
using Connectopia.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Connectopia.Persistence.Repositories.Menu
{
    public class MenuReadRepository : ReadRepository<Domain.Entities.Menu>, IMenuReadRepository
    {
        public MenuReadRepository(AppDbContext context) : base(context)
        {
        }
    }

}
