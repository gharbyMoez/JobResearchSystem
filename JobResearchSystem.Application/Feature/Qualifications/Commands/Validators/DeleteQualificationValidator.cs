using FluentValidation;

namespace JobResearchSystem.Application.Feature.Experiences.Commands.Validators
{
    public class DeleteQualificationValidator : AbstractValidator<DeleteQualificationCommand>
    {
        public DeleteQualificationValidator() { ApplyValidationsRules(); }
        public void ApplyValidationsRules()
        {

            RuleFor(x => x.ExperienceId)
                .NotEmpty().WithMessage("NotEmpty")
                .NotNull().WithMessage("Required");
        }
    }
}
