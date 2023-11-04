using JobResearchSystem.Application.GenericServices;
using JobResearchSystem.Domain.Entities;

namespace JobResearchSystem.Application.IService
{
    public interface IExperienceService : IGenericService<Experience>
    {
        Task<IEnumerable<Experience>?> GetAllExperiencesByJobseekerIdAsync(int jobSeekerId);
    }
}
