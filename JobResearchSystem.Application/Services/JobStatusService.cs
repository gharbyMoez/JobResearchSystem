using JobResearchSystem.Application.GenericServices;
using JobResearchSystem.Domain.Entities;
using JobResearchSystem.Infrastructure.UnitOfWorks;

namespace JobResearchSystem.Application.IService
{
    public class JobStatusService : GenericService<JobStatus>, IJobStatusService
    {
        public JobStatusService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
    }
}
