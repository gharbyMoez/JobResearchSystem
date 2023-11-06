using JobResearchSystem.Application.Feature.Skills.Commands.Models;
using JobResearchSystem.Application.GenericServices;
using JobResearchSystem.Application.IService;
using JobResearchSystem.Domain.Entities;
using JobResearchSystem.Infrastructure.UnitOfWorks;
using System.Linq.Expressions;

namespace JobResearchSystem.Application.Services
{
    public class SkillService : GenericService<Skill>, ISkillService
    {
        public SkillService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }


        public async Task<Skill?> AddSkillToJobseekerAsync(int jobSeekerId, Skill skill)
        {
            var jobSeeker = await _unitOfWork.GetRepository<JobSeeker>().GetByIdAsync(jobSeekerId, x => x.Skills);
            
            if (jobSeeker == null) return null;

            var newSkill = await _unitOfWork.Skills.CreateAsync(skill);

            if (newSkill is null) return null;

            jobSeeker.Skills.Add(newSkill);

            await _unitOfWork.JobSeekers.UpdateAsync(jobSeeker);

             await _unitOfWork.Complete();

            return skill;
        }

        public async Task<IEnumerable<Skill>?> GetAllSkillByJobseekerIdAsync(int jobSeekerId)
        {
            var jobSeeker = await _unitOfWork.GetRepository<JobSeeker>().GetByIdAsync(jobSeekerId, x => x.Skills);

            if (jobSeeker == null) return null;

            return jobSeeker.Skills.ToList();
        }

    }
}
