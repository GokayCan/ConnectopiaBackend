using Connectopia.Application.Abstractions.Services;
using Connectopia.Application.Abstractions.Services.Authentications;
using Connectopia.Application.Repositories;
using Connectopia.Application.Repositories.Endpoint;
using Connectopia.Application.Repositories.Menu;
using Connectopia.Domain.Entities;
using Connectopia.Persistence.Context;
using Connectopia.Persistence.Repositories;
using Connectopia.Persistence.Repositories.Endpoint;
using Connectopia.Persistence.Repositories.Menu;
using Connectopia.Persistence.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Connectopia.Persistence.DependencyResolver
{
    public static class ServiceRegistration
    {
        public static void AddPersistenceServices(this IServiceCollection services,IConfiguration configuration)
        {
            services.AddDbContext<AppDbContext>(options => {
                options.UseNpgsql(configuration.GetConnectionString("Default"));
            });
            services.AddIdentity<AppUser, AppRole>(options =>
            {
                options.SignIn.RequireConfirmedAccount = false;

                options.User.RequireUniqueEmail = true;

                options.Password.RequireDigit = true;
                options.Password.RequireLowercase = true;
                options.Password.RequireUppercase = true;
                options.Password.RequireNonAlphanumeric = true;

                //options.Lockout.MaxFailedAccessAttempts = 5;
                //options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(5);

            }).AddDefaultTokenProviders().AddEntityFrameworkStores<AppDbContext>();

            services.ConfigureApplicationCookie(options =>
            {
                options.SlidingExpiration = true;
                options.ExpireTimeSpan = TimeSpan.FromMinutes(60);
                options.Cookie.HttpOnly = true;
            });

            //services.AddIdentityApiEndpoints<AppUser>().AddDefaultTokenProviders().AddEntityFrameworkStores<AppDbContext>();

            services.AddScoped<IEndpointReadRepository, EndpointReadRepository>();
            services.AddScoped<IEndpointWriteRepository, EndpointWriteRepository>();
            services.AddScoped<IMenuReadRepository, MenuReadRepository>();
            services.AddScoped<IMenuWriteRepository, MenuWriteRepository>();


            services.AddScoped<IAuthService,AuthService>();
            services.AddScoped<IExternalAuthentication, AuthService>();
            services.AddScoped<IInternalAuthentication, AuthService>();
            services.AddScoped<IUserService,UserService>();
            services.AddScoped<IRoleService,RoleService>();
            services.AddScoped<IAuthorizationEndpointService,AuthorizationEndpointService>();
        }
    }
}
