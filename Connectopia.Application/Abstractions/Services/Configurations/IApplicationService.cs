

using Connectopia.Application.Dtos.Configuration;

namespace Connectopia.Application.Abstractions.Services.Configurations
{
    public interface IApplicationService
    {
        List<Menu> GetAuthorizeDefinitionEndpoints(Type type);
    }
}
