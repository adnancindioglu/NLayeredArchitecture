using NLayeredArchitecture.Core.Models;
using NLayeredArchitecture.Core.Repositories;
using NLayeredArchitecture.Core.Services;
using NLayeredArchitecture.Core.UnitOfWorks;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace NLayeredArchitecture.Service.Services
{
    public class ProductService : Service<Product>, IProductService
    {
        public ProductService(IUnitOfWork unitOfWork,IRepository<Product> repository):base(unitOfWork,repository)
        {

        }
        public async Task<Product> GetWithCategoryByProductIdAsync(int productId)
        {
            return await _unitOfWork.Products.GetWithCategoryByProductIdAsync(productId);
        }
    }
}
