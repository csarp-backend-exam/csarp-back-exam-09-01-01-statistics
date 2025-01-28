using Kreta.Shared.Models.Responses;
using System.Linq.Expressions;

namespace Kreta.Backend.Repos.Base
{
    public interface IBaseRepo<T>
    {
        IQueryable<T> GetEmpty();
        IQueryable<T> FindAll();
        IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression);
        Task<Response> CreateAsync(T entity);
        Task<Response> UpdateAsync(T entity);
        Task<Response> DeleteAsync(Guid id);
    }
}
