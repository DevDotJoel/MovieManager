using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieManager.Application.Common.Interfaces.Persistence
{
    public interface IBaseRepository<T> where T : class
    {
        Task<T> GetByIdAsync(Guid id);
        Task<IReadOnlyList<T>> GetAllAsync();
        Task AddAsync(T entity);
        Task UpdateAsync(T entity);
        Task DeleteAsync(T entity);

    }
}