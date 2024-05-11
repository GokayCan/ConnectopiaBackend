using Connectopia.Domain.Entities;
using Connectopia.Persistence.Context;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Connectopia.Persistence.DependencyResolver
{
    public static class ServiceRegistration
    {
        public static void AddDomainServices(this IServiceCollection services,IConfiguration configuration)
        {
            services.AddDbContext<AppDbContext>(options => {
                options.UseNpgsql(configuration.GetConnectionString("Default"));
            });
            //services.AddIdentity<AppUser, AppRole>().AddEntityFrameworkStores<AppDbContext>();

            services.AddIdentityApiEndpoints<AppUser>().AddDefaultTokenProviders().AddEntityFrameworkStores<AppDbContext>();
    ;
        }
    }
}
