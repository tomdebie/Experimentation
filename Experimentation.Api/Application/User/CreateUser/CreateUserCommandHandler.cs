using Experimentation.Api.Dto;
using FluentValidation;
using MediatR;

namespace Experimentation.Api.Application.User.CreateUser;

public class CreateUserCommandHandler : IRequestHandler<CreateUserCommand, UserDto>
{
    public async Task<UserDto> Handle(CreateUserCommand request, CancellationToken cancellationToken)
    {
        await new CreateUserCommandValidator().ValidateAndThrowAsync(request, cancellationToken);
        //if (validationResult.Errors.Any())
        //{
        //    var test = validationResult.ToDictionary();
        //    throw new ValidationException(validationResult.Errors);
        //}
            
        
        return null;
    }
}
