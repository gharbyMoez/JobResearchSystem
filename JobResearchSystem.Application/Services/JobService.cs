using JobResearchSystem.Application.GenericServices;
using JobResearchSystem.Domain.Entities;
using JobResearchSystem.Infrastructure.UnitOfWorks;

namespace JobResearchSystem.Application.IService
{
    public class JobService : GenericService<Job>, IJobService
    {
        public JobService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
    }
}
