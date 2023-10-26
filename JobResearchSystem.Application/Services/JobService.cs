using JobResearchSystem.Application.IService;
using JobResearchSystem.Domain.Entities;
using JobResearchSystem.Infrastructure.Repositories.JobRepositories;

namespace JobResearchSystem.Application.Services
{
    public class JobService : IJobService
    {
        #region CTOR
        private readonly IJobRepository _JobRepository;
        public JobService(IJobRepository jobRepository)
        {
            _JobRepository = jobRepository;
        }
        #endregion

        public async Task<string> AddJobAsync(Job Dto)
        {
            return await _JobRepository.CreateAsync(Dto);
        }

        public async Task<string> DeleteJobAsync(int id)
        {
            return await _JobRepository.DeleteAsync(id);
        }

        public async Task<IEnumerable<Job>> GetAllJobsAsync()
        {
            return await _JobRepository.GetAllAsync();
        }

        public async Task<Job> GetJobByIdAsync(int id)
        {
            return await _JobRepository.GetByIdAsync(id);
        }

        public async Task<Job> UpdateJobAsync(Job Dto)
        {
            return await _JobRepository.UpdateAsync(Dto);
        }
    }
}
