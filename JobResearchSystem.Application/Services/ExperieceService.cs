using JobResearchSystem.Application.GenericServices;
using JobResearchSystem.Domain.Entities;
using JobResearchSystem.Infrastructure.UnitOfWorks;

namespace JobResearchSystem.Application.IService
{
    public class ExperienceService : GenericService<Experience>, IExperienceService
    {
        public ExperienceService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        public override async Task<Experience?> UpdateAsync(Experience entity)
        {
            var oldEntity = await _repository.GetByIdAsync(entity.Id);

            if (oldEntity == null) return null;


            var newEntity = new Experience()
            {
                Id = entity.Id,
                ExperienceCompanyName = entity.ExperienceCompanyName,
                ExperienceTitle = entity.ExperienceTitle,
                PositionDescription = entity.PositionDescription,
                ExperienceStartDate = entity.ExperienceStartDate,
                ExperienceEndDate = entity.ExperienceEndDate,
                JobSeekerId = oldEntity.JobSeekerId,
                DateUpdated = DateTime.Now,
                DateCreated = entity.DateCreated,
                IsDeleted = entity.IsDeleted,
                DateDeleted = entity.DateDeleted,
            };

            return await base.UpdateAsync(entity);
        }

        public async Task<IEnumerable<Experience>?> GetAllExperiencesByJobseekerIdAsync(int jobSeekerId)
        {
            var jobSeeker = await _unitOfWork.GetRepository<JobSeeker>().GetByIdAsync(jobSeekerId, x => x.Experiences);

            if (jobSeeker == null) return null;

            return jobSeeker.Experiences?.ToList();
        }
    }

}
