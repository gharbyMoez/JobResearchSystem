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

        public override async Task<Company?> UpdateAsync(Company entity)
        {
            var oldEntity = await _repository.GetByIdAsync(entity.Id);

            if (oldEntity == null) return null;

            entity.UserId = oldEntity.UserId;

            //var newEntity = new Company() 
            //{
            //    Id = entity.Id,
            //    UserId = oldentity.UserId,
            //    CompanyName = entity.CompanyName,
            //    NumberOfJobs = entity.NumberOfJobs,
            //    Phone = entity.Phone,
            //    Address = entity.Address,
            //    Website = entity.Website,
            //    DateUpdated = DateTime.Now,
            //    DateCreated = entity.DateCreated,
            //    IsDeleted = entity.IsDeleted,
            //    DateDeleted = entity.DateDeleted,
            //};


            //return await base.UpdateAsync(entity);

            //await _unitOfWork.GetRepository<TEntity>().UpdateAsync(entity);
            await _repository.UpdateAsync(entity);
            var count = await _unitOfWork.Complete();

            return count > 0 ? entity : null;
        }
    }
}
