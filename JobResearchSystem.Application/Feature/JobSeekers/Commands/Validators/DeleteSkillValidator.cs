using FluentValidation;
using JobResearchSystem.Application.Feature.JobSeekers.Commands.Models;

namespace JobResearchSystem.Application.Feature.JobSeekers.Commands.Validators
{
    public class DeleteJobSeekerValidator : AbstractValidator<DeleteJobSeekerCommand>
    {
        public DeleteJobSeekerValidator() { ApplyValidationsRules(); }
        public void ApplyValidationsRules()
        {

            RuleFor(x => x.JobSeekerId)
                .NotEmpty().WithMessage("NotEmpty")
                .NotNull().WithMessage("Required");
        }
    }
}
