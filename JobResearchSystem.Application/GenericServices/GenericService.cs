using JobResearchSystem.Domain.Entities;
using JobResearchSystem.Infrastructure.GenericRepositories;
using JobResearchSystem.Infrastructure.UnitOfWorks;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace JobResearchSystem.Application.GenericServices
{
    public class GenericService<TEntity> : IGenericService<TEntity>
        where TEntity : BaseEntity
    {
        protected readonly IUnitOfWork _unitOfWork;
        private readonly IGenericRepository<TEntity> _repository;

        public GenericService(IUnitOfWork unitOfWork)
        {
            this._unitOfWork = unitOfWork;
            this._repository = unitOfWork.GetRepository<TEntity>();
        }


        public async Task<IEnumerable<TEntity>> GetAllAsync()
        {
            return await _repository.GetAllAsync();
        }

        public virtual async Task<TEntity?> GetByIdAsync(int id)
        {
            return await _repository.GetByIdAsync(id);
        }

        public async Task<TEntity?> CreateAsync(TEntity entity)
        {
            await _repository.CreateAsync(entity);
            var count = await _unitOfWork.Complete();

            return count > 0 ? entity : null;
        }

        public async Task<TEntity?> UpdateAsync(TEntity entity)
        {
            await _repository.UpdateAsync(entity);
            var count = await _unitOfWork.Complete();

            return count > 0 ? entity : null;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            await _repository.DeleteAsync(id);
            var count = await _unitOfWork.Complete();

            return count > 0 ? true : false;

        }
    }
}
