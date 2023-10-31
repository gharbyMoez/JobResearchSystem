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


    }
}
