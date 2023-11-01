using JobResearchSystem.Domain.Entities;
using JobResearchSystem.Infrastructure.Database;
using JobResearchSystem.Infrastructure.GenericRepositories;
using JobResearchSystem.Infrastructure.Repositories.ApplicantStatusRepositories;
using JobResearchSystem.Infrastructure.Repositories.ExperienceRepositories;
using JobResearchSystem.Infrastructure.Repositories.JobSeekerRepositories;
using JobResearchSystem.Infrastructure.Repositories.JobStatusRepositories;
using JobResearchSystem.Infrastructure.Repositories.QualificationRepositories;
using JobResearchSystem.Infrastructure.Repositories.UserTypeRepositories;
using Microsoft.EntityFrameworkCore;

namespace JobResearchSystem.Infrastructure.Repositories.ApplicantRepositories
{
    public class ApplicantRepository : GenericRepository<Applicant>, IApplicantRepository
    {
        #region CTOR
        public ApplicantRepository(ApplicationContext _appDbContext) : base(_appDbContext)
        {
        }
        #endregion

        public async Task<IEnumerable <Applicant>> GetApplicantsByJobIdAsync(int jobId)
        {
            var applicants = _appDbContext.Set<Applicant>()
                .AsNoTracking()
                .Where(x => x.IsDeleted == false)
                .Where( x => x.JobId == jobId)
                .Include(x => x.JobSeeker)
                .Include(x => x.ApplicantStatus);

            return applicants;
        }
    }
}
