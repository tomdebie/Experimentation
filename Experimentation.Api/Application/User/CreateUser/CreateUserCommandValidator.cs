using FluentValidation;
using FluentValidation.Results;

namespace Experimentation.Api.Application.User.CreateUser;

public class CreateUserCommandValidator : AbstractValidator<CreateUserCommand>
{
    public CreateUserCommandValidator()
    {
        RuleFor(x => x.Name).Length(0, 10);
        RuleFor(x => x.Email).Custom((validationRequest, context) =>
        {
            if (validationRequest != "test@test.com")
            {
                var failure = new ValidationFailure
                {
                    ErrorMessage = "Something went wrong with {id} and {email}",
                    FormattedMessagePlaceholderValues = new Dictionary<string, object>
                    {
                        { "id", "id" },
                        { "email", validationRequest }
                    }
                };
                context.AddFailure(failure);
            }
        });
    }
}
