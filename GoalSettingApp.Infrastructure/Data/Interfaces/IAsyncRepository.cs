using System.Linq.Expressions;
using GoalSettingApp.SharedKernel.Entities;

namespace GoalSettingApp.Infrastructure.Data.Interfaces;

public interface IAsyncRepository<T> where T:BaseEntity
{
    Task<T?> GetByIdAsync(Guid id);
    Task<IEnumerable<T>> GetAllAsync();
    Task<T> AddAsync(T entity);
    Task UpdateAsync(T entity);
    Task DeleteAsync(T entity);
    Task<IEnumerable<T>> FindAsync(Expression<Func<T, bool>> predicate);
}