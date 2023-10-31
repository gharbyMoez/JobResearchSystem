using FluentValidation;
using JobResearchSystem.Application.Feature.Experiences.Commands.Models;

namespace JobResearchSystem.Application.Feature.Experiences.Commands.Validators
{
    public class AddExperienceValidator : AbstractValidator<AddExperienceCommand>
    {
        public AddExperienceValidator() { ApplyValidationsRules(); }
        public void ApplyValidationsRules()
        {
            RuleFor(x => x.ExperienceTitle)
               .NotEmpty().WithMessage("NotEmpty")
               .NotNull().WithMessage("Experience Name Required")
               .MinimumLength(1).WithMessage("Skill Name Minimum Length is 1 characters ")
               .MaximumLength(50).WithMessage("Skill Name Maximum Length is 50 characters ");
        }
    }
}
