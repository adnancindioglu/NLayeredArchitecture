using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace NLayeredArchitecture.Core.Repositories
{
    public interface IRepository<TEntity>where TEntity:class
    {
        //Id ye göre veri getir
        Task<TEntity> GetByIdAsync(int Id);
        //Tüm veriyi getir
        Task<IEnumerator<TEntity>> GetAllAsync();
        //Parametreye göre veri getir
        Task<IEnumerator<TEntity>> Find(Expression<Func<TEntity, bool>> predicate);
        //Parametreye göre tek veri getir
        Task<TEntity> SingleOrDefaultAsync(Expression<Func<TEntity, bool>> predicate);
        //Veri ekleme işlemi
        Task AddAsync(TEntity entity);
        //Toplu veri ekleme işlemi
        Task AddRangeAsync(IEnumerable<TEntity> entities);
        //Veri silme işlemi
        void Remove(TEntity entity);
        //Toplu veri silme işlemi
        void RemoveRange(IEnumerable<TEntity> entities);
        //Veri güncelleme
        Task<TEntity> Update(TEntity entity);
    
    }
}
