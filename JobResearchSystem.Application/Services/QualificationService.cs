using JobResearchSystem.Application.GenericServices;
using JobResearchSystem.Domain.Entities;
using JobResearchSystem.Infrastructure.UnitOfWorks;

namespace JobResearchSystem.Application.IService
{
    public class QualificationService : GenericService<Qualification>, IQualificationService
    {
        public QualificationService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        public Task<Qualification?> CreateAsync(Qualification entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Qualification>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Qualification?> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Qualification?> UpdateAsync(Qualification entity)
        {
            throw new NotImplementedException();
        }
    }
}
