using FluentValidation;
using JobResearchSystem.Application.Feature.UserTypes.Commands.Models;

namespace JobResearchSystem.Application.Feature.UserTypes.Commands.Validators
{
    public class DeleteUserTypeValidator : AbstractValidator<DeleteUserTypeCommand>
    {
        public DeleteUserTypeValidator() { ApplyValidationsRules(); }
        public void ApplyValidationsRules()
        {

            RuleFor(x => x.UserTypeId)
                .NotEmpty().WithMessage("NotEmpty")
                .NotNull().WithMessage("Required");
        }
    }
}
