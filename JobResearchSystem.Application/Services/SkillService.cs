using JobResearchSystem.Application.GenericServices;
using JobResearchSystem.Application.IService;
using JobResearchSystem.Domain.Entities;
using JobResearchSystem.Infrastructure.UnitOfWorks;

namespace JobResearchSystem.Application.Services
{
    public class SkillService : GenericService<Skill>, ISkillService
    {
        public SkillService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        public override Task<Skill?> GetByIdAsync(int id)
        {
            return _unitOfWork.Skills.GetByIdAsync(id);
        }

    }
}
