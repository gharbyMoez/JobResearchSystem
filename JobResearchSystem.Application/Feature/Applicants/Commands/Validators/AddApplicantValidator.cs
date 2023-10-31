using FluentValidation;
using JobResearchSystem.Application.Feature.Applicants.Commands.Models;

namespace JobResearchSystem.Application.Feature.Skills.Commands.Validators
{
    public class AddApplicantValidator : AbstractValidator<AddApplicantCommand>
    {
        public AddApplicantValidator() { ApplyValidationsRules(); }
        public void ApplyValidationsRules()
        {
            RuleFor(x => x.JobSeekerId)
               .NotEmpty().WithMessage("NotEmpty")
               .NotNull().WithMessage("JobSeeker Id Is Required");

            RuleFor(x => x.JobId)
               .NotEmpty().WithMessage("NotEmpty")
               .NotNull().WithMessage("Job Id Is Required");

            //RuleFor(x => x. ApplicantStatusId )
            //   .NotEmpty().WithMessage("NotEmpty")
            //   .NotNull().WithMessage("Applicant Status Id Is Required") ;
        }
    }
}
