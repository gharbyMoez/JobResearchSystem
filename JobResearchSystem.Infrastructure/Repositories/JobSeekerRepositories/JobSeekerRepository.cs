using JobResearchSystem.Domain.Entities;
using JobResearchSystem.Infrastructure.Database;
using JobResearchSystem.Infrastructure.GenericRepositories;
using JobResearchSystem.Infrastructure.Repositories.JobStatusRepositories;
using JobResearchSystem.Infrastructure.Repositories.QualificationRepositories;
using JobResearchSystem.Infrastructure.Repositories.UserTypeRepositories;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace JobResearchSystem.Infrastructure.Repositories.JobSeekerRepositories
{
    public class JobSeekerRepository : GenericRepository<JobSeeker>, IJobSeekerRepository
    {
        #region CTOR
        public JobSeekerRepository(ApplicationContext _appDbContext) : base(_appDbContext)
        {
        }
        #endregion

        public async Task<JobSeeker?> GetJobSeekerByUserIdAsync(string userId, Expression<Func<JobSeeker, object>>[] includes = null)
        {
            IQueryable<JobSeeker> query = _appDbContext.Set<JobSeeker>().AsNoTracking().Where(x => x.IsDeleted == false);

            foreach (var include in includes)
            {
                query = query.Include(include);
            }

            var entity = await query.FirstOrDefaultAsync(x => x.UserId == userId);
            return entity;
        }
    }
}
