using JobResearchSystem.Application.IService;
using JobResearchSystem.Domain.Entities;
using JobResearchSystem.Infrastructure.Repositories.SkillRepositories;

namespace JobResearchSystem.Application.Services
{
    public class SkillService : ISkillService
    {
        #region CTOR
        private readonly ISkillRepository _skillRepository;
        public SkillService(ISkillRepository skillRepository)
        {
            _skillRepository = skillRepository;
        }
        #endregion

        public async Task<string> AddSkillAsync(Skill Dto)
        {
            return await _skillRepository.CreateAsync(Dto);
        }

        public async Task<string> DeleteSkillAsync(int id)
        {
            return await _skillRepository.DeleteAsync(id);
        }

        public async Task<IEnumerable<Skill>> GetAllSkillsAsync()
        {
            return await _skillRepository.GetAllAsync();
        }

        public async Task<Skill> GetSkillByIdAsync(int id)
        {
            return await _skillRepository.GetByIdAsync(id);
        }

        public async Task<Skill> UpdateSkillAsync(Skill Dto)
        {
            return await _skillRepository.UpdateAsync(Dto);
        }
    }
}
