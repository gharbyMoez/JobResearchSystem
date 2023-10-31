using JobResearchSystem.Domain.Entities;
using JobResearchSystem.Infrastructure.Database;
using JobResearchSystem.Infrastructure.GenericRepositories;
using JobResearchSystem.Infrastructure.Repositories.QualificationRepositories;
using JobResearchSystem.Infrastructure.Repositories.UserTypeRepositories;
using Microsoft.EntityFrameworkCore;

namespace JobResearchSystem.Infrastructure.Repositories.JobStatusRepositories
{
    public class JobStatusRepository : GenericRepository<JobStatus>, IJobStatusRepository
    {
        #region CTOR
        public JobStatusRepository(ApplicationContext _appDbContext) : base(_appDbContext)
        {
        }
        #endregion
    }
}
