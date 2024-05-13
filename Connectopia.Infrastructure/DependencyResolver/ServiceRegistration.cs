using Connectopia.Application.Abstractions.Services;
using Connectopia.Application.Abstractions.Services.Configurations;
using Connectopia.Application.Abstractions.Token;
using Connectopia.Infrastructure.Configurations;
using Connectopia.Infrastructure.Services;
using Connectopia.Infrastructure.Services.Token;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;


namespace Connectopia.Infrastructure.DependencyResolver
{
    public static class ServiceRegistration
    {
        public static void AddInfrastructureServices(this IServiceCollection collection)
        {
            collection.AddSingleton<ITokenHandler, TokenHandler>();
            collection.AddScoped<IApplicationService, ApplicationService>();
            collection.AddScoped<IMailService, MailService>();
        }
    }
}
