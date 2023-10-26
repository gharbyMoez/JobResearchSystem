﻿using FluentValidation;
using JobResearchSystem.Application.Feature.Skills.Commands.Models;

namespace JobResearchSystem.Application.Feature.Skills.Commands.Validators
{
    public class AddJobValidator : AbstractValidator<AddSkillCommand>
    {
        public AddJobValidator() { ApplyValidationsRules(); }
        public void ApplyValidationsRules()
        {
            RuleFor(x => x.SkillName)
               .NotEmpty().WithMessage("NotEmpty")
               .NotNull().WithMessage("Skill Name Required")
               .MinimumLength(1).WithMessage("Skill Name Minimum Length is 1 characters ")
               .MaximumLength(50).WithMessage("Skill Name Maximum Length is 50 characters ");
        }
    }
}
