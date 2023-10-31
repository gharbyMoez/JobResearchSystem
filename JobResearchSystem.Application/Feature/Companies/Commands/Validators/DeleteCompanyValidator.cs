using FluentValidation;
using JobResearchSystem.Application.Feature.Companies.Commands.Models;

namespace JobResearchSystem.Application.Feature.Companies.Commands.Validators
{
    public class DeleteCompanyValidator : AbstractValidator<DeleteCompanyCommand>
    {
        public DeleteCompanyValidator()
        {
            ApplyValidationsRules();
        }

        public void ApplyValidationsRules()
        {
            RuleFor(x => x.Id)
                .NotEmpty().WithMessage("NotEmpty")
                .NotNull().WithMessage("Required");
        }

    }
}
