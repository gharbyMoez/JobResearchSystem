using FluentValidation;
using JobResearchSystem.Application.Feature.Qualifications.Commands.Models;

namespace JobResearchSystem.Application.Feature.Qualifications.Commands.Validators
{
    public class DeleteQualificationValidator : AbstractValidator<DeleteQualificationCommand>
    {
        public DeleteQualificationValidator() { ApplyValidationsRules(); }
        public void ApplyValidationsRules()
        {

            RuleFor(x => x.QualificationId)
                .NotEmpty().WithMessage("NotEmpty")
                .NotNull().WithMessage("Required");
        }
    }
}
