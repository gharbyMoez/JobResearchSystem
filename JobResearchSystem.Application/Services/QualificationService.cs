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

        public async Task<IEnumerable<Qualification>?> GetAllQualificationByJobseekerIdAsync(int jobSeekerId)
        {
            var jobSeeker = await _unitOfWork.GetRepository<JobSeeker>().GetByIdAsync(jobSeekerId, x => x.Qualifications);

            if (jobSeeker == null) return null;

            return jobSeeker.Qualifications?.ToList();
        }

    }
}
