using Apricot.Core.Specification.Base;
using System.Linq.Expressions;

namespace Apricot.Core.Repositories.Base
{
    public interface IRepository<T> where T : class
    {
        Task<IReadOnlyList<T>> GetAllAsync();

        Task<IReadOnlyList<T>> GetAllAsync(CancellationToken cancellationToken);

        Task<IReadOnlyList<T>> GetAsync(Expression<Func<T, bool>> predicate);

        Task<IReadOnlyList<T>> GetAsync(Expression<Func<T, bool>> predicate,
            Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
            string includeString = null, bool disableTracking = true);

        Task<IReadOnlyList<T>> GetAsync(ISpecification<T> spec);

        Task<T> GetByIdAsync(int id);

        Task<T> AddAsync(T entity);

        Task UpdateAsync(T entity);

        Task DeleteAsync(int id);

        Task<int> CountAsync(ISpecification<T> spec);
    }
}