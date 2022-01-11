using NLayeredArchitecture.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NLayeredArchitecture.Core.Repositories
{
    public interface ICategoryRepository: IRepository<Category>
    {
        Task<Category> GetWithProductsByCategoryIdAsync(int categoryId);
    }
}
