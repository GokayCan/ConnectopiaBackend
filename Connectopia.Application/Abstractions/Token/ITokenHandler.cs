using Connectopia.Application.Dtos;
using Connectopia.Domain.Entities;

namespace Connectopia.Application.Abstractions.Token
{
    public interface ITokenHandler
    {
        Dtos.Token CreateAccessToken(int second, AppUser appUser);
        string CreateRefreshToken();
    }
}
