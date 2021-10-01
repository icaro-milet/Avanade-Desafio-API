using Avanade.Challenge.Domain.Base;
using System.Collections;
using System.Threading.Tasks;

namespace Avanade.Challenge.Domain.Interfaces
{
    public interface IRepository<T> where T : EntityBase
    {
        Task<int> AddAsync(T entity);

        Task DeleteAsync(T entity);

        Task<T> GetByIdAsync(int id);

        Task<IEnumerable> GetAllAsync();

        Task<int> CountAsync();
    }
}
