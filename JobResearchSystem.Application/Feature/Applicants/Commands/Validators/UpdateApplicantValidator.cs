using FluentValidation;
using JobResearchSystem.Application.Feature.Applicants.Commands.Models;

namespace JobResearchSystem.Application.Feature.Applicants.Commands.Validators
{
    public class UpdateApplicantValidator : AbstractValidator<UpdateApplicantCommand>
    {
        public UpdateApplicantValidator() { ApplyValidationsRules(); }
        public void ApplyValidationsRules()
        {

            RuleFor(x => x.Id)
               .NotEmpty().WithMessage("NotEmpty")
               .NotNull().WithMessage("Applicant Id Required");

            RuleFor(x => x.JobId)
                .NotEmpty().WithMessage("NotEmpty")
                .NotNull().WithMessage("Applicant Id Required");

            RuleFor(x => x.JobSeekerId)
               .NotEmpty().WithMessage("NotEmpty")
               .NotNull().WithMessage("Applicant Id Required");

            RuleFor(x => x.ApplicantStatusId)
               .NotEmpty().WithMessage("NotEmpty")
               .NotNull().WithMessage("Required");

        }
    }
}
