using Avanade.Challenge.Domain.Base;
using Avanade.Challenge.Domain.Interfaces;
using Avanade.Challenge.Infra.Context;
using Microsoft.EntityFrameworkCore;
using System.Collections;
using System.Threading.Tasks;

namespace Avanade.Challenge.Infra.Repository
{
    public class RepositorySQL<T> : IRepository<T> where T : EntityBase
    {
        private readonly ChallengeDB _context;

        internal readonly DbSet<T> _tables;

        public RepositorySQL(ChallengeDB context)
        {
            _context = context;
            _tables = _context.Set<T>();
        }

        public async Task<int> AddAsync(T entity)
        {
            _tables.Add(entity);

            await _context.SaveChangesAsync();

            return entity.Id;
        }

        public async Task<int> CountAsync()
        {
            return await _tables.CountAsync();
        }

        public async Task DeleteAsync(T entity)
        {
            _tables.Remove(entity);

            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable> GetAllAsync()
        {
            return await _tables.ToListAsync();
        }

        public async Task<T> GetByIdAsync(int id)
        {
            return await _tables.FindAsync(id);
        }
    }
}
