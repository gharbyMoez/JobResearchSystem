using JobResearchSystem.Application.GenericServices;
using JobResearchSystem.Application.IService;
using JobResearchSystem.Domain.Entities;
using JobResearchSystem.Infrastructure.Repositories.SkillRepositories;
using JobResearchSystem.Infrastructure.UnitOfWorks;

namespace JobResearchSystem.Application.Services
{
    public class SkillService :  GenericService<Skill> , ISkillService
    {
        public SkillService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        public override Task<Skill?> GetByIdAsync(int id)
        {
            return _unitOfWork.Skills.GetByIdAsync(id);
        }
        //public async Task<Skill?> AddSkillAsync(Skill Dto)
        //{
        //    await _uow.Skills.CreateAsync(Dto);

        //    //await _uow.Complete();
        //    return Dto;
        //}

        //public async Task<bool> DeleteSkillAsync(int id)
        //{
        //    return await _uow.Skills.DeleteAsync(id);
        //}

        //public async Task<IEnumerable<Skill>> GetAllSkillsAsync()
        //{
        //    return await _uow.Skills.GetAllAsync();
        //}

        //public async Task<Skill?> GetSkillByIdAsync(int id)
        //{
        //    return await _uow.Skills.GetByIdAsync(id);
        //}

        //public async Task<Skill?> UpdateSkillAsync(Skill Dto)
        //{
        //    return await _uow.Skills.UpdateAsync(Dto);
        //}
    }
}
