using JobResearchSystem.Application.GenericServices;
using JobResearchSystem.Domain.Entities;
using JobResearchSystem.Infrastructure.UnitOfWorks;

namespace JobResearchSystem.Application.IService
{
    public class ApplicantStatusService : GenericService<ApplicantStatus>, IApplicantStatusService
    {
        public ApplicantStatusService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
    }
}
