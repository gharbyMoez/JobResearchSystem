using JobResearchSystem.Domain.Entities;
using JobResearchSystem.Infrastructure.Database;
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
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobResearchSystem.Infrastructure.UnitOfWorks
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationContext _context;

        public ISkillRepository Skills { get; private set; }
        public IJobRepository Jobs { get; private set; }
        public IUserTypeRepository UserTypes { get; private set; }
        public IQualificationRepository Qualifications { get; private set; }
        public IJobStatusRepository JobStatuses { get; private set; }
        public IJobSeekerRepository JobSeekers { get; private set; }
        public IExperienceRepository Experiences { get; private set; }
        public ICompanyRepository Companies { get; private set; }
        public ICategoryRepository Categories { get; private set; }
        public IApplicantStatusRepository ApplicantStatuses { get; private set; }
        public IApplicantRepository Applicants { get; private set; }


        public UnitOfWork(ApplicationContext context)
        {
            _context = context;

            Skills = new SkillRepository(context);
            Jobs = new JobRepository(context);
            UserTypes = new UserTypeRepository(context);
            Qualifications = new QualificationRepository(context);
            JobStatuses = new JobStatusRepository(context);
            JobSeekers = new JobSeekerRepository(context);
            Experiences = new ExperienceRepository(context);
            Companies = new CompanyRepository(context);
            Categories = new CategoryRepository(context);
            ApplicantStatuses = new ApplicantStatusRepository(context);
            Applicants = new ApplicantRepository(context);
        }


        public async Task<int> Complete()
        {
            return await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context.Dispose();
        }

        public IGenericRepository<T> GetRepository<T>() where T : BaseEntity
        {
            return new GenericRepository<T>(_context);
        }
    }
}
