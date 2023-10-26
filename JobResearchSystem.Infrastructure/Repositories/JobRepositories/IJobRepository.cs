using JobResearchSystem.Domain.Entities;
using JobResearchSystem.Infrastructure.GenericRepositories;

namespace JobResearchSystem.Infrastructure.Repositories.JobRepositories
{
    public interface IJobRepository : IGenericRepository<Job>
    {
    }
}
