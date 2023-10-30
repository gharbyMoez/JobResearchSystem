using JobResearchSystem.Infrastructure.GenericRepositories;
using JobResearchSystem.Infrastructure.Repositories.SkillRepositories;
using JobResearchSystem.Infrastructure.Repositories.UserTypeRepositories;
using JobResearchSystem.Infrastructure.UnitOfWorks;
using Microsoft.Extensions.DependencyInjection;


namespace JobResearchSystem.Infrastructure
{
    public static class InfrastructureDependencies
    {
        public static IServiceCollection AddInfrastructureDependencies(this IServiceCollection services)
        {
            services.AddTransient(typeof(IGenericRepository<>), typeof(GenericRepository<>));
            services.AddTransient<ISkillRepository, SkillRepository>();

            services.AddTransient<IUnitOfWork, UnitOfWork>();

            return services;
        }
    }
}
