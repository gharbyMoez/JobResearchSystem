using FluentValidation;
using JobResearchSystem.Application.Feature.Categories.Commands.Models;

namespace JobResearchSystem.Application.Feature.Categories.Commands.Validators
{
    public class DeleteCategoryValidator : AbstractValidator<DeleteCategoryCommand>
    {
        public DeleteCategoryValidator() { ApplyValidationsRules(); }
        public void ApplyValidationsRules()
        {

            RuleFor(x => x.CategoryId)
                .NotEmpty().WithMessage("NotEmpty")
                .NotNull().WithMessage("Required");
        }
    }
}
