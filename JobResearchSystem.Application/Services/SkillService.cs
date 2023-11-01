using JobResearchSystem.Application.GenericServices;
using JobResearchSystem.Application.IService;
using JobResearchSystem.Domain.Entities;
using JobResearchSystem.Infrastructure.UnitOfWorks;
using System.Linq.Expressions;

namespace JobResearchSystem.Application.Services
{
    public class SkillService : GenericService<Skill>, ISkillService
    {
        public SkillService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        public override Task<Skill?> GetByIdAsync(int id, Expression<Func<Skill, object>>[] includes = null)
        {
            return base.GetByIdAsync(id, includes);
        }

    }
}
