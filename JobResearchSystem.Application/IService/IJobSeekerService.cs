using JobResearchSystem.Application.GenericServices;
using JobResearchSystem.Domain.Entities;

namespace JobResearchSystem.Application.IService
{
    public interface IJobSeekerService : IGenericService<JobSeeker>
    {
        public Task<JobSeeker?> GetJobSeekerByUserIdAsync(string userId);
    }
}
