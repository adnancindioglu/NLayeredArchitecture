using NLayeredArchitecture.Core.Models;
using NLayeredArchitecture.Core.Repositories;
using NLayeredArchitecture.Core.Services;
using NLayeredArchitecture.Core.UnitOfWorks;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NLayeredArchitecture.Service.Services
{
    public class CategoryService : Service<Category>, ICategoryService
    {
        public CategoryService(IUnitOfWork unitOfWork, IRepository<Category> repository):base(unitOfWork,repository)
        {

        }
        public async Task<Category> GetWithProductsByCategoryIdAsync(int categoryId)
        {
            return await _unitOfWork.Categories.GetWithProductsByCategoryIdAsync(categoryId);
        }
    }
}
