using System.Linq.Expressions;
using GoalSettingApp.Infrastructure.Data.Interfaces;
using GoalSettingApp.SharedKernel.Entities;

namespace GoalSettingApp.Infrastructure.Data.Services;

public class EfRepository<T> : IAsyncRepository<T> where T:BaseEntity
{
    public async Task<T?> GetByIdAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public async Task<IEnumerable<T>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public async Task<T> AddAsync(T entity)
    {
        throw new NotImplementedException();
    }

    public async Task UpdateAsync(T entity)
    {
        throw new NotImplementedException();
    }

    public async Task DeleteAsync(T entity)
    {
        throw new NotImplementedException();
    }

    public async Task<IEnumerable<T>> FindAsync(Expression<Func<T, bool>> predicate)
    {
        throw new NotImplementedException();
    }
}