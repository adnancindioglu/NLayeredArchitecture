using Microsoft.EntityFrameworkCore;
using NLayeredArchitecture.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace NLayeredArchitecture.Data.Repositories
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        protected readonly DbContext _context;
        private readonly DbSet<TEntity> _dbset;
        public Repository(AppDbContext context)
        {
            _context = context;
            _dbset = context.Set<TEntity>();
        }
        public async Task<TEntity> AddAsync(TEntity entity)
        {
            await _dbset.AddAsync(entity);
            return entity;
        }

        public async Task<IEnumerator<TEntity>> AddRangeAsync(IEnumerable<TEntity> entities)
        {
            await _dbset.AddRangeAsync(entities);
            return (IEnumerator<TEntity>)entities;
        }

        public async Task<IEnumerator<TEntity>> Where(Expression<Func<TEntity, bool>> predicate)
        {
            return (IEnumerator<TEntity>)await _dbset.Where(predicate).ToListAsync();
        }

        public async Task<List<TEntity>> GetAllAsync()
        {
            return await _dbset.ToListAsync();
        }

        public async Task<TEntity> GetByIdAsync(int Id)
        {
            return await _dbset.FindAsync(Id);
        }

        public void Remove(TEntity entity)
        {
            _dbset.Remove(entity);
        }

        public void RemoveRange(IEnumerable<TEntity> entities)
        {
            _dbset.RemoveRange(entities);
        }

        public async Task<TEntity> SingleOrDefaultAsync(Expression<Func<TEntity, bool>> predicate)
        {
            return await _dbset.SingleOrDefaultAsync(predicate);
        }

        public TEntity Update(TEntity entity)
        {
            _context.Entry(entity).State = EntityState.Modified;

            return entity;
        }
    }
}
