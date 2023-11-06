using JobResearchSystem.Application.GenericServices;
using JobResearchSystem.Domain.Entities;
using System.Linq.Expressions;

namespace JobResearchSystem.Application.IService
{
    public interface IJobService : IGenericService<Job>
    {
        IQueryable<Job> FilterJobPaginatedQueryable(string search);
        Task<IEnumerable<Applicant>?> GetByIdWithJobApplicantAndJobSeekerAsync(int jobId);

    }
}
