using NLayeredArchitecture.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NLayeredArchitecture.Core.Services
{
    public interface IProductService:IService<Product>
    {
        Task<Product> GetWithCategoryByProductIdAsync(int productId);
        //bool ControlInnerBarcode(Product product);
    }
}
