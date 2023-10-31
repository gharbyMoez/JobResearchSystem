using FluentValidation;
using JobResearchSystem.Application.Feature.UserTypes.Commands.Models;

namespace JobResearchSystem.Application.Feature.UserTypes.Commands.Validators
{
    public class AddUserTypeValidator : AbstractValidator<AddUserTypeCommand>
    {
        public AddUserTypeValidator() { ApplyValidationsRules(); }
        public void ApplyValidationsRules()
        {
            RuleFor(x => x.UserTypeName)
               .NotEmpty().WithMessage("NotEmpty")
               .NotNull().WithMessage("UserType Name Required")
               .MinimumLength(1).WithMessage("UserType Name Minimum Length is 1 characters ")
               .MaximumLength(50).WithMessage("UserType Name Maximum Length is 50 characters ");
        }
    }
}
