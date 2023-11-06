using JobResearchSystem.Application.GenericServices;
using JobResearchSystem.Domain.Entities;
using JobResearchSystem.Infrastructure.UnitOfWorks;
using System.Linq.Expressions;

namespace JobResearchSystem.Application.IService
{
    public class CompanyService : GenericService<Company>, ICompanyService
    {

        public CompanyService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {

        }

        public override async Task<Company?> UpdateAsync(Company entity)
        {
            var oldEntity = await _repository.GetByIdAsync(entity.Id);

            if (oldEntity == null) return null;


            var newEntity = new Company()
            {
                Id = entity.Id,
                UserId = oldEntity.UserId,
                CompanyName = entity.CompanyName,
                NumberOfJobs = entity.NumberOfJobs,
                Phone = entity.Phone,
                Address = entity.Address,
                Website = entity.Website,
                DateUpdated = DateTime.Now,
                DateCreated = entity.DateCreated,
                IsDeleted = entity.IsDeleted,
                DateDeleted = entity.DateDeleted,
            };


            return await base.UpdateAsync(newEntity);
        }

        public async Task<Company?> GetCompanyByUserIdAsync(string userId)
        {
            return await _unitOfWork.Companies.GetCompanyByUserIdAsync(userId);
        }
    }
}
