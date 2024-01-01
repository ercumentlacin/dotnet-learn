using LMS.Data.Entities;

namespace LMS.Data.Repositories;

public interface IGenericRepository<T> where  T: BaseEntities
{
    Task<IEnumerable<T>> GetAllAsync();
    Task<T?> GetByIdAsync(int id);
    Task<T> InsertAsync(T entity);
    Task<T> UpdateAsync(T entity);
    Task<T?> DeleteAsync(int id);
}