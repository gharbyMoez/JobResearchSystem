using JobResearchSystem.Application.GenericServices;
using JobResearchSystem.Domain.Entities;

namespace JobResearchSystem.Application.IService
{
    public interface ICompanyService : IGenericService<Company>
    {
        public Task<Company?> GetCompanyByUserIdAsync(string userId);
    }
}
