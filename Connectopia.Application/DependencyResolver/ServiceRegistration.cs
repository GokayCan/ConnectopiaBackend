using Microsoft.Extensions.DependencyInjection;
using System.Reflection;


namespace Connectopia.Application.DependencyResolver
{
    public static class ServiceRegistration
    {
        public static void AddApplicationServices(this IServiceCollection collection)
        {
            collection.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly()));
            collection.AddHttpClient();
        }
    }
}
