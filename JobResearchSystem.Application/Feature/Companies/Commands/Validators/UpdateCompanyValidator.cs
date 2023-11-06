using FluentValidation;
using JobResearchSystem.Application.Feature.Companies.Commands.Models;
using Microsoft.AspNetCore.Http;

namespace JobResearchSystem.Application.Feature.Companies.Commands.Validators
{
    public class UpdateCompanyValidator : AbstractValidator<UpdateCompanyCommand>
    {
        private readonly IHttpContextAccessor _httpContext;

        public UpdateCompanyValidator(IHttpContextAccessor httpContext)
        {
            this._httpContext = httpContext;
           

            ApplyValidationsRules();

        }

        public void ApplyValidationsRules()
        {
            var userIdXX = _httpContext.HttpContext.User.Claims.FirstOrDefault(c => c.Type == "uid")?.Value;

            RuleFor(x => x.UserId)
                .Equal(userIdXX).WithMessage("You are unauthorized!");

            RuleFor(x => x.Id)
                .NotEmpty().WithMessage("NotEmpty")
                .NotNull().WithMessage("Required");

            RuleFor(x => x.CompanyName)
               .NotEmpty().WithMessage("NotEmpty")
               .NotNull().WithMessage("Company Name Required")
               .MinimumLength(1).WithMessage("Company Name Minimum Length is 1 characters ")
               .MaximumLength(100).WithMessage("Company Name Maximum Length is 100 characters ");

            RuleFor(x => x.Address)
               .MinimumLength(3).WithMessage("Company Address Minimum Length is 3 characters ")
               .MaximumLength(100).WithMessage("Company Address Maximum Length is 100 characters ");

            RuleFor(x => x.Website)
               .MinimumLength(3).WithMessage("Company Website Minimum Length is 3 characters ")
               .MaximumLength(100).WithMessage("Company Website Maximum Length is 100 characters ");
        }

    }
}
