using JobResearchSystem.Domain.Entities;
using JobResearchSystem.Infrastructure.Database;
using JobResearchSystem.Infrastructure.GenericRepositories;
using Microsoft.EntityFrameworkCore;

namespace JobResearchSystem.Infrastructure.Repositories.UserTypeRepositories
{
    public class UserTypeRepository : GenericRepository<UserType>, IUserTypeRepository
    {
        #region CTOR
        public UserTypeRepository(ApplicationContext _appDbContext) : base(_appDbContext)
        {
        }
        #endregion
    }
}
