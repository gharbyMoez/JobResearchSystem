using JobResearchSystem.Infrastructure.Database;
using JobResearchSystem.Infrastructure.Repositories.JobsRepositories;
using JobResearchSystem.Infrastructure.Repositories.SkillRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobResearchSystem.Infrastructure.UnitOfWorks
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationContext _context;

        public ISkillRepository Skills { get; private set; }

        public IJobRepository Jobs { get; private set; }

        public UnitOfWork(ApplicationContext context)
        {
            _context = context;

            Skills = new SkillRepository(context);
            Jobs = new JobRepository(context);
        }


        public int Complete()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
