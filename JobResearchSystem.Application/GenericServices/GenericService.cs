using JobResearchSystem.Domain.Entities;
using JobResearchSystem.Infrastructure.GenericRepositories;
using JobResearchSystem.Infrastructure.UnitOfWorks;
using System.Linq.Expressions;

namespace JobResearchSystem.Application.GenericServices
{
    public class GenericService<TEntity> : IGenericService<TEntity>
        where TEntity : BaseEntity
    {
        protected readonly IUnitOfWork _unitOfWork;
        protected readonly IGenericRepository<TEntity> _repository;

        public GenericService(IUnitOfWork unitOfWork)
        {
            this._unitOfWork = unitOfWork;
            this._repository = unitOfWork.GetRepository<TEntity>();
        }


        public virtual async Task<IEnumerable<TEntity>> GetAllAsync(Expression<Func<TEntity, object>>[] includes = null)
        {
            var t = await _unitOfWork.GetRepository<TEntity>().GetAllAsync(includes);
            return t; /*await _repository.GetAllAsync();*/

        }

        public virtual async Task<TEntity?> GetByIdAsync(int id, Expression<Func<TEntity, object>>[] includes = null)
        {
            var t = await _unitOfWork.GetRepository<TEntity>().GetByIdAsync(id, includes);
            return t; /*await _repository.GetByIdAsync(id);*/
        }

        public virtual async Task<TEntity?> CreateAsync(TEntity entity)
        {
            await _unitOfWork.GetRepository<TEntity>().CreateAsync(entity);

            /*await _repository.CreateAsync(entity);*/
            var count = await _unitOfWork.Complete();

            return count > 0 ? entity : null;
        }

        public virtual async Task<TEntity?> UpdateAsync(TEntity entity)
        {
            await _unitOfWork.GetRepository<TEntity>().UpdateAsync(entity);
            // await _repository.UpdateAsync(entity);
            var count = await _unitOfWork.Complete();

            return count > 0 ? entity : null;
        }

        public virtual async Task<bool> DeleteAsync(int id)
        {
            await _unitOfWork.GetRepository<TEntity>().DeleteAsync(id);
            // await _repository.DeleteAsync(id);
            var count = await _unitOfWork.Complete();

            return count > 0 ? true : false;

        }
    }
}
