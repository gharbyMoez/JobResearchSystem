﻿using FluentValidation;
using JobResearchSystem.Application.Feature.Qualifications.Commands.Models;

namespace JobResearchSystem.Application.Feature.Qualifications.Commands.Validators
{
    public class UpdateQualificationValidator : AbstractValidator<UpdateQualificationCommand>
    {
        public UpdateQualificationValidator() { ApplyValidationsRules(); }
        public void ApplyValidationsRules()
        {
            RuleFor(x => x.ExperienceId)
                .NotEmpty().WithMessage("NotEmpty")
                .NotNull().WithMessage("Required");

            RuleFor(x => x.ExperienceTitle)
               .NotEmpty().WithMessage("NotEmpty")
               .NotNull().WithMessage("Skill Name Required")
               .MinimumLength(1).WithMessage("Skill Name Minimum Length is 1 characters ")
               .MaximumLength(50).WithMessage("Skill Name Maximum Length is 50 characters ");
        }
    }
}
