using JobResearchSystem.Infrastructure.GenericRepositories;
using JobResearchSystem.Infrastructure.Repositories.ApplicantRepositories;
using JobResearchSystem.Infrastructure.Repositories.ApplicantStatusRepositories;
using JobResearchSystem.Infrastructure.Repositories.CategoryRepositories;
using JobResearchSystem.Infrastructure.Repositories.CompanyRepositories;
using JobResearchSystem.Infrastructure.Repositories.ExperienceRepositories;
using JobResearchSystem.Infrastructure.Repositories.JobSeekerRepositories;
using JobResearchSystem.Infrastructure.Repositories.JobsRepositories;
using JobResearchSystem.Infrastructure.Repositories.JobStatusRepositories;
using JobResearchSystem.Infrastructure.Repositories.QualificationRepositories;
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




            services.AddTransient<IJobRepository, JobRepository>();
            services.AddTransient<IJobSeekerRepository, JobSeekerRepository>();
            services.AddTransient<IJobStatusRepository, JobStatusRepository>();
            services.AddTransient<ICategoryRepository, CategoryRepository>();
            services.AddTransient<IApplicantRepository, ApplicantRepository>();
            services.AddTransient<ICompanyRepository, CompanyRepository>();
            services.AddTransient<IExperienceRepository, ExperienceRepository>();
            services.AddTransient<IApplicantStatusRepository, ApplicantStatusRepository>();
            services.AddTransient<IUserTypeRepository, UserTypeRepository>();
            services.AddTransient<IQualificationRepository, QualificationRepository>();
            services.AddTransient<IUnitOfWork, UnitOfWork>();

            return services;
        }
    }
}
