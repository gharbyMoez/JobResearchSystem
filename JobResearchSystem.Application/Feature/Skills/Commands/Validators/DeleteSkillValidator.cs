﻿using FluentValidation;
using JobResearchSystem.Application.Feature.Skills.Commands.Models;

namespace JobResearchSystem.Application.Feature.Skills.Commands.Validators
{
    public class DeleteJobValidator : AbstractValidator<DeleteSkillCommand>
    {
        public DeleteJobValidator() { ApplyValidationsRules(); }
        public void ApplyValidationsRules()
        {

            RuleFor(x => x.SkillId)
                .NotEmpty().WithMessage("NotEmpty")
                .NotNull().WithMessage("Required");
        }
    }
}
