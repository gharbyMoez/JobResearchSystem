using JobResearchSystem.Domain.Entities;

namespace JobResearchSystem.Application.IService
{
    public interface ISkillService
    {
        Task<IEnumerable<Skill>> GetAllSkillsAsync();
        Task<Skill> GetSkillByIdAsync(int id);

        Task<string> AddSkillAsync(Skill Dto);
        Task<Skill> UpdateSkillAsync(Skill Dto);
        Task<string> DeleteSkillAsync(int id);
    }
}
