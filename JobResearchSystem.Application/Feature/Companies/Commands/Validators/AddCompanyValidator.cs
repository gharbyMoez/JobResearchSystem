using FluentValidation;
using JobResearchSystem.Application.Feature.Companies.Commands.Models;

namespace JobResearchSystem.Application.Feature.Companies.Commands.Validators
{
    public class AddCompanyValidator : AbstractValidator<AddCompanyCommand>
    {
        public AddCompanyValidator()
        {
            ApplyValidationsRules();
        }

        public void ApplyValidationsRules()
        {
            RuleFor(x => x.CompanyName)
               .NotEmpty().WithMessage("NotEmpty")
               .NotNull().WithMessage("Company Name Required")
               .MinimumLength(1).WithMessage("Company Name Minimum Length is 1 characters ")
               .MaximumLength(100).WithMessage("Company Name Maximum Length is 100 characters ");

            RuleFor(x => x.Address)
               .MinimumLength(3).WithMessage("Company Address Minimum Length is 3 characters ")
               .MaximumLength(100).WithMessage("Company Address Maximum Length is 100 characters ");

            RuleFor(x => x.Website)
               .MinimumLength(3).WithMessage("Company Website Minimum Length is 3 characters ")
               .MaximumLength(100).WithMessage("Company Website Maximum Length is 100 characters ");
        }

    }
}
