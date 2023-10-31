using FluentValidation;
using JobResearchSystem.Application.Feature.Qualifications.Commands.Models;

namespace JobResearchSystem.Application.Feature.Qualifications.Commands.Validators
{
    public class AddQualificationValidator : AbstractValidator<AddQualificationCommand>
    {
        public AddQualificationValidator() { ApplyValidationsRules(); }
        public void ApplyValidationsRules()
        {
            RuleFor(x => x.SchoolName)
               .NotEmpty().WithMessage("NotEmpty")
               .NotNull().WithMessage("Experience Name Required")
               .MinimumLength(1).WithMessage("Skill Name Minimum Length is 1 characters ")
               .MaximumLength(50).WithMessage("Skill Name Maximum Length is 50 characters ");
        }
    }
}
