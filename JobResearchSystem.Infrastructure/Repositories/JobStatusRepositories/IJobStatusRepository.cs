using JobResearchSystem.Domain.Entities;
using JobResearchSystem.Infrastructure.GenericRepositories;

namespace JobResearchSystem.Infrastructure.Repositories.JobStatusRepositories
{
    public interface IJobStatusRepository : IGenericRepository<JobStatus>
    {
    }
}
