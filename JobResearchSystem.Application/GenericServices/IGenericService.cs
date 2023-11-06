using JobResearchSystem.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace JobResearchSystem.Application.GenericServices
{
    public interface IGenericService<T> where T : BaseEntity
    {
        public Task<IEnumerable<T>> GetAllAsync(params Expression<Func<T, object>>[] includes);


        public Task<T?> GetByIdAsync(int id,params Expression<Func<T, object>>[] includes );


        public Task<T?> CreateAsync(T entity);


        public Task<T?> UpdateAsync(T entity);


        public Task<bool> DeleteAsync(int id);

    }
}
