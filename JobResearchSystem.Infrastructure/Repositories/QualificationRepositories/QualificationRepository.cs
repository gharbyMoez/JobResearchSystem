using JobResearchSystem.Domain.Entities;
using JobResearchSystem.Infrastructure.Database;
using JobResearchSystem.Infrastructure.GenericRepositories;
using JobResearchSystem.Infrastructure.Repositories.UserTypeRepositories;
using Microsoft.EntityFrameworkCore;

namespace JobResearchSystem.Infrastructure.Repositories.QualificationRepositories
{
    public class QualificationRepository : GenericRepository<Qualification>, IQualificationRepository
    {
        #region CTOR
        public QualificationRepository(ApplicationContext _appDbContext) : base(_appDbContext)
        {
        }
        #endregion
    }
}
