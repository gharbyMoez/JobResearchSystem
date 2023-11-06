using JobResearchSystem.Application.GenericServices;
using JobResearchSystem.Domain.Entities;
using JobResearchSystem.Infrastructure.UnitOfWorks;
using System.Linq.Expressions;

namespace JobResearchSystem.Application.IService
{
    public class JobService : GenericService<Job>, IJobService
    {
        public JobService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }


        public async Task<IEnumerable<Applicant>?> GetByIdWithJobApplicantAndJobSeekerAsync(int jobId)
        {
            var t = await _unitOfWork.Applicants.GetApplicantsByJobIdAsync(jobId);
            return t;
        }
    }
}
