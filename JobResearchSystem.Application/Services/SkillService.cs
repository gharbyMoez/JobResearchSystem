using JobResearchSystem.Application.IService;
using JobResearchSystem.Domain.Entities;
using JobResearchSystem.Infrastructure.Repositories.SkillRepositories;
using JobResearchSystem.Infrastructure.UnitOfWorks;

namespace JobResearchSystem.Application.Services
{
    public class SkillService : BaseService, ISkillService
    {
        public SkillService(IUnitOfWork uow) : base(uow)
        {
        }

        public async Task<string> AddSkillAsync(Skill Dto)
        {
            return await  _uow.Skills.CreateAsync(Dto);
        }

        public async Task<string> DeleteSkillAsync(int id)
        {
            return await _uow.Skills.DeleteAsync(id);
        }

        public async Task<IEnumerable<Skill>> GetAllSkillsAsync()
        {
            return await _uow.Skills.GetAllAsync();
        }

        public async Task<Skill> GetSkillByIdAsync(int id)
        {
            return await _uow.Skills.GetByIdAsync(id);
        }

        public async Task<Skill> UpdateSkillAsync(Skill Dto)
        {
            return await _uow.Skills.UpdateAsync(Dto);
        }
    }
}
