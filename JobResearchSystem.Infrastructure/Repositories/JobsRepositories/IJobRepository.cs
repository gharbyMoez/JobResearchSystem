using JobResearchSystem.Domain.Entities;
using JobResearchSystem.Infrastructure.GenericRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace JobResearchSystem.Infrastructure.Repositories.JobsRepositories
{
    public interface IJobRepository : IGenericRepository<Job>
    {
        Task<Job?> GetByIdWithJobApplicantAndJobSeekerAsync(int id, Expression<Func<Job, object>>[] includes = null);
    }
}
