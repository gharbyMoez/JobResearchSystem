using JobResearchSystem.Domain.Entities;
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

namespace JobResearchSystem.Infrastructure.UnitOfWorks
{
    public interface IUnitOfWork : IDisposable
    {
        ISkillRepository Skills { get; }
        IJobRepository Jobs { get; }
        IUserTypeRepository UserTypes { get; }
        IQualificationRepository Qualifications { get; }
        IJobStatusRepository JobStatuses { get; }
        IJobSeekerRepository JobSeekers { get; }
        IExperienceRepository Experiences { get; }
        ICompanyRepository Companies { get; }
        ICategoryRepository Categories { get; }
        IApplicantStatusRepository ApplicantStatuses { get; }
        IApplicantRepository Applicants { get; }

        IGenericRepository<T> GetRepository<T>() where T : BaseEntity;

        Task<int> Complete();
    }
}
