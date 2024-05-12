using Connectopia.Application.Abstractions.Services;
using MediatR;

namespace Connectopia.Application.Features.Commands.AppUser.CreateUser
{
    public class CreateUserCommandHandler : IRequestHandler<CreateUserCommandRequest, CreateUserCommandResponse>
    {
        readonly IUserService _userService;
        public CreateUserCommandHandler(IUserService userService)
        {
            _userService = userService;
        }

        public async Task<CreateUserCommandResponse> Handle(CreateUserCommandRequest request, CancellationToken cancellationToken)
        {
            var response = await _userService.CreateAsync(new()
            {
                Email = request.Email,
                Password = request.Password,
                NameSurname = request.NameSurname,
                PhoneNumber = request.PhoneNumber,
                PasswordConfirm = request.PasswordConfirm,
                UserName = request.UserName
            });

            return new()
            {
                Message = response.Message,
                Succeeded = response.Succeeded,
            };
        }
    }
}
