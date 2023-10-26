using FluentValidation;
using JobResearchSystem.Application.Feature.Jobs.Commands.Models;

namespace JobResearchSystem.Application.Feature.Jobs.Commands.Validators
{
    public class AddJobValidator : AbstractValidator<AddJobCommand>
    {
        public AddJobValidator() { ApplyValidationsRules(); }
        public void ApplyValidationsRules()
        {
            RuleFor(x => x.Title)
               .NotEmpty().WithMessage("NotEmpty")
               .NotNull().WithMessage("Title of the job is Required")
               .MinimumLength(1).WithMessage("Title Minimum Length is 1 characters ")
               .MaximumLength(50).WithMessage("Title Maximum Length is 50 characters ");
        }
    }
}
