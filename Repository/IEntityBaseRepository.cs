using System.Collections.Generic;
using System.Threading.Tasks;

namespace Repository
{
    public interface IEntityBaseRepository<T> where T:class, IEntityBase, new()
    {
        Task<IList<T>> GetAllAsync();

        Task<T> GetByIdAsync(int id);

        Task AddAsync(T entity);

        Task UpdateAsync(int id, T entity);

        Task DeleteAsync(int id);
    }
}
