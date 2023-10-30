using JobResearchSystem.Domain.Entities;
using JobResearchSystem.Infrastructure.Database;
using JobResearchSystem.Infrastructure.GenericRepositories;
using JobResearchSystem.Infrastructure.Repositories.ExperienceRepositories;
using JobResearchSystem.Infrastructure.Repositories.JobSeekerRepositories;
using JobResearchSystem.Infrastructure.Repositories.JobStatusRepositories;
using JobResearchSystem.Infrastructure.Repositories.QualificationRepositories;
using JobResearchSystem.Infrastructure.Repositories.UserTypeRepositories;
using Microsoft.EntityFrameworkCore;

namespace JobResearchSystem.Infrastructure.Repositories.CategoryRepositories
{
    public class CategoryRepository : GenericRepository<Category>, ICategoryRepository
    {
        #region CTOR
        public CategoryRepository(ApplicationContext _appDbContext) : base(_appDbContext)
        {
        }
        #endregion
    }
}
