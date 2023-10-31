using FluentValidation;
using JobResearchSystem.Application.Feature.JobSeekers.Commands.Models;

namespace JobResearchSystem.Application.Feature.JobSeekers.Commands.Validators
{
    public class AddJobSeekerValidator : AbstractValidator<AddJobSeekerCommand>
    {
        public AddJobSeekerValidator() { ApplyValidationsRules(); }
        public void ApplyValidationsRules()
        {
            //RuleFor(x => x.CVFilePath)

        }
    }
}
