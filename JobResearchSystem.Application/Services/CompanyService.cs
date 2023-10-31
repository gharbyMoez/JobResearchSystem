using JobResearchSystem.Application.GenericServices;
using JobResearchSystem.Domain.Entities;
using JobResearchSystem.Infrastructure.UnitOfWorks;

namespace JobResearchSystem.Application.IService
{
    public class CompanyService : GenericService<Company>, ICompanyService
    {
        public CompanyService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
    }
}
