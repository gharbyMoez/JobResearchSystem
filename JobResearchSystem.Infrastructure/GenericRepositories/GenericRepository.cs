using JobResearchSystem.Domain.Entities;
using JobResearchSystem.Infrastructure.Database;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace JobResearchSystem.Infrastructure.GenericRepositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : BaseEntity
    {

        private readonly ApplicationContext _appDbContext;

        public GenericRepository(ApplicationContext appDbContext)
        {
            _appDbContext = appDbContext;
        }


        public virtual async Task<string> CreateAsync(T entity)
        {
            await _appDbContext.Set<T>().AddAsync(entity);
            await _appDbContext.SaveChangesAsync();
            return "success";
        }

        public virtual async Task<T> UpdateAsync(T entity)
        {

            _appDbContext.Entry(entity).State = EntityState.Modified;
            await _appDbContext.SaveChangesAsync();
            return entity;
        }

        public virtual async Task<string> DeleteAsync(int id)
        {
            var entity = await _appDbContext.Set<T>().FindAsync(id);


            if (entity != null && entity.IsDeleted == false)
            {
                entity.IsDeleted = true;
                entity.DateDeleted = DateTime.Now;
                //_appDbContext.Entry(entity).State = EntityState.Deleted;
                await _appDbContext.SaveChangesAsync();
                return "success";
            }
            //By using the Query Filter if the item is soft deleted
            //the entity above will be null so no need for the next if condition
            //if (entity != null && entity.IsDeleted == true)
            //{
            //    return " Doesn't Exist";
            //}


            return "Fails";
        }

        public async Task<IEnumerable<T>> GetAllAsync(Expression<Func<T, object>>[] includes = null)
        {
            IQueryable<T> query = _appDbContext.Set<T>();//.Where(x => x.IsDeleted == false);//Query filter instead

            foreach (var include in includes)
            {
                query = query.Include(include);
            }

            return await query.ToListAsync();

        }

        public virtual async Task<T> GetByIdAsync(int id, Expression<Func<T, object>>[] includes = null)
        {
            IQueryable<T> query = _appDbContext.Set<T>();//.Where(x => x.IsDeleted == false);//query filter instead

            foreach (var include in includes)
            {
                query = query.Include(include);
            }

            var entity = await query.FirstOrDefaultAsync(x => x.Id == id);




            return entity;
        }
    }
}
