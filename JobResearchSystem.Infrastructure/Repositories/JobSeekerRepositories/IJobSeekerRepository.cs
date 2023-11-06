using JobResearchSystem.Domain.Entities;
using JobResearchSystem.Infrastructure.GenericRepositories;
using System.Linq.Expressions;

namespace JobResearchSystem.Infrastructure.Repositories.JobSeekerRepositories
{
    public interface IJobSeekerRepository : IGenericRepository<JobSeeker>
    {
        Task<JobSeeker?> GetJobSeekerByUserIdAsync(string userId,params Expression<Func<JobSeeker, object>>[] includes);

    }
}
