using FluentValidation;
using JobResearchSystem.Application.Behaviors;
using JobResearchSystem.Application.GenericServices;
using JobResearchSystem.Application.IService;
using JobResearchSystem.Application.Services;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace JobResearchSystem.Application
{
    public static class ApplicationDependeicies
    {
        public static IServiceCollection AddApplicationDependeicies(this IServiceCollection services)
        {

            services.AddTransient(typeof(IGenericService<>), typeof(GenericService<>));
            services.AddTransient<ISkillService, SkillService>();
            services.AddTransient<IJobService, JobService>();
            services.AddTransient<IJobSeekerService, JobSeekerService>();
            services.AddTransient<IJobStatusService, JobStatusService>();
            services.AddTransient<ICategoryService, CategoryService>();
            services.AddTransient<IApplicantService, ApplicantService>();
            services.AddTransient<ICompanyService, CompanyService>();
            services.AddTransient<IExperienceService, ExperienceService>();
            services.AddTransient<IApplicantStatusService, ApplicantStatusService>();
            services.AddTransient<IUserTypeService, UserTypeService>();
            services.AddTransient<IQualificationService, QualificationService>();

            services.AddTransient<IAuthService, AuthService>();




            services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblies(Assembly.GetExecutingAssembly()));

            services.AddAutoMapper(Assembly.GetExecutingAssembly());


            // Get Validators
            services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());
            // 
            services.AddTransient(typeof(IPipelineBehavior<,>), typeof(ValidationBehavior<,>));

            return services;
        }
    }
}
