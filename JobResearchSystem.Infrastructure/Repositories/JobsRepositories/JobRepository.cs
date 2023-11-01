using JobResearchSystem.Domain.Entities;
using JobResearchSystem.Infrastructure.Database;
using JobResearchSystem.Infrastructure.GenericRepositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace JobResearchSystem.Infrastructure.Repositories.JobsRepositories
{
    public class JobRepository : GenericRepository<Job>, IJobRepository
    {
        public JobRepository(ApplicationContext appDbContext) : base(appDbContext)
        {
        }

        public async Task<Job?> GetByIdWithJobApplicantAndJobSeekerAsync(int id, Expression<Func<Job, object>>[] includes = null)
        {

            var job = await _appDbContext.Set<Job>()
                .AsNoTracking()
                .Include(x => x.Company)
                .Include(x => x.Category)
                .Include(x => x.Applicants)
                .ThenInclude(x => x.JobSeeker)
                .Where(x => x.IsDeleted == false)
                .FirstOrDefaultAsync(x => x.Id == id);


            return job;
        }
    }
}
