﻿using FluentValidation;
using JobResearchSystem.Application.Feature.Categories.Commands.Models;

namespace JobResearchSystem.Application.Feature.Experiences.Commands.Validators
{
    public class UpdateCategoryValidator : AbstractValidator<UpdateCategoryCommand>
    {
        public UpdateCategoryValidator() { ApplyValidationsRules(); }
        public void ApplyValidationsRules()
        {
            RuleFor(x => x.CategoryId)
                .NotEmpty().WithMessage("NotEmpty")
                .NotNull().WithMessage("Required");

            RuleFor(x => x.CategoryName)
               .NotEmpty().WithMessage("NotEmpty")
               .NotNull().WithMessage("Skill Name Required")
               .MinimumLength(1).WithMessage("Skill Name Minimum Length is 1 characters ")
               .MaximumLength(50).WithMessage("Skill Name Maximum Length is 50 characters ");
        }
    }
}
