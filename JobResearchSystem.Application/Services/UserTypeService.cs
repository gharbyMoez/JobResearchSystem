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


    }
}
