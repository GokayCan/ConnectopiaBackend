using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Connectopia.Application.Features.Commands.AppUser.AssignToRoleUser
{
    public class AssignRoleToUserCommandRequest : IRequest<AssignRoleToUserCommandResponse>
    {
        public string UserId { get; set; }
        public string[] Roles { get; set; }
    }
}
