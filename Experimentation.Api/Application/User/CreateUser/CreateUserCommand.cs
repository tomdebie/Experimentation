using Experimentation.Api.Dto;
using MediatR;

namespace Experimentation.Api.Application.User.CreateUser;

public class CreateUserCommand : IRequest<UserDto>
{
    public string Name { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
}
