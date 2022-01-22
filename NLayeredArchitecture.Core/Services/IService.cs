using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace NLayeredArchitecture.Core.Services
{
    public interface IService<TEntity>where TEntity:class
    {
        //Id ye göre veri getir
        Task<TEntity> GetByIdAsync(int Id);
        //Tüm veriyi getir
        Task<List<TEntity>> GetAllAsync();
        //Parametreye göre veri getir
        Task<IEnumerator<TEntity>> Where(Expression<Func<TEntity, bool>> predicate);
        //Parametreye göre tek veri getir
        Task<TEntity> SingleOrDefaultAsync(Expression<Func<TEntity, bool>> predicate);
        //Veri ekleme işlemi
        Task<TEntity> AddAsync(TEntity entity);
        //Toplu veri ekleme işlemi
        Task<IEnumerator<TEntity>> AddRangeAsync(IEnumerable<TEntity> entities);
        //Veri silme işlemi
        void Remove(TEntity entity);
        //Toplu veri silme işlemi
        void RemoveRange(IEnumerable<TEntity> entities);
        //Veri güncelleme
        TEntity Update(TEntity entity);
    }
}
