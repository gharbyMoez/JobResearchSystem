using JobResearchSystem.Application.GenericServices;
using JobResearchSystem.Domain.Entities;

namespace JobResearchSystem.Application.IService
{
    public interface IQualificationService : IGenericService<Qualification>
    {
        public Task<IEnumerable<Qualification>?> GetAllQualificationByJobseekerIdAsync(int jobSeekerId);
    }
}
