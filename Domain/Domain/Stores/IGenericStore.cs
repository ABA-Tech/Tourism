namespace Domain.Stores;

public interface IGenericStore<T> where T : class
{
    Task<IEnumerable<T>> GetCollectionAsync();

    Task<T> GetByIdAsync(int id);

    Task<int> AddAsync(T entity);

    Task<int> UpdateAsync(T entity);

    Task<bool> DeleteAsync(T entity);
}
