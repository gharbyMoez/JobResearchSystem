using System.Linq.Expressions;

namespace JobResearchSystem.Infrastructure.GenericRepositories
{
    public interface IGenericRepository<T> where T : class
    {
        Task<IEnumerable<T>> GetAllAsync(params Expression<Func<T, object>>[] includes);
        Task<T?> GetByIdAsync(int id, params Expression<Func<T, object>>[] includes);
        Task<T?> CreateAsync(T entity);
        Task<bool> DeleteAsync(int id);
        Task<T?> UpdateAsync(T entity);
    }
}
