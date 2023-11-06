using JobResearchSystem.Domain.Entities;
using JobResearchSystem.Infrastructure.Database;
using JobResearchSystem.Infrastructure.GenericRepositories;
using Microsoft.EntityFrameworkCore;

namespace JobResearchSystem.Infrastructure.Repositories.CompanyRepositories
{
    public class CompanyRepository : GenericRepository<Company>, ICompanyRepository
    {
        #region CTOR
        public CompanyRepository(ApplicationContext _appDbContext) : base(_appDbContext)
        {
        }
        #endregion

        public async Task<Company?> GetCompanyByUserIdAsync(string userId)
        {
            IQueryable<Company> query = _appDbContext.Set<Company>().AsNoTracking().Where(x => x.IsDeleted == false);

            var entity = await query.FirstOrDefaultAsync(x => x.UserId == userId);
            return entity;
        }
    }
}
