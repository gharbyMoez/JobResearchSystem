using JobResearchSystem.Application.GenericServices;
using JobResearchSystem.Domain.Entities;
using JobResearchSystem.Infrastructure.UnitOfWorks;
using Microsoft.EntityFrameworkCore;

namespace JobResearchSystem.Application.IService
{
    public class JobSeekerService : GenericService<JobSeeker>, IJobSeekerService
    {
        public JobSeekerService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        public async Task<JobSeeker?> GetJobSeekerByUserIdAsync(string userId)
        {
            return await _unitOfWork.JobSeekers.GetJobSeekerByUserIdAsync(userId, x => x.Qualifications, x => x.Experiences, x => x.Skills);
        }
    }
}
