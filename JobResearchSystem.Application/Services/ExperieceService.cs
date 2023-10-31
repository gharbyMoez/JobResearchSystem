using JobResearchSystem.Application.GenericServices;
using JobResearchSystem.Domain.Entities;
using JobResearchSystem.Infrastructure.UnitOfWorks;

namespace JobResearchSystem.Application.IService
{
    public class ExperienceService : GenericService<Experience>, IExperienceService
    {
        public ExperienceService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
    }
}
