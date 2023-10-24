using JobResearchSystem.Domain.Entities;
using JobResearchSystem.Infrastructure.Database;
using JobResearchSystem.Infrastructure.GenericRepositories;
using Microsoft.EntityFrameworkCore;

namespace JobResearchSystem.Infrastructure.Repositories.SkillRepositories
{
    public class SkillRepository : GenericRepository<Skill>, ISkillRepository
    {
        #region CTOR
        private DbSet<Skill> _skill;
        public SkillRepository(ApplicationContext _appDbContext) : base(_appDbContext)
        {
            _skill = _appDbContext.Set<Skill>();
        }
        #endregion
    }
}
