using JobResearchSystem.Application.GenericServices;
using JobResearchSystem.Domain.Entities;

namespace JobResearchSystem.Application.IService
{
    public interface ISkillService : IGenericService<Skill>
    {
        public Task<Skill?> AddSkillToJobseekerAsync(int jobSeekerId, Skill skill);

        public Task<IEnumerable<Skill>?> GetAllSkillByJobseekerIdAsync(int jobSeekerId);
    }
}
