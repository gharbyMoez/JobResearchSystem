using JobResearchSystem.Domain.Entities;
using JobResearchSystem.Infrastructure.GenericRepositories;

namespace JobResearchSystem.Infrastructure.Repositories.CompanyRepositories
{
    public interface ICompanyRepository : IGenericRepository<Company>
    {

        public Task<Company?> GetCompanyByUserIdAsync(string userId);
    }
}
