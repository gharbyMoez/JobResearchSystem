using FluentValidation;
using JobResearchSystem.Application.Feature.UserTypes.Commands.Models;

namespace JobResearchSystem.Application.Feature.UserTypes.Commands.Validators
{
    public class UpdateUserTypeValidator : AbstractValidator<UpdateUserTypeCommand>
    {
        public UpdateUserTypeValidator() { ApplyValidationsRules(); }
        public void ApplyValidationsRules()
        {
            RuleFor(x => x.Id)
                .NotEmpty().WithMessage("NotEmpty")
                .NotNull().WithMessage("Required");

            RuleFor(x => x.UserTypeName)
               .NotEmpty().WithMessage("NotEmpty")
               .NotNull().WithMessage("UserType Name Required")
               .MinimumLength(1).WithMessage("UserType Name Minimum Length is 1 characters ")
               .MaximumLength(50).WithMessage("UserType Name Maximum Length is 50 characters ");
        }
    }
}
