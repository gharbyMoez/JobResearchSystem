using FluentValidation;
using JobResearchSystem.Application.Behaviors;
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
            services.AddTransient<ISkillService, SkillService>();



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
