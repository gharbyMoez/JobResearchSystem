using JobResearchSystem.Domain.Entities;
using JobResearchSystem.Infrastructure.Database;
using JobResearchSystem.Infrastructure.GenericRepositories;
using Microsoft.EntityFrameworkCore;

namespace JobResearchSystem.Infrastructure.Repositories.JobRepositories
{
    public class JobRepository : GenericRepository<Job>, IJobRepository
    {
        #region CTOR
        private DbSet<Job> _job;
        public JobRepository(ApplicationContext _appDbContext) : base(_appDbContext)
        {
            _job = _appDbContext.Set<Job>();
        }
        #endregion
    }
}
