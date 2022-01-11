using NLayeredArchitecture.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NLayeredArchitecture.Core.UnitOfWorks
{
    public interface IUnitOfWork
    {
        //UnitOfWork Pattern CreateiUpdate,Delete gibi işlemlerde toplu işlem olduğunda transaction gibi işlmeleri bekletip toplu işlem yapmamıza olanak tanır
        IProductRepository Products { get; }
        ICategoryRepository Categories { get; }
        Task CommitAsync();
        void Commit();
    }
}
