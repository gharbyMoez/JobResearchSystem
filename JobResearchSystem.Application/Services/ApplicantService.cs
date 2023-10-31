using JobResearchSystem.Application.GenericServices;
using JobResearchSystem.Domain.Entities;
using JobResearchSystem.Infrastructure.UnitOfWorks;

namespace JobResearchSystem.Application.IService
{
    public class ApplicantService : GenericService<Applicant>, IApplicantService
    {
        public ApplicantService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
    }
}
