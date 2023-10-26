using JobResearchSystem.Domain.Entities;

namespace JobResearchSystem.Application.IService
{
    public interface IJobService
    {
        Task<IEnumerable<Job>> GetAllJobsAsync();
        Task<Job> GetJobByIdAsync(int id);

        Task<string> AddJobAsync(Job Dto);
        Task<Job> UpdateJobAsync(Job Dto);
        Task<string> DeleteJobAsync(int id);
    }
}
