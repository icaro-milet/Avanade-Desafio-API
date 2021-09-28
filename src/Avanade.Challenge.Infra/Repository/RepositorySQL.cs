using Avanade.Challenge.Domain.Base;
using Avanade.Challenge.Domain.Interfaces;
using System.Collections;
using System.Threading.Tasks;

namespace Avanade.Challenge.Infra.Repository
{
    public class RepositorySQL<T> : IRepository<T> where T : EntityBase
    {
        public Task<int> AddAsync(T entity)
        {
            throw new System.NotImplementedException();
        }

        public Task<int> CountAsync()
        {
            throw new System.NotImplementedException();
        }

        public Task DeleteAsync(T entity)
        {
            throw new System.NotImplementedException();
        }

        public Task EditAsync(T entity)
        {
            throw new System.NotImplementedException();
        }

        public Task<IEnumerable> GetAllAsync()
        {
            throw new System.NotImplementedException();
        }

        public Task<T> GetByIdAsync(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}
