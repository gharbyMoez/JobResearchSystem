using FluentValidation;
using JobResearchSystem.Application.Feature.Applicants.Commands.Models;

namespace JobResearchSystem.Application.Feature.Applicants.Commands.Validators
{
    public class DeleteApplicantValidator : AbstractValidator<DeleteApplicantCommand>
    {
        public DeleteApplicantValidator() { ApplyValidationsRules(); }
        public void ApplyValidationsRules()
        {

            RuleFor(x => x.ApplicantId)
                .NotEmpty().WithMessage("NotEmpty")
                .NotNull().WithMessage("Required");
        }
    }
}
