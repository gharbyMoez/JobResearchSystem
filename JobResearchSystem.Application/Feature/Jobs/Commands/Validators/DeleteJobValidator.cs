using FluentValidation;
using JobResearchSystem.Application.Feature.Jobs.Commands.Models;

namespace JobResearchSystem.Application.Feature.Jobs.Commands.Validators
{
    public class DeleteJobValidator : AbstractValidator<DeleteJobCommand>
    {
        public DeleteJobValidator() { ApplyValidationsRules(); }
        public void ApplyValidationsRules()
        {

            RuleFor(x => x.JobId)
                .NotEmpty().WithMessage("NotEmpty")
                .NotNull().WithMessage("Required");
        }
    }
}
