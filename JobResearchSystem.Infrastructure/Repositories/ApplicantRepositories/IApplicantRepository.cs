using JobResearchSystem.Domain.Entities;
using JobResearchSystem.Infrastructure.GenericRepositories;

namespace JobResearchSystem.Infrastructure.Repositories.ApplicantRepositories
{
    public interface IApplicantRepository : IGenericRepository<Applicant>
    {
        Task<IEnumerable<Applicant>> GetApplicantsByJobIdAsync(int jobId);
    }
}
