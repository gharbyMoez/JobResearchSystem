using JobResearchSystem.Domain.Entities;
using JobResearchSystem.Infrastructure.GenericRepositories;
using JobResearchSystem.Infrastructure.Repositories.JobsRepositories;
using JobResearchSystem.Infrastructure.Repositories.SkillRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobResearchSystem.Infrastructure.UnitOfWorks
{
    public interface IUnitOfWork : IDisposable
    {
        ISkillRepository Skills { get; }
        IJobRepository Jobs { get; }


        int Complete();
    }
}
