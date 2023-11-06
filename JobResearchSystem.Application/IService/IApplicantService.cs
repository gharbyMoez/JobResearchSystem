using JobResearchSystem.Application.GenericServices;
using JobResearchSystem.Domain.Entities;

namespace JobResearchSystem.Application.IService
{
    public interface IApplicantService : IGenericService<Applicant>
    {
        Task<IEnumerable<Applicant>> GetApplicantsByJobIdAsync(int jobId);
    }
}
