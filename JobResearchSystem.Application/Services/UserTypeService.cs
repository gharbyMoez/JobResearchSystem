using JobResearchSystem.Application.GenericServices;
using JobResearchSystem.Domain.Entities;
using JobResearchSystem.Infrastructure.UnitOfWorks;

namespace JobResearchSystem.Application.IService
{
    public class UserTypeService : GenericService<UserType>, IUserTypeService
    {
        public UserTypeService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        public Task<UserType?> CreateAsync(UserType entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<UserType>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<UserType?> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<UserType?> UpdateAsync(UserType entity)
        {
            throw new NotImplementedException();
        }
    }
}
