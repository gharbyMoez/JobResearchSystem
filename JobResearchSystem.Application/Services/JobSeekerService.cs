using JobResearchSystem.Application.GenericServices;
using JobResearchSystem.Domain.Entities;
using JobResearchSystem.Infrastructure.UnitOfWorks;

namespace JobResearchSystem.Application.IService
{
    public class JobSeekerService : GenericService<JobSeeker>, IJobSeekerService
    {
        public JobSeekerService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

      
    }
}
